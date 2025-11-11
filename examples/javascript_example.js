/**
 * CPTo Naming Convention - JavaScript Example
 * 
 * This file demonstrates the CPTo naming convention in JavaScript.
 * Each variable name clearly indicates its type and scope.
 * 
 * Author: CPTo Community
 * Convention by: Richard S. Olsen, PhD PE
 */

// Global-level variables (G suffix)
const AppName_8strG = "CPTo JavaScript Demo";
const MaxRetries_8intG = 3;
let IsInitialized_8blnG = false;
const Version_8dblG = 1.5;

// Module-level variables (M suffix) - in a real module system
const Config_8strM = "config.json";
const ApiEndpoint_8strM = "https://api.example.com";
let RequestCount_8intM = 0;

/**
 * Calculator class demonstrating CPTo convention
 */
class Calculator {
    /**
     * Constructor - initialize class members
     */
    constructor() {
        // Class/Module-level variables (M suffix)
        this.PI_8dblM = 3.14159265359;
        this.LastResult_8dblM = 0;
        this.CalculationHistory_8aIntM = [];
    }
    
    /**
     * Calculate circle area
     * @param {number} Radius_8dblI - Input parameter: radius
     * @returns {number} Area_8dblFun - Function return: area
     */
    calculateArea(Radius_8dblI) {
        // Local variable
        const Area_8dbl = this.PI_8dblM * Radius_8dblI * Radius_8dblI;
        
        // Update class member
        this.LastResult_8dblM = Area_8dbl;
        this.CalculationHistory_8aIntM.push(Area_8dbl);
        
        // Return with function suffix
        const Area_8dblFun = Area_8dbl;
        return Area_8dblFun;
    }
    
    /**
     * Calculate square (demonstrates object mutation)
     * @param {number} Value_8dblI - Input parameter
     * @param {object} ResultObj_8oR - Reference object to store result
     */
    calculateSquare(Value_8dblI, ResultObj_8oR) {
        // Local calculation
        const Square_8dbl = Value_8dblI * Value_8dblI;
        
        // Modify reference object (simulating ByRef)
        ResultObj_8oR.value = Square_8dbl;
        
        // Update class member
        this.LastResult_8dblM = Square_8dbl;
    }
    
    /**
     * Get calculation history
     * @returns {Array} History_8aIntFun - Array of past calculations
     */
    getHistory() {
        const History_8aIntFun = [...this.CalculationHistory_8aIntM];
        return History_8aIntFun;
    }
}

/**
 * Demonstrate array operations
 */
function demonstrateArrays() {
    console.log("Array Operations:");
    
    // Single-dimensional arrays
    const Numbers_8aInt = [1, 2, 3, 4, 5];
    const Names_8aStr = ["Alice", "Bob", "Charlie", "David"];
    
    // Two-dimensional array (array of arrays)
    const Grid_8aaInt = [
        [1, 2, 3],
        [4, 5, 6],
        [7, 8, 9]
    ];
    
    // Process arrays
    const Sum_8int = Numbers_8aInt.reduce((acc, val) => acc + val, 0);
    const Count_8int = Names_8aStr.length;
    
    console.log(`  Sum of numbers: ${Sum_8int}`);
    console.log(`  Count of names: ${Count_8int}`);
    console.log(`  2D Grid first element: ${Grid_8aaInt[0][0]}`);
}

/**
 * String processing demonstration
 * @param {string} Input_8strI - Input string
 * @param {string} Pattern_8strI - Pattern to search
 * @returns {string} Result_8strFun - Result message
 */
function processString(Input_8strI, Pattern_8strI) {
    // Local variables
    const Modified_8str = Input_8strI.toLowerCase();
    const Found_8bln = Modified_8str.includes(Pattern_8strI.toLowerCase());
    const Position_8int = Found_8bln ? Modified_8str.indexOf(Pattern_8strI.toLowerCase()) : -1;
    
    // Build result
    let Result_8str;
    if (Found_8bln) {
        Result_8str = `Pattern found at position ${Position_8int}`;
    } else {
        Result_8str = "Pattern not found";
    }
    
    const Result_8strFun = Result_8str;
    return Result_8strFun;
}

/**
 * Physics calculation with unit information
 * @param {number} Distance_8km_8dbl - Distance in kilometers
 * @param {number} Time_8hr_8dbl - Time in hours
 * @returns {number} Speed_8kmph_8dblFun - Speed in km/h
 */
function calculateSpeed(Distance_8km_8dbl, Time_8hr_8dbl) {
    // Calculate with unit information
    const Speed_8kmph_8dbl = Distance_8km_8dbl / Time_8hr_8dbl;
    
    // Convert to miles
    const DistanceInMiles_8mi_8dbl = Distance_8km_8dbl * 0.621371;
    
    console.log(`  Distance: ${Distance_8km_8dbl} km (${DistanceInMiles_8mi_8dbl.toFixed(2)} miles)`);
    console.log(`  Time: ${Time_8hr_8dbl} hours`);
    console.log(`  Speed: ${Speed_8kmph_8dbl.toFixed(2)} km/h`);
    
    const Speed_8kmph_8dblFun = Speed_8kmph_8dbl;
    return Speed_8kmph_8dblFun;
}

/**
 * Demonstrate object usage
 */
function demonstrateObjects() {
    console.log("Object Operations:");
    
    // Object with CPTo naming for properties
    const Vehicle_8o = {
        Model_8str: "Tesla Model Y",
        Year_8int: 2024,
        Price_8dbl: 52000.00,
        IsElectric_8bln: true,
        Features_8aStr: ["Autopilot", "Glass Roof", "Premium Audio"]
    };
    
    console.log(`  Vehicle: ${Vehicle_8o.Model_8str}`);
    console.log(`  Year: ${Vehicle_8o.Year_8int}`);
    console.log(`  Price: $${Vehicle_8o.Price_8dbl.toFixed(2)}`);
    console.log(`  Electric: ${Vehicle_8o.IsElectric_8bln ? "Yes" : "No"}`);
    console.log(`  Features: ${Vehicle_8o.Features_8aStr.join(", ")}`);
}

/**
 * Demonstrate async operations with CPTo
 */
async function demonstrateAsync() {
    console.log("Async Operations:");
    
    // Simulate async data fetch
    const FetchData_8strFun = await new Promise((resolve) => {
        setTimeout(() => {
            const Data_8str = "Fetched data successfully";
            resolve(Data_8str);
        }, 100);
    });
    
    console.log(`  ${FetchData_8strFun}`);
    
    // Local variable from async operation
    const Result_8bln = FetchData_8strFun.includes("success");
    console.log(`  Success: ${Result_8bln}`);
}

/**
 * Demonstrate callback functions with CPTo
 */
function demonstrateCallbacks() {
    console.log("Callback Operations:");
    
    // Array to process
    const Values_8aInt = [1, 2, 3, 4, 5];
    
    // Map with callback - each item is processed
    const Doubled_8aInt = Values_8aInt.map((Item_8int) => {
        const Result_8int = Item_8int * 2;
        return Result_8int;
    });
    
    // Filter with callback
    const Filtered_8aInt = Values_8aInt.filter((Item_8int) => {
        const IsEven_8bln = Item_8int % 2 === 0;
        return IsEven_8bln;
    });
    
    console.log(`  Original: [${Values_8aInt.join(", ")}]`);
    console.log(`  Doubled: [${Doubled_8aInt.join(", ")}]`);
    console.log(`  Even numbers: [${Filtered_8aInt.join(", ")}]`);
}

/**
 * Demonstrate error handling with CPTo
 */
function demonstrateErrorHandling() {
    console.log("Error Handling:");
    
    try {
        // Local variables
        const Value_8str = "123abc";
        const Number_8int = parseInt(Value_8str);
        const IsValid_8bln = !isNaN(Number_8int);
        
        if (IsValid_8bln) {
            console.log(`  Parsed number: ${Number_8int}`);
        } else {
            const ErrorMsg_8str = "Invalid number format";
            throw new Error(ErrorMsg_8str);
        }
    } catch (Error_8o) {
        console.log(`  Caught error: ${Error_8o.message}`);
    }
}

/**
 * Main demonstration function
 */
async function main() {
    console.log("============================================================");
    console.log("CPTo Naming Convention - JavaScript Examples");
    console.log("============================================================");
    console.log();
    
    // 1. Calculator Demo
    console.log("1. Calculator Demo:");
    const Calc_8o = new Calculator();
    const Area_8dbl = Calc_8o.calculateArea(5.0);
    console.log(`  Circle area (r=5.0): ${Area_8dbl.toFixed(2)}`);
    
    // Demonstrate reference-style parameter
    const SquareResultObj_8o = { value: 0 };
    Calc_8o.calculateSquare(7.0, SquareResultObj_8o);
    console.log(`  Square of 7.0: ${SquareResultObj_8o.value.toFixed(2)}`);
    
    const History_8aInt = Calc_8o.getHistory();
    console.log(`  Calculation history: [${History_8aInt.map(v => v.toFixed(2)).join(", ")}]`);
    console.log();
    
    // 2. Array Operations
    console.log("2. ");
    demonstrateArrays();
    console.log();
    
    // 3. String Operations
    console.log("3. String Operations:");
    const SearchResult_8str = processString("Hello CPTo World", "cpto");
    console.log(`  ${SearchResult_8str}`);
    console.log();
    
    // 4. Physics Calculation
    console.log("4. Physics Calculation with Units:");
    const Speed_8dbl = calculateSpeed(120.0, 2.0);
    console.log();
    
    // 5. Objects
    console.log("5. ");
    demonstrateObjects();
    console.log();
    
    // 6. Async Operations
    console.log("6. ");
    await demonstrateAsync();
    console.log();
    
    // 7. Callbacks
    console.log("7. ");
    demonstrateCallbacks();
    console.log();
    
    // 8. Error Handling
    console.log("8. ");
    demonstrateErrorHandling();
    console.log();
    
    // 9. Global Variables
    console.log("9. Global Variables:");
    console.log(`  Application: ${AppName_8strG}`);
    console.log(`  Version: ${Version_8dblG}`);
    console.log(`  Max Retries: ${MaxRetries_8intG}`);
    console.log(`  Initialized: ${IsInitialized_8blnG ? "Yes" : "No"}`);
    console.log();
    
    console.log("============================================================");
    console.log("Demo Complete!");
    console.log("============================================================");
}

// Run the demo if this is the main module
if (typeof module !== 'undefined' && require.main === module) {
    main().catch((Error_8o) => {
        console.error("Error running demo:", Error_8o);
    });
}

// Export for use as a module
if (typeof module !== 'undefined' && module.exports) {
    module.exports = {
        Calculator,
        demonstrateArrays,
        processString,
        calculateSpeed,
        demonstrateObjects
    };
}
