Module Calculator
    Sub Main()
        Console.Write("Enter the first number: ")
        Dim num1 As Double = Console.ReadLine()

        Console.Write("Enter the operation (+, -, *, /, \, Mod, ^): ")
        Dim operation As String = Console.ReadLine()

        Console.Write("Enter the second number: ")
        Dim num2 As Double = Console.ReadLine()

        Dim result As Double

        Select Case operation
            Case "+"
                result = num1 + num2
            Case "-"
                result = num1 - num2
            Case "*"
                result = num1 * num2
            Case "/"
                result = num1 / num2
            Case "\"
                result = num1 \ num2
            Case "Mod"
                result = num1 Mod num2
            Case "^"
                result = num1 ^ num2
            Case Else
                Console.WriteLine("Invalid operation")
                Exit Sub
        End Select

        Console.WriteLine("The result of " & num1 & " " & operation & " " & num2 & " = " & result)
        Console.ReadLine() ' Keeps the console window open
    End Sub
End Module
