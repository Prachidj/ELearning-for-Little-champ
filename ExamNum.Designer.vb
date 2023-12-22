<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExamNum
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExamNum))
        Me.buttonnext = New System.Windows.Forms.Button()
        Me.op3 = New System.Windows.Forms.Button()
        Me.op2 = New System.Windows.Forms.Button()
        Me.op1 = New System.Windows.Forms.Button()
        Me.txtque = New System.Windows.Forms.TextBox()
        Me.lblQno = New System.Windows.Forms.Label()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayer2 = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buttonnext
        '
        Me.buttonnext.Font = New System.Drawing.Font("Monotype Corsiva", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonnext.Location = New System.Drawing.Point(634, 353)
        Me.buttonnext.Name = "buttonnext"
        Me.buttonnext.Size = New System.Drawing.Size(170, 93)
        Me.buttonnext.TabIndex = 15
        Me.buttonnext.Text = "NEXT"
        Me.buttonnext.UseVisualStyleBackColor = True
        '
        'op3
        '
        Me.op3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.op3.Location = New System.Drawing.Point(914, 185)
        Me.op3.Name = "op3"
        Me.op3.Size = New System.Drawing.Size(210, 116)
        Me.op3.TabIndex = 14
        Me.op3.UseVisualStyleBackColor = True
        '
        'op2
        '
        Me.op2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.op2.Location = New System.Drawing.Point(618, 185)
        Me.op2.Name = "op2"
        Me.op2.Size = New System.Drawing.Size(203, 116)
        Me.op2.TabIndex = 13
        Me.op2.UseVisualStyleBackColor = True
        '
        'op1
        '
        Me.op1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.op1.Location = New System.Drawing.Point(334, 185)
        Me.op1.Name = "op1"
        Me.op1.Size = New System.Drawing.Size(200, 116)
        Me.op1.TabIndex = 12
        Me.op1.UseVisualStyleBackColor = True
        '
        'txtque
        '
        Me.txtque.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtque.Location = New System.Drawing.Point(582, 94)
        Me.txtque.Name = "txtque"
        Me.txtque.Size = New System.Drawing.Size(554, 30)
        Me.txtque.TabIndex = 11
        '
        'lblQno
        '
        Me.lblQno.AutoSize = True
        Me.lblQno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQno.Location = New System.Drawing.Point(367, 99)
        Me.lblQno.Name = "lblQno"
        Me.lblQno.Size = New System.Drawing.Size(69, 24)
        Me.lblQno.TabIndex = 9
        Me.lblQno.Text = "Q .NO "
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(258, 551)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(75, 23)
        Me.AxWindowsMediaPlayer1.TabIndex = 16
        '
        'AxWindowsMediaPlayer2
        '
        Me.AxWindowsMediaPlayer2.Enabled = True
        Me.AxWindowsMediaPlayer2.Location = New System.Drawing.Point(177, 551)
        Me.AxWindowsMediaPlayer2.Name = "AxWindowsMediaPlayer2"
        Me.AxWindowsMediaPlayer2.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer2.Size = New System.Drawing.Size(75, 33)
        Me.AxWindowsMediaPlayer2.TabIndex = 17
        '
        'ExamNum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1409, 707)
        Me.Controls.Add(Me.AxWindowsMediaPlayer2)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.buttonnext)
        Me.Controls.Add(Me.op3)
        Me.Controls.Add(Me.op2)
        Me.Controls.Add(Me.op1)
        Me.Controls.Add(Me.txtque)
        Me.Controls.Add(Me.lblQno)
        Me.Name = "ExamNum"
        Me.Text = "ExamNum"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonnext As System.Windows.Forms.Button
    Friend WithEvents op3 As System.Windows.Forms.Button
    Friend WithEvents op2 As System.Windows.Forms.Button
    Friend WithEvents op1 As System.Windows.Forms.Button
    Friend WithEvents txtque As System.Windows.Forms.TextBox
    Friend WithEvents lblQno As System.Windows.Forms.Label
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayer2 As AxWMPLib.AxWindowsMediaPlayer
End Class
