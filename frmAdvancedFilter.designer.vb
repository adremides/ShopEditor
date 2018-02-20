<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdvancedFilter
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
        Me.btnClearFilters = New System.Windows.Forms.Button()
        Me.grpCharacterClass = New System.Windows.Forms.GroupBox()
        Me.chkCharClassOnly = New System.Windows.Forms.CheckBox()
        Me.cmbClass = New System.Windows.Forms.ComboBox()
        Me.chkCharClass = New System.Windows.Forms.CheckBox()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblSlot = New System.Windows.Forms.Label()
        Me.cmbSlot = New System.Windows.Forms.ComboBox()
        Me.grpCharacterClass.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClearFilters
        '
        Me.btnClearFilters.Location = New System.Drawing.Point(222, 226)
        Me.btnClearFilters.Name = "btnClearFilters"
        Me.btnClearFilters.Size = New System.Drawing.Size(50, 23)
        Me.btnClearFilters.TabIndex = 0
        Me.btnClearFilters.Text = "Clear"
        Me.btnClearFilters.UseVisualStyleBackColor = True
        '
        'grpCharacterClass
        '
        Me.grpCharacterClass.Controls.Add(Me.chkCharClassOnly)
        Me.grpCharacterClass.Controls.Add(Me.cmbClass)
        Me.grpCharacterClass.Location = New System.Drawing.Point(12, 12)
        Me.grpCharacterClass.Name = "grpCharacterClass"
        Me.grpCharacterClass.Size = New System.Drawing.Size(178, 56)
        Me.grpCharacterClass.TabIndex = 1
        Me.grpCharacterClass.TabStop = False
        Me.grpCharacterClass.Text = "Char. Class"
        '
        'chkCharClassOnly
        '
        Me.chkCharClassOnly.AutoSize = True
        Me.chkCharClassOnly.Location = New System.Drawing.Point(123, 25)
        Me.chkCharClassOnly.Name = "chkCharClassOnly"
        Me.chkCharClassOnly.Size = New System.Drawing.Size(47, 17)
        Me.chkCharClassOnly.TabIndex = 4
        Me.chkCharClassOnly.Text = "Only"
        Me.chkCharClassOnly.UseVisualStyleBackColor = True
        '
        'cmbClass
        '
        Me.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbClass.FormattingEnabled = True
        Me.cmbClass.Location = New System.Drawing.Point(6, 23)
        Me.cmbClass.Name = "cmbClass"
        Me.cmbClass.Size = New System.Drawing.Size(111, 21)
        Me.cmbClass.TabIndex = 3
        '
        'chkCharClass
        '
        Me.chkCharClass.AutoSize = True
        Me.chkCharClass.Location = New System.Drawing.Point(18, 11)
        Me.chkCharClass.Name = "chkCharClass"
        Me.chkCharClass.Size = New System.Drawing.Size(79, 17)
        Me.chkCharClass.TabIndex = 2
        Me.chkCharClass.Text = "Char. Class"
        Me.chkCharClass.UseVisualStyleBackColor = True
        '
        'cmbType
        '
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Location = New System.Drawing.Point(49, 74)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(141, 21)
        Me.cmbType.TabIndex = 3
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(12, 77)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(31, 13)
        Me.lblType.TabIndex = 4
        Me.lblType.Text = "Type"
        '
        'lblSlot
        '
        Me.lblSlot.AutoSize = True
        Me.lblSlot.Location = New System.Drawing.Point(12, 104)
        Me.lblSlot.Name = "lblSlot"
        Me.lblSlot.Size = New System.Drawing.Size(25, 13)
        Me.lblSlot.TabIndex = 5
        Me.lblSlot.Text = "Slot"
        '
        'cmbSlot
        '
        Me.cmbSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSlot.FormattingEnabled = True
        Me.cmbSlot.Location = New System.Drawing.Point(49, 101)
        Me.cmbSlot.Name = "cmbSlot"
        Me.cmbSlot.Size = New System.Drawing.Size(141, 21)
        Me.cmbSlot.TabIndex = 6
        '
        'frmAdvancedFilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.cmbSlot)
        Me.Controls.Add(Me.lblSlot)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.chkCharClass)
        Me.Controls.Add(Me.grpCharacterClass)
        Me.Controls.Add(Me.btnClearFilters)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAdvancedFilter"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Advanced Filter"
        Me.grpCharacterClass.ResumeLayout(False)
        Me.grpCharacterClass.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClearFilters As System.Windows.Forms.Button
    Friend WithEvents grpCharacterClass As System.Windows.Forms.GroupBox
    Friend WithEvents cmbClass As System.Windows.Forms.ComboBox
    Friend WithEvents chkCharClass As System.Windows.Forms.CheckBox
    Friend WithEvents chkCharClassOnly As System.Windows.Forms.CheckBox
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents lblSlot As System.Windows.Forms.Label
    Friend WithEvents cmbSlot As System.Windows.Forms.ComboBox
End Class
