﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExamFruits
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExamFruits))
        Me.buttonnext = New System.Windows.Forms.Button()
        Me.op3 = New System.Windows.Forms.Button()
        Me.op2 = New System.Windows.Forms.Button()
        Me.op1 = New System.Windows.Forms.Button()
        Me.txtque = New System.Windows.Forms.TextBox()
        Me.lblQno = New System.Windows.Forms.Label()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buttonnext
        '
        Me.buttonnext.Font = New System.Drawing.Font("Monotype Corsiva", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonnext.Location = New System.Drawing.Point(560, 287)
        Me.buttonnext.Name = "buttonnext"
        Me.buttonnext.Size = New System.Drawing.Size(194, 99)
        Me.buttonnext.TabIndex = 15
        Me.buttonnext.Text = "NEXT"
        Me.buttonnext.UseVisualStyleBackColor = True
        '
        'op3
        '
        Me.op3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.op3.Location = New System.Drawing.Point(848, 135)
        Me.op3.Name = "op3"
        Me.op3.Size = New System.Drawing.Size(216, 109)
        Me.op3.TabIndex = 14
        Me.op3.UseVisualStyleBackColor = True
        '
        'op2
        '
        Me.op2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.op2.Location = New System.Drawing.Point(560, 135)
        Me.op2.Name = "op2"
        Me.op2.Size = New System.Drawing.Size(194, 109)
        Me.op2.TabIndex = 13
        Me.op2.UseVisualStyleBackColor = True
        '
        'op1
        '
        Me.op1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.op1.Location = New System.Drawing.Point(281, 135)
        Me.op1.Name = "op1"
        Me.op1.Size = New System.Drawing.Size(192, 109)
        Me.op1.TabIndex = 12
        Me.op1.UseVisualStyleBackColor = True
        '
        'txtque
        '
        Me.txtque.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtque.Location = New System.Drawing.Point(449, 72)
        Me.txtque.Name = "txtque"
        Me.txtque.Size = New System.Drawing.Size(615, 38)
        Me.txtque.TabIndex = 11
        '
        'lblQno
        '
        Me.lblQno.AutoSize = True
        Me.lblQno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQno.Location = New System.Drawing.Point(287, 75)
        Me.lblQno.Name = "lblQno"
        Me.lblQno.Size = New System.Drawing.Size(69, 24)
        Me.lblQno.TabIndex = 9
        Me.lblQno.Text = "Q .NO "
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(76, 363)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(75, 23)
        Me.AxWindowsMediaPlayer1.TabIndex = 16
        '
        'ExamFruits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1264, 553)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.buttonnext)
        Me.Controls.Add(Me.op3)
        Me.Controls.Add(Me.op2)
        Me.Controls.Add(Me.op1)
        Me.Controls.Add(Me.txtque)
        Me.Controls.Add(Me.lblQno)
        Me.Name = "ExamFruits"
        Me.Text = "ExamFruits"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
