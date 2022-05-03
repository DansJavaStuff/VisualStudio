Public Class Main

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtPicker.ValueChanged
        Dim jDate = String.Format("{0}{1}", dtPicker.Value.DayOfYear.ToString("000"), dtPicker.Value.ToString("yy"))
        julianDate.Text = "LD" & jDate
    End Sub

    Private Sub gDateEnter_Leave(sender As Object, eA As EventArgs) Handles gDateEnter.Leave
        Dim thisYear As String = Year(Now)
        '        thisYear = Year(Now)
        gDate.Text = (Julian2Gregorian(thisYear & gDateEnter.Text, 4))
    End Sub

    Public Function Julian2Gregorian(ByVal vDate As Integer, ByVal yDigits As Integer) As Date
        Dim y As String = vDate.ToString.Substring(0, yDigits)
        Return CDate("01/01/" & y).AddDays(CInt(Strings.Right(vDate.ToString, vDate.ToString.Length - yDigits)) - 1)
    End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Close the form.
        Close()
    End Sub
End Class
