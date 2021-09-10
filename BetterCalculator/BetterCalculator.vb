'Sebastian Soto
'RCET0265
'Fall 2021
'BetterCalculator
'https://github.com/SebastianSotoMk4/BetterCalculator.git
Option Strict On
Option Explicit On
Option Compare Text
Module BetterCalculator
    Sub Main()
        Dim inputOne As String
        Dim inputTwo As String
        Dim operat As String
        Dim intOperat As Integer
        Dim result As Integer
        Dim numOne As Integer
        Dim numTwo As Integer

        Console.WriteLine("Plese enter two numbers. Enter Q at any time to Quit")
        '///////////////////////////////////////////////////////////////////////////////
        Try
            Console.WriteLine("Enter a number:")
            inputOne = Console.ReadLine()
            Console.WriteLine($"You entered {inputOne}")
            numOne = CInt(inputOne)
        Catch ex As Exception

        End Try

        '////////////////////////////////////////////////////////////////////////////////
        Console.WriteLine("Enter a number:")
        inputTwo = Console.ReadLine()
        Console.WriteLine($"You entered {inputTwo}")
        numTwo = CInt(inputTwo)
        '////////////////////////////////////////////////////////////////////////////////
        Console.WriteLine("Choose one of the following options:")
        Console.WriteLine("1. ADD")
        Console.WriteLine("2. Subtract")
        Console.WriteLine("3. Multiply")
        Console.WriteLine("4. Divide")
        '////////////////////////////////////////////////////////////////////////////////
        operat = Console.ReadLine()
        If operat = "1" Then
            result = numOne + numTwo
        ElseIf operat = "2" Then
            result = numOne - numTwo
        ElseIf operat = "3" Then
            result = numOne * numTwo
        ElseIf operat = "4" Then
            result = numOne \ numTwo
        End If

        Console.WriteLine(result)




        Console.ReadLine()
    End Sub
End Module

