Public Class Form1

    Public Sub New()
        InitializeComponent()

        ' Set the StartPosition property to Manual
        Me.StartPosition = FormStartPosition.Manual

        ' Set the initial location of the form
        Me.Location = New Point(100, 100) ' Specify the X and Y coordinates where you want the form to appear
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Check if the closing reason is not user closing the form
        If e.CloseReason <> CloseReason.UserClosing Then
            ' Allow the form to close for other reasons (e.g., application exit)
            Exit Sub
        End If

        ' Create an instance of the second form
        Dim secondForm As New Form2()

        ' Show the second form
        secondForm.Show()

        ' Prevent the first form from closing immediately
        e.Cancel = True

        ' Close the first form after the second form is fully loaded
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Trigger the FormClosing event to open the second form
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Application.Exit()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
