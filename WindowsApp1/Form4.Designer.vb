<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim SexLabel As System.Windows.Forms.Label
        Dim DoBLabel As System.Windows.Forms.Label
        Dim DPTLabel As System.Windows.Forms.Label
        Dim CCodeLabel As System.Windows.Forms.Label
        Dim SubjectLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim AdressLabel As System.Windows.Forms.Label
        Dim GPALabel As System.Windows.Forms.Label
        Dim GradeLabel As System.Windows.Forms.Label
        Dim LangLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim Tot_FeeLabel As System.Windows.Forms.Label
        Dim Paid_FeeLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.StudentsDataSet = New WindowsApp1.studentsDataSet()
        Me.StudBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudTableAdapter = New WindowsApp1.studentsDataSetTableAdapters.StudTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.studentsDataSetTableAdapters.TableAdapterManager()
        Me.StudBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.StudBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudDataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DPTTextBox = New System.Windows.Forms.TextBox()
        Me.CCodeTextBox = New System.Windows.Forms.TextBox()
        Me.SubjectTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.AdressTextBox = New System.Windows.Forms.TextBox()
        Me.GPATextBox = New System.Windows.Forms.TextBox()
        Me.GradeTextBox = New System.Windows.Forms.TextBox()
        Me.LangTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Tot_FeeTextBox = New System.Windows.Forms.TextBox()
        Me.Year_semTextBox = New System.Windows.Forms.TextBox()
        Me.Paid_FeeTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.SexTextBox = New System.Windows.Forms.TextBox()
        Me.DoBTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.OutButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.DelButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.PrevButton = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        IDLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        SexLabel = New System.Windows.Forms.Label()
        DoBLabel = New System.Windows.Forms.Label()
        DPTLabel = New System.Windows.Forms.Label()
        CCodeLabel = New System.Windows.Forms.Label()
        SubjectLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        AdressLabel = New System.Windows.Forms.Label()
        GPALabel = New System.Windows.Forms.Label()
        GradeLabel = New System.Windows.Forms.Label()
        LangLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        Tot_FeeLabel = New System.Windows.Forms.Label()
        Paid_FeeLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.StudentsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StudBindingNavigator.SuspendLayout()
        CType(Me.StudDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.BackColor = System.Drawing.Color.Transparent
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        IDLabel.Location = New System.Drawing.Point(33, 189)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(35, 22)
        IDLabel.TabIndex = 2
        IDLabel.Text = "ID:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.BackColor = System.Drawing.Color.Transparent
        NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        NameLabel.Location = New System.Drawing.Point(31, 250)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(67, 22)
        NameLabel.TabIndex = 4
        NameLabel.Text = "Name:"
        '
        'SexLabel
        '
        SexLabel.AutoSize = True
        SexLabel.BackColor = System.Drawing.Color.Transparent
        SexLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SexLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        SexLabel.Location = New System.Drawing.Point(33, 308)
        SexLabel.Name = "SexLabel"
        SexLabel.Size = New System.Drawing.Size(50, 22)
        SexLabel.TabIndex = 8
        SexLabel.Text = "Sex:"
        '
        'DoBLabel
        '
        DoBLabel.AutoSize = True
        DoBLabel.BackColor = System.Drawing.Color.Transparent
        DoBLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DoBLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DoBLabel.Location = New System.Drawing.Point(33, 346)
        DoBLabel.Name = "DoBLabel"
        DoBLabel.Size = New System.Drawing.Size(60, 22)
        DoBLabel.TabIndex = 10
        DoBLabel.Text = "Do B:"
        '
        'DPTLabel
        '
        DPTLabel.AutoSize = True
        DPTLabel.BackColor = System.Drawing.Color.Transparent
        DPTLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DPTLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DPTLabel.Location = New System.Drawing.Point(445, 244)
        DPTLabel.Name = "DPTLabel"
        DPTLabel.Size = New System.Drawing.Size(56, 22)
        DPTLabel.TabIndex = 12
        DPTLabel.Text = "DPT:"
        '
        'CCodeLabel
        '
        CCodeLabel.AutoSize = True
        CCodeLabel.BackColor = System.Drawing.Color.Transparent
        CCodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CCodeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        CCodeLabel.Location = New System.Drawing.Point(445, 276)
        CCodeLabel.Name = "CCodeLabel"
        CCodeLabel.Size = New System.Drawing.Size(77, 22)
        CCodeLabel.TabIndex = 14
        CCodeLabel.Text = "CCode:"
        '
        'SubjectLabel
        '
        SubjectLabel.AutoSize = True
        SubjectLabel.BackColor = System.Drawing.Color.Transparent
        SubjectLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SubjectLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        SubjectLabel.Location = New System.Drawing.Point(445, 308)
        SubjectLabel.Name = "SubjectLabel"
        SubjectLabel.Size = New System.Drawing.Size(83, 22)
        SubjectLabel.TabIndex = 16
        SubjectLabel.Text = "Subject:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.BackColor = System.Drawing.Color.Transparent
        PhoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PhoneLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        PhoneLabel.Location = New System.Drawing.Point(33, 410)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(73, 22)
        PhoneLabel.TabIndex = 18
        PhoneLabel.Text = "Phone:"
        '
        'AdressLabel
        '
        AdressLabel.AutoSize = True
        AdressLabel.BackColor = System.Drawing.Color.Transparent
        AdressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AdressLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        AdressLabel.Location = New System.Drawing.Point(839, 240)
        AdressLabel.Name = "AdressLabel"
        AdressLabel.Size = New System.Drawing.Size(78, 22)
        AdressLabel.TabIndex = 20
        AdressLabel.Text = "Adress:"
        '
        'GPALabel
        '
        GPALabel.AutoSize = True
        GPALabel.BackColor = System.Drawing.Color.Transparent
        GPALabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GPALabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        GPALabel.Location = New System.Drawing.Point(445, 340)
        GPALabel.Name = "GPALabel"
        GPALabel.Size = New System.Drawing.Size(57, 22)
        GPALabel.TabIndex = 22
        GPALabel.Text = "GPA:"
        '
        'GradeLabel
        '
        GradeLabel.AutoSize = True
        GradeLabel.BackColor = System.Drawing.Color.Transparent
        GradeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GradeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        GradeLabel.Location = New System.Drawing.Point(447, 372)
        GradeLabel.Name = "GradeLabel"
        GradeLabel.Size = New System.Drawing.Size(71, 22)
        GradeLabel.TabIndex = 24
        GradeLabel.Text = "Grade:"
        '
        'LangLabel
        '
        LangLabel.AutoSize = True
        LangLabel.BackColor = System.Drawing.Color.Transparent
        LangLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LangLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        LangLabel.Location = New System.Drawing.Point(839, 278)
        LangLabel.Name = "LangLabel"
        LangLabel.Size = New System.Drawing.Size(60, 22)
        LangLabel.TabIndex = 26
        LangLabel.Text = "Lang:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.BackColor = System.Drawing.Color.Transparent
        EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        EmailLabel.Location = New System.Drawing.Point(33, 378)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(65, 22)
        EmailLabel.TabIndex = 28
        EmailLabel.Text = "Email:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.BackColor = System.Drawing.Color.Transparent
        UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsernameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        UsernameLabel.Location = New System.Drawing.Point(839, 310)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(106, 22)
        UsernameLabel.TabIndex = 30
        UsernameLabel.Text = "Username:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.BackColor = System.Drawing.Color.Transparent
        PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PasswordLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        PasswordLabel.Location = New System.Drawing.Point(839, 342)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(103, 22)
        PasswordLabel.TabIndex = 32
        PasswordLabel.Text = "Password:"
        '
        'Tot_FeeLabel
        '
        Tot_FeeLabel.AutoSize = True
        Tot_FeeLabel.BackColor = System.Drawing.Color.Transparent
        Tot_FeeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Tot_FeeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Tot_FeeLabel.Location = New System.Drawing.Point(839, 374)
        Tot_FeeLabel.Name = "Tot_FeeLabel"
        Tot_FeeLabel.Size = New System.Drawing.Size(86, 22)
        Tot_FeeLabel.TabIndex = 34
        Tot_FeeLabel.Text = "Tot Fee:"
        '
        'Paid_FeeLabel
        '
        Paid_FeeLabel.AutoSize = True
        Paid_FeeLabel.BackColor = System.Drawing.Color.Transparent
        Paid_FeeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Paid_FeeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Paid_FeeLabel.Location = New System.Drawing.Point(839, 406)
        Paid_FeeLabel.Name = "Paid_FeeLabel"
        Paid_FeeLabel.Size = New System.Drawing.Size(96, 22)
        Paid_FeeLabel.TabIndex = 36
        Paid_FeeLabel.Text = "Paid Fee:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Label2.Location = New System.Drawing.Point(33, 278)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(111, 22)
        Label2.TabIndex = 50
        Label2.Text = "Last Name:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.BackColor = System.Drawing.Color.Transparent
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Label3.Location = New System.Drawing.Point(445, 403)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(101, 22)
        Label3.TabIndex = 84
        Label3.Text = "Year-sem:"
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
        'StudBindingNavigator
        '
        Me.StudBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StudBindingNavigator.BindingSource = Me.StudBindingSource
        Me.StudBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StudBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StudBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StudBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StudBindingNavigatorSaveItem})
        Me.StudBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.StudBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StudBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StudBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StudBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StudBindingNavigator.Name = "StudBindingNavigator"
        Me.StudBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StudBindingNavigator.Size = New System.Drawing.Size(1290, 31)
        Me.StudBindingNavigator.TabIndex = 0
        Me.StudBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(54, 28)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'StudBindingNavigatorSaveItem
        '
        Me.StudBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StudBindingNavigatorSaveItem.Image = CType(resources.GetObject("StudBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StudBindingNavigatorSaveItem.Name = "StudBindingNavigatorSaveItem"
        Me.StudBindingNavigatorSaveItem.Size = New System.Drawing.Size(28, 28)
        Me.StudBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Year-sem"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Year-sem"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Paid Fee"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Paid Fee"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Tot Fee"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Tot Fee"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Password"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Password"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Username"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Username"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Lang"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Lang"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Grade"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Grade"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "GPA"
        Me.DataGridViewTextBoxColumn11.HeaderText = "GPA"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Adress"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Adress"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Phone"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Phone"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Subject"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Subject"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CCode"
        Me.DataGridViewTextBoxColumn7.HeaderText = "CCode"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DPT"
        Me.DataGridViewTextBoxColumn6.HeaderText = "DPT"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DoB"
        Me.DataGridViewTextBoxColumn5.HeaderText = "DoB"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Sex"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Sex"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "LastName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'StudDataGridView
        '
        Me.StudDataGridView.AutoGenerateColumns = False
        Me.StudDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19})
        Me.StudDataGridView.DataSource = Me.StudBindingSource
        Me.StudDataGridView.Location = New System.Drawing.Point(42, 549)
        Me.StudDataGridView.Name = "StudDataGridView"
        Me.StudDataGridView.RowTemplate.Height = 28
        Me.StudDataGridView.Size = New System.Drawing.Size(1209, 220)
        Me.StudDataGridView.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Label3)
        Me.Panel1.Controls.Add(Label2)
        Me.Panel1.Controls.Add(Me.DPTTextBox)
        Me.Panel1.Controls.Add(Me.CCodeTextBox)
        Me.Panel1.Controls.Add(Me.SubjectTextBox)
        Me.Panel1.Controls.Add(Me.PhoneTextBox)
        Me.Panel1.Controls.Add(Me.AdressTextBox)
        Me.Panel1.Controls.Add(Me.GPATextBox)
        Me.Panel1.Controls.Add(Me.GradeTextBox)
        Me.Panel1.Controls.Add(Me.LangTextBox)
        Me.Panel1.Controls.Add(Me.EmailTextBox)
        Me.Panel1.Controls.Add(Me.UsernameTextBox)
        Me.Panel1.Controls.Add(Me.PasswordTextBox)
        Me.Panel1.Controls.Add(Me.Tot_FeeTextBox)
        Me.Panel1.Controls.Add(Me.Year_semTextBox)
        Me.Panel1.Controls.Add(Me.Paid_FeeTextBox)
        Me.Panel1.Controls.Add(IDLabel)
        Me.Panel1.Controls.Add(Me.NameTextBox)
        Me.Panel1.Controls.Add(Me.IDTextBox)
        Me.Panel1.Controls.Add(Me.SexTextBox)
        Me.Panel1.Controls.Add(Me.DoBTextBox)
        Me.Panel1.Controls.Add(NameLabel)
        Me.Panel1.Controls.Add(Me.LastNameTextBox)
        Me.Panel1.Controls.Add(SexLabel)
        Me.Panel1.Controls.Add(DoBLabel)
        Me.Panel1.Controls.Add(DPTLabel)
        Me.Panel1.Controls.Add(CCodeLabel)
        Me.Panel1.Controls.Add(SubjectLabel)
        Me.Panel1.Controls.Add(PhoneLabel)
        Me.Panel1.Controls.Add(AdressLabel)
        Me.Panel1.Controls.Add(GPALabel)
        Me.Panel1.Controls.Add(GradeLabel)
        Me.Panel1.Controls.Add(LangLabel)
        Me.Panel1.Controls.Add(EmailLabel)
        Me.Panel1.Controls.Add(UsernameLabel)
        Me.Panel1.Controls.Add(PasswordLabel)
        Me.Panel1.Controls.Add(Tot_FeeLabel)
        Me.Panel1.Controls.Add(Paid_FeeLabel)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(42, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1209, 458)
        Me.Panel1.TabIndex = 48
        '
        'DPTTextBox
        '
        Me.DPTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudBindingSource, "DPT", True))
        Me.DPTTextBox.Location = New System.Drawing.Point(554, 243)
        Me.DPTTextBox.Name = "DPTTextBox"
        Me.DPTTextBox.Size = New System.Drawing.Size(228, 26)
        Me.DPTTextBox.TabIndex = 59
        '
        'CCodeTextBox
        '
        Me.CCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudBindingSource, "CCode", True))
        Me.CCodeTextBox.Location = New System.Drawing.Point(554, 274)
        Me.CCodeTextBox.Name = "CCodeTextBox"
        Me.CCodeTextBox.Size = New System.Drawing.Size(228, 26)
        Me.CCodeTextBox.TabIndex = 61
        '
        'SubjectTextBox
        '
        Me.SubjectTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudBindingSource, "Subject", True))
        Me.SubjectTextBox.Location = New System.Drawing.Point(554, 304)
        Me.SubjectTextBox.Name = "SubjectTextBox"
        Me.SubjectTextBox.Size = New System.Drawing.Size(228, 26)
        Me.SubjectTextBox.TabIndex = 63
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudBindingSource, "Phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(150, 405)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(252, 26)
        Me.PhoneTextBox.TabIndex = 65
        '
        'AdressTextBox
        '
        Me.AdressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudBindingSource, "Adress", True))
        Me.AdressTextBox.Location = New System.Drawing.Point(956, 243)
        Me.AdressTextBox.Name = "AdressTextBox"
        Me.AdressTextBox.Size = New System.Drawing.Size(210, 26)
        Me.AdressTextBox.TabIndex = 67
        '
        'GPATextBox
        '
        Me.GPATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudBindingSource, "GPA", True))
        Me.GPATextBox.Location = New System.Drawing.Point(554, 336)
        Me.GPATextBox.Name = "GPATextBox"
        Me.GPATextBox.Size = New System.Drawing.Size(228, 26)
        Me.GPATextBox.TabIndex = 69
        '
        'GradeTextBox
        '
        Me.GradeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudBindingSource, "Grade", True))
        Me.GradeTextBox.Location = New System.Drawing.Point(554, 368)
        Me.GradeTextBox.Name = "GradeTextBox"
        Me.GradeTextBox.Size = New System.Drawing.Size(228, 26)
        Me.GradeTextBox.TabIndex = 71
        '
        'LangTextBox
        '
        Me.LangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudBindingSource, "Lang", True))
        Me.LangTextBox.Location = New System.Drawing.Point(956, 275)
        Me.LangTextBox.Name = "LangTextBox"
        Me.LangTextBox.Size = New System.Drawing.Size(210, 26)
        Me.LangTextBox.TabIndex = 73
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(150, 374)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(252, 26)
        Me.EmailTextBox.TabIndex = 75
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudBindingSource, "Username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(956, 307)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(210, 26)
        Me.UsernameTextBox.TabIndex = 77
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudBindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(956, 339)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(210, 26)
        Me.PasswordTextBox.TabIndex = 79
        '
        'Tot_FeeTextBox
        '
        Me.Tot_FeeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudBindingSource, "Tot Fee", True))
        Me.Tot_FeeTextBox.Location = New System.Drawing.Point(956, 371)
        Me.Tot_FeeTextBox.Name = "Tot_FeeTextBox"
        Me.Tot_FeeTextBox.Size = New System.Drawing.Size(210, 26)
        Me.Tot_FeeTextBox.TabIndex = 81
        '
        'Year_semTextBox
        '
        Me.Year_semTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudBindingSource, "Year-sem", True))
        Me.Year_semTextBox.Location = New System.Drawing.Point(554, 399)
        Me.Year_semTextBox.Name = "Year_semTextBox"
        Me.Year_semTextBox.Size = New System.Drawing.Size(228, 26)
        Me.Year_semTextBox.TabIndex = 85
        '
        'Paid_FeeTextBox
        '
        Me.Paid_FeeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudBindingSource, "Paid Fee", True))
        Me.Paid_FeeTextBox.Location = New System.Drawing.Point(956, 403)
        Me.Paid_FeeTextBox.Name = "Paid_FeeTextBox"
        Me.Paid_FeeTextBox.Size = New System.Drawing.Size(210, 26)
        Me.Paid_FeeTextBox.TabIndex = 83
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(150, 246)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(252, 26)
        Me.NameTextBox.TabIndex = 51
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(150, 189)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(252, 26)
        Me.IDTextBox.TabIndex = 49
        '
        'SexTextBox
        '
        Me.SexTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudBindingSource, "Sex", True))
        Me.SexTextBox.Location = New System.Drawing.Point(150, 310)
        Me.SexTextBox.Name = "SexTextBox"
        Me.SexTextBox.Size = New System.Drawing.Size(252, 26)
        Me.SexTextBox.TabIndex = 55
        '
        'DoBTextBox
        '
        Me.DoBTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudBindingSource, "DoB", True))
        Me.DoBTextBox.Location = New System.Drawing.Point(150, 342)
        Me.DoBTextBox.Name = "DoBTextBox"
        Me.DoBTextBox.Size = New System.Drawing.Size(252, 26)
        Me.DoBTextBox.TabIndex = 57
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(150, 278)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(252, 26)
        Me.LastNameTextBox.TabIndex = 53
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(26, 22)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1156, 114)
        Me.Panel3.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Verdana", 40.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(218, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(705, 97)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Students Infos"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(-214, 45)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1924, 107)
        Me.Panel2.TabIndex = 1
        '
        'OutButton
        '
        Me.OutButton.AccessibleDescription = "ConfirmButton"
        Me.OutButton.Font = New System.Drawing.Font("Verdana", 16.25!, System.Drawing.FontStyle.Bold)
        Me.OutButton.Location = New System.Drawing.Point(1060, 814)
        Me.OutButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OutButton.Name = "OutButton"
        Me.OutButton.Size = New System.Drawing.Size(191, 56)
        Me.OutButton.TabIndex = 54
        Me.OutButton.Text = "LogOut"
        Me.OutButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.AccessibleDescription = "ConfirmButton"
        Me.SaveButton.Font = New System.Drawing.Font("Verdana", 16.25!, System.Drawing.FontStyle.Bold)
        Me.SaveButton.Location = New System.Drawing.Point(231, 814)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(179, 55)
        Me.SaveButton.TabIndex = 55
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'DelButton
        '
        Me.DelButton.AccessibleDescription = "DelButton"
        Me.DelButton.Font = New System.Drawing.Font("Verdana", 16.25!, System.Drawing.FontStyle.Bold)
        Me.DelButton.Location = New System.Drawing.Point(882, 814)
        Me.DelButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DelButton.Name = "DelButton"
        Me.DelButton.Size = New System.Drawing.Size(180, 56)
        Me.DelButton.TabIndex = 56
        Me.DelButton.Text = "Dele"
        Me.DelButton.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.AccessibleDescription = "ConfirmButton"
        Me.AddButton.Font = New System.Drawing.Font("Verdana", 16.25!, System.Drawing.FontStyle.Bold)
        Me.AddButton.Location = New System.Drawing.Point(42, 814)
        Me.AddButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(191, 55)
        Me.AddButton.TabIndex = 57
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'NextButton
        '
        Me.NextButton.AccessibleDescription = "ConfirmButton"
        Me.NextButton.Font = New System.Drawing.Font("Verdana", 16.25!, System.Drawing.FontStyle.Bold)
        Me.NextButton.Location = New System.Drawing.Point(635, 821)
        Me.NextButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(98, 49)
        Me.NextButton.TabIndex = 58
        Me.NextButton.Text = ">>"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'PrevButton
        '
        Me.PrevButton.AccessibleDescription = "ConfirmButton"
        Me.PrevButton.Font = New System.Drawing.Font("Verdana", 16.25!, System.Drawing.FontStyle.Bold)
        Me.PrevButton.Location = New System.Drawing.Point(532, 821)
        Me.PrevButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PrevButton.Name = "PrevButton"
        Me.PrevButton.Size = New System.Drawing.Size(112, 49)
        Me.PrevButton.TabIndex = 59
        Me.PrevButton.Text = "<<"
        Me.PrevButton.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.ForeColor = System.Drawing.Color.Transparent
        Me.Panel4.Location = New System.Drawing.Point(42, 889)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1208, 26)
        Me.Panel4.TabIndex = 60
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1290, 956)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.OutButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.DelButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.PrevButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StudDataGridView)
        Me.Controls.Add(Me.StudBindingNavigator)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        CType(Me.StudentsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StudBindingNavigator.ResumeLayout(False)
        Me.StudBindingNavigator.PerformLayout()
        CType(Me.StudDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StudentsDataSet As studentsDataSet
    Friend WithEvents StudBindingSource As BindingSource
    Friend WithEvents StudTableAdapter As studentsDataSetTableAdapters.StudTableAdapter
    Friend WithEvents TableAdapterManager As studentsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StudBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents StudBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents StudDataGridView As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents SexTextBox As TextBox
    Friend WithEvents DoBTextBox As TextBox
    Friend WithEvents DPTTextBox As TextBox
    Friend WithEvents CCodeTextBox As TextBox
    Friend WithEvents SubjectTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents AdressTextBox As TextBox
    Friend WithEvents GPATextBox As TextBox
    Friend WithEvents GradeTextBox As TextBox
    Friend WithEvents LangTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents Tot_FeeTextBox As TextBox
    Friend WithEvents Paid_FeeTextBox As TextBox
    Friend WithEvents Year_semTextBox As TextBox
    Friend WithEvents OutButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents DelButton As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents NextButton As Button
    Friend WithEvents PrevButton As Button
    Friend WithEvents Panel4 As Panel
End Class
