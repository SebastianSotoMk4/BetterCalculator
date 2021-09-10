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
        Dim quit As Boolean
        Do While quit = False


            Console.WriteLine("Plese enter two numbers. Enter Q at any time to Quit")

            '///////////////////////////////////////////////////////////////////////////////
            Do Until numOneGood = True Or quit = True
                Try
                    Console.WriteLine("Enter a number:")
                    inputOne = Console.ReadLine()
                    Console.WriteLine($"You entered {inputOne}")
                    numOne = CInt(inputOne)
                    numOneGood = True
                Catch ex As Exception
                    If inputOne = "q" Then
                        quit = True
                    ElseIf inputOne <> "q" Then
                        Console.WriteLine($"You entered: {inputOne} , please enter a whole number")
                    End If
                End Try
            Loop

            '////////////////////////////////////////////////////////////////////////////////

            Do Until numTwoGood = True Or quit = True
                Try
                    Console.WriteLine("Enter a number:")
                    inputTwo = Console.ReadLine()
                    Console.WriteLine($"You entered {inputTwo}")
                    numTwo = CInt(inputTwo)
                    numTwoGood = True
                Catch ex As Exception
                    If inputTwo = "q" Or quit = True Then
                        numTwoGood = True
                    ElseIf inputTwo <> "q" Or quit <> True Then
                        Console.WriteLine($"You entered: {inputOne} , please enter a whole number")
                    End If

                End Try
            Loop

            '////////////////////////////////////////////////////////////////////////////////
            If quit = True Then

            ElseIf quit = False Then
                Console.WriteLine("Choose one of the following options:")
                Console.WriteLine("1. ADD")
                Console.WriteLine("2. Subtract")
                Console.WriteLine("3. Multiply")
                Console.WriteLine("4. Divide")
            End If


            '////////////////////////////////////////////////////////////////////////////////
            If quit = True Then

            ElseIf quit = False Then
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
                numOneGood = False
                numTwoGood = False
            End If

        Loop
        Console.WriteLine("have a nice life")

        Console.ReadLine()
    End Sub
End Module

