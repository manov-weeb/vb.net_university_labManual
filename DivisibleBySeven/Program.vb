Module DivisibleBySeven
    Sub Main()
        Console.WriteLine("Numbers from 1 to 50 that are divisible by 7:")

        For i As Integer = 1 To 50
            If i Mod 7 = 0 Then
                Console.WriteLine(i)
            End If
        Next

        Console.ReadLine() ' Keeps the console window open
    End Sub
End Module
