"""
CPTo Naming Convention - Python Example

This file demonstrates the CPTo naming convention in Python.
Each variable name clearly indicates its type and scope.

Author: CPTo Community
Convention by: Richard S. Olsen, PhD PE
"""

# Global-level variables (G suffix)
AppName_8strG = "CPTo Demo Application"
MaxUsers_8intG = 1000
IsDebugMode_8blnG = True
Version_8dblG = 1.0

# Module-level variables (M suffix)
Config_8strM = "config.json"
DatabasePath_8strM = "/data/app.db"
DefaultTimeout_8intM = 30


class CalculatorDemo:
    """Demonstrates CPTo convention in a class context"""
    
    # Class/Module-level variables
    PI_8dblM = 3.14159265359
    DefaultPrecision_8intM = 2
    
    def __init__(self):
        """Initialize with local variables"""
        # Local variables (no suffix)
        self.ResultCache_8aInt = []  # Array of integers
        self.LastResult_8dbl = 0.0
    
    def calculate_area(self, Radius_8dblI):
        """
        Calculate circle area with input parameter
        
        Args:
            Radius_8dblI: Input parameter - radius as double
        
        Returns:
            Area_8dblFun: Function return value - area as double
        """
        # Local variable
        Area_8dbl = self.PI_8dblM * Radius_8dblI * Radius_8dblI
        
        # Store in class variable
        self.LastResult_8dbl = Area_8dbl
        
        # Return with function suffix
        Area_8dblFun = Area_8dbl
        return Area_8dblFun
    
    def process_values(self, InputList_8aIntI, Multiplier_8intI):
        """
        Process array of values with reference behavior
        
        Args:
            InputList_8aIntI: Input array of integers
            Multiplier_8intI: Input multiplier integer
        
        Returns:
            Results_8aInt: Array of processed integers
        """
        # Local variables
        Results_8aInt = []
        Count_8int = 0
        
        # Process each value
        for Value_8int in InputList_8aIntI:
            Result_8int = Value_8int * Multiplier_8intI
            Results_8aInt.append(Result_8int)
            Count_8int += 1
        
        # Store count as local
        TotalProcessed_8int = Count_8int
        print(f"Processed {TotalProcessed_8int} values")
        
        return Results_8aInt


def demonstrate_string_operations(Input_8strI, Pattern_8strI):
    """
    Demonstrate string operations with CPTo convention
    
    Args:
        Input_8strI: Input string parameter
        Pattern_8strI: Input pattern string
    
    Returns:
        Result_8strFun: Function return string
    """
    # Local variables
    Modified_8str = Input_8strI.upper()
    Found_8bln = Pattern_8strI in Modified_8str
    Position_8int = Modified_8str.find(Pattern_8strI) if Found_8bln else -1
    
    # Build result string
    if Found_8bln:
        Result_8str = f"Pattern found at position {Position_8int}"
    else:
        Result_8str = "Pattern not found"
    
    Result_8strFun = Result_8str
    return Result_8strFun


def work_with_arrays():
    """Demonstrate array operations with CPTo convention"""
    # Single-dimensional array
    Numbers_8aInt = [1, 2, 3, 4, 5]
    Names_8aStr = ["Alice", "Bob", "Charlie"]
    
    # Two-dimensional array (list of lists)
    Grid_8aaInt = [
        [1, 2, 3],
        [4, 5, 6],
        [7, 8, 9]
    ]
    
    # Three-dimensional array
    Cube_8aaaInt = [
        [[1, 2], [3, 4]],
        [[5, 6], [7, 8]]
    ]
    
    # Process arrays
    Sum_8int = sum(Numbers_8aInt)
    Count_8int = len(Names_8aStr)
    
    print(f"Sum of numbers: {Sum_8int}")
    print(f"Count of names: {Count_8int}")
    print(f"2D Grid: {Grid_8aaInt}")


def demonstrate_distance_calculation(Distance_8km_8dbl, Time_8hr_8dbl):
    """
    Demonstrate secondary type information (units)
    
    Args:
        Distance_8km_8dbl: Distance in kilometers
        Time_8hr_8dbl: Time in hours
    
    Returns:
        Speed_8kmph_8dblFun: Speed in km/h
    """
    # Calculate with unit information in variable name
    Speed_8kmph_8dbl = Distance_8km_8dbl / Time_8hr_8dbl
    
    # Local variables with units
    DistanceInMiles_8mi_8dbl = Distance_8km_8dbl * 0.621371
    
    print(f"Distance: {Distance_8km_8dbl} km ({DistanceInMiles_8mi_8dbl:.2f} miles)")
    print(f"Time: {Time_8hr_8dbl} hours")
    print(f"Speed: {Speed_8kmph_8dbl:.2f} km/h")
    
    Speed_8kmph_8dblFun = Speed_8kmph_8dbl
    return Speed_8kmph_8dblFun


def main():
    """Main demonstration function"""
    print("=" * 60)
    print("CPTo Naming Convention - Python Examples")
    print("=" * 60)
    print()
    
    # Demonstrate calculator
    print("1. Calculator Demo:")
    Calculator_8o = CalculatorDemo()
    Area_8dbl = Calculator_8o.calculate_area(5.0)
    print(f"   Circle area (r=5.0): {Area_8dbl:.2f}")
    print()
    
    # Demonstrate array processing
    print("2. Array Processing:")
    TestValues_8aInt = [1, 2, 3, 4, 5]
    ProcessedResults_8aInt = Calculator_8o.process_values(TestValues_8aInt, 2)
    print(f"   Original: {TestValues_8aInt}")
    print(f"   Multiplied by 2: {ProcessedResults_8aInt}")
    print()
    
    # Demonstrate string operations
    print("3. String Operations:")
    SearchResult_8str = demonstrate_string_operations("Hello World", "WORLD")
    print(f"   {SearchResult_8str}")
    print()
    
    # Demonstrate arrays
    print("4. Array Operations:")
    work_with_arrays()
    print()
    
    # Demonstrate distance calculation
    print("5. Distance Calculation with Units:")
    Speed_8dbl = demonstrate_distance_calculation(100.0, 2.0)
    print()
    
    # Access global variables
    print("6. Global Variables:")
    print(f"   Application: {AppName_8strG}")
    print(f"   Version: {Version_8dblG}")
    print(f"   Max Users: {MaxUsers_8intG}")
    print(f"   Debug Mode: {IsDebugMode_8blnG}")
    print()
    
    print("=" * 60)
    print("Demo Complete!")
    print("=" * 60)


if __name__ == "__main__":
    main()
