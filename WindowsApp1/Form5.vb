Public Class Form5
    Private Sub StudBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StudBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentsDataSet)

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentsDataSet.Stud' table. You can move, or remove it, as needed.
        Me.StudTableAdapter.Fill(Me.StudentsDataSet.Stud)
        Panel1.BackColor = Color.FromArgb(100, 0, 0, 0)


        NextButton2.FlatStyle = FlatStyle.Flat
        NextButton2.BackColor = Color.FromArgb(26, 117, 255)
        NextButton2.FlatAppearance.BorderColor = Color.WhiteSmoke

        PrevButton1.FlatStyle = FlatStyle.Flat
        PrevButton1.BackColor = Color.FromArgb(26, 117, 255)
        PrevButton1.FlatAppearance.BorderColor = Color.WhiteSmoke


        OutButton.FlatStyle = FlatStyle.Flat
        OutButton.BackColor = Color.FromArgb(255, 0, 128)
        OutButton.ForeColor = Color.WhiteSmoke

    End Sub



    Private Sub OutButton_Click(sender As Object, e As EventArgs) Handles OutButton.Click
        Me.Hide()
        Form1.Show()
        If Form1.Visible Then
            Form1.TextBox1.Clear()
            Form1.TextBox2.Clear()
        End If
    End Sub

    Private Sub BindingNavigatorMovePreviousItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PrevButton1_Click_1(sender As Object, e As EventArgs) Handles PrevButton1.Click
        StudBindingSource.MovePrevious()
    End Sub

    Private Sub NextButton2_Click_1(sender As Object, e As EventArgs) Handles NextButton2.Click
        StudBindingSource.MoveNext()
    End Sub
End Class