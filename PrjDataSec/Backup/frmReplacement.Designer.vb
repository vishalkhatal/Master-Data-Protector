<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReplacement
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim RepNoteNoLabel As System.Windows.Forms.Label
        Dim BillNoLabel As System.Windows.Forms.Label
        Dim PNameLabel As System.Windows.Forms.Label
        Dim SaleCostLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim QtyLabel As System.Windows.Forms.Label
        Dim TotalAmtLabel As System.Windows.Forms.Label
        Dim ReplStatusLabel As System.Windows.Forms.Label
        Dim DperLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReplacement))
        Me.Label1 = New System.Windows.Forms.Label
        Me.StockDataSet = New PrjDataSec.StockDataSet
        Me.ReplecementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReplecementTableAdapter = New PrjDataSec.StockDataSetTableAdapters.ReplecementTableAdapter
        Me.ReplecementBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ReplecementBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.RepNoteNoTextBox = New System.Windows.Forms.TextBox
        Me.PartCodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PartCodeTableAdapter = New PrjDataSec.StockDataSetTableAdapters.PartCodeTableAdapter
        Me.BillNoComboBox = New System.Windows.Forms.ComboBox
        Me.PNameComboBox = New System.Windows.Forms.ComboBox
        Me.SaleCostTextBox = New System.Windows.Forms.TextBox
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.QtyTextBox = New System.Windows.Forms.TextBox
        Me.TotalAmtTextBox = New System.Windows.Forms.TextBox
        Me.ReplStatusTextBox = New System.Windows.Forms.TextBox
        Me.DperTextBox = New System.Windows.Forms.TextBox
        Me.ReplecementDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        RepNoteNoLabel = New System.Windows.Forms.Label
        BillNoLabel = New System.Windows.Forms.Label
        PNameLabel = New System.Windows.Forms.Label
        SaleCostLabel = New System.Windows.Forms.Label
        DateLabel = New System.Windows.Forms.Label
        QtyLabel = New System.Windows.Forms.Label
        TotalAmtLabel = New System.Windows.Forms.Label
        ReplStatusLabel = New System.Windows.Forms.Label
        DperLabel = New System.Windows.Forms.Label
        CType(Me.StockDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReplecementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReplecementBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ReplecementBindingNavigator.SuspendLayout()
        CType(Me.PartCodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReplecementDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RepNoteNoLabel
        '
        RepNoteNoLabel.AutoSize = True
        RepNoteNoLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        RepNoteNoLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RepNoteNoLabel.Location = New System.Drawing.Point(24, 22)
        RepNoteNoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        RepNoteNoLabel.Name = "RepNoteNoLabel"
        RepNoteNoLabel.Size = New System.Drawing.Size(96, 19)
        RepNoteNoLabel.TabIndex = 4
        RepNoteNoLabel.Text = "Rep Note No:"
        '
        'BillNoLabel
        '
        BillNoLabel.AutoSize = True
        BillNoLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        BillNoLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BillNoLabel.Location = New System.Drawing.Point(65, 65)
        BillNoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BillNoLabel.Name = "BillNoLabel"
        BillNoLabel.Size = New System.Drawing.Size(55, 19)
        BillNoLabel.TabIndex = 5
        BillNoLabel.Text = "Bill No:"
        '
        'PNameLabel
        '
        PNameLabel.AutoSize = True
        PNameLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        PNameLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PNameLabel.Location = New System.Drawing.Point(42, 103)
        PNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PNameLabel.Name = "PNameLabel"
        PNameLabel.Size = New System.Drawing.Size(78, 19)
        PNameLabel.TabIndex = 6
        PNameLabel.Text = "Part Name:"
        '
        'SaleCostLabel
        '
        SaleCostLabel.AutoSize = True
        SaleCostLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        SaleCostLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SaleCostLabel.Location = New System.Drawing.Point(357, 28)
        SaleCostLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SaleCostLabel.Name = "SaleCostLabel"
        SaleCostLabel.Size = New System.Drawing.Size(71, 19)
        SaleCostLabel.TabIndex = 8
        SaleCostLabel.Text = "Sale Cost:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DateLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateLabel.Location = New System.Drawing.Point(79, 149)
        DateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(41, 19)
        DateLabel.TabIndex = 10
        DateLabel.Text = "Date:"
        '
        'QtyLabel
        '
        QtyLabel.AutoSize = True
        QtyLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        QtyLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        QtyLabel.Location = New System.Drawing.Point(365, 60)
        QtyLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        QtyLabel.Name = "QtyLabel"
        QtyLabel.Size = New System.Drawing.Size(63, 19)
        QtyLabel.TabIndex = 12
        QtyLabel.Text = "Quantity:"
        '
        'TotalAmtLabel
        '
        TotalAmtLabel.AutoSize = True
        TotalAmtLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        TotalAmtLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TotalAmtLabel.Location = New System.Drawing.Point(355, 93)
        TotalAmtLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TotalAmtLabel.Name = "TotalAmtLabel"
        TotalAmtLabel.Size = New System.Drawing.Size(73, 19)
        TotalAmtLabel.TabIndex = 14
        TotalAmtLabel.Text = "Total Amt:"
        '
        'ReplStatusLabel
        '
        ReplStatusLabel.AutoSize = True
        ReplStatusLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        ReplStatusLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReplStatusLabel.Location = New System.Drawing.Point(297, 139)
        ReplStatusLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ReplStatusLabel.Name = "ReplStatusLabel"
        ReplStatusLabel.Size = New System.Drawing.Size(131, 19)
        ReplStatusLabel.TabIndex = 16
        ReplStatusLabel.Text = "Replacement Status:"
        '
        'DperLabel
        '
        DperLabel.AutoSize = True
        DperLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DperLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DperLabel.Location = New System.Drawing.Point(34, 181)
        DperLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DperLabel.Name = "DperLabel"
        DperLabel.Size = New System.Drawing.Size(86, 19)
        DperLabel.TabIndex = 18
        DperLabel.Text = "Damage per:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Replacement Note"
        '
        'StockDataSet
        '
        Me.StockDataSet.DataSetName = "StockDataSet"
        Me.StockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReplecementBindingSource
        '
        Me.ReplecementBindingSource.DataMember = "Replecement"
        Me.ReplecementBindingSource.DataSource = Me.StockDataSet
        '
        'ReplecementTableAdapter
        '
        Me.ReplecementTableAdapter.ClearBeforeFill = True
        '
        'ReplecementBindingNavigator
        '
        Me.ReplecementBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ReplecementBindingNavigator.BindingSource = Me.ReplecementBindingSource
        Me.ReplecementBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ReplecementBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ReplecementBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ReplecementBindingNavigatorSaveItem})
        Me.ReplecementBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ReplecementBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ReplecementBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ReplecementBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ReplecementBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ReplecementBindingNavigator.Name = "ReplecementBindingNavigator"
        Me.ReplecementBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ReplecementBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ReplecementBindingNavigator.Size = New System.Drawing.Size(779, 25)
        Me.ReplecementBindingNavigator.TabIndex = 4
        Me.ReplecementBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(42, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(73, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ReplecementBindingNavigatorSaveItem
        '
        Me.ReplecementBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ReplecementBindingNavigatorSaveItem.Image = CType(resources.GetObject("ReplecementBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ReplecementBindingNavigatorSaveItem.Name = "ReplecementBindingNavigatorSaveItem"
        Me.ReplecementBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ReplecementBindingNavigatorSaveItem.Text = "Save Data"
        '
        'RepNoteNoTextBox
        '
        Me.RepNoteNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RepNoteNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReplecementBindingSource, "RepNoteNo", True))
        Me.RepNoteNoTextBox.Location = New System.Drawing.Point(128, 25)
        Me.RepNoteNoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.RepNoteNoTextBox.Name = "RepNoteNoTextBox"
        Me.RepNoteNoTextBox.Size = New System.Drawing.Size(123, 24)
        Me.RepNoteNoTextBox.TabIndex = 5
        '
        'PartCodeBindingSource
        '
        Me.PartCodeBindingSource.DataMember = "PartCode"
        Me.PartCodeBindingSource.DataSource = Me.StockDataSet
        '
        'PartCodeTableAdapter
        '
        Me.PartCodeTableAdapter.ClearBeforeFill = True
        '
        'BillNoComboBox
        '
        Me.BillNoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReplecementBindingSource, "BillNo", True))
        Me.BillNoComboBox.FormattingEnabled = True
        Me.BillNoComboBox.Location = New System.Drawing.Point(128, 65)
        Me.BillNoComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.BillNoComboBox.Name = "BillNoComboBox"
        Me.BillNoComboBox.Size = New System.Drawing.Size(148, 26)
        Me.BillNoComboBox.TabIndex = 6
        '
        'PNameComboBox
        '
        Me.PNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReplecementBindingSource, "PName", True))
        Me.PNameComboBox.FormattingEnabled = True
        Me.PNameComboBox.Location = New System.Drawing.Point(128, 104)
        Me.PNameComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PNameComboBox.Name = "PNameComboBox"
        Me.PNameComboBox.Size = New System.Drawing.Size(148, 26)
        Me.PNameComboBox.TabIndex = 7
        '
        'SaleCostTextBox
        '
        Me.SaleCostTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SaleCostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReplecementBindingSource, "SaleCost", True))
        Me.SaleCostTextBox.Location = New System.Drawing.Point(476, 127)
        Me.SaleCostTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SaleCostTextBox.Name = "SaleCostTextBox"
        Me.SaleCostTextBox.Size = New System.Drawing.Size(93, 24)
        Me.SaleCostTextBox.TabIndex = 9
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ReplecementBindingSource, "Date", True))
        Me.DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateDateTimePicker.Location = New System.Drawing.Point(128, 142)
        Me.DateDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(148, 24)
        Me.DateDateTimePicker.TabIndex = 11
        '
        'QtyTextBox
        '
        Me.QtyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.QtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReplecementBindingSource, "Qty", True))
        Me.QtyTextBox.Location = New System.Drawing.Point(476, 159)
        Me.QtyTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.QtyTextBox.Name = "QtyTextBox"
        Me.QtyTextBox.Size = New System.Drawing.Size(148, 24)
        Me.QtyTextBox.TabIndex = 13
        '
        'TotalAmtTextBox
        '
        Me.TotalAmtTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalAmtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReplecementBindingSource, "TotalAmt", True))
        Me.TotalAmtTextBox.Location = New System.Drawing.Point(476, 195)
        Me.TotalAmtTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TotalAmtTextBox.Name = "TotalAmtTextBox"
        Me.TotalAmtTextBox.Size = New System.Drawing.Size(148, 24)
        Me.TotalAmtTextBox.TabIndex = 15
        '
        'ReplStatusTextBox
        '
        Me.ReplStatusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReplStatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReplecementBindingSource, "ReplStatus", True))
        Me.ReplStatusTextBox.Location = New System.Drawing.Point(477, 238)
        Me.ReplStatusTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ReplStatusTextBox.Name = "ReplStatusTextBox"
        Me.ReplStatusTextBox.Size = New System.Drawing.Size(174, 24)
        Me.ReplStatusTextBox.TabIndex = 17
        '
        'DperTextBox
        '
        Me.DperTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DperTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReplecementBindingSource, "Dper", True))
        Me.DperTextBox.Location = New System.Drawing.Point(128, 178)
        Me.DperTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DperTextBox.Name = "DperTextBox"
        Me.DperTextBox.Size = New System.Drawing.Size(148, 24)
        Me.DperTextBox.TabIndex = 19
        '
        'ReplecementDataGridView
        '
        Me.ReplecementDataGridView.AutoGenerateColumns = False
        Me.ReplecementDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.ReplecementDataGridView.DataSource = Me.ReplecementBindingSource
        Me.ReplecementDataGridView.Location = New System.Drawing.Point(70, 329)
        Me.ReplecementDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.ReplecementDataGridView.Name = "ReplecementDataGridView"
        Me.ReplecementDataGridView.Size = New System.Drawing.Size(629, 169)
        Me.ReplecementDataGridView.TabIndex = 20
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "RepNoteNo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "RepNoteNo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "BillNo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "BillNo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "PName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PartCode"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PartCode"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "SaleCost"
        Me.DataGridViewTextBoxColumn5.HeaderText = "SaleCost"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Qty"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Qty"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "TotalAmt"
        Me.DataGridViewTextBoxColumn8.HeaderText = "TotalAmt"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ReplStatus"
        Me.DataGridViewTextBoxColumn9.HeaderText = "ReplStatus"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Dper"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Dper"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DperTextBox)
        Me.Panel1.Controls.Add(RepNoteNoLabel)
        Me.Panel1.Controls.Add(BillNoLabel)
        Me.Panel1.Controls.Add(ReplStatusLabel)
        Me.Panel1.Controls.Add(DperLabel)
        Me.Panel1.Controls.Add(PNameLabel)
        Me.Panel1.Controls.Add(TotalAmtLabel)
        Me.Panel1.Controls.Add(DateLabel)
        Me.Panel1.Controls.Add(Me.RepNoteNoTextBox)
        Me.Panel1.Controls.Add(QtyLabel)
        Me.Panel1.Controls.Add(Me.BillNoComboBox)
        Me.Panel1.Controls.Add(Me.PNameComboBox)
        Me.Panel1.Controls.Add(SaleCostLabel)
        Me.Panel1.Controls.Add(Me.DateDateTimePicker)
        Me.Panel1.Location = New System.Drawing.Point(39, 98)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(696, 429)
        Me.Panel1.TabIndex = 21
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(594, 533)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 46)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "&Exit"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(431, 533)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 46)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "&Show Report"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.PrjDataSec.My.Resources.Resources.POINT04
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(111, 533)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(149, 47)
        Me.Button4.TabIndex = 34
        Me.Button4.Text = "Delete Record"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.PrjDataSec.My.Resources.Resources.POINT04
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(266, 533)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(149, 47)
        Me.Button3.TabIndex = 33
        Me.Button3.Text = "Update Record"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'frmReplacement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(779, 591)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ReplecementDataGridView)
        Me.Controls.Add(Me.ReplStatusTextBox)
        Me.Controls.Add(Me.TotalAmtTextBox)
        Me.Controls.Add(Me.QtyTextBox)
        Me.Controls.Add(Me.SaleCostTextBox)
        Me.Controls.Add(Me.ReplecementBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmReplacement"
        Me.Text = "Replacement Note Generation"
        CType(Me.StockDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReplecementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReplecementBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ReplecementBindingNavigator.ResumeLayout(False)
        Me.ReplecementBindingNavigator.PerformLayout()
        CType(Me.PartCodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReplecementDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StockDataSet As PrjDataSec.StockDataSet
    Friend WithEvents ReplecementBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReplecementTableAdapter As PrjDataSec.StockDataSetTableAdapters.ReplecementTableAdapter
    Friend WithEvents ReplecementBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ReplecementBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents RepNoteNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PartCodeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PartCodeTableAdapter As PrjDataSec.StockDataSetTableAdapters.PartCodeTableAdapter
    Friend WithEvents BillNoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SaleCostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents QtyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalAmtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReplStatusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DperTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReplecementDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
