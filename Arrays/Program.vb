Module Array
    Sub Main()
        Console.Write("Enter the number of elements in the array: ")
        Dim size As Integer = Console.ReadLine()
        Dim array(size - 1) As Integer
        Dim arraySum As Integer = 0


        For i As Integer = 0 To size - 1
            Console.Write("Enter element " & (i + 1) & ": ")
            array(i) = CInt(Console.ReadLine())
        Next


        Console.Write("The elements of the array are: ")
        For i As Integer = 0 To size - 1
            Console.Write(array(i) & " ")
            arraySum += array(i)

        Next

        Console.WriteLine("The sum of the array elements are: " & arraySum
                          )

        Console.ReadLine()
    End Sub
End Module
