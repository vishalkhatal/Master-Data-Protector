<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewPart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNewPart))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.PartCodeDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PartCodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.New_StockDataSet = New PrjDataSec.New_StockDataSet
        Me.ScostTextBox = New System.Windows.Forms.TextBox
        Me.WPeriodTextBox = New System.Windows.Forms.TextBox
        Me.TQtyTextBox = New System.Windows.Forms.TextBox
        Me.MYearDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.MCostTextBox = New System.Windows.Forms.TextBox
        Me.PartNameTextBox = New System.Windows.Forms.TextBox
        Me.PartCodeTextBox = New System.Windows.Forms.TextBox
        Me.PartCodeTableAdapter = New PrjDataSec.New_StockDataSetTableAdapters.PartCodeTableAdapter
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
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        PartCodeLabel = New System.Windows.Forms.Label
        PartNameLabel = New System.Windows.Forms.Label
        MCostLabel = New System.Windows.Forms.Label
        MYearLabel = New System.Windows.Forms.Label
        TQtyLabel = New System.Windows.Forms.Label
        WPeriodLabel = New System.Windows.Forms.Label
        ScostLabel = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        CType(Me.PartCodeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartCodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.New_StockDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartCodeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PartCodeBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'PartCodeLabel
        '
        PartCodeLabel.AutoSize = True
        PartCodeLabel.Location = New System.Drawing.Point(52, 49)
        PartCodeLabel.Name = "PartCodeLabel"
        PartCodeLabel.Size = New System.Drawing.Size(75, 19)
        PartCodeLabel.TabIndex = 0
        PartCodeLabel.Text = "Part Code:"
        '
        'PartNameLabel
        '
        PartNameLabel.AutoSize = True
        PartNameLabel.Location = New System.Drawing.Point(49, 81)
        PartNameLabel.Name = "PartNameLabel"
        PartNameLabel.Size = New System.Drawing.Size(78, 19)
        PartNameLabel.TabIndex = 2
        PartNameLabel.Text = "Part Name:"
        '
        'MCostLabel
        '
        MCostLabel.AutoSize = True
        MCostLabel.Location = New System.Drawing.Point(56, 113)
        MCostLabel.Name = "MCostLabel"
        MCostLabel.Size = New System.Drawing.Size(71, 19)
        MCostLabel.TabIndex = 4
        MCostLabel.Text = "Mfd Cost:"
        '
        'MYearLabel
        '
        MYearLabel.AutoSize = True
        MYearLabel.Location = New System.Drawing.Point(365, 118)
        MYearLabel.Name = "MYearLabel"
        MYearLabel.Size = New System.Drawing.Size(56, 19)
        MYearLabel.TabIndex = 6
        MYearLabel.Text = "MYear:"
        '
        'TQtyLabel
        '
        TQtyLabel.AutoSize = True
        TQtyLabel.Location = New System.Drawing.Point(351, 36)
        TQtyLabel.Name = "TQtyLabel"
        TQtyLabel.Size = New System.Drawing.Size(70, 19)
        TQtyLabel.TabIndex = 8
        TQtyLabel.Text = "Total Qty:"
        '
        'WPeriodLabel
        '
        WPeriodLabel.AutoSize = True
        WPeriodLabel.Location = New System.Drawing.Point(313, 81)
        WPeriodLabel.Name = "WPeriodLabel"
        WPeriodLabel.Size = New System.Drawing.Size(108, 19)
        WPeriodLabel.TabIndex = 10
        WPeriodLabel.Text = "Warenty Period:"
        '
        'ScostLabel
        '
        ScostLabel.AutoSize = True
        ScostLabel.Location = New System.Drawing.Point(56, 145)
        ScostLabel.Name = "ScostLabel"
        ScostLabel.Size = New System.Drawing.Size(71, 19)
        ScostLabel.TabIndex = 12
        ScostLabel.Text = "Sale Cost:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PartCodeDataGridView)
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
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(56, 86)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(622, 431)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(533, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "In Days."
        '
        'PartCodeDataGridView
        '
        Me.PartCodeDataGridView.AutoGenerateColumns = False
        Me.PartCodeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.PartCodeDataGridView.DataSource = Me.PartCodeBindingSource
        Me.PartCodeDataGridView.Location = New System.Drawing.Point(70, 184)
        Me.PartCodeDataGridView.Name = "PartCodeDataGridView"
        Me.PartCodeDataGridView.Size = New System.Drawing.Size(508, 220)
        Me.PartCodeDataGridView.TabIndex = 14
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PartCode"
        Me.DataGridViewTextBoxColumn1.HeaderText = "PartCode"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PartName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "PartName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "MCost"
        Me.DataGridViewTextBoxColumn3.HeaderText = "MCost"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "MYear"
        Me.DataGridViewTextBoxColumn4.HeaderText = "MYear"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TQty"
        Me.DataGridViewTextBoxColumn5.HeaderText = "TQty"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "WPeriod"
        Me.DataGridViewTextBoxColumn6.HeaderText = "WPeriod"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Scost"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Scost"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'PartCodeBindingSource
        '
        Me.PartCodeBindingSource.DataMember = "PartCode"
        Me.PartCodeBindingSource.DataSource = Me.New_StockDataSet
        '
        'New_StockDataSet
        '
        Me.New_StockDataSet.DataSetName = "New_StockDataSet"
        Me.New_StockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ScostTextBox
        '
        Me.ScostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PartCodeBindingSource, "Scost", True))
        Me.ScostTextBox.Location = New System.Drawing.Point(133, 142)
        Me.ScostTextBox.Name = "ScostTextBox"
        Me.ScostTextBox.Size = New System.Drawing.Size(100, 26)
        Me.ScostTextBox.TabIndex = 13
        '
        'WPeriodTextBox
        '
        Me.WPeriodTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PartCodeBindingSource, "WPeriod", True))
        Me.WPeriodTextBox.Location = New System.Drawing.Point(427, 75)
        Me.WPeriodTextBox.Name = "WPeriodTextBox"
        Me.WPeriodTextBox.Size = New System.Drawing.Size(100, 26)
        Me.WPeriodTextBox.TabIndex = 11
        '
        'TQtyTextBox
        '
        Me.TQtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PartCodeBindingSource, "TQty", True))
        Me.TQtyTextBox.Location = New System.Drawing.Point(427, 33)
        Me.TQtyTextBox.Name = "TQtyTextBox"
        Me.TQtyTextBox.Size = New System.Drawing.Size(100, 26)
        Me.TQtyTextBox.TabIndex = 9
        '
        'MYearDateTimePicker
        '
        Me.MYearDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PartCodeBindingSource, "MYear", True))
        Me.MYearDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.MYearDateTimePicker.Location = New System.Drawing.Point(427, 114)
        Me.MYearDateTimePicker.Name = "MYearDateTimePicker"
        Me.MYearDateTimePicker.Size = New System.Drawing.Size(120, 26)
        Me.MYearDateTimePicker.TabIndex = 7
        '
        'MCostTextBox
        '
        Me.MCostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PartCodeBindingSource, "MCost", True))
        Me.MCostTextBox.Location = New System.Drawing.Point(133, 110)
        Me.MCostTextBox.Name = "MCostTextBox"
        Me.MCostTextBox.Size = New System.Drawing.Size(120, 26)
        Me.MCostTextBox.TabIndex = 5
        '
        'PartNameTextBox
        '
        Me.PartNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PartCodeBindingSource, "PartName", True))
        Me.PartNameTextBox.Location = New System.Drawing.Point(133, 78)
        Me.PartNameTextBox.Name = "PartNameTextBox"
        Me.PartNameTextBox.Size = New System.Drawing.Size(180, 26)
        Me.PartNameTextBox.TabIndex = 3
        '
        'PartCodeTextBox
        '
        Me.PartCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PartCodeBindingSource, "PartCode", True))
        Me.PartCodeTextBox.Location = New System.Drawing.Point(133, 46)
        Me.PartCodeTextBox.Name = "PartCodeTextBox"
        Me.PartCodeTextBox.Size = New System.Drawing.Size(120, 26)
        Me.PartCodeTextBox.TabIndex = 1
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
        Me.PartCodeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PartCodeBindingNavigator.Size = New System.Drawing.Size(745, 25)
        Me.PartCodeBindingNavigator.TabIndex = 1
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
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(541, 523)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(137, 44)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "&Exit"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(387, 523)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 44)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "&Show Report"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 48)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 23)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Part Description Store"
        '
        'FrmNewPart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(745, 597)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PartCodeBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmNewPart"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PartCodeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartCodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.New_StockDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartCodeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PartCodeBindingNavigator.ResumeLayout(False)
        Me.PartCodeBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents New_StockDataSet As PrjDataSec.New_StockDataSet
    Friend WithEvents PartCodeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PartCodeTableAdapter As PrjDataSec.New_StockDataSetTableAdapters.PartCodeTableAdapter
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
    Friend WithEvents ScostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WPeriodTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TQtyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MYearDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents MCostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PartNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PartCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PartCodeDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
