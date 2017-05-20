<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaleBill
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
        Dim BillNoLabel As System.Windows.Forms.Label
        Dim BillDateLabel As System.Windows.Forms.Label
        Dim SubCompNameLabel As System.Windows.Forms.Label
        Dim PartNameLabel As System.Windows.Forms.Label
        Dim QtyLabel As System.Windows.Forms.Label
        Dim CostLabel As System.Windows.Forms.Label
        Dim TotalAmtLabel As System.Windows.Forms.Label
        Dim DisLabel As System.Windows.Forms.Label
        Dim NetAmtLabel As System.Windows.Forms.Label
        Dim ModeofPaymentLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSaleBill))
        Dim PartCodeLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.StockDataSet = New PrjDataSec.StockDataSet
        Me.BillBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BillTableAdapter = New PrjDataSec.StockDataSetTableAdapters.BillTableAdapter
        Me.BillBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.BillBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.BillNoTextBox = New System.Windows.Forms.TextBox
        Me.BillDateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.SubCompNameComboBox = New System.Windows.Forms.ComboBox
        Me.PartNameComboBox = New System.Windows.Forms.ComboBox
        Me.QtyTextBox = New System.Windows.Forms.TextBox
        Me.CostTextBox = New System.Windows.Forms.TextBox
        Me.TotalAmtTextBox = New System.Windows.Forms.TextBox
        Me.DisTextBox = New System.Windows.Forms.TextBox
        Me.NetAmtTextBox = New System.Windows.Forms.TextBox
        Me.ModeofPaymentComboBox = New System.Windows.Forms.ComboBox
        Me.BillDataGridView = New System.Windows.Forms.DataGridView
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
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.PartCodeComboBox = New System.Windows.Forms.ComboBox
        Me.PartCodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PartCodeTableAdapter = New PrjDataSec.StockDataSetTableAdapters.PartCodeTableAdapter
        Me.PartCodeBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubCompanyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubCompanyTableAdapter = New PrjDataSec.StockDataSetTableAdapters.SubCompanyTableAdapter
        BillNoLabel = New System.Windows.Forms.Label
        BillDateLabel = New System.Windows.Forms.Label
        SubCompNameLabel = New System.Windows.Forms.Label
        PartNameLabel = New System.Windows.Forms.Label
        QtyLabel = New System.Windows.Forms.Label
        CostLabel = New System.Windows.Forms.Label
        TotalAmtLabel = New System.Windows.Forms.Label
        DisLabel = New System.Windows.Forms.Label
        NetAmtLabel = New System.Windows.Forms.Label
        ModeofPaymentLabel = New System.Windows.Forms.Label
        PartCodeLabel = New System.Windows.Forms.Label
        CType(Me.StockDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BillBindingNavigator.SuspendLayout()
        CType(Me.BillDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PartCodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartCodeBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubCompanyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BillNoLabel
        '
        BillNoLabel.AutoSize = True
        BillNoLabel.Location = New System.Drawing.Point(82, 18)
        BillNoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BillNoLabel.Name = "BillNoLabel"
        BillNoLabel.Size = New System.Drawing.Size(55, 18)
        BillNoLabel.TabIndex = 5
        BillNoLabel.Text = "Bill No:"
        '
        'BillDateLabel
        '
        BillDateLabel.AutoSize = True
        BillDateLabel.Location = New System.Drawing.Point(71, 52)
        BillDateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BillDateLabel.Name = "BillDateLabel"
        BillDateLabel.Size = New System.Drawing.Size(66, 18)
        BillDateLabel.TabIndex = 6
        BillDateLabel.Text = "Bill Date:"
        '
        'SubCompNameLabel
        '
        SubCompNameLabel.AutoSize = True
        SubCompNameLabel.Location = New System.Drawing.Point(12, 81)
        SubCompNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SubCompNameLabel.Name = "SubCompNameLabel"
        SubCompNameLabel.Size = New System.Drawing.Size(124, 18)
        SubCompNameLabel.TabIndex = 7
        SubCompNameLabel.Text = "Company  Name:"
        '
        'PartNameLabel
        '
        PartNameLabel.AutoSize = True
        PartNameLabel.Location = New System.Drawing.Point(54, 160)
        PartNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PartNameLabel.Name = "PartNameLabel"
        PartNameLabel.Size = New System.Drawing.Size(83, 18)
        PartNameLabel.TabIndex = 8
        PartNameLabel.Text = "Part Name:"
        '
        'QtyLabel
        '
        QtyLabel.AutoSize = True
        QtyLabel.Location = New System.Drawing.Point(372, 17)
        QtyLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        QtyLabel.Name = "QtyLabel"
        QtyLabel.Size = New System.Drawing.Size(66, 18)
        QtyLabel.TabIndex = 10
        QtyLabel.Text = "Quantity:"
        '
        'CostLabel
        '
        CostLabel.AutoSize = True
        CostLabel.Location = New System.Drawing.Point(363, 52)
        CostLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CostLabel.Name = "CostLabel"
        CostLabel.Size = New System.Drawing.Size(75, 18)
        CostLabel.TabIndex = 12
        CostLabel.Text = "Part Cost:"
        '
        'TotalAmtLabel
        '
        TotalAmtLabel.AutoSize = True
        TotalAmtLabel.Location = New System.Drawing.Point(338, 88)
        TotalAmtLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TotalAmtLabel.Name = "TotalAmtLabel"
        TotalAmtLabel.Size = New System.Drawing.Size(100, 18)
        TotalAmtLabel.TabIndex = 14
        TotalAmtLabel.Text = "Total Amount:"
        '
        'DisLabel
        '
        DisLabel.AutoSize = True
        DisLabel.Location = New System.Drawing.Point(367, 124)
        DisLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DisLabel.Name = "DisLabel"
        DisLabel.Size = New System.Drawing.Size(71, 18)
        DisLabel.TabIndex = 16
        DisLabel.Text = "Discount:"
        '
        'NetAmtLabel
        '
        NetAmtLabel.AutoSize = True
        NetAmtLabel.Location = New System.Drawing.Point(348, 160)
        NetAmtLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NetAmtLabel.Name = "NetAmtLabel"
        NetAmtLabel.Size = New System.Drawing.Size(90, 18)
        NetAmtLabel.TabIndex = 18
        NetAmtLabel.Text = "Net Amount:"
        '
        'ModeofPaymentLabel
        '
        ModeofPaymentLabel.AutoSize = True
        ModeofPaymentLabel.Location = New System.Drawing.Point(12, 190)
        ModeofPaymentLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ModeofPaymentLabel.Name = "ModeofPaymentLabel"
        ModeofPaymentLabel.Size = New System.Drawing.Size(125, 18)
        ModeofPaymentLabel.TabIndex = 20
        ModeofPaymentLabel.Text = "Modeof Payment:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 62)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Sale Bill Creation"
        '
        'StockDataSet
        '
        Me.StockDataSet.DataSetName = "StockDataSet"
        Me.StockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BillBindingSource
        '
        Me.BillBindingSource.DataMember = "Bill"
        Me.BillBindingSource.DataSource = Me.StockDataSet
        '
        'BillTableAdapter
        '
        Me.BillTableAdapter.ClearBeforeFill = True
        '
        'BillBindingNavigator
        '
        Me.BillBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BillBindingNavigator.BindingSource = Me.BillBindingSource
        Me.BillBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BillBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BillBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BillBindingNavigatorSaveItem, Me.ToolStripButton1})
        Me.BillBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BillBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BillBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BillBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BillBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BillBindingNavigator.Name = "BillBindingNavigator"
        Me.BillBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.BillBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BillBindingNavigator.Size = New System.Drawing.Size(690, 25)
        Me.BillBindingNavigator.TabIndex = 5
        Me.BillBindingNavigator.Text = "BindingNavigator1"
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
        'BillBindingNavigatorSaveItem
        '
        Me.BillBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BillBindingNavigatorSaveItem.Image = CType(resources.GetObject("BillBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BillBindingNavigatorSaveItem.Name = "BillBindingNavigatorSaveItem"
        Me.BillBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.BillBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'BillNoTextBox
        '
        Me.BillNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BillNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillBindingSource, "BillNo", True))
        Me.BillNoTextBox.Location = New System.Drawing.Point(145, 14)
        Me.BillNoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.BillNoTextBox.Name = "BillNoTextBox"
        Me.BillNoTextBox.Size = New System.Drawing.Size(103, 24)
        Me.BillNoTextBox.TabIndex = 6
        '
        'BillDateDateTimePicker
        '
        Me.BillDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BillBindingSource, "BillDate", True))
        Me.BillDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.BillDateDateTimePicker.Location = New System.Drawing.Point(145, 46)
        Me.BillDateDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.BillDateDateTimePicker.Name = "BillDateDateTimePicker"
        Me.BillDateDateTimePicker.Size = New System.Drawing.Size(121, 24)
        Me.BillDateDateTimePicker.TabIndex = 7
        '
        'SubCompNameComboBox
        '
        Me.SubCompNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillBindingSource, "SubCompName", True))
        Me.SubCompNameComboBox.DataSource = Me.SubCompanyBindingSource
        Me.SubCompNameComboBox.DisplayMember = "Sname"
        Me.SubCompNameComboBox.FormattingEnabled = True
        Me.SubCompNameComboBox.Location = New System.Drawing.Point(145, 78)
        Me.SubCompNameComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SubCompNameComboBox.Name = "SubCompNameComboBox"
        Me.SubCompNameComboBox.Size = New System.Drawing.Size(164, 26)
        Me.SubCompNameComboBox.TabIndex = 8
        '
        'PartNameComboBox
        '
        Me.PartNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillBindingSource, "PartName", True))
        Me.PartNameComboBox.DataSource = Me.PartCodeBindingSource1
        Me.PartNameComboBox.DisplayMember = "PartName"
        Me.PartNameComboBox.FormattingEnabled = True
        Me.PartNameComboBox.Location = New System.Drawing.Point(145, 152)
        Me.PartNameComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PartNameComboBox.Name = "PartNameComboBox"
        Me.PartNameComboBox.Size = New System.Drawing.Size(164, 26)
        Me.PartNameComboBox.TabIndex = 9
        '
        'QtyTextBox
        '
        Me.QtyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.QtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillBindingSource, "Qty", True))
        Me.QtyTextBox.Location = New System.Drawing.Point(446, 15)
        Me.QtyTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.QtyTextBox.Name = "QtyTextBox"
        Me.QtyTextBox.Size = New System.Drawing.Size(92, 24)
        Me.QtyTextBox.TabIndex = 11
        Me.QtyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CostTextBox
        '
        Me.CostTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillBindingSource, "Cost", True))
        Me.CostTextBox.Location = New System.Drawing.Point(446, 51)
        Me.CostTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CostTextBox.Name = "CostTextBox"
        Me.CostTextBox.Size = New System.Drawing.Size(92, 24)
        Me.CostTextBox.TabIndex = 13
        Me.CostTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TotalAmtTextBox
        '
        Me.TotalAmtTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalAmtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillBindingSource, "TotalAmt", True))
        Me.TotalAmtTextBox.Location = New System.Drawing.Point(446, 87)
        Me.TotalAmtTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TotalAmtTextBox.Name = "TotalAmtTextBox"
        Me.TotalAmtTextBox.Size = New System.Drawing.Size(92, 24)
        Me.TotalAmtTextBox.TabIndex = 15
        Me.TotalAmtTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DisTextBox
        '
        Me.DisTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillBindingSource, "Dis", True))
        Me.DisTextBox.Location = New System.Drawing.Point(446, 123)
        Me.DisTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DisTextBox.Name = "DisTextBox"
        Me.DisTextBox.Size = New System.Drawing.Size(92, 24)
        Me.DisTextBox.TabIndex = 17
        Me.DisTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NetAmtTextBox
        '
        Me.NetAmtTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NetAmtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillBindingSource, "NetAmt", True))
        Me.NetAmtTextBox.Location = New System.Drawing.Point(446, 159)
        Me.NetAmtTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NetAmtTextBox.Name = "NetAmtTextBox"
        Me.NetAmtTextBox.Size = New System.Drawing.Size(92, 24)
        Me.NetAmtTextBox.TabIndex = 19
        Me.NetAmtTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ModeofPaymentComboBox
        '
        Me.ModeofPaymentComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillBindingSource, "ModeofPayment", True))
        Me.ModeofPaymentComboBox.FormattingEnabled = True
        Me.ModeofPaymentComboBox.Items.AddRange(New Object() {"Cash", "Cheque"})
        Me.ModeofPaymentComboBox.Location = New System.Drawing.Point(145, 186)
        Me.ModeofPaymentComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ModeofPaymentComboBox.Name = "ModeofPaymentComboBox"
        Me.ModeofPaymentComboBox.Size = New System.Drawing.Size(164, 26)
        Me.ModeofPaymentComboBox.TabIndex = 21
        '
        'BillDataGridView
        '
        Me.BillDataGridView.AutoGenerateColumns = False
        Me.BillDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.BillDataGridView.DataSource = Me.BillBindingSource
        Me.BillDataGridView.Location = New System.Drawing.Point(15, 243)
        Me.BillDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.BillDataGridView.Name = "BillDataGridView"
        Me.BillDataGridView.Size = New System.Drawing.Size(531, 155)
        Me.BillDataGridView.TabIndex = 22
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "BillNo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "BillNo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "BillDate"
        Me.DataGridViewTextBoxColumn2.HeaderText = "BillDate"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "SubCompName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "SubCompName"
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
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PartName"
        Me.DataGridViewTextBoxColumn5.HeaderText = "PartName"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Qty"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Qty"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Cost"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Cost"
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
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Dis"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Dis"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "NetAmt"
        Me.DataGridViewTextBoxColumn10.HeaderText = "NetAmt"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ModeofPayment"
        Me.DataGridViewTextBoxColumn11.HeaderText = "ModeofPayment"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Bankname"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Bankname"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Cqno"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Cqno"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "cqdate"
        Me.DataGridViewTextBoxColumn14.HeaderText = "cqdate"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(PartCodeLabel)
        Me.Panel1.Controls.Add(Me.PartCodeComboBox)
        Me.Panel1.Controls.Add(Me.BillDataGridView)
        Me.Panel1.Controls.Add(ModeofPaymentLabel)
        Me.Panel1.Controls.Add(Me.ModeofPaymentComboBox)
        Me.Panel1.Controls.Add(NetAmtLabel)
        Me.Panel1.Controls.Add(Me.NetAmtTextBox)
        Me.Panel1.Controls.Add(DisLabel)
        Me.Panel1.Controls.Add(Me.DisTextBox)
        Me.Panel1.Controls.Add(TotalAmtLabel)
        Me.Panel1.Controls.Add(Me.TotalAmtTextBox)
        Me.Panel1.Controls.Add(CostLabel)
        Me.Panel1.Controls.Add(Me.CostTextBox)
        Me.Panel1.Controls.Add(QtyLabel)
        Me.Panel1.Controls.Add(Me.QtyTextBox)
        Me.Panel1.Controls.Add(PartNameLabel)
        Me.Panel1.Controls.Add(Me.PartNameComboBox)
        Me.Panel1.Controls.Add(SubCompNameLabel)
        Me.Panel1.Controls.Add(Me.SubCompNameComboBox)
        Me.Panel1.Controls.Add(BillDateLabel)
        Me.Panel1.Controls.Add(Me.BillDateDateTimePicker)
        Me.Panel1.Controls.Add(BillNoLabel)
        Me.Panel1.Controls.Add(Me.BillNoTextBox)
        Me.Panel1.Location = New System.Drawing.Point(19, 99)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(595, 420)
        Me.Panel1.TabIndex = 23
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(505, 525)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 47)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "&Exit"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(371, 525)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 47)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "&Show Report"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.PrjDataSec.My.Resources.Resources.POINT04
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(211, 525)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(149, 47)
        Me.Button3.TabIndex = 31
        Me.Button3.Text = "Update Record"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.PrjDataSec.My.Resources.Resources.POINT04
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(56, 525)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(149, 47)
        Me.Button4.TabIndex = 32
        Me.Button4.Text = "Delete Record"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'PartCodeLabel
        '
        PartCodeLabel.AutoSize = True
        PartCodeLabel.Location = New System.Drawing.Point(60, 122)
        PartCodeLabel.Name = "PartCodeLabel"
        PartCodeLabel.Size = New System.Drawing.Size(79, 18)
        PartCodeLabel.TabIndex = 22
        PartCodeLabel.Text = "Part Code:"
        '
        'PartCodeComboBox
        '
        Me.PartCodeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillBindingSource, "PartCode", True))
        Me.PartCodeComboBox.DataSource = Me.PartCodeBindingSource
        Me.PartCodeComboBox.DisplayMember = "PartCode"
        Me.PartCodeComboBox.FormattingEnabled = True
        Me.PartCodeComboBox.Location = New System.Drawing.Point(145, 119)
        Me.PartCodeComboBox.Name = "PartCodeComboBox"
        Me.PartCodeComboBox.Size = New System.Drawing.Size(121, 26)
        Me.PartCodeComboBox.TabIndex = 23
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
        'PartCodeBindingSource1
        '
        Me.PartCodeBindingSource1.DataMember = "PartCode"
        Me.PartCodeBindingSource1.DataSource = Me.StockDataSet
        '
        'SubCompanyBindingSource
        '
        Me.SubCompanyBindingSource.DataMember = "SubCompany"
        Me.SubCompanyBindingSource.DataSource = Me.StockDataSet
        '
        'SubCompanyTableAdapter
        '
        Me.SubCompanyTableAdapter.ClearBeforeFill = True
        '
        'frmSaleBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(690, 581)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.BillBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmSaleBill"
        Me.Text = "Bill Information"
        CType(Me.StockDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BillBindingNavigator.ResumeLayout(False)
        Me.BillBindingNavigator.PerformLayout()
        CType(Me.BillDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PartCodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartCodeBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubCompanyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StockDataSet As PrjDataSec.StockDataSet
    Friend WithEvents BillBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BillTableAdapter As PrjDataSec.StockDataSetTableAdapters.BillTableAdapter
    Friend WithEvents BillBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents BillBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BillNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BillDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents SubCompNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PartNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents QtyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalAmtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DisTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NetAmtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ModeofPaymentComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BillDataGridView As System.Windows.Forms.DataGridView
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
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents PartCodeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PartCodeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PartCodeTableAdapter As PrjDataSec.StockDataSetTableAdapters.PartCodeTableAdapter
    Friend WithEvents PartCodeBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents SubCompanyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubCompanyTableAdapter As PrjDataSec.StockDataSetTableAdapters.SubCompanyTableAdapter
End Class
