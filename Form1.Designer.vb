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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.emp_id = New System.Windows.Forms.TextBox()
        Me.name1 = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(293, 224)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 30)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'emp_id
        '
        Me.emp_id.Location = New System.Drawing.Point(289, 63)
        Me.emp_id.Name = "emp_id"
        Me.emp_id.Size = New System.Drawing.Size(106, 23)
        Me.emp_id.TabIndex = 1
        '
        'name1
        '
        Me.name1.Location = New System.Drawing.Point(287, 105)
        Me.name1.Name = "name1"
        Me.name1.Size = New System.Drawing.Size(207, 23)
        Me.name1.TabIndex = 2
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(287, 147)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(206, 23)
        Me.email.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.name1)
        Me.Controls.Add(Me.emp_id)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents emp_id As TextBox
    Friend WithEvents name1 As TextBox
    Friend WithEvents email As TextBox
End Class
