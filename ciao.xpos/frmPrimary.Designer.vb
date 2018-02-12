<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrimary
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.ptbLogoSucasa = New System.Windows.Forms.PictureBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.ptbLogoSaidi = New System.Windows.Forms.PictureBox()
        Me.TimerPos = New System.Windows.Forms.Timer(Me.components)
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        CType(Me.ptbLogoSucasa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbLogoSaidi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.lblTime)
        Me.Panel3.Controls.Add(Me.ptbLogoSucasa)
        Me.Panel3.Controls.Add(Me.lblDate)
        Me.Panel3.Controls.Add(Me.ptbLogoSaidi)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(190, 600)
        Me.Panel3.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(99, 576)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "CiaoMarvic ©2018"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Agency FB", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.Gray
        Me.lblTime.Location = New System.Drawing.Point(43, 382)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(111, 39)
        Me.lblTime.TabIndex = 3
        Me.lblTime.Text = "17:00 PM"
        '
        'ptbLogoSucasa
        '
        Me.ptbLogoSucasa.Image = Global.ciao.xpos.My.Resources.Resources.LOGOS
        Me.ptbLogoSucasa.Location = New System.Drawing.Point(29, 133)
        Me.ptbLogoSucasa.Name = "ptbLogoSucasa"
        Me.ptbLogoSucasa.Size = New System.Drawing.Size(138, 236)
        Me.ptbLogoSucasa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbLogoSucasa.TabIndex = 3
        Me.ptbLogoSucasa.TabStop = False
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(12, 19)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(104, 18)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "10 de Febrero 2018"
        '
        'ptbLogoSaidi
        '
        Me.ptbLogoSaidi.Image = Global.ciao.xpos.My.Resources.Resources.S
        Me.ptbLogoSaidi.Location = New System.Drawing.Point(3, 133)
        Me.ptbLogoSaidi.Name = "ptbLogoSaidi"
        Me.ptbLogoSaidi.Size = New System.Drawing.Size(187, 236)
        Me.ptbLogoSaidi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbLogoSaidi.TabIndex = 3
        Me.ptbLogoSaidi.TabStop = False
        Me.ptbLogoSaidi.Visible = False
        '
        'TimerPos
        '
        Me.TimerPos.Enabled = True
        Me.TimerPos.Interval = 1000
        '
        'btnOpen
        '
        Me.btnOpen.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnOpen.Location = New System.Drawing.Point(3, 3)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(80, 39)
        Me.btnOpen.TabIndex = 1
        Me.btnOpen.Text = "Usuario [F2]"
        Me.btnOpen.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(84, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 39)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Consultar[F3]"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnOpen)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(190, 554)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(610, 46)
        Me.Panel1.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Tomato
        Me.Button2.Location = New System.Drawing.Point(161, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 39)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Cerrar[F10]"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'frmPrimary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPrimary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.ptbLogoSucasa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbLogoSaidi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents ptbLogoSucasa As PictureBox
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TimerPos As Timer
    Friend WithEvents btnOpen As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ptbLogoSaidi As PictureBox
    Friend WithEvents Button2 As Button
End Class
