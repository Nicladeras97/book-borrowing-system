<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReturnForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightBlue
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(998, 62)
        Me.Panel1.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.notification
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(961, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(15, 15)
        Me.Button2.TabIndex = 5
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Book Borrowing System"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(27, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(726, 503)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 38)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "RETURN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.back
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(61, 125)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(15, 15)
        Me.Button3.TabIndex = 21
        Me.Button3.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = ""
        Me.DateTimePicker1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(239, 377)
        Me.DateTimePicker1.MaxDate = New Date(2070, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(355, 26)
        Me.DateTimePicker1.TabIndex = 7
        Me.DateTimePicker1.Value = New Date(2025, 2, 20, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(96, 377)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Return Date"
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.BackColor = System.Drawing.Color.White
        Me.MaskedTextBox2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox2.Location = New System.Drawing.Point(239, 313)
        Me.MaskedTextBox2.Mask = "00-0000"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(355, 26)
        Me.MaskedTextBox2.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(96, 316)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Student Number"
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(95, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(499, 70)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "TITLE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(96, 347)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 18)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Borrower Name"
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(239, 345)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(355, 26)
        Me.TextBox6.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(176, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 18)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "000000"
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(645, 113)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(298, 365)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 32
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(96, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 18)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Book ID"
        '
        'ReturnForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(998, 560)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.MaskedTextBox2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ReturnForm"
        Me.Text = "Return Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents Label5 As Label
End Class
