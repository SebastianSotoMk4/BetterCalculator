'Sebastian Soto
'RCET0265
'Fall 2021
'BetterCalculator
'https://github.com/SebastianSotoMk4/BetterCalculator.git
Option Strict On
Option Explicit On
Module BetterCalculator
    Sub Main()
        ' ask how to like, readline with text

        Dim userInput As String
        Dim numOne As Integer
        Dim NumTwo As Integer
        Dim result As Integer
        Console.WriteLine("Plese enter two numbers. Enter Q at any time to quit.")
        Console.ReadLine("Enter a number:")
        Console.WriteLine($"You entered {userInput}")
        Console.ReadLine()
        'Do Until userInput = "q" Or userInput = "Q" ' the Do Untill should allow the all functions untill a "Q" is enterd

        '    Try
        '        numOne = CInt(userInput)

        '    Catch ex As Exception

        '    End Try

        '    Console.WriteLine("")
        'Loop
    End Sub

End Module
