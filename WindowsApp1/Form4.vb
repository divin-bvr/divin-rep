Public Class Form4


    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentsDataSet.Stud' table. You can move, or remove it, as needed.
        Me.StudTableAdapter.Fill(Me.StudentsDataSet.Stud)

        'these lines of cod here down are for design button,color etc ...
        Panel1.BackColor = Color.FromArgb(125, 0, 0, 0)

        OutButton.FlatStyle = FlatStyle.Flat
        OutButton.BackColor = Color.FromArgb(255, 0, 0)
        OutButton.ForeColor = Color.WhiteSmoke
        OutButton.FlatAppearance.BorderColor = Color.White

        NextButton.FlatStyle = FlatStyle.Flat
        NextButton.BackColor = Color.FromArgb(0, 204, 255)
        NextButton.ForeColor = Color.WhiteSmoke
        NextButton.FlatAppearance.BorderColor = Color.White

        PrevButton.FlatStyle = FlatStyle.Flat
        PrevButton.BackColor = Color.FromArgb(0, 204, 255)
        PrevButton.ForeColor = Color.WhiteSmoke
        PrevButton.FlatAppearance.BorderColor = Color.White


        SaveButton.FlatStyle = FlatStyle.Flat
        SaveButton.BackColor = Color.FromArgb(0, 128, 255)
        SaveButton.ForeColor = Color.WhiteSmoke
        SaveButton.FlatAppearance.BorderColor = Color.White

        AddButton.FlatStyle = FlatStyle.Flat
        AddButton.BackColor = Color.FromArgb(0, 128, 255)
        AddButton.ForeColor = Color.WhiteSmoke
        AddButton.FlatAppearance.BorderColor = Color.White

        DelButton.FlatStyle = FlatStyle.Flat
        DelButton.BackColor = Color.FromArgb(255, 0, 0)
        DelButton.ForeColor = Color.WhiteSmoke
        DelButton.FlatAppearance.BorderColor = Color.White

    End Sub
    'save here ...
    Private Sub StudBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StudBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StudBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentsDataSet)
        Me.StudentsDataSet.AcceptChanges()

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click


        Me.StudentsDataSet.AcceptChanges()


    End Sub


    'close btn here
    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles OutButton.Click
            Me.Hide()
            Form3.Show()
            If Form3.Visible Then
                Form3.TextBoxConf1.Clear()
                Form3.TextBoxConf2.Clear()
            End If
        End Sub

    'Add in our database
    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Me.StudBindingSource.AddNew()
    End Sub

    'delete here ....
    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click

    End Sub

    Private Sub DelButton_Click(sender As Object, e As EventArgs) Handles DelButton.Click
        StudBindingSource.RemoveCurrent()
        Me.StudentsDataSet.AcceptChanges()
    End Sub

    'nextbtn here... 
    Private Sub BindingNavigatorMovePreviousItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMovePreviousItem.Click

    End Sub

    Private Sub PrevButton_Click(sender As Object, e As EventArgs) Handles PrevButton.Click
        StudBindingSource.MovePrevious()
    End Sub

    ' this is next button
    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click

    End Sub
    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        StudBindingSource.MoveNext()
    End Sub
End Class