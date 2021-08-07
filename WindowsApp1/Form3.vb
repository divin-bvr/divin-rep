Imports System.Data.OleDb
Imports System.Data

Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.FromArgb(120, 0, 0, 0)
        Panel2.BackColor = Color.FromArgb(120, 0, 0, 0)

        PreviousButton.FlatAppearance.BorderSize =
        PreviousButton.FlatStyle = FlatStyle.Flat
        PreviousButton.BackColor = Color.FromArgb(204, 0, 82)
        PreviousButton.ForeColor = Color.White
        PreviousButton.FlatAppearance.BorderColor = Color.WhiteSmoke

        ConfirmButton.FlatAppearance.BorderSize =
        ConfirmButton.FlatStyle = FlatStyle.Flat
        ConfirmButton.BackColor = Color.FromArgb(0, 68, 204)
        ConfirmButton.ForeColor = Color.White
        ConfirmButton.FlatAppearance.BorderColor = Color.WhiteSmoke
    End Sub

    Private Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        Dim uname As String = ""
        Dim pword As String
        Dim username As String = ""
        Dim pass As String
        If TextBoxConf1.Text = "" Or TextBoxConf2.Text = "" Then
            MsgBox("Oh my gosh what is this? fill all the fields! ")
        Else
            uname = TextBoxConf1.Text
            pword = TextBoxConf2.Text
            Dim querry As String = "Select pwd From admin where user= '" & uname & "';"
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\admin.accdb"
            Dim conn = New OleDbConnection(dbsource)
            Dim cmd As New OleDbCommand(querry, conn)
            conn.Open()
            Try
                pass = cmd.ExecuteScalar().ToString
            Catch ex As Exception
                MsgBox("OMG! This never exit, Please !")
            End Try
            If (pword = pass) Then
                MsgBox("Welcome Admin, your Login was success")
                Form4.Show()
                If Form4.Visible Then
                    Me.Hide()
                End If

            Else
                MsgBox("login Failed, please don't try again, our security departement is alerted")
                TextBoxConf1.Clear()
                TextBoxConf1.Clear()
            End If
        End If




    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub


End Class