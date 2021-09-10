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
        Dim userNumOne As String
        Dim userNumTwo As String
        Dim numberValid As Boolean
        Dim numOne As Integer
        Dim numTwo As Integer
        Dim result As Integer
        Console.WriteLine("Plese enter two numbers. Enter Q at any time to quit.")
        userNumOne = Console.ReadLine()
        Console.WriteLine($"You entered {userNumOne}")
        Console.WriteLine("Enter another number")
        userNumTwo = Console.ReadLine()
        Console.WriteLine($"You entered {userNumTwo}")
        Do
            Try
                numOne = CInt(userNumOne)



            Catch ex As Exception

            End Try
            Try

                numTwo = CInt(userNumTwo)
                numberValid = True
                result = numOne + numTwo
                Console.WriteLine($"{numOne} + {numTwo} = {result}")
                Console.WriteLine("Enter a Whole Number Please")
                Console.WriteLine("Enter First number")
                userNumOne = Console.ReadLine()
                Console.WriteLine("Enter Second number")
                userNumTwo = Console.ReadLine()

            Catch ex As Exception
                If userNumTwo <> "q" Or userNumOne <> "q" Then
                    numberValid = False
                End If
            End Try
        Loop Until numberValid = False
    End Sub

End Module
