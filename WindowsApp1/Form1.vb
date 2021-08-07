Imports System.Data.OleDb
Imports System.Data

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.FromArgb(120, 0, 0, 0)
        Panel2.BackColor = Color.FromArgb(120, 0, 0, 0)


        CloseButton.FlatStyle = FlatStyle.Flat
        CloseButton.BackColor = Color.FromArgb(230, 0, 0)
        CloseButton.ForeColor = Color.Black
        CloseButton.FlatAppearance.BorderColor = Color.FromArgb(255, 0, 0)

        SigninButton.FlatAppearance.BorderSize = 3
        SigninButton.FlatStyle = FlatStyle.Flat
        SigninButton.BackColor = Color.FromArgb(0, 68, 204)
        SigninButton.ForeColor = Color.WhiteSmoke

        AdminButton.FlatAppearance.BorderSize = 1
        AdminButton.FlatStyle = FlatStyle.Flat
        AdminButton.BackColor = Color.FromArgb(51, 153, 255)
        AdminButton.ForeColor = Color.White
        AdminButton.FlatAppearance.BorderColor = Color.WhiteSmoke

        SignupButton.FlatAppearance.BorderSize = 1
        SignupButton.FlatStyle = FlatStyle.Flat
        SignupButton.BackColor = Color.FromArgb(51, 153, 255)
        SignupButton.ForeColor = Color.White
        SignupButton.FlatAppearance.BorderColor = Color.WhiteSmoke
    End Sub

    Private Sub SignupButton_Click(sender As Object, e As EventArgs) Handles SignupButton.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub AdminButton_Click(sender As Object, e As EventArgs) Handles AdminButton.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub SigninButton_Click(sender As Object, e As EventArgs) Handles SigninButton.Click


        Dim uname As String = ""
        Dim pword As String
        Dim username As String = ""
        Dim pass As String
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("what is this, please fill the field!")
        Else
            uname = TextBox1.Text
            pword = TextBox2.Text
            Dim querry As String = "Select Password From stud where UserName= '" & uname & "';"
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\students.accdb"
            Dim conn = New OleDbConnection(dbsource)
            Dim cmd As New OleDbCommand(querry, conn)
            conn.Open()
            Try
                pass = cmd.ExecuteScalar().ToString
            Catch ex As Exception
                MsgBox("Sorry, you are not recognized.contact our registration office please before i lose my temper! ")
            End Try
            If (pword = pass) Then
                MsgBox("Login success, welcome ")
                Form5.Show()
                If Form5.Visible Then
                    Me.Hide()
                End If

            Else
                MsgBox("login Failed, you can't access!")
                TextBox1.Clear()
                TextBox2.Clear()
            End If
        End If




    End Sub
End Class
