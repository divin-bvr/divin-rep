Imports System.Data.OleDb
Imports System.Data

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Panel1.BackColor = Color.FromArgb(120, 0, 0, 0)
        Panel2.BackColor = Color.FromArgb(120, 0, 0, 0)

        PreviousButton.FlatAppearance.BorderSize =
        PreviousButton.FlatStyle = FlatStyle.Flat
        PreviousButton.BackColor = Color.FromArgb(204, 0, 82)
        PreviousButton.ForeColor = Color.White
        PreviousButton.FlatAppearance.BorderColor = Color.WhiteSmoke


        ConfirmButton.FlatAppearance.BorderSize =
        ConfirmButton.FlatStyle = FlatStyle.Flat
        ConfirmButton.BackColor = Color.FromArgb(0, 92, 230)
        ConfirmButton.ForeColor = Color.White
        ConfirmButton.FlatAppearance.BorderColor = Color.WhiteSmoke

        Dim connection As OleDbConnection
        connection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\students.accdb")

    End Sub

    Private Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click
        TextBoxAdd1.Clear()
        TextBoxAdd2.Clear()
        TextBoxAdd3.Clear()
        TextBoxAdd4.Clear()
        TextBoxAdd5.Clear()
        TextBoxAdd6.Clear()
        TextBoxAdd7.Clear()
        TextBoxAdd8.Clear()
        TextBoxAdd9.Clear()
        TextBoxAdd10.Clear()
        TextBoxAdd11.Clear()
        Me.Hide()
        Form1.Show()
        End Sub

    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        MsgBox("We are verry sorry to let you no that we can't receive new applicant")
        MsgBox("We'll be waiting for you next August")
    End Sub

    'Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
    '    If TextBoxAdd1.Text = "" Or TextBoxAdd2.Text = "" Or TextBoxAdd3.Text = "" Or TextBoxAdd4.Text = "" Or TextBoxAdd5.Text = "" Or TextBoxAdd6.Text = "" Or TextBoxAdd7.Text = "" Or TextBoxAdd8.Text = "" Or TextBoxAdd9.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Or ComboBox3.Text = "" Or DateTimePicker1.Text = "" Then
    '        MsgBox("plz fill the info")
    '        Exit Sub
    '    End If
    '    Dim sqlconn As New OleDb.OleDbConnection
    '    Dim sqlquery As New OleDbCommand
    'Dim connString As String

    'connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\students.accdb"

    'Try
    '        sqlconn.ConnectionString = connString
    '        sqlquery.Connection = sqlconn
    '        sqlconn.Open()

    '    sqlquery.CommandText = " Insert into stud (Name, LastName, Subject,DPT,DoB,Sex,CCode,Email,Adress,Phone,Lang,CHours,Username,Password)VALUES(@Name,@LastName,@Subject,@DPT,@DoB,@Sex,@CCode,@Email,@Adress,@Phone,@Lang,@CHours,@Username,@Password)"

    '    sqlquery.Parameters.AddWithValue("@Name", TextBoxAdd.Text)
    '        sqlquery.Parameters.AddWithValue("@LastName", TextBoxAdd1.Text)
    '        sqlquery.Parameters.AddWithValue("@Subject", ComboBox2.Text)
    '        sqlquery.Parameters.AddWithValue("@DPT", TextBoxAdd4.Text)
    '        sqlquery.Parameters.AddWithValue("@DoB", DateTimePicker1.Text)
    '        sqlquery.Parameters.AddWithValue("@Sex", ComboBox3.Text)
    '        sqlquery.Parameters.AddWithValue("@CCode", TextBoxAdd5.Text)
    '        sqlquery.Parameters.AddWithValue("@Adress", TextBoxAdd7.Text)
    '        sqlquery.Parameters.AddWithValue("@Phone ", TextBoxAdd8.Text)
    '        sqlquery.Parameters.AddWithValue("@Lang", ComboBox1.Text)
    '        sqlquery.Parameters.AddWithValue("@CHours", TextBoxAdd9.Text)
    '        sqlquery.Parameters.AddWithValue("@Username", TextBoxAdd10.Text)
    '        sqlquery.Parameters.AddWithValue("@Password", TextBoxAdd11.Text)
    '        sqlquery.Parameters.AddWithValue("@Email", TextBoxAdd6.Text)


    '        sqlquery.ExecuteNonQuery()
    '        sqlconn.Close()

    '        MsgBox("Success !!!")

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try


    'End Sub




End Class