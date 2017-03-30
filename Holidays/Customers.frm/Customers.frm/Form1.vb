Imports System.IO
Public Class Form1
    Private Structure Holidays
        Public HolidayID As String
        Public HolidayName As String
        Public Location As String                       'All of this, is the structure that holds our data 
        Public HolidayType As String
        Public Rating As String

    End Structure


    Private Sub txtHolidayID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHolidayID.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then e.Handled = True 'This allows only numbers to be enetered, but allows backspaces 

    End Sub

    Private Sub txtHolidayName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHolidayName.KeyPress
        If IsNumeric(e.KeyChar) Then
            MsgBox("You cannot enter a number into here")
            e.KeyChar = Nothing 'This allows for only characters to be entered 

        End If



    End Sub

    Private Sub txtLocation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLocation.KeyPress
        If IsNumeric(e.KeyChar) Then
            MsgBox("You cannot enter a number into here")
            e.KeyChar = Nothing

        End If



    End Sub

    Private Sub txtHolidayType_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHolidayType.KeyPress


        If IsNumeric(e.KeyChar) Then
            MsgBox("You cannot enter a number into here")
            e.KeyChar = Nothing

        End If

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim HolidayData As New Holidays
        Dim sw As New System.IO.StreamWriter("customerdetails.txt", True)

        HolidayData.HolidayID = LSet(txtHolidayID.Text, 50)
        HolidayData.HolidayName = LSet(txtHolidayName.Text, 50)
        HolidayData.Location = LSet(txtHolidayType.Text, 50)
        HolidayData.HolidayType = LSet(txtLocation.Text, 50)
        HolidayData.Rating = LSet(txtRating.Text, 50)

        sw.WriteLine(HolidayData.HolidayID & HolidayData.HolidayName & HolidayData.HolidayType & HolidayData.Location & HolidayData.Rating)
        sw.Close()
        MsgBox("File Saved!")
        

    End Sub

    Private Sub btnCount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCount.Click

        Dim FILE_NAME As String = "C:\Users\Owner\Documentscustomerdetails.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objReader As New System.IO.StreamReader(FILE_NAME)

            txtHolidayID.Text = objReader.ReadLine
            txtHolidayName.Text = objReader.ReadLine
            txtLocation.Text = objReader.ReadLine
            txtHolidayType.Text = objReader.ReadLine
            txtRating.Text = objReader.ReadLine
            objReader.Close()
        Else
            MessageBox.Show("File Does Not Exist")

        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Dir$("customerdetails.txt") = "" Then
            Dim sw As New StreamWriter("cusstomerdetails.txt", True) 'This creates a new textfile if there is not already one 
            sw.WriteLine("")
            sw.Close()
            MsgBox("A new file has been created", vbExclamation, "Warning!")
        End If
    End Sub
End Class
