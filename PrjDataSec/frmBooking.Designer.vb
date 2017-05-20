<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBooking
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
        Dim BQtyLabel As System.Windows.Forms.Label
        Dim DelDateLabel As System.Windows.Forms.Label
        Dim PerQtyCostLabel As System.Windows.Forms.Label
        Dim TotalCostLabel As System.Windows.Forms.Label
        Dim RemarkLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBooking))
        Me.Label1 = New System.Windows.Forms.Label
        Me.StockDataSet = New PrjDataSec.StockDataSet
        Me.BookingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookingTableAdapter = New PrjDataSec.StockDataSetTableAdapters.BookingTableAdapter
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
        Me.SubNameComboBox = New System.Windows.Forms.ComboBox
        Me.PNameComboBox = New System.Windows.Forms.ComboBox
        Me.BookingBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LimitTextBox = New System.Windows.Forms.TextBox
        Me.BkdateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.BQtyTextBox = New System.Windows.Forms.TextBox
        Me.DelDateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.PerQtyCostTextBox = New System.Windows.Forms.TextBox
        Me.TotalCostTextBox = New System.Windows.Forms.TextBox
        Me.RemarkTextBox = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.StockDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PartCodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PartCodeTableAdapter = New PrjDataSec.StockDataSetTableAdapters.PartCodeTableAdapter
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        SubNameLabel = New System.Windows.Forms.Label
        PNameLabel = New System.Windows.Forms.Label
        LimitLabel = New System.Windows.Forms.Label
        BkdateLabel = New System.Windows.Forms.Label
        BQtyLabel = New System.Windows.Forms.Label
        DelDateLabel = New System.Windows.Forms.Label
        PerQtyCostLabel = New System.Windows.Forms.Label
        TotalCostLabel = New System.Windows.Forms.Label
        RemarkLabel = New System.Windows.Forms.Label
        CType(Me.StockDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BookingBindingNavigator.SuspendLayout()
        CType(Me.BookingBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.StockDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartCodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SubNameLabel
        '
        SubNameLabel.AutoSize = True
        SubNameLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        SubNameLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SubNameLabel.Location = New System.Drawing.Point(93, 150)
        SubNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SubNameLabel.Name = "SubNameLabel"
        SubNameLabel.Size = New System.Drawing.Size(85, 19)
        SubNameLabel.TabIndex = 4
        SubNameLabel.Text = "Party Name:"
        '
        'PNameLabel
        '
        PNameLabel.AutoSize = True
        PNameLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        PNameLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PNameLabel.Location = New System.Drawing.Point(100, 186)
        PNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PNameLabel.Name = "PNameLabel"
        PNameLabel.Size = New System.Drawing.Size(78, 19)
        PNameLabel.TabIndex = 5
        PNameLabel.Text = "Part Name:"
        '
        'LimitLabel
        '
        LimitLabel.AutoSize = True
        LimitLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        LimitLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LimitLabel.Location = New System.Drawing.Point(136, 220)
        LimitLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        LimitLabel.Name = "LimitLabel"
        LimitLabel.Size = New System.Drawing.Size(42, 19)
        LimitLabel.TabIndex = 6
        LimitLabel.Text = "Limit:"
        '
        'BkdateLabel
        '
        BkdateLabel.AutoSize = True
        BkdateLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        BkdateLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BkdateLabel.Location = New System.Drawing.Point(325, 48)
        BkdateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BkdateLabel.Name = "BkdateLabel"
        BkdateLabel.Size = New System.Drawing.Size(96, 19)
        BkdateLabel.TabIndex = 8
        BkdateLabel.Text = "Booking Date:"
        '
        'BQtyLabel
        '
        BQtyLabel.AutoSize = True
        BQtyLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        BQtyLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BQtyLabel.Location = New System.Drawing.Point(60, 267)
        BQtyLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BQtyLabel.Name = "BQtyLabel"
        BQtyLabel.Size = New System.Drawing.Size(118, 19)
        BQtyLabel.TabIndex = 10
        BQtyLabel.Text = "Booking Quantity:"
        '
        'DelDateLabel
        '
        DelDateLabel.AutoSize = True
        DelDateLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DelDateLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DelDateLabel.Location = New System.Drawing.Point(326, 81)
        DelDateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DelDateLabel.Name = "DelDateLabel"
        DelDateLabel.Size = New System.Drawing.Size(95, 19)
        DelDateLabel.TabIndex = 12
        DelDateLabel.Text = "Delivery Date:"
        '
        'PerQtyCostLabel
        '
        PerQtyCostLabel.AutoSize = True
        PerQtyCostLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        PerQtyCostLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PerQtyCostLabel.Location = New System.Drawing.Point(57, 297)
        PerQtyCostLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PerQtyCostLabel.Name = "PerQtyCostLabel"
        PerQtyCostLabel.Size = New System.Drawing.Size(121, 19)
        PerQtyCostLabel.TabIndex = 14
        PerQtyCostLabel.Text = "Per Quantity Cost:"
        '
        'TotalCostLabel
        '
        TotalCostLabel.AutoSize = True
        TotalCostLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        TotalCostLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TotalCostLabel.Location = New System.Drawing.Point(345, 121)
        TotalCostLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TotalCostLabel.Name = "TotalCostLabel"
        TotalCostLabel.Size = New System.Drawing.Size(76, 19)
        TotalCostLabel.TabIndex = 16
        TotalCostLabel.Text = "Total Cost:"
        '
        'RemarkLabel
        '
        RemarkLabel.AutoSize = True
        RemarkLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        RemarkLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RemarkLabel.Location = New System.Drawing.Point(361, 154)
        RemarkLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        RemarkLabel.Name = "RemarkLabel"
        RemarkLabel.Size = New System.Drawing.Size(60, 19)
        RemarkLabel.TabIndex = 18
        RemarkLabel.Text = "Remark:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Part Booking Status..."
        '
        'StockDataSet
        '
        Me.StockDataSet.DataSetName = "StockDataSet"
        Me.StockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookingBindingSource
        '
        Me.BookingBindingSource.DataMember = "Booking"
        Me.BookingBindingSource.DataSource = Me.StockDataSet
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
        Me.BookingBindingNavigator.Size = New System.Drawing.Size(745, 25)
        Me.BookingBindingNavigator.TabIndex = 4
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
        'SubNameComboBox
        '
        Me.SubNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "SubName", True))
        Me.SubNameComboBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubNameComboBox.FormattingEnabled = True
        Me.SubNameComboBox.Location = New System.Drawing.Point(198, 147)
        Me.SubNameComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SubNameComboBox.Name = "SubNameComboBox"
        Me.SubNameComboBox.Size = New System.Drawing.Size(129, 27)
        Me.SubNameComboBox.TabIndex = 5
        '
        'PNameComboBox
        '
        Me.PNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "PName", True))
        Me.PNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.BookingBindingSource1, "PName", True))
        Me.PNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BookingBindingSource1, "PName", True))
        Me.PNameComboBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PNameComboBox.FormattingEnabled = True
        Me.PNameComboBox.Location = New System.Drawing.Point(198, 186)
        Me.PNameComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PNameComboBox.Name = "PNameComboBox"
        Me.PNameComboBox.Size = New System.Drawing.Size(129, 27)
        Me.PNameComboBox.TabIndex = 6
        '
        'BookingBindingSource1
        '
        Me.BookingBindingSource1.DataMember = "Booking"
        Me.BookingBindingSource1.DataSource = Me.StockDataSet
        '
        'LimitTextBox
        '
        Me.LimitTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LimitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "Limit", True))
        Me.LimitTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LimitTextBox.Location = New System.Drawing.Point(198, 220)
        Me.LimitTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.LimitTextBox.Name = "LimitTextBox"
        Me.LimitTextBox.Size = New System.Drawing.Size(129, 26)
        Me.LimitTextBox.TabIndex = 7
        '
        'BkdateDateTimePicker
        '
        Me.BkdateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BookingBindingSource, "Bkdate", True))
        Me.BkdateDateTimePicker.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BkdateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.BkdateDateTimePicker.Location = New System.Drawing.Point(448, 144)
        Me.BkdateDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.BkdateDateTimePicker.Name = "BkdateDateTimePicker"
        Me.BkdateDateTimePicker.Size = New System.Drawing.Size(134, 26)
        Me.BkdateDateTimePicker.TabIndex = 9
        '
        'BQtyTextBox
        '
        Me.BQtyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BQtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "BQty", True))
        Me.BQtyTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BQtyTextBox.Location = New System.Drawing.Point(193, 261)
        Me.BQtyTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.BQtyTextBox.Name = "BQtyTextBox"
        Me.BQtyTextBox.Size = New System.Drawing.Size(134, 26)
        Me.BQtyTextBox.TabIndex = 11
        '
        'DelDateDateTimePicker
        '
        Me.DelDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BookingBindingSource, "DelDate", True))
        Me.DelDateDateTimePicker.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DelDateDateTimePicker.Location = New System.Drawing.Point(448, 183)
        Me.DelDateDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.DelDateDateTimePicker.Name = "DelDateDateTimePicker"
        Me.DelDateDateTimePicker.Size = New System.Drawing.Size(134, 26)
        Me.DelDateDateTimePicker.TabIndex = 13
        '
        'PerQtyCostTextBox
        '
        Me.PerQtyCostTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PerQtyCostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "PerQtyCost", True))
        Me.PerQtyCostTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PerQtyCostTextBox.Location = New System.Drawing.Point(193, 294)
        Me.PerQtyCostTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PerQtyCostTextBox.Name = "PerQtyCostTextBox"
        Me.PerQtyCostTextBox.Size = New System.Drawing.Size(134, 26)
        Me.PerQtyCostTextBox.TabIndex = 15
        '
        'TotalCostTextBox
        '
        Me.TotalCostTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalCostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "TotalCost", True))
        Me.TotalCostTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalCostTextBox.Location = New System.Drawing.Point(445, 220)
        Me.TotalCostTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TotalCostTextBox.Name = "TotalCostTextBox"
        Me.TotalCostTextBox.Size = New System.Drawing.Size(137, 26)
        Me.TotalCostTextBox.TabIndex = 17
        '
        'RemarkTextBox
        '
        Me.RemarkTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RemarkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "Remark", True))
        Me.RemarkTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemarkTextBox.Location = New System.Drawing.Point(445, 252)
        Me.RemarkTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.RemarkTextBox.Name = "RemarkTextBox"
        Me.RemarkTextBox.Size = New System.Drawing.Size(137, 26)
        Me.RemarkTextBox.TabIndex = 19
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(BkdateLabel)
        Me.Panel1.Controls.Add(DelDateLabel)
        Me.Panel1.Controls.Add(RemarkLabel)
        Me.Panel1.Controls.Add(TotalCostLabel)
        Me.Panel1.Location = New System.Drawing.Point(18, 98)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(636, 343)
        Me.Panel1.TabIndex = 20
        '
        'StockDataSetBindingSource
        '
        Me.StockDataSetBindingSource.DataSource = Me.StockDataSet
        Me.StockDataSetBindingSource.Position = 0
        '
        'PartCodeBindingSource
        '
        Me.PartCodeBindingSource.DataMember = "PartCode"
        Me.PartCodeBindingSource.DataSource = Me.StockDataSetBindingSource
        '
        'PartCodeTableAdapter
        '
        Me.PartCodeTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(513, 447)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 43)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "&Exit"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(354, 447)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 43)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "&Show Report"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(389, 42)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(192, 24)
        Me.TextBox1.TabIndex = 23
        '
        'frmBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(745, 502)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RemarkTextBox)
        Me.Controls.Add(Me.TotalCostTextBox)
        Me.Controls.Add(PerQtyCostLabel)
        Me.Controls.Add(Me.PerQtyCostTextBox)
        Me.Controls.Add(Me.DelDateDateTimePicker)
        Me.Controls.Add(BQtyLabel)
        Me.Controls.Add(Me.BQtyTextBox)
        Me.Controls.Add(Me.BkdateDateTimePicker)
        Me.Controls.Add(LimitLabel)
        Me.Controls.Add(Me.LimitTextBox)
        Me.Controls.Add(PNameLabel)
        Me.Controls.Add(Me.PNameComboBox)
        Me.Controls.Add(SubNameLabel)
        Me.Controls.Add(Me.SubNameComboBox)
        Me.Controls.Add(Me.BookingBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmBooking"
        Me.Text = "Booking Status"
        CType(Me.StockDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BookingBindingNavigator.ResumeLayout(False)
        Me.BookingBindingNavigator.PerformLayout()
        CType(Me.BookingBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.StockDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartCodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StockDataSet As PrjDataSec.StockDataSet
    Friend WithEvents BookingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BookingTableAdapter As PrjDataSec.StockDataSetTableAdapters.BookingTableAdapter
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
    Friend WithEvents SubNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents LimitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BkdateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents BQtyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DelDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents PerQtyCostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalCostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RemarkTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BookingBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents StockDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PartCodeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PartCodeTableAdapter As PrjDataSec.StockDataSetTableAdapters.PartCodeTableAdapter
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
