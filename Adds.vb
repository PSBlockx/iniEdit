Module Adds
    Sub AddVal(ByVal optionName As String, ByVal newVal As String)
        Dim optionGroup = GetOptionGroup(optionName)
        For Each line In curini
            If line.StartsWith(optionGroup, StringComparison.OrdinalIgnoreCase) Then
                curini.Insert(curini.IndexOf(line) + 1, optionName & newVal)
                Console.WriteLine($"Added {optionName} with val {newVal}")
                Exit Sub
            End If
        Next
    End Sub
    Sub AddVal(ByVal optionName As String, ByVal newVal As Object, ByVal optionGroup As String)
        For Each line In curini
            If line.StartsWith(optionGroup, StringComparison.OrdinalIgnoreCase) Then
                curini.Insert(curini.IndexOf(line) + 1, optionName & newVal)
                Console.WriteLine($"Added {optionName} with val {newVal}")
                Exit Sub
            End If
        Next
    End Sub
    Sub AddValMyIni(ByVal optionName As String, ByVal newVal As String)
        iniini.Add(optionName & newVal)
        Console.WriteLine($"Added {optionName} with val {newVal}")
    End Sub
End Module