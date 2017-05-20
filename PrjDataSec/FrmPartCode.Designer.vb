<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPartCode
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
        Dim PartCodeLabel As System.Windows.Forms.Label
        Dim PartNameLabel As System.Windows.Forms.Label
        Dim MCostLabel As System.Windows.Forms.Label
        Dim MYearLabel As System.Windows.Forms.Label
        Dim TQtyLabel As System.Windows.Forms.Label
        Dim WPeriodLabel As System.Windows.Forms.Label
        Dim ScostLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPartCode))
        Me.Label1 = New System.Windows.Forms.Label
        Me.StockDataSet = New PrjDataSec.StockDataSet
        Me.PartCodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PartCodeTableAdapter = New PrjDataSec.StockDataSetTableAdapters.PartCodeTableAdapter
        Me.PartCodeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PartCodeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.PartCodeTextBox = New System.Windows.Forms.TextBox
        Me.PartNameTextBox = New System.Windows.Forms.TextBox
        Me.MCostTextBox = New System.Windows.Forms.TextBox
        Me.MYearDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.TQtyTextBox = New System.Windows.Forms.TextBox
        Me.WPeriodTextBox = New System.Windows.Forms.TextBox
        Me.ScostTextBox = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        PartCodeLabel = New System.Windows.Forms.Label
        PartNameLabel = New System.Windows.Forms.Label
        MCostLabel = New System.Windows.Forms.Label
        MYearLabel = New System.Windows.Forms.Label
        TQtyLabel = New System.Windows.Forms.Label
        WPeriodLabel = New System.Windows.Forms.Label
        ScostLabel = New System.Windows.Forms.Label
        CType(Me.StockDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartCodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartCodeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PartCodeBindingNavigator.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PartCodeLabel
        '
        PartCodeLabel.AutoSize = True
        PartCodeLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PartCodeLabel.Location = New System.Drawing.Point(16, 14)
        PartCodeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PartCodeLabel.Name = "PartCodeLabel"
        PartCodeLabel.Size = New System.Drawing.Size(75, 19)
        PartCodeLabel.TabIndex = 3
        PartCodeLabel.Text = "Part Code:"
        '
        'PartNameLabel
        '
        PartNameLabel.AutoSize = True
        PartNameLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PartNameLabel.Location = New System.Drawing.Point(13, 55)
        PartNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PartNameLabel.Name = "PartNameLabel"
        PartNameLabel.Size = New System.Drawing.Size(78, 19)
        PartNameLabel.TabIndex = 4
        PartNameLabel.Text = "Part Name:"
        '
        'MCostLabel
        '
        MCostLabel.AutoSize = True
        MCostLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MCostLabel.Location = New System.Drawing.Point(16, 86)
        MCostLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        MCostLabel.Name = "MCostLabel"
        MCostLabel.Size = New System.Drawing.Size(70, 19)
        MCostLabel.TabIndex = 6
        MCostLabel.Text = "Mfg Cost:"
        '
        'MYearLabel
        '
        MYearLabel.AutoSize = True
        MYearLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MYearLabel.Location = New System.Drawing.Point(374, 11)
        MYearLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        MYearLabel.Name = "MYearLabel"
        MYearLabel.Size = New System.Drawing.Size(71, 19)
        MYearLabel.TabIndex = 8
        MYearLabel.Text = "Mfg Year:"
        '
        'TQtyLabel
        '
        TQtyLabel.AutoSize = True
        TQtyLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TQtyLabel.Location = New System.Drawing.Point(13, 158)
        TQtyLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TQtyLabel.Name = "TQtyLabel"
        TQtyLabel.Size = New System.Drawing.Size(70, 19)
        TQtyLabel.TabIndex = 10
        TQtyLabel.Text = "Total Qty:"
        '
        'WPeriodLabel
        '
        WPeriodLabel.AutoSize = True
        WPeriodLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WPeriodLabel.Location = New System.Drawing.Point(337, 41)
        WPeriodLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        WPeriodLabel.Name = "WPeriodLabel"
        WPeriodLabel.Size = New System.Drawing.Size(108, 19)
        WPeriodLabel.TabIndex = 12
        WPeriodLabel.Text = "Warenty Period:"
        '
        'ScostLabel
        '
        ScostLabel.AutoSize = True
        ScostLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ScostLabel.Location = New System.Drawing.Point(16, 125)
        ScostLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ScostLabel.Name = "ScostLabel"
        ScostLabel.Size = New System.Drawing.Size(71, 19)
        ScostLabel.TabIndex = 14
        ScostLabel.Text = "Sale Cost:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 59)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Part Description Store"
        '
        'StockDataSet
        '
        Me.StockDataSet.DataSetName = "StockDataSet"
        Me.StockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'PartCodeBindingNavigator
        '
        Me.PartCodeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PartCodeBindingNavigator.BindingSource = Me.PartCodeBindingSource
        Me.PartCodeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PartCodeBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PartCodeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PartCodeBindingNavigatorSaveItem})
        Me.PartCodeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PartCodeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PartCodeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PartCodeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PartCodeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PartCodeBindingNavigator.Name = "PartCodeBindingNavigator"
        Me.PartCodeBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.PartCodeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PartCodeBindingNavigator.Size = New System.Drawing.Size(777, 25)
        Me.PartCodeBindingNavigator.TabIndex = 3
        Me.PartCodeBindingNavigator.Text = "BindingNavigator1"
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
        'PartCodeBindingNavigatorSaveItem
        '
        Me.PartCodeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PartCodeBindingNavigatorSaveItem.Image = CType(resources.GetObject("PartCodeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PartCodeBindingNavigatorSaveItem.Name = "PartCodeBindingNavigatorSaveItem"
        Me.PartCodeBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PartCodeBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PartCodeTextBox
        '
        Me.PartCodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PartCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PartCodeBindingSource, "PartCode", True))
        Me.PartCodeTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PartCodeTextBox.Location = New System.Drawing.Point(110, 14)
        Me.PartCodeTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PartCodeTextBox.Name = "PartCodeTextBox"
        Me.PartCodeTextBox.Size = New System.Drawing.Size(92, 26)
        Me.PartCodeTextBox.TabIndex = 4
        '
        'PartNameTextBox
        '
        Me.PartNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PartNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PartCodeBindingSource, "PartName", True))
        Me.PartNameTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PartNameTextBox.Location = New System.Drawing.Point(110, 48)
        Me.PartNameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PartNameTextBox.Name = "PartNameTextBox"
        Me.PartNameTextBox.Size = New System.Drawing.Size(193, 26)
        Me.PartNameTextBox.TabIndex = 5
        '
        'MCostTextBox
        '
        Me.MCostTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MCostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PartCodeBindingSource, "MCost", True))
        Me.MCostTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MCostTextBox.Location = New System.Drawing.Point(110, 84)
        Me.MCostTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.MCostTextBox.Name = "MCostTextBox"
        Me.MCostTextBox.Size = New System.Drawing.Size(92, 26)
        Me.MCostTextBox.TabIndex = 7
        '
        'MYearDateTimePicker
        '
        Me.MYearDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PartCodeBindingSource, "MYear", True))
        Me.MYearDateTimePicker.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MYearDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.MYearDateTimePicker.Location = New System.Drawing.Point(469, 7)
        Me.MYearDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.MYearDateTimePicker.Name = "MYearDateTimePicker"
        Me.MYearDateTimePicker.Size = New System.Drawing.Size(116, 26)
        Me.MYearDateTimePicker.TabIndex = 9
        '
        'TQtyTextBox
        '
        Me.TQtyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TQtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PartCodeBindingSource, "TQty", True))
        Me.TQtyTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TQtyTextBox.Location = New System.Drawing.Point(110, 156)
        Me.TQtyTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TQtyTextBox.Name = "TQtyTextBox"
        Me.TQtyTextBox.Size = New System.Drawing.Size(101, 26)
        Me.TQtyTextBox.TabIndex = 11
        '
        'WPeriodTextBox
        '
        Me.WPeriodTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WPeriodTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PartCodeBindingSource, "WPeriod", True))
        Me.WPeriodTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WPeriodTextBox.Location = New System.Drawing.Point(469, 41)
        Me.WPeriodTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.WPeriodTextBox.Name = "WPeriodTextBox"
        Me.WPeriodTextBox.Size = New System.Drawing.Size(69, 26)
        Me.WPeriodTextBox.TabIndex = 13
        '
        'ScostTextBox
        '
        Me.ScostTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ScostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PartCodeBindingSource, "Scost", True))
        Me.ScostTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScostTextBox.Location = New System.Drawing.Point(110, 118)
        Me.ScostTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ScostTextBox.Name = "ScostTextBox"
        Me.ScostTextBox.Size = New System.Drawing.Size(92, 26)
        Me.ScostTextBox.TabIndex = 15
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(ScostLabel)
        Me.Panel1.Controls.Add(Me.ScostTextBox)
        Me.Panel1.Controls.Add(WPeriodLabel)
        Me.Panel1.Controls.Add(Me.WPeriodTextBox)
        Me.Panel1.Controls.Add(TQtyLabel)
        Me.Panel1.Controls.Add(Me.TQtyTextBox)
        Me.Panel1.Controls.Add(MYearLabel)
        Me.Panel1.Controls.Add(Me.MYearDateTimePicker)
        Me.Panel1.Controls.Add(MCostLabel)
        Me.Panel1.Controls.Add(Me.MCostTextBox)
        Me.Panel1.Controls.Add(PartNameLabel)
        Me.Panel1.Controls.Add(Me.PartNameTextBox)
        Me.Panel1.Controls.Add(PartCodeLabel)
        Me.Panel1.Controls.Add(Me.PartCodeTextBox)
        Me.Panel1.Location = New System.Drawing.Point(68, 106)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(654, 202)
        Me.Panel1.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(545, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "In Days."
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(585, 331)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(137, 44)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "&Exit"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(431, 331)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 44)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "&Show Report"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FrmPartCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(777, 430)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PartCodeBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmPartCode"
        Me.Text = "Part Code Storing..."
        CType(Me.StockDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartCodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartCodeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PartCodeBindingNavigator.ResumeLayout(False)
        Me.PartCodeBindingNavigator.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StockDataSet As PrjDataSec.StockDataSet
    Friend WithEvents PartCodeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PartCodeTableAdapter As PrjDataSec.StockDataSetTableAdapters.PartCodeTableAdapter
    Friend WithEvents PartCodeBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PartCodeBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PartCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PartNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MCostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MYearDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TQtyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WPeriodTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ScostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
