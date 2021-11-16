Module Module1

    Sub Main()
        Dim str1 As String
        Dim str2 As String
        Dim Cstr1 As String
        Dim Cstr2 As String
        Dim lastStr1 As String
        Dim lastStr2 As String

        str1 = ""
        str2 = ""
        Cstr1 = ""
        Cstr2 = ""
        lastStr1 = ""
        lastStr2 = ""

        Console.Write("Enter string 1 for the calculations: ")
        str1 = Console.ReadLine
        Console.Write("Enter string 2 for the calculations: ")
        str2 = Console.ReadLine

        Cstr1 = Left(str1, 2)
        Cstr2 = Left(str2, 2)
        lastStr1 = Mid(str1, 3, Len(str1) - 2)
        lastStr2 = Mid(str2, 3, Len(str2) - 2)

        Console.Write((Cstr2 & lastStr1) & " " & (Cstr1 & lastStr2))
        Console.ReadLine()
        
    End Sub

End Module
