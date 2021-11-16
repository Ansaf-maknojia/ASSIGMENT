Module Module1

    Sub Main()
        Dim Count As Integer
        Dim Char1 As Char
        Dim Char2 As Char
        Dim str1, str2 As String

        Char2 = ""
        str1 = ""
        Count = 0
        Char1 = ""
        str2 = ""

        Console.Write("Enter a string you want to manipulate: ")
        str1 = Console.ReadLine

        Char1 = Left(str1, 1)
        For Count = 2 To Len(str1)
            Char2 = Mid(str1, Count, 1)
            If Char2 = Char1 Then
                str2 = str2 + "*"
            Else
                str2 = str2 + Char2
            End If
        Next

        Console.Write("The final string is: " + char1 + str2)
        Console.ReadKey()
    End Sub

End Module
