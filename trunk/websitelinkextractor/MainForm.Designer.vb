<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.wb = New System.Windows.Forms.WebBrowser
        Me.GridView = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtUrl = New System.Windows.Forms.TextBox
        Me.cmdExtract = New System.Windows.Forms.Button
        Me.cmdExport = New System.Windows.Forms.Button
        Me.cmdExcel = New System.Windows.Forms.Button
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'wb
        '
        Me.wb.Location = New System.Drawing.Point(21, 298)
        Me.wb.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wb.Name = "wb"
        Me.wb.Size = New System.Drawing.Size(663, 80)
        Me.wb.TabIndex = 0
        '
        'GridView
        '
        Me.GridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridView.Location = New System.Drawing.Point(12, 45)
        Me.GridView.Name = "GridView"
        Me.GridView.Size = New System.Drawing.Size(698, 348)
        Me.GridView.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "URL"
        '
        'txtUrl
        '
        Me.txtUrl.Location = New System.Drawing.Point(58, 16)
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(313, 20)
        Me.txtUrl.TabIndex = 3
        '
        'cmdExtract
        '
        Me.cmdExtract.Location = New System.Drawing.Point(377, 15)
        Me.cmdExtract.Name = "cmdExtract"
        Me.cmdExtract.Size = New System.Drawing.Size(87, 23)
        Me.cmdExtract.TabIndex = 4
        Me.cmdExtract.Text = "Extract Links"
        Me.cmdExtract.UseVisualStyleBackColor = True
        '
        'cmdExport
        '
        Me.cmdExport.Location = New System.Drawing.Point(572, 15)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(96, 23)
        Me.cmdExport.TabIndex = 5
        Me.cmdExport.Text = "Export CSV"
        Me.cmdExport.UseVisualStyleBackColor = True
        '
        'cmdExcel
        '
        Me.cmdExcel.Location = New System.Drawing.Point(470, 15)
        Me.cmdExcel.Name = "cmdExcel"
        Me.cmdExcel.Size = New System.Drawing.Size(96, 23)
        Me.cmdExcel.TabIndex = 5
        Me.cmdExcel.Text = "Export to Excel"
        Me.cmdExcel.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(12, 397)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(111, 13)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "www.thetechhub.com"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 413)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.cmdExcel)
        Me.Controls.Add(Me.cmdExport)
        Me.Controls.Add(Me.cmdExtract)
        Me.Controls.Add(Me.txtUrl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GridView)
        Me.Controls.Add(Me.wb)
        Me.Name = "MainForm"
        Me.Text = "Website Link Extractor"
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents wb As System.Windows.Forms.WebBrowser
    Friend WithEvents GridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUrl As System.Windows.Forms.TextBox
    Friend WithEvents cmdExtract As System.Windows.Forms.Button
    Friend WithEvents cmdExport As System.Windows.Forms.Button
    Friend WithEvents cmdExcel As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel

End Class
