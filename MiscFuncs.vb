Module MiscFuncs
    Function colorGetter()
        'Opens Windows color picker and returns user-chosen color
        'Value needs to be in BGR format, and is converted before use in update function
        Dim chosenColor = Nothing
        Dim colorDialog As New ColorDialog()
        If colorDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            chosenColor = colorDialog.Color
        End If
        Return chosenColor
    End Function
    Function colorDecimalSwap(ByVal color As Integer)
        'Math-y way of bit swapping RGB<>BGR and vice versa from decimal color values
        Dim Channel1 As Integer = color \ 65536
        Dim Channel2 As Integer = (color - Channel1 * 65536) \ 256
        Dim Channel3 As Integer = color - (Channel1 * 65536 + Channel2 * 256)
        Dim Result As Integer = Channel1 + Channel2 * 256 + Channel3 * 65536
        Return Result
    End Function
#Region "AimCalcs"
    Function hipTurnCalc(DPI, Sens)
        Dim distance As Double = Math.Round((1 / DPI) * (11.7581 / (Sens + 0.3)) ^ 3, 2, MidpointRounding.AwayFromZero)
        Return distance.ToString()
    End Function
    Function aimTurncalc(DPI, Sens, Zoom)
        Dim distance As Double = Math.Round((1 / DPI) * (11.7581 / (Sens + 0.3)) ^ 3 * 1.6 * Zoom, 2, MidpointRounding.AwayFromZero)
        Return distance.ToString()
    End Function
    Function hipSensCalc(DPI, Distance)
        Dim sens As Double = Math.Round((DPI * Distance) ^ (-1 / 3) * 11.7581 - 0.3, 3, MidpointRounding.AwayFromZero)
        If sens > 1 Then
            sens = 1
        End If
        Return sens.ToString()
    End Function
    Function aimSensCalc(DPI, Distance, Zoom)
        Dim sens As Double = Math.Round(((DPI * Distance) / (Zoom * 1.6)) ^ (-1 / 3) * 11.7581 - 0.3, 3, MidpointRounding.AwayFromZero)
        If sens > 1 Then
            sens = 1
        End If
        Return sens.ToString()
    End Function
#End Region
End Module
