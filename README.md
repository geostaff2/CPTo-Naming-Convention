# CPTo Naming Convention

## Purpose
The CPTo naming convention is designed to standardize the naming of components in projects to enhance clarity, readability, and maintenance. By following this convention, developers can easily understand the purpose and function of each component within a codebase.

The CPTo naming convention, created by Richard S. Olsen, PhD PE, is a method for naming variables systemically in all computer programming languages. The goal of CPTo is to offer **clarity, readability, and quick insight** into variables' contexts.

## Syntax
The syntax for names using the CPTo convention generally follows:

```plaintext
[BaseName]_8[DataType][ScopeIndicator][Additional Notes]
```

### Key Conventions:
1. **BaseName**: A clear, descriptive name that represents the purpose of the variable.
2. **`_8` Symbol**: This unique symbol symbolizes a chain-link connection to clarify type/scope.
3. **DataType**: Encodes meaningful type information:
   - `int` = Integer
   - `dbl` = Double
   - `str` = String
   - `sng` = Single value
   - `lbl` = Label
The following describes the 
Richard S. Olsen PhD PE method called the 
 "CPTo methods" for variable naming in 
all computer languages.  

Variable type is defined at the end of 
all variable names, 
starting with a “_”, then 
the symbol "8" to represent linkage 
(like physical chain links) and 
finally very specific codes.  
This standard defines the variable type 
and its programming level scope, 
i.e., where it originated, its purpose, 
and potentially where it is going.  
This 30-year convention has been slowly 
crafted and modified.  It was developed 
so the programmer can quickly see type and 
scope while reading code.  

The best way to explain it is to 
show examples: 
Cylinder_8int defines a local integer.
Car_8str is for a local string.
Bike_8strI for a string that was brought 
into (inputted) a procedure. 
Kitten_8aStr() is an array of strings.
HorseTypes_8aaStr(x,x) is a 
two-dimensional array of strings
Airplane_8sngR is a single variable 
that will leave a procedure as a 
(vs.net) ByRef. 
Chair_8strF is a string that was 
defined elsewhere, such as from a 
procedural call. 
Lamp_8dblM is a double that was 
defined at the module level.
Building_8intG is an integer variable 
defined at the Global level. 
Toy_8sG is (VS.net) structure variable 
and defined at the Globe  level, 
which has the initial structure 
described in this example module level 
“Structure s8___toy” and using  
“Public toy_8sG as s8___toy” 
(note the 3 “_”).
CarTitle_8lbl is a VS.net Label
Main_8frm.CAD_8pic is a 
VS.net CAD picture inside of the Main form 
Eye_8pix is the physical pixel point 
on the final screen.
FordPicture_8oXXX is a local object of XXX.
EnginePower_8sngFun is a function 
that is outputting as a Single type.
Traveled_8km_8sng is a single variable 
that also has a secondary link showing 
the importance Units of kilometers. 
Car_8colorG is a drawing.color variable 
defined at the Global level
CatAndDog_8bitmapM is a bitmap defined 
at the module level
And the list goes on and on.