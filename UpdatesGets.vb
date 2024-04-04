Imports iniEdit.Form1

Module UpdatesGets
#Region "UpdatesAndGets"
    Sub UpdateVal(ByVal optionName As String, ByVal newVal As Object)
        'Reads the ini line by line for the specified option
        'If option isn't found, run through option arrays for option and insert a line for the correct category
        If Not doneLoading Then
            Exit Sub
        End If
        Dim found As Boolean = False
        For index As Integer = 0 To curini.Count - 1
            If curini(index).StartsWith(optionName, StringComparison.OrdinalIgnoreCase) Then
                found = True
                curini(index) = optionName & newVal
                Console.WriteLine($"Updated {optionName} to {newVal}")
            End If
        Next
        If Not found Then
            For Each list As List(Of String) In Lists.bigOptions
                If list.Contains(optionName) Then
                    For Each line In curini
                        If line.StartsWith(list(0), StringComparison.OrdinalIgnoreCase) Then
                            curini.Insert(curini.IndexOf(line) + 1, optionName & newVal)
                            Console.WriteLine($"Added {optionName} with val {newVal}")
                            Exit Sub
                        End If
                    Next
                End If
            Next
        End If
    End Sub
    Sub UpdateVal(ByVal optionName As String, ByVal newVal As Object, ByVal optionGroup As String)
        'Voice options are stupid
        If Not doneLoading Then
            Exit Sub
        End If
        Dim found As Boolean = False
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
                found = True
                curini(ctr) = optionName & newVal
                Console.WriteLine($"Updated {optionName} to {newVal}")
            End If
        Next
        If Not found Then
            curini.Insert(curini(optionGroupIndex + 1), optionName & newVal)
            Console.WriteLine($"Added {optionName} with val {newVal}")
        End If
    End Sub
    Sub UpdateVal(ByVal optionName As String, ByVal newVal As Object, ByVal addremove As Boolean)
        If Not doneLoading Then
            Exit Sub
        End If
        Dim found As Boolean = False
        For index As Integer = 0 To curini.Count - 1
            If curini(index).StartsWith(optionName, StringComparison.OrdinalIgnoreCase) Then
                found = True
                Dim lineList As List(Of String) = curini(index).Split("="c, ","c).ToList
                lineList.RemoveAll(Function(str) String.IsNullOrEmpty(str))
                If lineList.Contains(newVal) And addremove = True Then
                    Console.WriteLine("option already in list")
                    Exit Sub
                ElseIf Not lineList.Contains(newVal) And addremove = False Then
                    Console.WriteLine("option already not in list")
                    Exit Sub
                ElseIf lineList.Contains(newVal) And addremove = False Then
                    Console.WriteLine("option removed from list")
                    lineList.Remove(newVal)
                ElseIf Not lineList.Contains(newVal) And addremove = True Then
                    Console.WriteLine("option added to list")
                    lineList.Add(newVal)
                End If
                Dim newLine As String
                For index2 As Integer = 0 To lineList.Count - 1
                    If index2 = 0 Then
                        newLine = lineList(index2) + "="
                    ElseIf index2 = lineList.Count - 1 Then
                        newLine = newLine + lineList(index2)
                    Else
                        newLine = newLine + lineList(index2) + ","
                    End If
                Next
                curini(index) = newLine
                Console.WriteLine(curini(index))
            End If
        Next
        Console.WriteLine($"Updated {optionName} to {newVal}")
        If Not found Then
            For Each list As List(Of String) In Lists.bigOptions
                If list.Contains(optionName) Then
                    For Each line In curini
                        If line.StartsWith(list(0), StringComparison.OrdinalIgnoreCase) Then
                            curini.Insert(curini.IndexOf(line) + 1, optionName & newVal)
                            Console.WriteLine($"Added {optionName} with val {newVal}")
                            Exit Sub
                        End If
                    Next
                End If
            Next
        End If
    End Sub
    Function UpdateValMyIni(ByVal optionName As String, ByVal newVal As Object)
        If Not doneLoading Then
            Exit Function
        End If
        Dim found As Boolean = False
        For index As Integer = 0 To iniini.Count - 1
            If iniini(index).StartsWith(optionName, StringComparison.OrdinalIgnoreCase) Then
                found = True
                iniini(index) = optionName & newVal
                Console.WriteLine($"Updated {optionName} to {newVal}")
            End If
        Next
        If Not found Then
            iniini.Add(optionName & newVal)
            Console.WriteLine($"Added {optionName} with val {newVal}")
            Exit Function
        End If
    End Function
    Function GetState(ByVal optionName As String)
        'Find the line which has the desired option, and return the value after the = sign
        For Each line In curini
            If line.StartsWith(optionName, StringComparison.OrdinalIgnoreCase) Then
                Dim optionVal As Array = line.Split("="c)
                Console.WriteLine($"Got {optionName} with {optionVal(1)}")
                Return optionVal(1)
            End If
        Next
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
    Function GetStateSpecific(ByVal optionName As String, ByVal optionGroup As String)
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
    Public Sub ColorUpdate(ByVal optionName As String, ByVal newVal As String, ByVal faction As Integer)
        'Specialized update function for color options with multiple values separated by commas, could be used for other options with multiple values
        If Not doneLoading Then
            Exit Sub
        End If
        Dim found As Boolean = False
        For index As Integer = 0 To curini.Count - 1
            If curini(index).StartsWith(optionName, StringComparison.OrdinalIgnoreCase) Then
                found = True
                Dim lineList As List(Of String) = curini(index).Split("="c, ","c).ToList
                lineList(faction) = newVal
                curini(index) = optionName & lineList(1) & "," & lineList(2) & "," & lineList(3)
            End If
        Next
        Console.WriteLine($"Updated {optionName} to {newVal}")
        If Not found Then
            For Each list As List(Of String) In Lists.bigOptions
                If list.Contains(optionName) Then
                    For Each line In curini
                        If line.StartsWith(list(0), StringComparison.OrdinalIgnoreCase) Then
                            curini.Insert(curini.IndexOf(line) + 1, optionName & newVal)
                            Console.WriteLine($"Added {optionName} with val {newVal}")
                            Exit Sub
                        End If
                    Next
                End If
            Next
        End If
    End Sub
    Function ColorGetState(ByVal optionName As String, ByVal faction As Integer)
        'Specialized getState for options with multiple values separated by commas
        For Each line In curini
            If line.StartsWith(optionName, StringComparison.OrdinalIgnoreCase) Then
                Dim optionVal As Array = line.Split("="c, ","c)
                Console.WriteLine($"Got {optionName} with {optionVal(faction)}")
                Return optionVal(faction)
            End If
        Next
    End Function
#End Region
End Module
