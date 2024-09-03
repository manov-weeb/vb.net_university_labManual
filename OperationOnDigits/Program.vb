Module OperationOnDigits
    Sub Main()
        Console.Write("Enter a number: ")
        Dim number As Integer = Console.ReadLine()
        Dim sum As Integer = 0
        Dim reverse As Integer = 0
        Dim input As Integer = number

        While input > 0
            Dim digit As Integer = input Mod 10 ' Get the last digit
            sum += digit ' Add the digit to the sum
            reverse = reverse * 10 + digit ' Append the digit to the reversed number
            input \= 10 ' Remove the last digit from the number
        End While

        Console.WriteLine("The sum of the digits is: " & sum)
        Console.WriteLine("The reversed number is: " & reverse)

        If number = reverse Then
            Console.WriteLine(number & " is a palindrome.")
        Else
            Console.WriteLine(number & " is not a palindrome.")
        End If


        Console.ReadLine() ' Keeps the console window open
    End Sub
End Module

