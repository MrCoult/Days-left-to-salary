Public Class Form1
    Private Sub btnLuna_Click(sender As Object, e As EventArgs) Handles btnLuna.Click
        Dim luna, an, zile As Integer
        luna = DatePicker.Value.Month
        an = DatePicker.Value.Year
        Select Case luna
            Case 1, 3, 5, 7, 8, 10, 12
                zile = 31
            Case 4, 6, 9, 11
                zile = 30
            Case 2
                If ((an Mod 400 = 0 Or an Mod 4 = 0) And an Mod 100 <> 0) Then
                    zile = 29
                Else
                    zile = 28
                End If
        End Select
        TextBox1.Text = zile
    End Sub

    Private Sub btnZileSal_Click(sender As Object, e As EventArgs) Handles btnZileSal.Click
        Dim luna, an, zile As Integer
        luna = DatePicker.Value.Month
        an = DatePicker.Value.Year
        Select Case luna
            Case 1, 3, 5, 7, 8, 10, 12
                zile = 31
            Case 4, 6, 9, 11
                zile = 30
            Case 2
                If ((an Mod 400 = 0 Or an Mod 4 = 0) And an Mod 100 <> 0) Then
                    zile = 29
                Else
                    zile = 28
                End If
        End Select
        TextBox1.Text = zile - DatePicker.Value.Day + 1
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
