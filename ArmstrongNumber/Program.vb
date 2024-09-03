Module ArmstrongNumber
    Sub Main()
        Console.Write("Enter a number: ")
        Dim number As Integer = (Console.ReadLine())
        Dim originalNumber As Integer = number
        Dim sum As Integer = 0
        Dim numberInString As String = originalNumber

        Dim digits As Integer = numberInString.Length


        While number > 0
            Dim digit As Integer = number Mod 10
            sum += Math.Pow(digit, digits)
            number \= 10
        End While

        If sum = originalNumber Then
            Console.WriteLine(originalNumber & " is an Armstrong number.")
        Else
            Console.WriteLine(originalNumber & " is not an Armstrong number.")
        End If

        Console.ReadLine() ' Keeps the console window open
    End Sub
End Module
