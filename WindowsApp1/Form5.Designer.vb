<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FullName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sevice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeSlot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeferredDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Perpetua Titling MT", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(365, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(626, 72)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LIST OF BOOKINGS"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FullName, Me.Phone, Me.Email, Me.Sevice, Me.TimeSlot, Me.PeferredDate})
        Me.DataGridView1.Location = New System.Drawing.Point(258, 184)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(841, 300)
        Me.DataGridView1.TabIndex = 1
        '
        'FullName
        '
        Me.FullName.HeaderText = "FullName"
        Me.FullName.MinimumWidth = 6
        Me.FullName.Name = "FullName"
        Me.FullName.Width = 125
        '
        'Phone
        '
        Me.Phone.HeaderText = "Phone"
        Me.Phone.MinimumWidth = 6
        Me.Phone.Name = "Phone"
        Me.Phone.Width = 125
        '
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.MinimumWidth = 6
        Me.Email.Name = "Email"
        Me.Email.Width = 125
        '
        'Sevice
        '
        Me.Sevice.HeaderText = "Service"
        Me.Sevice.MinimumWidth = 6
        Me.Sevice.Name = "Sevice"
        Me.Sevice.Width = 125
        '
        'TimeSlot
        '
        Me.TimeSlot.HeaderText = "TimeSlot"
        Me.TimeSlot.MinimumWidth = 6
        Me.TimeSlot.Name = "TimeSlot"
        Me.TimeSlot.Width = 125
        '
        'PeferredDate
        '
        Me.PeferredDate.HeaderText = "PeferredDate"
        Me.PeferredDate.MinimumWidth = 6
        Me.PeferredDate.Name = "PeferredDate"
        Me.PeferredDate.Width = 125
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightCoral
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(407, 530)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(543, 50)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "RETURN TO HOMEPAGE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(1357, 707)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form5"
        Me.Text = "Form5"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents FullName As DataGridViewTextBoxColumn
    Friend WithEvents Phone As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents Sevice As DataGridViewTextBoxColumn
    Friend WithEvents TimeSlot As DataGridViewTextBoxColumn
    Friend WithEvents PeferredDate As DataGridViewTextBoxColumn
End Class
