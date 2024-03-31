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
        Me.txtFileContent = New System.Windows.Forms.TextBox()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtFileContent
        '
        Me.txtFileContent.Location = New System.Drawing.Point(107, 12)
        Me.txtFileContent.Multiline = True
        Me.txtFileContent.Name = "txtFileContent"
        Me.txtFileContent.Size = New System.Drawing.Size(681, 411)
        Me.txtFileContent.TabIndex = 0
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Location = New System.Drawing.Point(12, 12)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(75, 23)
        Me.btnOpenFile.TabIndex = 1
        Me.btnOpenFile.Text = "Open File"
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnOpenFile)
        Me.Controls.Add(Me.txtFileContent)
        Me.Name = "Form1"
        Me.Text = "Open File"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFileContent As TextBox
    Friend WithEvents btnOpenFile As Button
End Class
