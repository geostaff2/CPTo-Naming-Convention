/**
 * CPTo Naming Convention - C++ Example
 * 
 * This file demonstrates the CPTo naming convention in C++.
 * Each variable name clearly indicates its type and scope.
 * 
 * Author: CPTo Community
 * Convention by: Richard S. Olsen, PhD PE
 */

#include <iostream>
#include <string>
#include <vector>
#include <cmath>

// Global-level variables (G suffix)
std::string AppName_8strG = "CPTo C++ Demo";
int MaxConnections_8intG = 100;
bool IsInitialized_8blnG = false;
double Version_8dblG = 2.5;

// Module/Namespace-level constants (M suffix)
namespace Config {
    const double PI_8dblM = 3.14159265359;
    const int DefaultBufferSize_8intM = 1024;
    const std::string DatabaseName_8strM = "app_database.db";
}

/**
 * Calculator class demonstrating CPTo in C++
 */
class Calculator {
private:
    // Class member variables (M suffix)
    double LastResult_8dblM;
    int CalculationCount_8intM;
    
public:
    /**
     * Constructor - initialize member variables
     */
    Calculator() {
        // Local variables in constructor
        double InitialValue_8dbl = 0.0;
        int InitialCount_8int = 0;
        
        this->LastResult_8dblM = InitialValue_8dbl;
        this->CalculationCount_8intM = InitialCount_8int;
    }
    
    /**
     * Calculate circle area
     * 
     * @param Radius_8dblI Input parameter - radius
     * @return Area_8dblFun Function return value - area
     */
    double calculateArea(double Radius_8dblI) {
        // Local variable
        double Area_8dbl = Config::PI_8dblM * Radius_8dblI * Radius_8dblI;
        
        // Update member variable
        this->LastResult_8dblM = Area_8dbl;
        this->CalculationCount_8intM++;
        
        // Return with function suffix
        double Area_8dblFun = Area_8dbl;
        return Area_8dblFun;
    }
    
    /**
     * Calculate using reference parameter
     * 
     * @param Value_8dblI Input value
     * @param Result_8dblR Reference parameter - modified by function
     */
    void calculateSquare(double Value_8dblI, double& Result_8dblR) {
        // Local calculation
        double Square_8dbl = Value_8dblI * Value_8dblI;
        
        // Modify reference parameter
        Result_8dblR = Square_8dbl;
        
        // Update member
        this->LastResult_8dblM = Square_8dbl;
        this->CalculationCount_8intM++;
    }
    
    /**
     * Get calculation count
     * 
     * @return Count_8intFun Function return value
     */
    int getCalculationCount() const {
        int Count_8intFun = this->CalculationCount_8intM;
        return Count_8intFun;
    }
};

/**
 * Demonstrate array operations with CPTo convention
 */
void demonstrateArrays() {
    std::cout << "Array Operations:" << std::endl;
    
    // Single-dimensional array (vector)
    std::vector<int> Numbers_8aInt = {1, 2, 3, 4, 5};
    std::vector<std::string> Names_8aStr = {"Alice", "Bob", "Charlie"};
    
    // Two-dimensional array
    std::vector<std::vector<int>> Grid_8aaInt = {
        {1, 2, 3},
        {4, 5, 6},
        {7, 8, 9}
    };
    
    // Process array
    int Sum_8int = 0;
    for (int Value_8int : Numbers_8aInt) {
        Sum_8int += Value_8int;
    }
    
    int Count_8int = static_cast<int>(Names_8aStr.size());
    
    std::cout << "  Sum of numbers: " << Sum_8int << std::endl;
    std::cout << "  Count of names: " << Count_8int << std::endl;
    std::cout << "  2D Grid first element: " << Grid_8aaInt[0][0] << std::endl;
}

/**
 * String operations demonstration
 * 
 * @param Input_8strI Input string
 * @param Pattern_8strI Pattern to search
 * @return Result_8strFun Result message
 */
std::string processString(std::string Input_8strI, std::string Pattern_8strI) {
    // Local variables
    std::string Modified_8str = Input_8strI;
    bool Found_8bln = Modified_8str.find(Pattern_8strI) != std::string::npos;
    size_t Position_8int = Found_8bln ? Modified_8str.find(Pattern_8strI) : -1;
    
    // Build result
    std::string Result_8str;
    if (Found_8bln) {
        Result_8str = "Pattern found at position " + std::to_string(Position_8int);
    } else {
        Result_8str = "Pattern not found";
    }
    
    std::string Result_8strFun = Result_8str;
    return Result_8strFun;
}

/**
 * Physics calculation with unit information
 * 
 * @param Distance_8km_8dbl Distance in kilometers
 * @param Time_8hr_8dbl Time in hours
 * @return Speed_8kmph_8dblFun Speed in km/h
 */
double calculateSpeed(double Distance_8km_8dbl, double Time_8hr_8dbl) {
    // Calculate with unit information
    double Speed_8kmph_8dbl = Distance_8km_8dbl / Time_8hr_8dbl;
    
    // Convert to miles
    double DistanceInMiles_8mi_8dbl = Distance_8km_8dbl * 0.621371;
    
    std::cout << "  Distance: " << Distance_8km_8dbl << " km (" 
              << DistanceInMiles_8mi_8dbl << " miles)" << std::endl;
    std::cout << "  Time: " << Time_8hr_8dbl << " hours" << std::endl;
    std::cout << "  Speed: " << Speed_8kmph_8dbl << " km/h" << std::endl;
    
    double Speed_8kmph_8dblFun = Speed_8kmph_8dbl;
    return Speed_8kmph_8dblFun;
}

/**
 * Demonstrate pointer and reference usage
 */
void demonstratePointers() {
    std::cout << "Pointer and Reference Operations:" << std::endl;
    
    // Local variables
    int Value_8int = 42;
    int* Pointer_8pInt = &Value_8int;  // Pointer to integer
    int& Reference_8rInt = Value_8int;  // Reference to integer
    
    // Modify through pointer
    *Pointer_8pInt = 100;
    
    std::cout << "  Original value: " << Value_8int << std::endl;
    std::cout << "  Through pointer: " << *Pointer_8pInt << std::endl;
    std::cout << "  Through reference: " << Reference_8rInt << std::endl;
    
    // Demonstrate array pointer
    int ArrayData_8aInt[] = {1, 2, 3, 4, 5};
    int* ArrayPointer_8pInt = ArrayData_8aInt;
    
    std::cout << "  First array element via pointer: " << *ArrayPointer_8pInt << std::endl;
}

/**
 * Structure example with CPTo convention
 */
struct s8___Vehicle {
    std::string Model_8str;
    int Year_8int;
    double Price_8dbl;
    bool IsElectric_8bln;
};

/**
 * Demonstrate structure usage
 */
void demonstrateStructures() {
    std::cout << "Structure Operations:" << std::endl;
    
    // Create structure instance
    s8___Vehicle Car_8s;
    Car_8s.Model_8str = "Tesla Model 3";
    Car_8s.Year_8int = 2024;
    Car_8s.Price_8dbl = 45000.00;
    Car_8s.IsElectric_8bln = true;
    
    std::cout << "  Vehicle: " << Car_8s.Model_8str << std::endl;
    std::cout << "  Year: " << Car_8s.Year_8int << std::endl;
    std::cout << "  Price: $" << Car_8s.Price_8dbl << std::endl;
    std::cout << "  Electric: " << (Car_8s.IsElectric_8bln ? "Yes" : "No") << std::endl;
}

/**
 * Main demonstration function
 */
int main() {
    std::cout << "============================================================" << std::endl;
    std::cout << "CPTo Naming Convention - C++ Examples" << std::endl;
    std::cout << "============================================================" << std::endl;
    std::cout << std::endl;
    
    // 1. Calculator Demo
    std::cout << "1. Calculator Demo:" << std::endl;
    Calculator Calc_8o;
    double Area_8dbl = Calc_8o.calculateArea(5.0);
    std::cout << "  Circle area (r=5.0): " << Area_8dbl << std::endl;
    
    // Demonstrate reference parameter
    double SquareResult_8dbl = 0.0;
    Calc_8o.calculateSquare(7.0, SquareResult_8dbl);
    std::cout << "  Square of 7.0: " << SquareResult_8dbl << std::endl;
    std::cout << "  Total calculations: " << Calc_8o.getCalculationCount() << std::endl;
    std::cout << std::endl;
    
    // 2. Array Operations
    std::cout << "2. ";
    demonstrateArrays();
    std::cout << std::endl;
    
    // 3. String Operations
    std::cout << "3. String Operations:" << std::endl;
    std::string SearchResult_8str = processString("Hello CPTo World", "CPTo");
    std::cout << "  " << SearchResult_8str << std::endl;
    std::cout << std::endl;
    
    // 4. Physics Calculation
    std::cout << "4. Physics Calculation with Units:" << std::endl;
    double Speed_8dbl = calculateSpeed(150.0, 2.5);
    std::cout << std::endl;
    
    // 5. Pointers and References
    std::cout << "5. ";
    demonstratePointers();
    std::cout << std::endl;
    
    // 6. Structures
    std::cout << "6. ";
    demonstrateStructures();
    std::cout << std::endl;
    
    // 7. Global Variables
    std::cout << "7. Global Variables:" << std::endl;
    std::cout << "  Application: " << AppName_8strG << std::endl;
    std::cout << "  Version: " << Version_8dblG << std::endl;
    std::cout << "  Max Connections: " << MaxConnections_8intG << std::endl;
    std::cout << "  Initialized: " << (IsInitialized_8blnG ? "Yes" : "No") << std::endl;
    std::cout << std::endl;
    
    std::cout << "============================================================" << std::endl;
    std::cout << "Demo Complete!" << std::endl;
    std::cout << "============================================================" << std::endl;
    
    return 0;
}
