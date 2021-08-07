<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NameLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim GPALabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.StudentsDataSet = New WindowsApp1.studentsDataSet()
        Me.StudBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudTableAdapter = New WindowsApp1.studentsDataSetTableAdapters.StudTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.studentsDataSetTableAdapters.TableAdapterManager()
        Me.StudBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentsDataSet1 = New WindowsApp1.studentsDataSet()
        Me.AdminDataSet = New WindowsApp1.adminDataSet()
        Me.AdminBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdminTableAdapter = New WindowsApp1.adminDataSetTableAdapters.adminTableAdapter()
        Me.TableAdapterManager1 = New WindowsApp1.adminDataSetTableAdapters.TableAdapterManager()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudTableAdapter1 = New WindowsApp1.studentsDataSetTableAdapters.StudTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GPATextBox = New System.Windows.Forms.TextBox()
        Me.Tot_FeeTextBox = New System.Windows.Forms.TextBox()
        Me.Paid_FeeTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.Year_semTextBox = New System.Windows.Forms.TextBox()
        Me.SubjectTextBox = New System.Windows.Forms.TextBox()
        Me.CCodeTextBox = New System.Windows.Forms.TextBox()
        Me.DPTTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.TableAdapterManager2 = New WindowsApp1.studentsDataSetTableAdapters.TableAdapterManager()
        Me.NextButton2 = New System.Windows.Forms.Button()
        Me.PrevButton1 = New System.Windows.Forms.Button()
        Me.OutButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GradeTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        NameLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        GPALabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.StudentsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentsDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(72, 34)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(0, 20)
        NameLabel.TabIndex = 95
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.BackColor = System.Drawing.Color.Transparent
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Label4.Location = New System.Drawing.Point(360, 70)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(101, 22)
        Label4.TabIndex = 94
        Label4.Text = "Year-sem:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.BackColor = System.Drawing.Color.Transparent
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Label5.Location = New System.Drawing.Point(16, 159)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(56, 22)
        Label5.TabIndex = 85
        Label5.Text = "DPT:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.BackColor = System.Drawing.Color.Transparent
        Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Label6.Location = New System.Drawing.Point(14, 192)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(77, 22)
        Label6.TabIndex = 86
        Label6.Text = "CCode:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.BackColor = System.Drawing.Color.Transparent
        Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Label7.Location = New System.Drawing.Point(14, 223)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(83, 22)
        Label7.TabIndex = 87
        Label7.Text = "Subject:"
        '
        'GPALabel
        '
        GPALabel.AutoSize = True
        GPALabel.BackColor = System.Drawing.Color.Transparent
        GPALabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GPALabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        GPALabel.Location = New System.Drawing.Point(360, 166)
        GPALabel.Name = "GPALabel"
        GPALabel.Size = New System.Drawing.Size(57, 22)
        GPALabel.TabIndex = 89
        GPALabel.Text = "GPA:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.BackColor = System.Drawing.Color.Transparent
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Label3.Location = New System.Drawing.Point(14, 99)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(67, 22)
        Label3.TabIndex = 90
        Label3.Text = "Name:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.BackColor = System.Drawing.Color.Transparent
        Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Label8.Location = New System.Drawing.Point(360, 131)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(71, 22)
        Label8.TabIndex = 90
        Label8.Text = "Grade:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.BackColor = System.Drawing.Color.Transparent
        Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Label9.Location = New System.Drawing.Point(360, 98)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(106, 22)
        Label9.TabIndex = 91
        Label9.Text = "Username:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.BackColor = System.Drawing.Color.Transparent
        Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Label10.Location = New System.Drawing.Point(360, 195)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(86, 22)
        Label10.TabIndex = 92
        Label10.Text = "Tot Fee:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.BackColor = System.Drawing.Color.Transparent
        Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Label11.Location = New System.Drawing.Point(360, 230)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(96, 22)
        Label11.TabIndex = 93
        Label11.Text = "Paid Fee:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Label2.Location = New System.Drawing.Point(14, 127)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(111, 22)
        Label2.TabIndex = 57
        Label2.Text = "Last Name:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Label1.Location = New System.Drawing.Point(16, 63)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(35, 22)
        Label1.TabIndex = 51
        Label1.Text = "ID:"
        '
        'StudentsDataSet
        '
        Me.StudentsDataSet.DataSetName = "studentsDataSet"
        Me.StudentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudBindingSource
        '
        Me.StudBindingSource.DataMember = "Stud"
        Me.StudBindingSource.DataSource = Me.StudentsDataSet
        '
        'StudTableAdapter
        '
        Me.StudTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.StudTableAdapter = Me.StudTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApp1.studentsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StudBindingSource2
        '
        Me.StudBindingSource2.DataMember = "Stud"
        Me.StudBindingSource2.DataSource = Me.StudentsDataSet1
        '
        'StudentsDataSet1
        '
        Me.StudentsDataSet1.DataSetName = "studentsDataSet"
        Me.StudentsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdminDataSet
        '
        Me.AdminDataSet.DataSetName = "adminDataSet"
        Me.AdminDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdminBindingSource
        '
        Me.AdminBindingSource.DataMember = "admin"
        Me.AdminBindingSource.DataSource = Me.AdminDataSet
        '
        'AdminTableAdapter
        '
        Me.AdminTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.adminTableAdapter = Me.AdminTableAdapter
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.UpdateOrder = WindowsApp1.adminDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "stud"
        '
        'StudTableAdapter1
        '
        Me.StudTableAdapter1.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.IDTextBox)
        Me.Panel1.Controls.Add(Me.NameTextBox)
        Me.Panel1.Controls.Add(Me.GradeTextBox)
        Me.Panel1.Controls.Add(Me.GPATextBox)
        Me.Panel1.Controls.Add(Me.Tot_FeeTextBox)
        Me.Panel1.Controls.Add(Me.Paid_FeeTextBox)
        Me.Panel1.Controls.Add(Me.UsernameTextBox)
        Me.Panel1.Controls.Add(Me.Year_semTextBox)
        Me.Panel1.Controls.Add(Me.SubjectTextBox)
        Me.Panel1.Controls.Add(Me.CCodeTextBox)
        Me.Panel1.Controls.Add(Me.DPTTextBox)
        Me.Panel1.Controls.Add(Me.LastNameTextBox)
        Me.Panel1.Controls.Add(NameLabel)
        Me.Panel1.Controls.Add(Label4)
        Me.Panel1.Controls.Add(Label5)
        Me.Panel1.Controls.Add(Label6)
        Me.Panel1.Controls.Add(Label7)
        Me.Panel1.Controls.Add(GPALabel)
        Me.Panel1.Controls.Add(Label3)
        Me.Panel1.Controls.Add(Label8)
        Me.Panel1.Controls.Add(Label9)
        Me.Panel1.Controls.Add(Label10)
        Me.Panel1.Controls.Add(Label11)
        Me.Panel1.Controls.Add(Label2)
        Me.Panel1.Controls.Add(Label1)
        Me.Panel1.Location = New System.Drawing.Point(71, 118)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(717, 316)
        Me.Panel1.TabIndex = 60
        '
        'GPATextBox
        '
        Me.GPATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudBindingSource, "GPA", True))
        Me.GPATextBox.Location = New System.Drawing.Point(478, 163)
        Me.GPATextBox.Name = "GPATextBox"
        Me.GPATextBox.Size = New System.Drawing.Size(208, 26)
        Me.GPATextBox.TabIndex = 107
        '
        'Tot_FeeTextBox
        '
        Me.Tot_FeeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudBindingSource, "Tot Fee", True))
        Me.Tot_FeeTextBox.Location = New System.Drawing.Point(478, 198)
        Me.Tot_FeeTextBox.Name = "Tot_FeeTextBox"
        Me.Tot_FeeTextBox.Size = New System.Drawing.Size(208, 26)
        Me.Tot_FeeTextBox.TabIndex = 106
        '
        'Paid_FeeTextBox
        '
        Me.Paid_FeeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudBindingSource, "Paid Fee", True))
        Me.Paid_FeeTextBox.Location = New System.Drawing.Point(478, 230)
        Me.Paid_FeeTextBox.Name = "Paid_FeeTextBox"
        Me.Paid_FeeTextBox.Size = New System.Drawing.Size(208, 26)
        Me.Paid_FeeTextBox.TabIndex = 105
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudBindingSource, "Grade", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(478, 99)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(208, 26)
        Me.UsernameTextBox.TabIndex = 103
        '
        'Year_semTextBox
        '
        Me.Year_semTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudBindingSource, "Year-sem", True))
        Me.Year_semTextBox.Location = New System.Drawing.Point(478, 66)
        Me.Year_semTextBox.Name = "Year_semTextBox"
        Me.Year_semTextBox.Size = New System.Drawing.Size(208, 26)
        Me.Year_semTextBox.TabIndex = 102
        '
        'SubjectTextBox
        '
        Me.SubjectTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudBindingSource, "Subject", True))
        Me.SubjectTextBox.Location = New System.Drawing.Point(127, 220)
        Me.SubjectTextBox.Name = "SubjectTextBox"
        Me.SubjectTextBox.Size = New System.Drawing.Size(204, 26)
        Me.SubjectTextBox.TabIndex = 101
        '
        'CCodeTextBox
        '
        Me.CCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudBindingSource, "CCode", True))
        Me.CCodeTextBox.Location = New System.Drawing.Point(127, 188)
        Me.CCodeTextBox.Name = "CCodeTextBox"
        Me.CCodeTextBox.Size = New System.Drawing.Size(204, 26)
        Me.CCodeTextBox.TabIndex = 100
        '
        'DPTTextBox
        '
        Me.DPTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudBindingSource, "CCode", True))
        Me.DPTTextBox.Location = New System.Drawing.Point(127, 158)
        Me.DPTTextBox.Name = "DPTTextBox"
        Me.DPTTextBox.Size = New System.Drawing.Size(204, 26)
        Me.DPTTextBox.TabIndex = 99
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(127, 126)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(204, 26)
        Me.LastNameTextBox.TabIndex = 98
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.Connection = Nothing
        Me.TableAdapterManager2.StudTableAdapter = Nothing
        Me.TableAdapterManager2.UpdateOrder = WindowsApp1.studentsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NextButton2
        '
        Me.NextButton2.AccessibleDescription = "ConfirmButton"
        Me.NextButton2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextButton2.Location = New System.Drawing.Point(427, 434)
        Me.NextButton2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NextButton2.Name = "NextButton2"
        Me.NextButton2.Size = New System.Drawing.Size(361, 34)
        Me.NextButton2.TabIndex = 62
        Me.NextButton2.Text = ">>"
        Me.NextButton2.UseVisualStyleBackColor = True
        '
        'PrevButton1
        '
        Me.PrevButton1.AccessibleDescription = "ConfirmButton"
        Me.PrevButton1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrevButton1.Location = New System.Drawing.Point(71, 434)
        Me.PrevButton1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PrevButton1.Name = "PrevButton1"
        Me.PrevButton1.Size = New System.Drawing.Size(358, 34)
        Me.PrevButton1.TabIndex = 63
        Me.PrevButton1.Text = "<<"
        Me.PrevButton1.UseVisualStyleBackColor = True
        '
        'OutButton
        '
        Me.OutButton.AccessibleDescription = "PreviousButton"
        Me.OutButton.BackColor = System.Drawing.Color.Tomato
        Me.OutButton.Font = New System.Drawing.Font("Verdana", 10.25!, System.Drawing.FontStyle.Bold)
        Me.OutButton.Location = New System.Drawing.Point(795, 429)
        Me.OutButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OutButton.Name = "OutButton"
        Me.OutButton.Size = New System.Drawing.Size(193, 39)
        Me.OutButton.TabIndex = 61
        Me.OutButton.Text = "Logout"
        Me.OutButton.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(795, 118)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(192, 308)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 59
        Me.PictureBox1.TabStop = False
        '
        'GradeTextBox
        '
        Me.GradeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudBindingSource, "Grade", True))
        Me.GradeTextBox.Location = New System.Drawing.Point(478, 131)
        Me.GradeTextBox.Name = "GradeTextBox"
        Me.GradeTextBox.Size = New System.Drawing.Size(208, 26)
        Me.GradeTextBox.TabIndex = 64
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(127, 94)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(204, 26)
        Me.NameTextBox.TabIndex = 108
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(127, 59)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(204, 26)
        Me.IDTextBox.TabIndex = 109
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1064, 599)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.NextButton2)
        Me.Controls.Add(Me.PrevButton1)
        Me.Controls.Add(Me.OutButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form5"
        Me.Text = "Form6"
        CType(Me.StudentsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentsDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StudentsDataSet As studentsDataSet
    Friend WithEvents StudBindingSource As BindingSource
    Friend WithEvents StudTableAdapter As studentsDataSetTableAdapters.StudTableAdapter
    Friend WithEvents TableAdapterManager As studentsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StudBindingSource2 As BindingSource
    Friend WithEvents StudentsDataSet1 As studentsDataSet
    Friend WithEvents AdminDataSet As adminDataSet
    Friend WithEvents AdminBindingSource As BindingSource
    Friend WithEvents AdminTableAdapter As adminDataSetTableAdapters.adminTableAdapter
    Friend WithEvents TableAdapterManager1 As adminDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents StudTableAdapter1 As studentsDataSetTableAdapters.StudTableAdapter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableAdapterManager2 As studentsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NextButton2 As Button
    Friend WithEvents PrevButton1 As Button
    Friend WithEvents OutButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DPTTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents Year_semTextBox As TextBox
    Friend WithEvents SubjectTextBox As TextBox
    Friend WithEvents CCodeTextBox As TextBox
    Friend WithEvents GPATextBox As TextBox
    Friend WithEvents Tot_FeeTextBox As TextBox
    Friend WithEvents Paid_FeeTextBox As TextBox
    Friend WithEvents GradeTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents IDTextBox As TextBox
End Class
