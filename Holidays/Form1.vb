Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtHolidayID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHolidayID.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then e.Handled = True
    End Sub

    Private Sub txtHolidayName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHolidayName.KeyPress
        If IsNumeric(e.KeyChar) Then
            MsgBox("You cannot enter a number into here")
            e.KeyChar = Nothing

        End If

    End Sub

    Private Sub txtLocation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLocation.KeyPress

        If IsNumeric(e.KeyChar) Then
            MsgBox("You cannot enter a number into here")
            e.KeyChar = Nothing



        End If
    End Sub 

End Class