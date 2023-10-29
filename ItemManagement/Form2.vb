Public Class Form2

    Public Sub New()
        InitializeComponent()

        ' Set the StartPosition property to Manual
        Me.StartPosition = FormStartPosition.Manual

        ' Set the initial location of the form
        Me.Location = New Point(100, 100) ' Specify the X and Y coordinates where you want the form to appear
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FirstForm As New Form1()

        FirstForm.Show()

        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class