Module PermutationsCombinations
    Sub Main()
        Console.Write("Enter the value of n: ")
        Dim n As Integer = CInt(Console.ReadLine())

        Console.Write("Enter the value of r: ")
        Dim r As Integer = CInt(Console.ReadLine())

        ' Calculate nPr
        Dim nPr As Integer = Factorial(n) \ Factorial(n - r)
        Console.WriteLine("nPr (Permutations) = " & nPr)

        ' Calculate nCr
        Dim nCr As Integer = Factorial(n) \ (Factorial(r) * Factorial(n - r))
        Console.WriteLine("nCr (Combinations) = " & nCr)

        Console.ReadLine() ' Keeps the console window open
    End Sub

    ' Function to calculate factorial
    Function Factorial(ByVal num As Integer) As Integer
        If num = 0 Or num = 1 Then
            Return 1
        Else
            Return num * Factorial(num - 1)
        End If
    End Function
End Module
