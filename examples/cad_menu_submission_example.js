/**
 * CAD Menu Submission Example
 *
 * Demonstrates a single menu submission entry point with:
 * - Command payload creation
 * - Validation (required fields, ranges, collision checks)
 * - Centralized command execution
 * - Preview before submit
 * - Canvas refresh and undo/redo logging
 */

class CadModel {
    constructor() {
        this.Shapes_8aM = [];
        this.NextId_8intM = 1;
    }

    cloneShapes() {
        return this.Shapes_8aM.map((Shape_8o) => ({ ...Shape_8o }));
    }

    setShapes(Shapes_8aI) {
        this.Shapes_8aM = Shapes_8aI.map((Shape_8o) => ({ ...Shape_8o }));
        this.NextId_8intM = this.Shapes_8aM.reduce((Max_8int, Shape_8o) => {
            return Math.max(Max_8int, Shape_8o.id + 1);
        }, 1);
    }
}

class CadCommandSystem {
    constructor(Model_8oI) {
        this.Model_8oM = Model_8oI;
        this.UndoStack_8aM = [];
        this.RedoStack_8aM = [];
    }

    submitMenu(MenuSelection_8oI, MenuContext_8oI) {
        const PayloadResult_8o = this.buildCommandPayload(MenuSelection_8oI, MenuContext_8oI);
        if (!PayloadResult_8o.ok) {
            return this.inlineError(PayloadResult_8o.errors);
        }

        const Validation_8o = this.validatePayload(PayloadResult_8o.payload);
        if (!Validation_8o.ok) {
            return this.inlineError(Validation_8o.errors);
        }

        if (PayloadResult_8o.payload.preview === true) {
            const Preview_8o = this.previewCommand(PayloadResult_8o.payload);
            return {
                ok: Preview_8o.ok,
                message: Preview_8o.ok ? "Preview generated." : "Preview failed.",
                feedbackType: Preview_8o.ok ? "success" : "error",
                inlineErrors: Preview_8o.errors || [],
                previewShapes: Preview_8o.previewShapes || []
            };
        }

        const Execute_8o = this.executeCommand(PayloadResult_8o.payload);
        if (!Execute_8o.ok) {
            return this.inlineError(Execute_8o.errors);
        }

        this.refreshCanvas();
        return {
            ok: true,
            message: "Command applied.",
            feedbackType: "success",
            inlineErrors: []
        };
    }

    buildCommandPayload(MenuSelection_8oI, MenuContext_8oI) {
        const Tool_8str = MenuSelection_8oI?.tool;
        const Parameters_8o = MenuSelection_8oI?.parameters || {};
        const TargetObjectId_8int = MenuSelection_8oI?.targetObjectId || null;
        const Preview_8bln = MenuSelection_8oI?.preview === true;
        const MouseState_8o = {
            worldX: MenuContext_8oI?.mouseState?.worldX,
            worldY: MenuContext_8oI?.mouseState?.worldY,
            isDragging: MenuContext_8oI?.mouseState?.isDragging === true
        };

        const Errors_8aStr = [];
        if (!Tool_8str) {
            Errors_8aStr.push("Tool is required.");
        }

        return {
            ok: Errors_8aStr.length === 0,
            errors: Errors_8aStr,
            payload: {
                tool: Tool_8str,
                parameters: Parameters_8o,
                targetObjectId: TargetObjectId_8int,
                mouseState: MouseState_8o,
                preview: Preview_8bln
            }
        };
    }

    validatePayload(Payload_8oI) {
        const Errors_8aStr = [];
        const AllowedTools_8aStr = ["drawCircle", "moveShape"];

        if (!AllowedTools_8aStr.includes(Payload_8oI.tool)) {
            Errors_8aStr.push(`Unsupported tool: ${Payload_8oI.tool}`);
            return { ok: false, errors: Errors_8aStr };
        }

        if (Payload_8oI.tool === "drawCircle") {
            const Radius_8dbl = Payload_8oI.parameters.radius;
            if (typeof Radius_8dbl !== "number") {
                Errors_8aStr.push("Radius is required and must be a number.");
            } else if (Radius_8dbl < 1 || Radius_8dbl > 5000) {
                Errors_8aStr.push("Radius must be between 1 and 5000.");
            }

            if (!Number.isFinite(Payload_8oI.mouseState.worldX) || !Number.isFinite(Payload_8oI.mouseState.worldY)) {
                Errors_8aStr.push("Mouse world position is required for drawing.");
            }

            if (Errors_8aStr.length === 0) {
                const Candidate_8o = {
                    id: -1,
                    type: "circle",
                    cx: Payload_8oI.mouseState.worldX,
                    cy: Payload_8oI.mouseState.worldY,
                    radius: Radius_8dbl
                };
                if (this.hasCollision(Candidate_8o, null)) {
                    Errors_8aStr.push("Collision detected with existing geometry.");
                }
            }
        }

        if (Payload_8oI.tool === "moveShape") {
            const Shape_8o = this.Model_8oM.Shapes_8aM.find((S_8o) => S_8o.id === Payload_8oI.targetObjectId);
            if (!Shape_8o) {
                Errors_8aStr.push("Target object was not found.");
            }

            const DeltaX_8dbl = Payload_8oI.parameters.deltaX;
            const DeltaY_8dbl = Payload_8oI.parameters.deltaY;
            if (!Number.isFinite(DeltaX_8dbl) || !Number.isFinite(DeltaY_8dbl)) {
                Errors_8aStr.push("deltaX and deltaY are required numeric values.");
            }

            if (Shape_8o && Errors_8aStr.length === 0) {
                const Candidate_8o = {
                    ...Shape_8o,
                    cx: Shape_8o.cx + DeltaX_8dbl,
                    cy: Shape_8o.cy + DeltaY_8dbl
                };
                if (this.hasCollision(Candidate_8o, Shape_8o.id)) {
                    Errors_8aStr.push("Move would cause a collision.");
                }
            }
        }

        return {
            ok: Errors_8aStr.length === 0,
            errors: Errors_8aStr
        };
    }

    previewCommand(Payload_8oI) {
        const Before_8a = this.Model_8oM.cloneShapes();
        const Simulated_8a = this.simulateAfter(Payload_8oI, Before_8a);
        if (!Simulated_8a.ok) {
            return { ok: false, errors: Simulated_8a.errors };
        }
        return { ok: true, previewShapes: Simulated_8a.shapes };
    }

    executeCommand(Payload_8oI) {
        const Before_8a = this.Model_8oM.cloneShapes();
        const Simulated_8a = this.simulateAfter(Payload_8oI, Before_8a);
        if (!Simulated_8a.ok) {
            return { ok: false, errors: Simulated_8a.errors };
        }

        this.Model_8oM.setShapes(Simulated_8a.shapes);
        const After_8a = this.Model_8oM.cloneShapes();
        this.logUndoRedo({
            tool: Payload_8oI.tool,
            before: Before_8a,
            after: After_8a
        });
        return { ok: true };
    }

    simulateAfter(Payload_8oI, SourceShapes_8aI) {
        const Shapes_8a = SourceShapes_8aI.map((Shape_8o) => ({ ...Shape_8o }));
        if (Payload_8oI.tool === "drawCircle") {
            Shapes_8a.push({
                id: this.Model_8oM.NextId_8intM,
                type: "circle",
                cx: Payload_8oI.mouseState.worldX,
                cy: Payload_8oI.mouseState.worldY,
                radius: Payload_8oI.parameters.radius
            });
            return { ok: true, shapes: Shapes_8a };
        }

        if (Payload_8oI.tool === "moveShape") {
            const Index_8int = Shapes_8a.findIndex((Shape_8o) => Shape_8o.id === Payload_8oI.targetObjectId);
            if (Index_8int < 0) {
                return { ok: false, errors: ["Target object was not found."] };
            }
            Shapes_8a[Index_8int] = {
                ...Shapes_8a[Index_8int],
                cx: Shapes_8a[Index_8int].cx + Payload_8oI.parameters.deltaX,
                cy: Shapes_8a[Index_8int].cy + Payload_8oI.parameters.deltaY
            };
            return { ok: true, shapes: Shapes_8a };
        }

        return { ok: false, errors: ["Unsupported tool."] };
    }

    hasCollision(Candidate_8oI, IgnoreId_8intI) {
        if (Candidate_8oI.type !== "circle") {
            return false;
        }

        return this.Model_8oM.Shapes_8aM.some((Shape_8o) => {
            if (Shape_8o.id === IgnoreId_8intI || Shape_8o.type !== "circle") {
                return false;
            }
            const DeltaX_8dbl = Shape_8o.cx - Candidate_8oI.cx;
            const DeltaY_8dbl = Shape_8o.cy - Candidate_8oI.cy;
            const DistanceSq_8dbl = (DeltaX_8dbl * DeltaX_8dbl) + (DeltaY_8dbl * DeltaY_8dbl);
            const RadiusSum_8dbl = Shape_8o.radius + Candidate_8oI.radius;
            return DistanceSq_8dbl < (RadiusSum_8dbl * RadiusSum_8dbl);
        });
    }

    logUndoRedo(Action_8oI) {
        this.UndoStack_8aM.push(Action_8oI);
        this.RedoStack_8aM = [];
    }

    undo() {
        if (this.UndoStack_8aM.length === 0) {
            return { ok: false, message: "Nothing to undo." };
        }
        const Action_8o = this.UndoStack_8aM.pop();
        this.RedoStack_8aM.push(Action_8o);
        this.Model_8oM.setShapes(Action_8o.before);
        this.refreshCanvas();
        return { ok: true, message: "Undo complete." };
    }

    redo() {
        if (this.RedoStack_8aM.length === 0) {
            return { ok: false, message: "Nothing to redo." };
        }
        const Action_8o = this.RedoStack_8aM.pop();
        this.UndoStack_8aM.push(Action_8o);
        this.Model_8oM.setShapes(Action_8o.after);
        this.refreshCanvas();
        return { ok: true, message: "Redo complete." };
    }

    refreshCanvas() {
        const ShapeCount_8int = this.Model_8oM.Shapes_8aM.length;
        console.log(`[Canvas Refresh] Shapes on canvas: ${ShapeCount_8int}`);
    }

    inlineError(Errors_8aStrI) {
        return {
            ok: false,
            message: "Menu submission failed.",
            feedbackType: "error",
            inlineErrors: Errors_8aStrI
        };
    }
}

function runDemo() {
    const Model_8o = new CadModel();
    const Commands_8o = new CadCommandSystem(Model_8o);

    console.log("=== CAD Menu Submission Demo ===");

    const DrawPreview_8o = Commands_8o.submitMenu(
        { tool: "drawCircle", parameters: { radius: 15 }, preview: true },
        { mouseState: { worldX: 100, worldY: 100, isDragging: false } }
    );
    console.log("Preview:", DrawPreview_8o);

    const DrawApply_8o = Commands_8o.submitMenu(
        { tool: "drawCircle", parameters: { radius: 15 }, preview: false },
        { mouseState: { worldX: 100, worldY: 100, isDragging: false } }
    );
    console.log("Submit:", DrawApply_8o);

    const DrawCollision_8o = Commands_8o.submitMenu(
        { tool: "drawCircle", parameters: { radius: 20 }, preview: false },
        { mouseState: { worldX: 110, worldY: 110, isDragging: false } }
    );
    console.log("Collision Submit:", DrawCollision_8o);

    const MoveApply_8o = Commands_8o.submitMenu(
        { tool: "moveShape", targetObjectId: 1, parameters: { deltaX: 40, deltaY: 0 }, preview: false },
        { mouseState: { worldX: 0, worldY: 0, isDragging: true } }
    );
    console.log("Move Submit:", MoveApply_8o);

    console.log("Undo:", Commands_8o.undo());
    console.log("Redo:", Commands_8o.redo());
}

if (typeof module !== "undefined" && require.main === module) {
    runDemo();
}

if (typeof module !== "undefined" && module.exports) {
    module.exports = {
        CadModel,
        CadCommandSystem
    };
}
