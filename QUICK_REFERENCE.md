# CPTo Naming Convention - Quick Reference Guide

This guide provides a quick lookup for the CPTo naming convention.

## Basic Pattern

```
[BaseName]_8[DataType][ScopeIndicator][AdditionalInfo]
```

## Data Types

| Code | Type | Example |
|------|------|---------|
| `int` | Integer | `Counter_8int` |
| `lng` | Long Integer | `BigNumber_8lng` |
| `sng` | Single (Float) | `Temperature_8sng` |
| `dbl` | Double | `Precision_8dbl` |
| `str` | String | `Name_8str` |
| `bln` | Boolean | `IsActive_8bln` |
| `chr` | Character | `Letter_8chr` |
| `byt` | Byte | `Data_8byt` |

## Scope Indicators

| Code | Scope | Example | Meaning |
|------|-------|---------|---------|
| *(none)* | Local | `Value_8int` | Local variable |
| `I` | Input | `Name_8strI` | Input parameter |
| `R` | Reference | `Result_8dblR` | ByRef/Reference parameter |
| `F` | Foreign | `Config_8strF` | From another scope |
| `M` | Module | `Setting_8intM` | Module/Class level |
| `G` | Global | `AppName_8strG` | Global/Application level |

## Arrays

| Code | Type | Example | Declaration |
|------|------|---------|-------------|
| `a` | 1D Array | `Items_8aStr()` | Array of strings |
| `aa` | 2D Array | `Grid_8aaInt(,)` | 2D array of integers |
| `aaa` | 3D Array | `Cube_8aaaInt(,,)` | 3D array of integers |

## Objects and Structures

| Code | Type | Example | Meaning |
|------|------|---------|---------|
| `o` | Object | `Car_8oCar` | Object instance |
| `s` | Structure | `Person_8s` | Structure instance |
| `s8___` | Structure Definition | `s8___Person` | Structure type (3 underscores) |

## UI Elements (Common in VB.NET, WinForms)

| Code | Element | Example |
|------|---------|---------|
| `lbl` | Label | `Title_8lbl` |
| `txt` | TextBox | `Input_8txt` |
| `btn` | Button | `Submit_8btn` |
| `frm` | Form | `Main_8frm` |
| `pic` | Picture | `Logo_8pic` |
| `lst` | List | `Users_8lst` |
| `cmb` | ComboBox | `Options_8cmb` |
| `chk` | CheckBox | `Agree_8chk` |
| `pix` | Pixel | `Position_8pix` |

## Functions

| Code | Type | Example |
|------|------|---------|
| `Fun` | Function Return | `CalculateArea_8dblFun` |

## Additional Information (Secondary Links)

Units or other metadata can be added as secondary `_8` links:

| Example | Meaning |
|---------|---------|
| `Distance_8km_8dbl` | Double representing kilometers |
| `Time_8sec_8int` | Integer representing seconds |
| `Temperature_8celsius_8dbl` | Double in Celsius |
| `Weight_8kg_8sng` | Single representing kilograms |
| `Speed_8mph_8dbl` | Double representing miles per hour |

## Common Patterns

### Basic Variable
```
Temperature_8dbl        // Local double variable
```

### Function Parameter
```
Function Calculate(Input_8dblI As Double)
                  ↑
                  Input parameter
```

### Reference Parameter
```
Sub Process(ByRef Result_8intR As Integer)
                         ↑
                         Reference parameter
```

### Module-Level Variable
```
Private Config_8strM = "config.json"
                  ↑
                  Module level
```

### Global Variable
```
Public AppVersion_8dblG = 1.0
                      ↑
                      Global level
```

### Array
```
Dim Values_8aInt() = {1, 2, 3}
           ↑
           Array of integers
```

### 2D Array
```
Dim Matrix_8aaInt(10, 10)
           ↑↑
           2D array of integers
```

### Object
```
Dim myCar_8oCar As New Car()
          ↑
          Object of type Car
```

### Structure
```
Structure s8___Employee    ' Structure definition (3 underscores)
    Public Name_8str
    Public ID_8int
End Structure

Dim worker_8s As s8___Employee   ' Structure instance
```

### Function with Return Type
```
Function GetTotal_8intFun() As Integer
                     ↑↑↑
                     Returns integer
```

### With Units
```
Distance_8km_8dbl = 100.5    ' 100.5 kilometers
Time_8hr_8dbl = 2.5          ' 2.5 hours
Speed_8kmph_8dbl = Distance_8km_8dbl / Time_8hr_8dbl
```

## Complete Examples

### Python
```python
# Local variable
Counter_8int = 0

# Input parameter
def process(Name_8strI, Age_8intI):
    pass

# Module-level
Config_8strM = "settings.json"

# Global
APP_NAME_8strG = "MyApp"

# Array
Numbers_8aInt = [1, 2, 3, 4, 5]

# 2D Array
Grid_8aaInt = [[1, 2], [3, 4]]

# Object
car_8oCar = Car()
```

### C++
```cpp
// Local variable
int counter_8int = 0;

// Input parameter
void process(string name_8strI, int age_8intI) {
    // Local
    string result_8str;
}

// Reference parameter
void calculate(double value_8dblI, double& result_8dblR) {
    result_8dblR = value_8dblI * 2;
}

// Module-level (class)
class MyClass {
private:
    double pi_8dblM = 3.14159;
public:
    // ...
};

// Global
string appName_8strG = "MyApp";

// Array
vector<int> numbers_8aInt = {1, 2, 3, 4, 5};

// 2D Array
vector<vector<int>> grid_8aaInt;
```

### VB.NET
```vb
' Local variable
Dim Counter_8int As Integer = 0

' Input parameter
Sub Process(ByVal Name_8strI As String, ByVal Age_8intI As Integer)
    ' ...
End Sub

' Reference parameter
Sub Calculate(ByVal Value_8dblI As Double, ByRef Result_8dblR As Double)
    Result_8dblR = Value_8dblI * 2
End Sub

' Module-level
Private Config_8strM As String = "settings.json"

' Global
Public AppName_8strG As String = "MyApp"

' Array
Dim Numbers_8aInt() As Integer = {1, 2, 3, 4, 5}

' 2D Array
Dim Grid_8aaInt(10, 10) As Integer

' Structure
Structure s8___Person
    Public Name_8str As String
    Public Age_8int As Integer
End Structure

' Structure instance
Dim employee_8s As s8___Person
```

## Tips for Using CPTo

1. **Be Consistent**: Always use the convention throughout your project
2. **Choose Descriptive Base Names**: The base name should clearly indicate the variable's purpose
3. **Type First, Then Scope**: Follow the pattern: `_8[type][scope]`
4. **Arrays Use Prefix**: `a`, `aa`, `aaa` come before the type: `_8aStr`, `_8aaInt`
5. **Structures**: Use `s8___` with 3 underscores for definitions
6. **Units**: Add secondary `_8` links when units are important
7. **Functions**: Add `Fun` suffix to indicate return value variables

## Benefits at a Glance

- ✅ **Instant type recognition** - Know the type without hovering or checking
- ✅ **Scope awareness** - Understand variable lifetime and origin
- ✅ **Reduced bugs** - Type mismatches are easier to spot
- ✅ **Better refactoring** - Change scope or type, update the name
- ✅ **Self-documenting** - Less need for comments
- ✅ **Cross-language** - Works in any programming language
- ✅ **Team consistency** - Everyone follows the same standard

## Quick Decision Tree

```
Start with variable purpose → BaseName
              ↓
         Add _8 separator
              ↓
         What's the type? → int, str, dbl, etc.
              ↓
         Is it an array? → Add 'a', 'aa', 'aaa'
              ↓
         What's the scope?
              ├─ Local → (nothing)
              ├─ Input → I
              ├─ Reference → R
              ├─ Module → M
              └─ Global → G
              ↓
         Need units? → Add _8[unit]
              ↓
         Done! → BaseName_8type[scope][extra]
```

## Examples by Use Case

### Simple Counter
```
Count_8int                  // Local integer counter
```

### Function Processing User Input
```
Function ValidateUser(Username_8strI, Password_8strI) As Boolean
    Dim IsValid_8bln
    Dim HashValue_8str
    // ...
    Return IsValid_8bln
End Function
```

### Class with Members
```
Class DataProcessor
    ' Module-level members
    Private buffer_8aIntM
    Private maxSize_8intM
    Private isReady_8blnM
End Class
```

### Scientific Calculation
```
Function CalculateForce(Mass_8kg_8dbl, Accel_8ms2_8dbl) As Double
    Dim Force_8N_8dbl = Mass_8kg_8dbl * Accel_8ms2_8dbl
    Return Force_8N_8dbl
End Function
```

---

**Ready to use CPTo in your projects?** Start with local variables, then gradually apply to parameters, module-level, and global variables. The consistency will make your code more maintainable and easier to understand!
