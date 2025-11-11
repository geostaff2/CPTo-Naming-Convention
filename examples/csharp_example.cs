/**
 * CPTo Naming Convention - C# Example
 * 
 * This file demonstrates the CPTo naming convention in C#.
 * Each variable name clearly indicates its type and scope.
 * 
 * Author: CPTo Community
 * Convention by: Richard S. Olsen, PhD PE
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace CPToDemo
{
    /// <summary>
    /// Main demonstration program
    /// </summary>
    class Program
    {
        // Global-level variables (G suffix) - static for demo purposes
        public static string AppName_8strG = "CPTo C# Demo";
        public static int MaxConnections_8intG = 200;
        public static bool IsDebugMode_8blnG = true;
        public static double Version_8dblG = 2.0;
        
        /// <summary>
        /// Main entry point
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("============================================================");
            Console.WriteLine("CPTo Naming Convention - C# Examples");
            Console.WriteLine("============================================================");
            Console.WriteLine();
            
            // 1. Calculator Demo
            Console.WriteLine("1. Calculator Demo:");
            Calculator Calc_8o = new Calculator();
            double Area_8dbl = Calc_8o.CalculateArea(5.0);
            Console.WriteLine($"  Circle area (r=5.0): {Area_8dbl:F2}");
            
            // Demonstrate ref parameter
            double SquareResult_8dbl = 0.0;
            Calc_8o.CalculateSquare(7.0, ref SquareResult_8dbl);
            Console.WriteLine($"  Square of 7.0: {SquareResult_8dbl:F2}");
            Console.WriteLine($"  Total calculations: {Calc_8o.GetCount()}");
            Console.WriteLine();
            
            // 2. Array Operations
            Console.Write("2. ");
            DemonstrateArrays();
            Console.WriteLine();
            
            // 3. String Operations
            Console.WriteLine("3. String Operations:");
            string SearchResult_8str = ProcessString("Hello CPTo World", "CPTo");
            Console.WriteLine($"  {SearchResult_8str}");
            Console.WriteLine();
            
            // 4. Physics Calculation
            Console.WriteLine("4. Physics Calculation with Units:");
            double Speed_8dbl = CalculateSpeed(180.0, 3.0);
            Console.WriteLine();
            
            // 5. Collections
            Console.Write("5. ");
            DemonstrateCollections();
            Console.WriteLine();
            
            // 6. Structures
            Console.Write("6. ");
            DemonstrateStructures();
            Console.WriteLine();
            
            // 7. LINQ Operations
            Console.Write("7. ");
            DemonstrateLINQ();
            Console.WriteLine();
            
            // 8. Global Variables
            Console.WriteLine("8. Global Variables:");
            Console.WriteLine($"  Application: {AppName_8strG}");
            Console.WriteLine($"  Version: {Version_8dblG:F1}");
            Console.WriteLine($"  Max Connections: {MaxConnections_8intG}");
            Console.WriteLine($"  Debug Mode: {(IsDebugMode_8blnG ? "Yes" : "No")}");
            Console.WriteLine();
            
            Console.WriteLine("============================================================");
            Console.WriteLine("Demo Complete!");
            Console.WriteLine("============================================================");
            
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        
        /// <summary>
        /// Demonstrate array operations
        /// </summary>
        static void DemonstrateArrays()
        {
            Console.WriteLine("Array Operations:");
            
            // Single-dimensional arrays
            int[] Numbers_8aInt = { 1, 2, 3, 4, 5 };
            string[] Names_8aStr = { "Alice", "Bob", "Charlie", "David" };
            
            // Two-dimensional array
            int[,] Grid_8aaInt = new int[3, 3] {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };
            
            // Process arrays
            int Sum_8int = 0;
            foreach (int Value_8int in Numbers_8aInt)
            {
                Sum_8int += Value_8int;
            }
            
            int Count_8int = Names_8aStr.Length;
            
            Console.WriteLine($"  Sum of numbers: {Sum_8int}");
            Console.WriteLine($"  Count of names: {Count_8int}");
            Console.WriteLine($"  2D Grid [0,0]: {Grid_8aaInt[0, 0]}");
        }
        
        /// <summary>
        /// String processing demonstration
        /// </summary>
        /// <param name="Input_8strI">Input string</param>
        /// <param name="Pattern_8strI">Pattern to search</param>
        /// <returns>Result message</returns>
        static string ProcessString(string Input_8strI, string Pattern_8strI)
        {
            // Local variables
            string Modified_8str = Input_8strI.ToUpper();
            bool Found_8bln = Modified_8str.Contains(Pattern_8strI.ToUpper());
            int Position_8int = Found_8bln ? Modified_8str.IndexOf(Pattern_8strI.ToUpper()) : -1;
            
            // Build result
            string Result_8str;
            if (Found_8bln)
            {
                Result_8str = $"Pattern found at position {Position_8int}";
            }
            else
            {
                Result_8str = "Pattern not found";
            }
            
            string Result_8strFun = Result_8str;
            return Result_8strFun;
        }
        
        /// <summary>
        /// Physics calculation with unit information
        /// </summary>
        /// <param name="Distance_8km_8dbl">Distance in kilometers</param>
        /// <param name="Time_8hr_8dbl">Time in hours</param>
        /// <returns>Speed in km/h</returns>
        static double CalculateSpeed(double Distance_8km_8dbl, double Time_8hr_8dbl)
        {
            // Calculate with unit information
            double Speed_8kmph_8dbl = Distance_8km_8dbl / Time_8hr_8dbl;
            
            // Convert to miles
            double DistanceInMiles_8mi_8dbl = Distance_8km_8dbl * 0.621371;
            
            Console.WriteLine($"  Distance: {Distance_8km_8dbl} km ({DistanceInMiles_8mi_8dbl:F2} miles)");
            Console.WriteLine($"  Time: {Time_8hr_8dbl} hours");
            Console.WriteLine($"  Speed: {Speed_8kmph_8dbl:F2} km/h");
            
            double Speed_8kmph_8dblFun = Speed_8kmph_8dbl;
            return Speed_8kmph_8dblFun;
        }
        
        /// <summary>
        /// Demonstrate collection operations
        /// </summary>
        static void DemonstrateCollections()
        {
            Console.WriteLine("Collection Operations:");
            
            // List of integers
            List<int> Values_8aInt = new List<int> { 10, 20, 30, 40, 50 };
            
            // List of strings
            List<string> Cities_8aStr = new List<string> { "New York", "London", "Tokyo", "Paris" };
            
            // Dictionary
            Dictionary<string, int> Ages_8oDictStrInt = new Dictionary<string, int>
            {
                { "Alice", 30 },
                { "Bob", 25 },
                { "Charlie", 35 }
            };
            
            // Process collections
            int Total_8int = Values_8aInt.Sum();
            int CityCount_8int = Cities_8aStr.Count;
            bool HasAlice_8bln = Ages_8oDictStrInt.ContainsKey("Alice");
            
            Console.WriteLine($"  Total of values: {Total_8int}");
            Console.WriteLine($"  Number of cities: {CityCount_8int}");
            Console.WriteLine($"  Dictionary has 'Alice': {(HasAlice_8bln ? "Yes" : "No")}");
        }
        
        /// <summary>
        /// Demonstrate structure usage
        /// </summary>
        static void DemonstrateStructures()
        {
            Console.WriteLine("Structure Operations:");
            
            // Create structure instance
            s8___Product Laptop_8s = new s8___Product
            {
                Name_8str = "HP Spectre x360",
                Price_8dbl = 1599.99,
                Quantity_8int = 25,
                InStock_8bln = true
            };
            
            Console.WriteLine($"  Product: {Laptop_8s.Name_8str}");
            Console.WriteLine($"  Price: ${Laptop_8s.Price_8dbl:F2}");
            Console.WriteLine($"  Quantity: {Laptop_8s.Quantity_8int}");
            Console.WriteLine($"  In Stock: {(Laptop_8s.InStock_8bln ? "Yes" : "No")}");
        }
        
        /// <summary>
        /// Demonstrate LINQ operations with CPTo
        /// </summary>
        static void DemonstrateLINQ()
        {
            Console.WriteLine("LINQ Operations:");
            
            // Sample data
            int[] Numbers_8aInt = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            // Filter even numbers
            var EvenNumbers_8aInt = Numbers_8aInt.Where(n_8int => n_8int % 2 == 0).ToArray();
            
            // Calculate squares
            var Squares_8aInt = Numbers_8aInt.Select(n_8int => n_8int * n_8int).ToArray();
            
            // Sum of all
            int Total_8int = Numbers_8aInt.Sum();
            
            Console.WriteLine($"  Original: [{string.Join(", ", Numbers_8aInt)}]");
            Console.WriteLine($"  Even numbers: [{string.Join(", ", EvenNumbers_8aInt)}]");
            Console.WriteLine($"  Squares: [{string.Join(", ", Squares_8aInt)}]");
            Console.WriteLine($"  Total sum: {Total_8int}");
        }
    }
    
    /// <summary>
    /// Calculator class demonstrating CPTo in C#
    /// </summary>
    public class Calculator
    {
        // Class member variables (M suffix)
        private const double PI_8dblM = 3.14159265359;
        private double LastResult_8dblM;
        private int CalculationCount_8intM;
        
        /// <summary>
        /// Constructor
        /// </summary>
        public Calculator()
        {
            // Local variables in constructor
            double InitialValue_8dbl = 0.0;
            int InitialCount_8int = 0;
            
            this.LastResult_8dblM = InitialValue_8dbl;
            this.CalculationCount_8intM = InitialCount_8int;
        }
        
        /// <summary>
        /// Calculate circle area
        /// </summary>
        /// <param name="Radius_8dblI">Input parameter - radius</param>
        /// <returns>Area of the circle</returns>
        public double CalculateArea(double Radius_8dblI)
        {
            // Local variable
            double Area_8dbl = PI_8dblM * Radius_8dblI * Radius_8dblI;
            
            // Update member variable
            this.LastResult_8dblM = Area_8dbl;
            this.CalculationCount_8intM++;
            
            // Return with function suffix
            double Area_8dblFun = Area_8dbl;
            return Area_8dblFun;
        }
        
        /// <summary>
        /// Calculate square using ref parameter
        /// </summary>
        /// <param name="Value_8dblI">Input value</param>
        /// <param name="Result_8dblR">Reference parameter - modified by method</param>
        public void CalculateSquare(double Value_8dblI, ref double Result_8dblR)
        {
            // Local calculation
            double Square_8dbl = Value_8dblI * Value_8dblI;
            
            // Modify reference parameter
            Result_8dblR = Square_8dbl;
            
            // Update member
            this.LastResult_8dblM = Square_8dbl;
            this.CalculationCount_8intM++;
        }
        
        /// <summary>
        /// Get calculation count
        /// </summary>
        /// <returns>Number of calculations performed</returns>
        public int GetCount()
        {
            int Count_8intFun = this.CalculationCount_8intM;
            return Count_8intFun;
        }
        
        /// <summary>
        /// Get last result
        /// </summary>
        /// <returns>Last calculation result</returns>
        public double GetLastResult()
        {
            double Result_8dblFun = this.LastResult_8dblM;
            return Result_8dblFun;
        }
    }
    
    /// <summary>
    /// Structure definition with CPTo convention
    /// Note: Structure names use s8___ prefix with 3 underscores
    /// </summary>
    public struct s8___Product
    {
        public string Name_8str;
        public double Price_8dbl;
        public int Quantity_8int;
        public bool InStock_8bln;
    }
}
