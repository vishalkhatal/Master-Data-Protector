<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewParty
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
        Dim ClientIdLabel As System.Windows.Forms.Label
        Dim CompanyNameLabel As System.Windows.Forms.Label
        Dim ContactPNameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim PhoneNoLabel As System.Windows.Forms.Label
        Dim MobNoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNewParty))
        Me.StockDataSet = New PrjDataSec.StockDataSet
        Me.PartyMastBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PartyMastTableAdapter = New PrjDataSec.StockDataSetTableAdapters.PartyMastTableAdapter
        Me.PartyMastBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PartyMastBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ClientIdTextBox = New System.Windows.Forms.TextBox
        Me.CompanyNameTextBox = New System.Windows.Forms.TextBox
        Me.ContactPNameTextBox = New System.Windows.Forms.TextBox
        Me.AddressTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.PhoneNoMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.MobNoMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        ClientIdLabel = New System.Windows.Forms.Label
        CompanyNameLabel = New System.Windows.Forms.Label
        ContactPNameLabel = New System.Windows.Forms.Label
        AddressLabel = New System.Windows.Forms.Label
        PhoneNoLabel = New System.Windows.Forms.Label
        MobNoLabel = New System.Windows.Forms.Label
        CType(Me.StockDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartyMastBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartyMastBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PartyMastBindingNavigator.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ClientIdLabel
        '
        ClientIdLabel.AutoSize = True
        ClientIdLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ClientIdLabel.Location = New System.Drawing.Point(88, 19)
        ClientIdLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ClientIdLabel.Name = "ClientIdLabel"
        ClientIdLabel.Size = New System.Drawing.Size(64, 19)
        ClientIdLabel.TabIndex = 1
        ClientIdLabel.Text = "Client Id:"
        '
        'CompanyNameLabel
        '
        CompanyNameLabel.AutoSize = True
        CompanyNameLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CompanyNameLabel.Location = New System.Drawing.Point(40, 53)
        CompanyNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CompanyNameLabel.Name = "CompanyNameLabel"
        CompanyNameLabel.Size = New System.Drawing.Size(112, 19)
        CompanyNameLabel.TabIndex = 3
        CompanyNameLabel.Text = "Company Name:"
        '
        'ContactPNameLabel
        '
        ContactPNameLabel.AutoSize = True
        ContactPNameLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContactPNameLabel.Location = New System.Drawing.Point(5, 92)
        ContactPNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ContactPNameLabel.Name = "ContactPNameLabel"
        ContactPNameLabel.Size = New System.Drawing.Size(147, 19)
        ContactPNameLabel.TabIndex = 5
        ContactPNameLabel.Text = "Contact Person Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.Location = New System.Drawing.Point(89, 134)
        AddressLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(63, 19)
        AddressLabel.TabIndex = 7
        AddressLabel.Text = "Address:"
        '
        'PhoneNoLabel
        '
        PhoneNoLabel.AutoSize = True
        PhoneNoLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PhoneNoLabel.Location = New System.Drawing.Point(87, 218)
        PhoneNoLabel.Name = "PhoneNoLabel"
        PhoneNoLabel.Size = New System.Drawing.Size(74, 19)
        PhoneNoLabel.TabIndex = 13
        PhoneNoLabel.Text = "Phone No:"
        '
        'MobNoLabel
        '
        MobNoLabel.AutoSize = True
        MobNoLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MobNoLabel.Location = New System.Drawing.Point(100, 248)
        MobNoLabel.Name = "MobNoLabel"
        MobNoLabel.Size = New System.Drawing.Size(66, 19)
        MobNoLabel.TabIndex = 14
        MobNoLabel.Text = "Mob No:"
        '
        'StockDataSet
        '
        Me.StockDataSet.DataSetName = "StockDataSet"
        Me.StockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PartyMastBindingSource
        '
        Me.PartyMastBindingSource.DataMember = "PartyMast"
        Me.PartyMastBindingSource.DataSource = Me.StockDataSet
        '
        'PartyMastTableAdapter
        '
        Me.PartyMastTableAdapter.ClearBeforeFill = True
        '
        'PartyMastBindingNavigator
        '
        Me.PartyMastBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PartyMastBindingNavigator.BindingSource = Me.PartyMastBindingSource
        Me.PartyMastBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PartyMastBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PartyMastBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PartyMastBindingNavigatorSaveItem})
        Me.PartyMastBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PartyMastBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PartyMastBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PartyMastBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PartyMastBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PartyMastBindingNavigator.Name = "PartyMastBindingNavigator"
        Me.PartyMastBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PartyMastBindingNavigator.Size = New System.Drawing.Size(601, 25)
        Me.PartyMastBindingNavigator.TabIndex = 0
        Me.PartyMastBindingNavigator.Text = "BindingNavigator1"
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
        'PartyMastBindingNavigatorSaveItem
        '
        Me.PartyMastBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PartyMastBindingNavigatorSaveItem.Image = CType(resources.GetObject("PartyMastBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PartyMastBindingNavigatorSaveItem.Name = "PartyMastBindingNavigatorSaveItem"
        Me.PartyMastBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PartyMastBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ClientIdTextBox
        '
        Me.ClientIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ClientIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PartyMastBindingSource, "ClientId", True))
        Me.ClientIdTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClientIdTextBox.Location = New System.Drawing.Point(172, 17)
        Me.ClientIdTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ClientIdTextBox.Name = "ClientIdTextBox"
        Me.ClientIdTextBox.Size = New System.Drawing.Size(87, 26)
        Me.ClientIdTextBox.TabIndex = 2
        '
        'CompanyNameTextBox
        '
        Me.CompanyNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CompanyNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PartyMastBindingSource, "CompanyName", True))
        Me.CompanyNameTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompanyNameTextBox.Location = New System.Drawing.Point(172, 51)
        Me.CompanyNameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CompanyNameTextBox.Name = "CompanyNameTextBox"
        Me.CompanyNameTextBox.Size = New System.Drawing.Size(247, 26)
        Me.CompanyNameTextBox.TabIndex = 4
        '
        'ContactPNameTextBox
        '
        Me.ContactPNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ContactPNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PartyMastBindingSource, "ContactPName", True))
        Me.ContactPNameTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactPNameTextBox.Location = New System.Drawing.Point(172, 85)
        Me.ContactPNameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ContactPNameTextBox.Name = "ContactPNameTextBox"
        Me.ContactPNameTextBox.Size = New System.Drawing.Size(247, 26)
        Me.ContactPNameTextBox.TabIndex = 6
        '
        'AddressTextBox
        '
        Me.AddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PartyMastBindingSource, "Address", True))
        Me.AddressTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTextBox.Location = New System.Drawing.Point(172, 120)
        Me.AddressTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.AddressTextBox.Size = New System.Drawing.Size(247, 88)
        Me.AddressTextBox.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 23)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Party Information"
        '
        'PhoneNoMaskedTextBox
        '
        Me.PhoneNoMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PartyMastBindingSource, "PhoneNo", True))
        Me.PhoneNoMaskedTextBox.Location = New System.Drawing.Point(172, 215)
        Me.PhoneNoMaskedTextBox.Mask = "####-#######"
        Me.PhoneNoMaskedTextBox.Name = "PhoneNoMaskedTextBox"
        Me.PhoneNoMaskedTextBox.Size = New System.Drawing.Size(195, 24)
        Me.PhoneNoMaskedTextBox.TabIndex = 14
        '
        'MobNoMaskedTextBox
        '
        Me.MobNoMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PartyMastBindingSource, "MobNo", True))
        Me.MobNoMaskedTextBox.Location = New System.Drawing.Point(172, 245)
        Me.MobNoMaskedTextBox.Mask = "##########"
        Me.MobNoMaskedTextBox.Name = "MobNoMaskedTextBox"
        Me.MobNoMaskedTextBox.Size = New System.Drawing.Size(195, 24)
        Me.MobNoMaskedTextBox.TabIndex = 15
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(MobNoLabel)
        Me.Panel1.Controls.Add(Me.MobNoMaskedTextBox)
        Me.Panel1.Controls.Add(PhoneNoLabel)
        Me.Panel1.Controls.Add(Me.PhoneNoMaskedTextBox)
        Me.Panel1.Controls.Add(AddressLabel)
        Me.Panel1.Controls.Add(Me.AddressTextBox)
        Me.Panel1.Controls.Add(ContactPNameLabel)
        Me.Panel1.Controls.Add(Me.ContactPNameTextBox)
        Me.Panel1.Controls.Add(CompanyNameLabel)
        Me.Panel1.Controls.Add(Me.CompanyNameTextBox)
        Me.Panel1.Controls.Add(ClientIdLabel)
        Me.Panel1.Controls.Add(Me.ClientIdTextBox)
        Me.Panel1.Location = New System.Drawing.Point(43, 94)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(479, 295)
        Me.Panel1.TabIndex = 16
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(381, 420)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 43)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "&Exit"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(234, 420)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 43)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "&Show Report"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FrmNewParty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(601, 500)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PartyMastBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmNewParty"
        Me.Text = "Party Information"
        CType(Me.StockDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartyMastBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartyMastBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PartyMastBindingNavigator.ResumeLayout(False)
        Me.PartyMastBindingNavigator.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StockDataSet As PrjDataSec.StockDataSet
    Friend WithEvents PartyMastBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PartyMastTableAdapter As PrjDataSec.StockDataSetTableAdapters.PartyMastTableAdapter
    Friend WithEvents PartyMastBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PartyMastBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ClientIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CompanyNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactPNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PhoneNoMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MobNoMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
