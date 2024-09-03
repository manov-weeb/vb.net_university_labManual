Module SumOfNaturalNumbers
    Sub Main()
        Console.Write("Enter a number (N): ")
        Dim N As Integer = CInt(Console.ReadLine())

        Dim sum As Integer = (N * (N + 1)) \ 2 ' Using integer division to get the sum

        Console.WriteLine("The sum of the first " & N & " natural numbers is: " & sum)
        Console.ReadLine() ' Keeps the console window open
    End Sub
End Module
