Module CityNamesSorter
    Sub Main()
        ' Declare an array to store 5 city names
        Dim cities(4) As String

        ' Input city names
        For i As Integer = 0 To 4
            Console.Write("Enter city name " & (i + 1) & ": ")
            cities(i) = Console.ReadLine()
        Next

        ' Sort the city names in alphabetical order
        Array.Sort(cities)

        ' Display the sorted city names
        Console.WriteLine("City names in alphabetical order:")
        For i As Integer = 0 To 4
            Console.WriteLine(cities(i))
        Next

        Console.ReadLine() ' Keeps the console window open
    End Sub
End Module
