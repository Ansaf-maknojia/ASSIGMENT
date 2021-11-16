Module Module1

    Sub Main()
        Dim count As Integer
        Dim str As String
        Dim newStr As String

        count = 0
        newStr = ""
        Str = ""

        Console.Write("Enter a string for verbing: ")
        str = Console.ReadLine

        If Len(Str) > 2 Then
            If Right(str, 3) = "ing" Then
                newStr = str + "ly"
                Console.Write(newStr)
                Console.ReadKey()
            Else
                newStr = str + "ing"
                Console.Write(newStr)
                Console.ReadKey()
            End If
        Else
            Console.Write(str)
            Console.ReadKey()
        End If
    End Sub

End Module
