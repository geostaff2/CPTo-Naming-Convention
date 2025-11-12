'**********************************************************************
' CPTo Naming Convention - VB.NET Example
' 
' This file demonstrates the CPTo naming convention in VB.NET.
' Each variable name clearly indicates its type and scope.
' 
' Author: CPTo Community
' Convention by: Richard S. Olsen, PhD PE
'**********************************************************************

Imports System
Imports System.Collections.Generic

Module CPToDemo
    ' Global-level variables (G suffix)
    Public AppName_8strG As String = "CPTo VB.NET Demo"
    Public MaxUsers_8intG As Integer = 500
    Public IsRunning_8blnG As Boolean = True
    Public Version_8dblG As Double = 3.0
    
    ' Module-level variables (M suffix)
    Private Config_8strM As String = "app.config"
    Private DatabasePath_8strM As String = "C:\Data\app.mdb"
    Private DefaultTimeout_8intM As Integer = 60
    
    '**********************************************************************
    ' Structure definition with CPTo convention
    ' Note: Structure names use s8___ prefix with 3 underscores
    '**********************************************************************
    Public Structure s8___Product
        Public Name_8str As String
        Public Price_8dbl As Double
        Public Quantity_8int As Integer
        Public InStock_8bln As Boolean
    End Structure
    
    '**********************************************************************
    ' Calculator Class demonstrating CPTo in VB.NET
    '**********************************************************************
    Public Class Calculator
        ' Class-level variables (M suffix for module/class level)
        Private PI_8dblM As Double = 3.14159265359
        Private LastResult_8dblM As Double = 0
        Private CalculationCount_8intM As Integer = 0
        
        ' Constructor
        Public Sub New()
            ' Local variables in constructor
            Dim InitialValue_8dbl As Double = 0.0
            Dim InitialCount_8int As Integer = 0
            
            Me.LastResult_8dblM = InitialValue_8dbl
            Me.CalculationCount_8intM = InitialCount_8int
        End Sub
        
        '**********************************************************************
        ' Calculate circle area with input parameter
        ' Radius_8dblI: Input parameter (I suffix)
        ' Returns: Area_8dblFun (Fun suffix for function return)
        '**********************************************************************
        Public Function CalculateArea(ByVal Radius_8dblI As Double) As Double
            ' Local variable
            Dim Area_8dbl As Double
            Area_8dbl = Me.PI_8dblM * Radius_8dblI * Radius_8dblI
            
            ' Update class member
            Me.LastResult_8dblM = Area_8dbl
            Me.CalculationCount_8intM += 1
            
            ' Return with function suffix
            Dim Area_8dblFun As Double = Area_8dbl
            Return Area_8dblFun
        End Function
        
        '**********************************************************************
        ' Calculate square with ByRef parameter
        ' Value_8dblI: Input parameter
        ' Result_8dblR: Reference parameter (R suffix for ByRef)
        '**********************************************************************
        Public Sub CalculateSquare(ByVal Value_8dblI As Double, ByRef Result_8dblR As Double)
            ' Local calculation
            Dim Square_8dbl As Double = Value_8dblI * Value_8dblI
            
            ' Modify reference parameter
            Result_8dblR = Square_8dbl
            
            ' Update class member
            Me.LastResult_8dblM = Square_8dbl
            Me.CalculationCount_8intM += 1
        End Sub
        
        '**********************************************************************
        ' Get calculation count
        '**********************************************************************
        Public Function GetCount() As Integer
            Dim Count_8intFun As Integer = Me.CalculationCount_8intM
            Return Count_8intFun
        End Function
    End Class
    
    '**********************************************************************
    ' Demonstrate array operations with CPTo convention
    '**********************************************************************
    Sub DemonstrateArrays()
        Console.WriteLine("Array Operations:")
        
        ' Single-dimensional array (a prefix)
        Dim Numbers_8aInt() As Integer = {1, 2, 3, 4, 5}
        Dim Names_8aStr() As String = {"Alice", "Bob", "Charlie", "David"}
        
        ' Two-dimensional array (aa prefix)
        Dim Grid_8aaInt(2, 2) As Integer
        Grid_8aaInt(0, 0) = 1
        Grid_8aaInt(0, 1) = 2
        Grid_8aaInt(0, 2) = 3
        Grid_8aaInt(1, 0) = 4
        Grid_8aaInt(1, 1) = 5
        Grid_8aaInt(1, 2) = 6
        Grid_8aaInt(2, 0) = 7
        Grid_8aaInt(2, 1) = 8
        Grid_8aaInt(2, 2) = 9
        
        ' Process array
        Dim Sum_8int As Integer = 0
        For Each Value_8int As Integer In Numbers_8aInt
            Sum_8int += Value_8int
        Next
        
        Dim Count_8int As Integer = Names_8aStr.Length
        
        Console.WriteLine("  Sum of numbers: " & Sum_8int.ToString())
        Console.WriteLine("  Count of names: " & Count_8int.ToString())
        Console.WriteLine("  2D Grid [0,0]: " & Grid_8aaInt(0, 0).ToString())
    End Sub
    
    '**********************************************************************
    ' String processing with input parameters
    '**********************************************************************
    Function ProcessString(ByVal Input_8strI As String, ByVal Pattern_8strI As String) As String
        ' Local variables
        Dim Modified_8str As String = Input_8strI.ToUpper()
        Dim Found_8bln As Boolean = Modified_8str.Contains(Pattern_8strI)
        Dim Position_8int As Integer = If(Found_8bln, Modified_8str.IndexOf(Pattern_8strI), -1)
        
        ' Build result
        Dim Result_8str As String
        If Found_8bln Then
            Result_8str = "Pattern found at position " & Position_8int.ToString()
        Else
            Result_8str = "Pattern not found"
        End If
        
        Dim Result_8strFun As String = Result_8str
        Return Result_8strFun
    End Function
    
    '**********************************************************************
    ' Physics calculation with unit information in variable names
    ' Distance_8km_8dbl: Distance in kilometers (secondary _8km info)
    ' Time_8hr_8dbl: Time in hours
    '**********************************************************************
    Function CalculateSpeed(ByVal Distance_8km_8dbl As Double, ByVal Time_8hr_8dbl As Double) As Double
        ' Calculate with unit information
        Dim Speed_8kmph_8dbl As Double = Distance_8km_8dbl / Time_8hr_8dbl
        
        ' Convert to miles
        Dim DistanceInMiles_8mi_8dbl As Double = Distance_8km_8dbl * 0.621371
        
        Console.WriteLine("  Distance: " & Distance_8km_8dbl.ToString() & " km (" & _
                         DistanceInMiles_8mi_8dbl.ToString("F2") & " miles)")
        Console.WriteLine("  Time: " & Time_8hr_8dbl.ToString() & " hours")
        Console.WriteLine("  Speed: " & Speed_8kmph_8dbl.ToString("F2") & " km/h")
        
        Dim Speed_8kmph_8dblFun As Double = Speed_8kmph_8dbl
        Return Speed_8kmph_8dblFun
    End Function
    
    '**********************************************************************
    ' Demonstrate structure usage
    '**********************************************************************
    Sub DemonstrateStructures()
        Console.WriteLine("Structure Operations:")
        
        ' Create structure instance with s8___ naming
        Dim Laptop_8s As s8___Product
        Laptop_8s.Name_8str = "Dell XPS 15"
        Laptop_8s.Price_8dbl = 1299.99
        Laptop_8s.Quantity_8int = 50
        Laptop_8s.InStock_8bln = True
        
        Console.WriteLine("  Product: " & Laptop_8s.Name_8str)
        Console.WriteLine("  Price: $" & Laptop_8s.Price_8dbl.ToString("F2"))
        Console.WriteLine("  Quantity: " & Laptop_8s.Quantity_8int.ToString())
        Console.WriteLine("  In Stock: " & If(Laptop_8s.InStock_8bln, "Yes", "No"))
    End Sub
    
    '**********************************************************************
    ' Demonstrate List/Collection operations
    '**********************************************************************
    Sub DemonstrateLists()
        Console.WriteLine("List/Collection Operations:")
        
        ' List of integers
        Dim Values_8aInt As New List(Of Integer)
        Values_8aInt.Add(10)
        Values_8aInt.Add(20)
        Values_8aInt.Add(30)
        Values_8aInt.Add(40)
        Values_8aInt.Add(50)
        
        ' List of strings
        Dim Cities_8aStr As New List(Of String) From {"New York", "London", "Tokyo", "Paris"}
        
        ' Process lists
        Dim Total_8int As Integer = 0
        For Each Value_8int As Integer In Values_8aInt
            Total_8int += Value_8int
        Next
        
        Dim CityCount_8int As Integer = Cities_8aStr.Count
        
        Console.WriteLine("  Total of values: " & Total_8int.ToString())
        Console.WriteLine("  Number of cities: " & CityCount_8int.ToString())
    End Sub
    
    '**********************************************************************
    ' Main entry point
    '**********************************************************************
    Sub Main()
        Console.WriteLine("============================================================")
        Console.WriteLine("CPTo Naming Convention - VB.NET Examples")
        Console.WriteLine("============================================================")
        Console.WriteLine()
        
        ' 1. Calculator Demo
        Console.WriteLine("1. Calculator Demo:")
        Dim Calc_8o As New Calculator()
        Dim Area_8dbl As Double = Calc_8o.CalculateArea(5.0)
        Console.WriteLine("  Circle area (r=5.0): " & Area_8dbl.ToString("F2"))
        
        ' Demonstrate ByRef parameter
        Dim SquareResult_8dbl As Double = 0.0
        Calc_8o.CalculateSquare(7.0, SquareResult_8dbl)
        Console.WriteLine("  Square of 7.0: " & SquareResult_8dbl.ToString("F2"))
        Console.WriteLine("  Total calculations: " & Calc_8o.GetCount().ToString())
        Console.WriteLine()
        
        ' 2. Array Operations
        Console.WriteLine("2. ")
        DemonstrateArrays()
        Console.WriteLine()
        
        ' 3. String Operations
        Console.WriteLine("3. String Operations:")
        Dim SearchResult_8str As String = ProcessString("Hello CPTo World", "CPTO")
        Console.WriteLine("  " & SearchResult_8str)
        Console.WriteLine()
        
        ' 4. Physics Calculation
        Console.WriteLine("4. Physics Calculation with Units:")
        Dim Speed_8dbl As Double = CalculateSpeed(200.0, 3.0)
        Console.WriteLine()
        
        ' 5. Structures
        Console.WriteLine("5. ")
        DemonstrateStructures()
        Console.WriteLine()
        
        ' 6. Lists
        Console.WriteLine("6. ")
        DemonstrateLists()
        Console.WriteLine()
        
        ' 7. Global Variables
        Console.WriteLine("7. Global Variables:")
        Console.WriteLine("  Application: " & AppName_8strG)
        Console.WriteLine("  Version: " & Version_8dblG.ToString("F1"))
        Console.WriteLine("  Max Users: " & MaxUsers_8intG.ToString())
        Console.WriteLine("  Running: " & If(IsRunning_8blnG, "Yes", "No"))
        Console.WriteLine()
        
        Console.WriteLine("============================================================")
        Console.WriteLine("Demo Complete!")
        Console.WriteLine("============================================================")
        
        ' Wait for user input before closing
        Console.WriteLine()
        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()
    End Sub
    
End Module
