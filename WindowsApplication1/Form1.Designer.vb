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
        Me.DatePicker = New System.Windows.Forms.DateTimePicker()
        Me.btnLuna = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnZileSal = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DatePicker
        '
        Me.DatePicker.Location = New System.Drawing.Point(86, 85)
        Me.DatePicker.Name = "DatePicker"
        Me.DatePicker.Size = New System.Drawing.Size(200, 20)
        Me.DatePicker.TabIndex = 0
        '
        'btnLuna
        '
        Me.btnLuna.Location = New System.Drawing.Point(96, 147)
        Me.btnLuna.Name = "btnLuna"
        Me.btnLuna.Size = New System.Drawing.Size(150, 23)
        Me.btnLuna.TabIndex = 1
        Me.btnLuna.Text = "zile luna curenta"
        Me.btnLuna.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(146, 248)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'btnZileSal
        '
        Me.btnZileSal.Location = New System.Drawing.Point(96, 196)
        Me.btnZileSal.Name = "btnZileSal"
        Me.btnZileSal.Size = New System.Drawing.Size(150, 23)
        Me.btnZileSal.TabIndex = 3
        Me.btnZileSal.Text = "zile pana la salariu"
        Me.btnZileSal.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 251)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Rezultat:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(144, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Data curenta"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 343)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnZileSal)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnLuna)
        Me.Controls.Add(Me.DatePicker)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DatePicker As DateTimePicker
    Friend WithEvents btnLuna As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnZileSal As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
