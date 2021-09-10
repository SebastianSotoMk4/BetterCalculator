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
        Dim numOneGood As Boolean
        Dim numTwoGood As Boolean
        Dim intOperat As Integer
        Dim result As Integer
        Dim numOne As Integer
        Dim numTwo As Integer

        Console.WriteLine("Plese enter two numbers. Enter Q at any time to Quit")

        '///////////////////////////////////////////////////////////////////////////////
        Do
            Try
                Console.WriteLine("Enter a number:")
                inputOne = Console.ReadLine()
                Console.WriteLine($"You entered {inputOne}")
                numOne = CInt(inputOne)
                numOneGood = True
            Catch ex As Exception
                Console.WriteLine($"You entered: {inputOne} , please enter a whole number")
            End Try
        Loop Until numOneGood = True

        '////////////////////////////////////////////////////////////////////////////////

        Do
            Try
                Console.WriteLine("Enter a number:")
                inputTwo = Console.ReadLine()
                Console.WriteLine($"You entered {inputTwo}")
                numTwo = CInt(inputTwo)
                numTwoGood = True

            Catch ex As Exception
                Console.WriteLine($"You entered: {inputOne} , please enter a whole number")
            End Try
        Loop Until numTwoGood = True

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
            Console.WriteLine($"{numOne} + {numTwo} = {result}")
        ElseIf operat = "2" Then
            result = numOne - numTwo
            Console.WriteLine($"{numOne} - {numTwo} = {result}")
        ElseIf operat = "3" Then
            result = numOne * numTwo
            Console.WriteLine($"{numOne} * {numTwo} = {result}")
        ElseIf operat = "4" Then
            result = numOne \ numTwo
            Console.WriteLine($"{numOne} \ {numTwo} = {result}")
        End If





        Console.ReadLine()
    End Sub
End Module

