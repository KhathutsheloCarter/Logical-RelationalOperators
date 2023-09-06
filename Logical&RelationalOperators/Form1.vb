Public Class Form1
    Private Sub btnGrade_Click(sender As Object, e As EventArgs) Handles btnGrade.Click

        Dim iScore As Integer
        iScore = txtScore.Text


        If iScore < 0 Or iScore > 100 Then
            MsgBox("That is not a Valid Score.  Please Enter a score between 0 and 100 ")

            Exit Sub


        ElseIf iScore < 50 Then
            MessageBox.Show("Fail")


        ElseIf iScore >= 50 And iScore < 75 Then
            MsgBox("pass")


        ElseIf iScore >= 75 Then
            MsgBox("Pass Distiction")
        End If

        MsgBox("All done !")


    End Sub
End Class
