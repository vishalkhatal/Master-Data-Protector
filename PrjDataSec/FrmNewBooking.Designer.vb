<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewBooking
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
        Dim SubNameLabel As System.Windows.Forms.Label
        Dim PNameLabel As System.Windows.Forms.Label
        Dim LimitLabel As System.Windows.Forms.Label
        Dim BkdateLabel As System.Windows.Forms.Label
        Dim DelDateLabel As System.Windows.Forms.Label
        Dim BQtyLabel As System.Windows.Forms.Label
        Dim PerQtyCostLabel As System.Windows.Forms.Label
        Dim TotalCostLabel As System.Windows.Forms.Label
        Dim RemarkLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNewBooking))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BookingDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BookingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.New_StockDataSet = New PrjDataSec.New_StockDataSet
        Me.RemarkTextBox = New System.Windows.Forms.TextBox
        Me.TotalCostTextBox = New System.Windows.Forms.TextBox
        Me.PerQtyCostTextBox = New System.Windows.Forms.TextBox
        Me.BQtyTextBox = New System.Windows.Forms.TextBox
        Me.DelDateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.BkdateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.LimitTextBox = New System.Windows.Forms.TextBox
        Me.PNameComboBox = New System.Windows.Forms.ComboBox
        Me.PartCodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubNameComboBox = New System.Windows.Forms.ComboBox
        Me.SubCompanyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockDataSet = New PrjDataSec.StockDataSet
        Me.BookingTableAdapter = New PrjDataSec.New_StockDataSetTableAdapters.BookingTableAdapter
        Me.BookingBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.BookingBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.SubCompanyTableAdapter = New PrjDataSec.StockDataSetTableAdapters.SubCompanyTableAdapter
        Me.PartCodeTableAdapter = New PrjDataSec.New_StockDataSetTableAdapters.PartCodeTableAdapter
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        SubNameLabel = New System.Windows.Forms.Label
        PNameLabel = New System.Windows.Forms.Label
        LimitLabel = New System.Windows.Forms.Label
        BkdateLabel = New System.Windows.Forms.Label
        DelDateLabel = New System.Windows.Forms.Label
        BQtyLabel = New System.Windows.Forms.Label
        PerQtyCostLabel = New System.Windows.Forms.Label
        TotalCostLabel = New System.Windows.Forms.Label
        RemarkLabel = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        CType(Me.BookingDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.New_StockDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartCodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubCompanyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BookingBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'SubNameLabel
        '
        SubNameLabel.AutoSize = True
        SubNameLabel.Location = New System.Drawing.Point(33, 32)
        SubNameLabel.Name = "SubNameLabel"
        SubNameLabel.Size = New System.Drawing.Size(73, 17)
        SubNameLabel.TabIndex = 0
        SubNameLabel.Text = "Sub Name:"
        '
        'PNameLabel
        '
        PNameLabel.AutoSize = True
        PNameLabel.Location = New System.Drawing.Point(50, 63)
        PNameLabel.Name = "PNameLabel"
        PNameLabel.Size = New System.Drawing.Size(56, 17)
        PNameLabel.TabIndex = 2
        PNameLabel.Text = "PName:"
        '
        'LimitLabel
        '
        LimitLabel.AutoSize = True
        LimitLabel.Location = New System.Drawing.Point(65, 94)
        LimitLabel.Name = "LimitLabel"
        LimitLabel.Size = New System.Drawing.Size(41, 17)
        LimitLabel.TabIndex = 4
        LimitLabel.Text = "Limit:"
        '
        'BkdateLabel
        '
        BkdateLabel.AutoSize = True
        BkdateLabel.Location = New System.Drawing.Point(53, 126)
        BkdateLabel.Name = "BkdateLabel"
        BkdateLabel.Size = New System.Drawing.Size(53, 17)
        BkdateLabel.TabIndex = 6
        BkdateLabel.Text = "Bkdate:"
        '
        'DelDateLabel
        '
        DelDateLabel.AutoSize = True
        DelDateLabel.Location = New System.Drawing.Point(41, 157)
        DelDateLabel.Name = "DelDateLabel"
        DelDateLabel.Size = New System.Drawing.Size(65, 17)
        DelDateLabel.TabIndex = 8
        DelDateLabel.Text = "Del Date:"
        '
        'BQtyLabel
        '
        BQtyLabel.AutoSize = True
        BQtyLabel.Location = New System.Drawing.Point(353, 35)
        BQtyLabel.Name = "BQtyLabel"
        BQtyLabel.Size = New System.Drawing.Size(43, 17)
        BQtyLabel.TabIndex = 10
        BQtyLabel.Text = "BQty:"
        '
        'PerQtyCostLabel
        '
        PerQtyCostLabel.AutoSize = True
        PerQtyCostLabel.Location = New System.Drawing.Point(307, 66)
        PerQtyCostLabel.Name = "PerQtyCostLabel"
        PerQtyCostLabel.Size = New System.Drawing.Size(89, 17)
        PerQtyCostLabel.TabIndex = 12
        PerQtyCostLabel.Text = "Per Qty Cost:"
        '
        'TotalCostLabel
        '
        TotalCostLabel.AutoSize = True
        TotalCostLabel.Location = New System.Drawing.Point(324, 97)
        TotalCostLabel.Name = "TotalCostLabel"
        TotalCostLabel.Size = New System.Drawing.Size(72, 17)
        TotalCostLabel.TabIndex = 14
        TotalCostLabel.Text = "Total Cost:"
        '
        'RemarkLabel
        '
        RemarkLabel.AutoSize = True
        RemarkLabel.Location = New System.Drawing.Point(338, 129)
        RemarkLabel.Name = "RemarkLabel"
        RemarkLabel.Size = New System.Drawing.Size(58, 17)
        RemarkLabel.TabIndex = 16
        RemarkLabel.Text = "Remark:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BookingDataGridView)
        Me.Panel1.Controls.Add(RemarkLabel)
        Me.Panel1.Controls.Add(Me.RemarkTextBox)
        Me.Panel1.Controls.Add(TotalCostLabel)
        Me.Panel1.Controls.Add(Me.TotalCostTextBox)
        Me.Panel1.Controls.Add(PerQtyCostLabel)
        Me.Panel1.Controls.Add(Me.PerQtyCostTextBox)
        Me.Panel1.Controls.Add(BQtyLabel)
        Me.Panel1.Controls.Add(Me.BQtyTextBox)
        Me.Panel1.Controls.Add(DelDateLabel)
        Me.Panel1.Controls.Add(Me.DelDateDateTimePicker)
        Me.Panel1.Controls.Add(BkdateLabel)
        Me.Panel1.Controls.Add(Me.BkdateDateTimePicker)
        Me.Panel1.Controls.Add(LimitLabel)
        Me.Panel1.Controls.Add(Me.LimitTextBox)
        Me.Panel1.Controls.Add(PNameLabel)
        Me.Panel1.Controls.Add(Me.PNameComboBox)
        Me.Panel1.Controls.Add(SubNameLabel)
        Me.Panel1.Controls.Add(Me.SubNameComboBox)
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(65, 107)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(637, 402)
        Me.Panel1.TabIndex = 0
        '
        'BookingDataGridView
        '
        Me.BookingDataGridView.AutoGenerateColumns = False
        Me.BookingDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.BookingDataGridView.DataSource = Me.BookingBindingSource
        Me.BookingDataGridView.Location = New System.Drawing.Point(68, 199)
        Me.BookingDataGridView.Name = "BookingDataGridView"
        Me.BookingDataGridView.Size = New System.Drawing.Size(496, 173)
        Me.BookingDataGridView.TabIndex = 18
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "SubName"
        Me.DataGridViewTextBoxColumn1.HeaderText = "SubName"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "PName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Limit"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Limit"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Bkdate"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Bkdate"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "BQty"
        Me.DataGridViewTextBoxColumn5.HeaderText = "BQty"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DelDate"
        Me.DataGridViewTextBoxColumn6.HeaderText = "DelDate"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PerQtyCost"
        Me.DataGridViewTextBoxColumn7.HeaderText = "PerQtyCost"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "TotalCost"
        Me.DataGridViewTextBoxColumn8.HeaderText = "TotalCost"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Remark"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Remark"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'BookingBindingSource
        '
        Me.BookingBindingSource.DataMember = "Booking"
        Me.BookingBindingSource.DataSource = Me.New_StockDataSet
        '
        'New_StockDataSet
        '
        Me.New_StockDataSet.DataSetName = "New_StockDataSet"
        Me.New_StockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RemarkTextBox
        '
        Me.RemarkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "Remark", True))
        Me.RemarkTextBox.Location = New System.Drawing.Point(402, 126)
        Me.RemarkTextBox.Name = "RemarkTextBox"
        Me.RemarkTextBox.Size = New System.Drawing.Size(162, 25)
        Me.RemarkTextBox.TabIndex = 17
        '
        'TotalCostTextBox
        '
        Me.TotalCostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "TotalCost", True))
        Me.TotalCostTextBox.Location = New System.Drawing.Point(402, 94)
        Me.TotalCostTextBox.Name = "TotalCostTextBox"
        Me.TotalCostTextBox.Size = New System.Drawing.Size(100, 25)
        Me.TotalCostTextBox.TabIndex = 15
        '
        'PerQtyCostTextBox
        '
        Me.PerQtyCostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "PerQtyCost", True))
        Me.PerQtyCostTextBox.Location = New System.Drawing.Point(402, 63)
        Me.PerQtyCostTextBox.Name = "PerQtyCostTextBox"
        Me.PerQtyCostTextBox.Size = New System.Drawing.Size(100, 25)
        Me.PerQtyCostTextBox.TabIndex = 13
        '
        'BQtyTextBox
        '
        Me.BQtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "BQty", True))
        Me.BQtyTextBox.Location = New System.Drawing.Point(402, 32)
        Me.BQtyTextBox.Name = "BQtyTextBox"
        Me.BQtyTextBox.Size = New System.Drawing.Size(100, 25)
        Me.BQtyTextBox.TabIndex = 11
        '
        'DelDateDateTimePicker
        '
        Me.DelDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BookingBindingSource, "DelDate", True))
        Me.DelDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DelDateDateTimePicker.Location = New System.Drawing.Point(112, 153)
        Me.DelDateDateTimePicker.Name = "DelDateDateTimePicker"
        Me.DelDateDateTimePicker.Size = New System.Drawing.Size(121, 25)
        Me.DelDateDateTimePicker.TabIndex = 9
        '
        'BkdateDateTimePicker
        '
        Me.BkdateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BookingBindingSource, "Bkdate", True))
        Me.BkdateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.BkdateDateTimePicker.Location = New System.Drawing.Point(112, 122)
        Me.BkdateDateTimePicker.Name = "BkdateDateTimePicker"
        Me.BkdateDateTimePicker.Size = New System.Drawing.Size(121, 25)
        Me.BkdateDateTimePicker.TabIndex = 7
        '
        'LimitTextBox
        '
        Me.LimitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "Limit", True))
        Me.LimitTextBox.Location = New System.Drawing.Point(112, 91)
        Me.LimitTextBox.Name = "LimitTextBox"
        Me.LimitTextBox.Size = New System.Drawing.Size(121, 25)
        Me.LimitTextBox.TabIndex = 5
        '
        'PNameComboBox
        '
        Me.PNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "PName", True))
        Me.PNameComboBox.DataSource = Me.PartCodeBindingSource
        Me.PNameComboBox.DisplayMember = "PartName"
        Me.PNameComboBox.FormattingEnabled = True
        Me.PNameComboBox.Location = New System.Drawing.Point(112, 60)
        Me.PNameComboBox.Name = "PNameComboBox"
        Me.PNameComboBox.Size = New System.Drawing.Size(121, 25)
        Me.PNameComboBox.TabIndex = 3
        '
        'PartCodeBindingSource
        '
        Me.PartCodeBindingSource.DataMember = "PartCode"
        Me.PartCodeBindingSource.DataSource = Me.New_StockDataSet
        '
        'SubNameComboBox
        '
        Me.SubNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "SubName", True))
        Me.SubNameComboBox.DataSource = Me.SubCompanyBindingSource
        Me.SubNameComboBox.DisplayMember = "Sname"
        Me.SubNameComboBox.FormattingEnabled = True
        Me.SubNameComboBox.Location = New System.Drawing.Point(112, 29)
        Me.SubNameComboBox.Name = "SubNameComboBox"
        Me.SubNameComboBox.Size = New System.Drawing.Size(121, 25)
        Me.SubNameComboBox.TabIndex = 1
        '
        'SubCompanyBindingSource
        '
        Me.SubCompanyBindingSource.DataMember = "SubCompany"
        Me.SubCompanyBindingSource.DataSource = Me.StockDataSet
        '
        'StockDataSet
        '
        Me.StockDataSet.DataSetName = "StockDataSet"
        Me.StockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookingTableAdapter
        '
        Me.BookingTableAdapter.ClearBeforeFill = True
        '
        'BookingBindingNavigator
        '
        Me.BookingBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BookingBindingNavigator.BindingSource = Me.BookingBindingSource
        Me.BookingBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BookingBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BookingBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BookingBindingNavigatorSaveItem})
        Me.BookingBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BookingBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BookingBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BookingBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BookingBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BookingBindingNavigator.Name = "BookingBindingNavigator"
        Me.BookingBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BookingBindingNavigator.Size = New System.Drawing.Size(879, 25)
        Me.BookingBindingNavigator.TabIndex = 1
        Me.BookingBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
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
        'BookingBindingNavigatorSaveItem
        '
        Me.BookingBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BookingBindingNavigatorSaveItem.Image = CType(resources.GetObject("BookingBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BookingBindingNavigatorSaveItem.Name = "BookingBindingNavigatorSaveItem"
        Me.BookingBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.BookingBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Part Booking Status..."
        '
        'SubCompanyTableAdapter
        '
        Me.SubCompanyTableAdapter.ClearBeforeFill = True
        '
        'PartCodeTableAdapter
        '
        Me.PartCodeTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(561, 515)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 43)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "&Exit"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(402, 515)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 43)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "&Show Report"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.PrjDataSec.My.Resources.Resources.POINT04
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(83, 512)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(149, 46)
        Me.Button4.TabIndex = 36
        Me.Button4.Text = "Delete Record"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.PrjDataSec.My.Resources.Resources.POINT04
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(238, 512)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(149, 46)
        Me.Button3.TabIndex = 35
        Me.Button3.Text = "Update Record"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'FrmNewBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(879, 581)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BookingBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmNewBooking"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BookingDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.New_StockDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartCodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubCompanyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BookingBindingNavigator.ResumeLayout(False)
        Me.BookingBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents New_StockDataSet As PrjDataSec.New_StockDataSet
    Friend WithEvents BookingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BookingTableAdapter As PrjDataSec.New_StockDataSetTableAdapters.BookingTableAdapter
    Friend WithEvents BookingBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents BookingBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SubNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BkdateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents LimitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BookingDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RemarkTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalCostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PerQtyCostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BQtyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DelDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StockDataSet As PrjDataSec.StockDataSet
    Friend WithEvents SubCompanyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubCompanyTableAdapter As PrjDataSec.StockDataSetTableAdapters.SubCompanyTableAdapter
    Friend WithEvents PartCodeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PartCodeTableAdapter As PrjDataSec.New_StockDataSetTableAdapters.PartCodeTableAdapter
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
