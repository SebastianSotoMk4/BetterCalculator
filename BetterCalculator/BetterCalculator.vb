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
        Dim operat As String 'operator choice + - * \
        Dim numOneValid As Boolean
        Dim numTwoValid As Boolean
        Dim operatValid As Boolean
        Dim quit As Boolean
        Dim result As Integer
        Dim numOne As Integer
        Dim numTwo As Integer

        Do While quit = False
            Console.WriteLine("Plese enter two numbers. Enter Q at any time to Quit")

            Do Until numOneValid = True Or quit = True
                Try
                    Console.WriteLine("Enter a number:")
                    inputOne = Console.ReadLine()
                    Console.WriteLine($"You entered {inputOne}")
                    numOne = CInt(inputOne)
                    numOneValid = True
                Catch ex As Exception  'IF the catch is triggerd Quit will be checked for. If not a Q then user will be prompted to re enter a number
                    If inputOne = "q" Then
                        quit = True
                    ElseIf inputOne <> "q" Then
                        Console.WriteLine($"You entered: {inputOne} , please enter a whole number")
                    End If
                End Try
            Loop

            Do Until numTwoValid = True Or quit = True 'If quit is True from previous loop then this loop will not trigger.
                Try
                    Console.WriteLine("Enter a number:")
                    inputTwo = Console.ReadLine()
                    Console.WriteLine($"You entered {inputTwo}")
                    numTwo = CInt(inputTwo)
                    numTwoValid = True
                Catch ex As Exception
                    If inputTwo = "q" Or quit = True Then
                        numTwoValid = True
                        quit = True
                    ElseIf inputTwo <> "q" Or quit <> True Then
                        Console.WriteLine($"You entered: {inputOne} , please enter a whole number")
                    End If
                End Try
            Loop

            If quit = True Then
                'Do nothing.
            ElseIf quit = False Then
                Console.WriteLine("Choose one of the following options:")
                Console.WriteLine("1. ADD")
                Console.WriteLine("2. Subtract")
                Console.WriteLine("3. Multiply")
                Console.WriteLine("4. Divide")
            End If

            Do
                If quit = True Then
                    'Do nothing
                ElseIf quit = False Then
                    operat = Console.ReadLine()
                    If operat = "1" Or operat = "2" Or operat = "3" Or operat = "4" Or operat = "q" Then
                        operatValid = True
                    ElseIf operatValid = False Then
                        Console.WriteLine("Please select option 1, 2, 3 ,4 or Q to Quit")
                    End If
                End If

            Loop Until operatValid = True Or quit = True

            If operat = "q" Then ' if the user types Q in the operator select, the main loop will end, closing the program.
                quit = True
            ElseIf operat = "1" Then
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

            numOneValid = False 'Resets valid checks
            numTwoValid = False
            operatValid = False
        Loop
        Console.WriteLine("Have a good day!")
        Console.WriteLine("Press enter to close program")
        Console.ReadLine()
    End Sub
End Module

