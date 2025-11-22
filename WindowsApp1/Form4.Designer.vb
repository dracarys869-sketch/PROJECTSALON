<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN
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
        Me.LBLUSERNAME = New System.Windows.Forms.Label()
        Me.LBLPASSWORD = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTUSER = New System.Windows.Forms.TextBox()
        Me.TXTPASSWORD = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LBLUSERNAME
        '
        Me.LBLUSERNAME.AutoSize = True
        Me.LBLUSERNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLUSERNAME.Location = New System.Drawing.Point(54, 105)
        Me.LBLUSERNAME.Name = "LBLUSERNAME"
        Me.LBLUSERNAME.Size = New System.Drawing.Size(111, 20)
        Me.LBLUSERNAME.TabIndex = 0
        Me.LBLUSERNAME.Text = "USERNAME"
        '
        'LBLPASSWORD
        '
        Me.LBLPASSWORD.AutoSize = True
        Me.LBLPASSWORD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPASSWORD.Location = New System.Drawing.Point(50, 140)
        Me.LBLPASSWORD.Name = "LBLPASSWORD"
        Me.LBLPASSWORD.Size = New System.Drawing.Size(115, 20)
        Me.LBLPASSWORD.TabIndex = 1
        Me.LBLPASSWORD.Text = "PASSWORD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Perpetua Titling MT", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(151, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 39)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "LOGIN"
        '
        'TXTUSER
        '
        Me.TXTUSER.Location = New System.Drawing.Point(196, 103)
        Me.TXTUSER.Name = "TXTUSER"
        Me.TXTUSER.Size = New System.Drawing.Size(168, 22)
        Me.TXTUSER.TabIndex = 3
        '
        'TXTPASSWORD
        '
        Me.TXTPASSWORD.Location = New System.Drawing.Point(196, 140)
        Me.TXTPASSWORD.Name = "TXTPASSWORD"
        Me.TXTPASSWORD.Size = New System.Drawing.Size(168, 22)
        Me.TXTPASSWORD.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(148, 210)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 31)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "CONTINUE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(437, 311)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TXTPASSWORD)
        Me.Controls.Add(Me.TXTUSER)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LBLPASSWORD)
        Me.Controls.Add(Me.LBLUSERNAME)
        Me.Name = "LOGIN"
        Me.Text = "login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBLUSERNAME As Label
    Friend WithEvents LBLPASSWORD As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TXTUSER As TextBox
    Friend WithEvents TXTPASSWORD As TextBox
    Friend WithEvents Button1 As Button
End Class
