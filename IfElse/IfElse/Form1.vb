Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click
        Dim num1, num2 As Double

        ' Modify the program such that it does not crash 
        ' if the user types incorrect input

        Dim st1 As String = txtFirstNum.Text
        Dim st2 As String = txtSecondNum.Text

        ' checkpoint to see where user messed up and jumps to the end of the program '
        If Not (IsNumeric(st1) And IsNumeric(st2)) Then
        Else
            MessageBox.Show("Check 1: Please type numbers here")
            Return
        End If

        ' clean area, good place to start over'

        num1 = CDbl(st1)
        num2 = CDbl(st2)

        ' checkpoint 2 '
        If Not (num1 >= 0 And num2 >= 0) Then
            MessageBox.Show("Check 2: Please type non-negative numbers here")
            Return
        End If

        Dim result As String

        If num1 > num2 Then
            result = "The larger number is " & num1
        ElseIf num2 > num1 Then
            result = "The larger number is " & num2
        Else
            result = "They are equal"
        End If

        txtResult.Text = result


    End Sub

End Class
