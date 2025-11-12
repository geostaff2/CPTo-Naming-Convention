# CPTo Naming Convention - Code Examples

This directory contains practical examples of the CPTo naming convention in various programming languages.

## Available Examples

### Python (`python_example.py`)
Demonstrates CPTo convention in Python including:
- Local variables and global variables
- Input parameters and function returns
- Arrays (lists) and multi-dimensional arrays
- Classes and methods
- Unit information in variable names

**Run it:**
```bash
python python_example.py
```

### C++ (`cpp_example.cpp`)
Demonstrates CPTo convention in C++ including:
- Local, module, and global variables
- Input parameters and reference parameters
- Arrays (vectors) and 2D arrays
- Classes with member variables
- Pointers and references
- Structures with CPTo naming
- Namespace-level constants

**Compile and run:**
```bash
g++ -std=c++11 cpp_example.cpp -o cpp_example
./cpp_example
```

### VB.NET (`vbnet_example.vb`)
Demonstrates CPTo convention in VB.NET including:
- Global and module-level variables
- ByVal and ByRef parameters
- Arrays and multi-dimensional arrays
- Classes with member variables
- Structure definitions with `s8___` prefix
- Lists and collections
- UI element naming conventions

**Compile and run (with .NET Framework or Mono):**
```bash
vbnc vbnet_example.vb
mono vbnet_example.exe
```

Or with .NET Core:
```bash
dotnet build
dotnet run
```

### JavaScript (`javascript_example.js`)
Demonstrates CPTo convention in JavaScript including:
- Global and module-level variables
- Function parameters and returns
- Arrays and nested arrays
- Classes with ES6 syntax
- Objects with CPTo property names
- Async/await operations
- Callback functions
- Error handling

**Run it:**
```bash
node javascript_example.js
```

### C# (`csharp_example.cs`)
Demonstrates CPTo convention in C# including:
- Static (global) and instance variables
- Value and reference parameters
- Arrays and multi-dimensional arrays
- Collections (List, Dictionary)
- Classes with member variables
- Structures with CPTo naming
- LINQ operations
- Property naming

**Compile and run:**
```bash
csc csharp_example.cs
./csharp_example.exe
```

Or with .NET Core:
```bash
dotnet run
```

## Common Patterns Across All Examples

### Basic Variable Types
- `Name_8str` - String variable
- `Count_8int` - Integer variable
- `Price_8dbl` - Double variable
- `IsActive_8bln` - Boolean variable

### Scope Indicators
- `Config_8strM` - Module/class-level string
- `AppName_8strG` - Global string
- `Input_8strI` - Input parameter
- `Result_8dblR` - Reference parameter

### Arrays
- `Numbers_8aInt` - Single-dimensional array
- `Grid_8aaInt` - Two-dimensional array
- `Cube_8aaaInt` - Three-dimensional array

### Functions and Objects
- `CalculateArea_8dblFun` - Function return value
- `Car_8oCar` - Object instance
- `s8___Product` - Structure definition

### Units
- `Distance_8km_8dbl` - Distance in kilometers
- `Time_8hr_8dbl` - Time in hours
- `Speed_8kmph_8dbl` - Speed in km/h

## Learning Path

1. **Start with Python** - Easiest to read and understand the basic concepts
2. **Move to JavaScript** - See how it works in modern web development
3. **Try C#** - Understand typed languages with CPTo
4. **Explore C++** - See advanced features like pointers with CPTo
5. **Finish with VB.NET** - See traditional enterprise patterns

## Key Takeaways

After reviewing these examples, you should understand:

1. **Type Clarity** - Each variable immediately tells you its type
2. **Scope Awareness** - You know where variables come from and their lifetime
3. **Self-Documentation** - The code needs fewer comments
4. **Consistency** - Same pattern works across all languages
5. **Refactoring Safety** - Easy to spot type or scope mismatches

## Customization

Feel free to modify these examples to:
- Add your own data types
- Create language-specific variations
- Add more complex scenarios
- Integrate with your existing projects

## Contributing

If you create examples in other languages or have improvements:
1. Follow the existing pattern
2. Include comprehensive comments
3. Demonstrate all major CPTo features
4. Add a section to this README

## Questions?

Refer to the main [README.md](../README.md) and [QUICK_REFERENCE.md](../QUICK_REFERENCE.md) for detailed documentation.

Have questions or want to discuss these examples? [Join the Discussion](https://github.com/geostaff2/CPTo-Naming-Convention/discussions) to connect with the community!

---

**Happy Coding with CPTo!** 🚀
