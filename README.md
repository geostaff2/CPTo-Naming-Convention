   # CPTo Naming Convention

A proven standard for variable naming developed over 30 years by Richard S. Olsen, PhD PE.

## Purpose

The CPTo naming convention is designed to standardize the naming of components in projects to enhance clarity, readability, and maintenance. By following this convention, developers can easily understand the purpose and function of each component within a codebase.

The CPTo naming convention, created by Richard S. Olsen, PhD PE, is a method for naming variables systematically in all computer programming languages. The goal of CPTo is to offer **clarity, readability, and quick insight** into variables' types, scopes, and contexts.

## Core Concept

Variable type and scope are defined at the end of all variable names, starting with an underscore `_`, then the symbol `8` to represent linkage (like physical chain links), and finally very specific codes. This standard defines the variable type and its programming level scope - where it originated, its purpose, and potentially where it is going.

This 30-year convention has been slowly crafted and modified. It was developed so the programmer can quickly see type and scope while reading code.

## Syntax

The syntax for names using the CPTo convention generally follows:

```plaintext
[BaseName]_8[DataType][ScopeIndicator][AdditionalNotes]
```

### Key Components

1. **BaseName**: A clear, descriptive name that represents the purpose of the variable (e.g., `Cylinder`, `Car`, `Temperature`)

2. **`_8` Separator**: This unique symbol symbolizes a chain-link connection to clarify type/scope

3. **DataType**: Encodes meaningful type information:
   - `int` = Integer
   - `dbl` = Double
   - `str` = String
   - `sng` = Single precision floating point
   - `lng` = Long integer
   - `bln` = Boolean
   - `lbl` = Label (UI element)
   - `frm` = Form (UI element)
   - `pic` = Picture (UI element)
   - `pix` = Pixel
   - `s` = Structure/Class
   - `o` = Object
   - `a` = Array (prefix)
   - `aa` = Two-dimensional array (prefix)
   - `aaa` = Three-dimensional array (prefix)

4. **ScopeIndicator** (optional but recommended):
   - *(none)* = Local variable
   - `I` = Input parameter (passed into a function/procedure)
   - `R` = Reference parameter (ByRef in VB.NET, reference in C++)
   - `F` = Foreign/From elsewhere (passed from another scope)
   - `M` = Module level (class/module scope)
   - `G` = Global level (application-wide scope)

5. **AdditionalNotes** (optional):
   - `Fun` = Function return value
   - Units like `_8km`, `_8sec` for secondary information

## Examples

### Basic Variables
- `Cylinder_8int` - A local integer variable
- `Car_8str` - A local string variable
- `Temperature_8dbl` - A local double variable
- `IsActive_8bln` - A local boolean variable

### Scope Indicators
- `Bike_8strI` - A string input parameter
- `Airplane_8sngR` - A single precision reference parameter
- `Chair_8strF` - A string from another scope
- `Lamp_8dblM` - A double defined at module level
- `Building_8intG` - An integer defined at global level

### Arrays
- `Kitten_8aStr()` - An array of strings
- `HorseTypes_8aaStr(x,x)` - A two-dimensional array of strings
- `Matrix_8aaaInt(x,x,x)` - A three-dimensional array of integers

### Objects and Structures
- `FordPicture_8oXXX` - A local object of type XXX
- `Toy_8sG` - A structure variable defined at global level
- `s8___toy` - Structure definition (note the 3 underscores)

### UI Elements
- `CarTitle_8lbl` - A label control
- `Main_8frm` - A form
- `Main_8frm.CAD_8pic` - A picture control inside the Main form
- `Eye_8pix` - A pixel point on screen

### Functions
- `EnginePower_8sngFun` - A function returning a single precision value

### Additional Information
- `Traveled_8km_8sng` - A single variable with units (kilometers)
- `Car_8colorG` - A color variable defined at global level
- `CatAndDog_8bitmapM` - A bitmap defined at module level

And the list goes on and on!

## Language Support

The CPTo naming convention works seamlessly across multiple programming languages:
- Python
- VB.NET
- C++
- C#
- Java
- JavaScript
- And many more!

See the `examples/` directory for practical demonstrations in various languages.

## Benefits

- **Instant Type Recognition**: Know the data type at a glance
- **Scope Awareness**: Understand where variables come from and their lifetime
- **Code Maintenance**: Easier to refactor and debug
- **Cross-Language Consistency**: Same convention across all your projects
- **Self-Documenting**: Reduces need for excessive comments
- **Team Collaboration**: Everyone understands variable purpose immediately

## Quick Reference

| Pattern | Meaning | Example |
|---------|---------|---------|
| `Name_8type` | Local variable | `Count_8int` |
| `Name_8typeI` | Input parameter | `Name_8strI` |
| `Name_8typeR` | Reference parameter | `Value_8dblR` |
| `Name_8typeM` | Module-level | `Config_8strM` |
| `Name_8typeG` | Global | `AppName_8strG` |
| `Name_8aType()` | Array | `Items_8aStr()` |
| `Name_8aaType(,)` | 2D Array | `Grid_8aaInt(,)` |
| `Name_8oClass` | Object | `Car_8oCar` |

## Discussion & Community

Join the conversation about CPTo naming convention! We'd love to hear your thoughts, questions, and experiences.

**[💬 Join the Discussion](https://github.com/geostaff2/CPTo-Naming-Convention/discussions)**

Share your:
- Questions about implementing CPTo
- Success stories and use cases
- Ideas for improvements
- Language-specific tips and tricks

You can also:
- 🐛 [Report issues](https://github.com/geostaff2/CPTo-Naming-Convention/issues) for bugs or problems
- 💡 [Suggest features](https://github.com/geostaff2/CPTo-Naming-Convention/issues/new) to enhance the convention

## Contributing

Feedback and contributions are welcome! Please feel free to submit issues or pull requests with:
- Additional examples
- Language-specific implementations
- Documentation improvements
- Use cases and success stories

## License

This naming convention is shared freely for the benefit of the programming community.
