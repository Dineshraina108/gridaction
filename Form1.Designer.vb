<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.Gridpanel = New System.Windows.Forms.Panel()
        Me.Rgvcus = New Telerik.WinControls.UI.RadGridView()
        Me.btninsert = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Gridpanel.SuspendLayout()
        CType(Me.Rgvcus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rgvcus.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Gridpanel
        '
        Me.Gridpanel.AutoSize = True
        Me.Gridpanel.Controls.Add(Me.Rgvcus)
        Me.Gridpanel.Location = New System.Drawing.Point(51, 13)
        Me.Gridpanel.Name = "Gridpanel"
        Me.Gridpanel.Size = New System.Drawing.Size(512, 275)
        Me.Gridpanel.TabIndex = 0
        '
        'Rgvcus
        '
        Me.Rgvcus.BackColor = System.Drawing.SystemColors.Control
        Me.Rgvcus.Cursor = System.Windows.Forms.Cursors.Default
        Me.Rgvcus.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Rgvcus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Rgvcus.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Rgvcus.Location = New System.Drawing.Point(20, 19)
        '
        '
        '
        Me.Rgvcus.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.FieldName = "CID"
        GridViewTextBoxColumn1.HeaderText = "CUSTOMER ID"
        GridViewTextBoxColumn1.Name = "CID"
        GridViewTextBoxColumn1.Width = 94
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.FieldName = "NAME"
        GridViewTextBoxColumn2.HeaderText = "CUSTOMER NAME"
        GridViewTextBoxColumn2.Name = "NAME"
        GridViewTextBoxColumn2.Width = 128
        GridViewTextBoxColumn3.EnableExpressionEditor = False
        GridViewTextBoxColumn3.FieldName = "DOB"
        GridViewTextBoxColumn3.HeaderText = "DATE OF BIRTH"
        GridViewTextBoxColumn3.Name = "DOB"
        GridViewTextBoxColumn3.Width = 95
        GridViewTextBoxColumn4.EnableExpressionEditor = False
        GridViewTextBoxColumn4.FieldName = "MOBNO"
        GridViewTextBoxColumn4.HeaderText = "MOBILE NUMBER"
        GridViewTextBoxColumn4.Name = "MOBNO"
        GridViewTextBoxColumn4.Width = 126
        Me.Rgvcus.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4})
        Me.Rgvcus.MasterTemplate.EnableFiltering = True
        Me.Rgvcus.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.Rgvcus.Name = "Rgvcus"
        Me.Rgvcus.NewRowEnterKeyMode = Telerik.WinControls.UI.RadGridViewNewRowEnterKeyMode.EnterMovesToNextCell
        Me.Rgvcus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Rgvcus.Size = New System.Drawing.Size(466, 232)
        Me.Rgvcus.TabIndex = 0
        '
        'btninsert
        '
        Me.btninsert.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninsert.Location = New System.Drawing.Point(90, 329)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(75, 26)
        Me.btninsert.TabIndex = 1
        Me.btninsert.Text = "INSERT"
        Me.btninsert.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(192, 329)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(90, 26)
        Me.btnupdate.TabIndex = 2
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(315, 329)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(87, 26)
        Me.btndelete.TabIndex = 3
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(426, 328)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(87, 26)
        Me.btnsave.TabIndex = 4
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 402)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btninsert)
        Me.Controls.Add(Me.Gridpanel)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Gridpanel.ResumeLayout(False)
        CType(Me.Rgvcus.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rgvcus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Gridpanel As Panel
    Friend WithEvents Rgvcus As Telerik.WinControls.UI.RadGridView
    Friend WithEvents btninsert As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnsave As Button
End Class
