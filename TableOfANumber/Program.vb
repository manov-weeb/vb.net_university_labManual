Module MultiplicationTable
    Sub Main()
        Console.Write("Enter a number to print its multiplication table: ")
        Dim number As Integer = Console.ReadLine()

        Console.WriteLine("Multiplication Table for " & number & ":")

        For i As Integer = 1 To 10
            Console.WriteLine(number & " x " & i & " = " & (number * i))
        Next

        Console.ReadLine()
    End Sub
End Module
