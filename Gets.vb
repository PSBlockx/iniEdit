Module Gets
    Function GetState(ByVal optionName As String)
        'Find the line which has the desired option, and return the value after the = sign
        Dim found As Boolean = False
        For Each line In curini
            If line.StartsWith(optionName, StringComparison.OrdinalIgnoreCase) Then
                found = True
                Dim optionVal As Array = line.Split("="c)
                Console.WriteLine($"Got {optionName} with {optionVal(1)}")
                If optionVal(1) = Nothing Then
                    Return GetDefaultVal(optionName)
                Else
                    Return optionVal(1)
                End If
            End If
        Next
        If found = False Then
            Console.WriteLine($"{optionName} not found, adding with default")
            Dim defval As String = GetDefaultVal(optionName)
            AddVal(optionName, defval)
            Return defval
        End If
    End Function
    Function GetStateMyIni(ByVal optionName As String)
        For Each line In iniini
            If line.StartsWith(optionName, StringComparison.OrdinalIgnoreCase) Then
                Dim optionVal As Array = line.Split("="c)
                Console.WriteLine($"Got {optionName} with {optionVal(1)}")
                Return optionVal(1)
            End If
        Next
    End Function
    Function GetStateSpecificGroup(ByVal optionName As String, ByVal optionGroup As String)
        'Voice options are stupid
        Dim optionIndexes = New ArrayList()
        For Each line In curini
            If line.StartsWith("[") Then
                optionIndexes.Add(line)
                optionIndexes.Add(curini.IndexOf(line))
            End If
        Next
        Dim optionGroupIndex As Integer = optionIndexes(optionIndexes.IndexOf(optionGroup) + 1)
        Dim optionGroupNextIndex As Integer = 0
        Try
            optionGroupNextIndex = optionIndexes(optionIndexes.IndexOf(optionGroup) + 3)
        Catch ex As ArgumentOutOfRangeException
            optionGroupNextIndex = curini.FindLastIndex(Function(str) str.Equals(curini.Last))
        End Try
        For ctr As Integer = optionGroupIndex To optionGroupNextIndex
            If curini(ctr).StartsWith(optionName, StringComparison.OrdinalIgnoreCase) Then
                Dim optionVal As Array = curini(ctr).Split("="c)
                Console.WriteLine($"Got {optionName} with {optionVal(1)} under {optionGroup}")
                Return optionVal(1)
            End If
        Next
    End Function
    Function GetStateContains(ByVal optionName As String, ByVal findVal As String)
        For Each line In curini
            If line.StartsWith(optionName, StringComparison.OrdinalIgnoreCase) Then
                Dim optionVal As List(Of String) = line.Split("="c, ","c).ToList
                Return optionVal.Contains(findVal)
            End If
        Next
    End Function
    Function GetStateSpecificIndex(ByVal optionName As String, ByVal faction As Integer)
        'Specialized getState for options with multiple values separated by commas
        For Each line In curini
            If line.StartsWith(optionName, StringComparison.OrdinalIgnoreCase) Then
                Dim optionVal As Array = line.Split("="c, ","c)
                Console.WriteLine($"Got {optionName} with {optionVal(faction)}")
                Return optionVal(faction)
            End If
        Next
    End Function
    Function GetDefaultVal(ByVal optionName As String)
        For Each list As List(Of String) In bigOptions
            If list.Contains(optionName) Then
                Return list(list.IndexOf(optionName) + 1)
            End If
        Next
    End Function
    Function GetDefaultVal(ByVal optionName As String, ByVal optionGroup As String)
        If optionGroup.Contains(optionName) Then
            Return optionGroup(optionGroup.IndexOf(optionName) + 1)
        End If
    End Function
    Function GetOptionGroup(ByVal optionName As String)
        For Each list As List(Of String) In bigOptions
            If list.Contains(optionName) Then
                Return list(0)
            End If
        Next
    End Function
End Module