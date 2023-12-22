<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExamVegetable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExamVegetable))
        Me.buttonnext = New System.Windows.Forms.Button()
        Me.op3 = New System.Windows.Forms.Button()
        Me.op2 = New System.Windows.Forms.Button()
        Me.op1 = New System.Windows.Forms.Button()
        Me.txtque = New System.Windows.Forms.TextBox()
        Me.lblQno = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'buttonnext
        '
        Me.buttonnext.Font = New System.Drawing.Font("Monotype Corsiva", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonnext.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.buttonnext.Location = New System.Drawing.Point(507, 309)
        Me.buttonnext.Name = "buttonnext"
        Me.buttonnext.Size = New System.Drawing.Size(170, 94)
        Me.buttonnext.TabIndex = 22
        Me.buttonnext.Text = "NEXT"
        Me.buttonnext.UseVisualStyleBackColor = True
        '
        'op3
        '
        Me.op3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.op3.Location = New System.Drawing.Point(739, 164)
        Me.op3.Name = "op3"
        Me.op3.Size = New System.Drawing.Size(170, 115)
        Me.op3.TabIndex = 21
        Me.op3.UseVisualStyleBackColor = True
        '
        'op2
        '
        Me.op2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.op2.Location = New System.Drawing.Point(507, 164)
        Me.op2.Name = "op2"
        Me.op2.Size = New System.Drawing.Size(170, 115)
        Me.op2.TabIndex = 20
        Me.op2.UseVisualStyleBackColor = True
        '
        'op1
        '
        Me.op1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.op1.Location = New System.Drawing.Point(260, 164)
        Me.op1.Name = "op1"
        Me.op1.Size = New System.Drawing.Size(170, 115)
        Me.op1.TabIndex = 19
        Me.op1.UseVisualStyleBackColor = True
        '
        'txtque
        '
        Me.txtque.Location = New System.Drawing.Point(492, 98)
        Me.txtque.Name = "txtque"
        Me.txtque.Size = New System.Drawing.Size(445, 22)
        Me.txtque.TabIndex = 18
        '
        'lblQno
        '
        Me.lblQno.AutoSize = True
        Me.lblQno.Location = New System.Drawing.Point(257, 98)
        Me.lblQno.Name = "lblQno"
        Me.lblQno.Size = New System.Drawing.Size(52, 17)
        Me.lblQno.TabIndex = 16
        Me.lblQno.Text = "Q .NO "
        '
        'ExamVegetable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1064, 638)
        Me.Controls.Add(Me.buttonnext)
        Me.Controls.Add(Me.op3)
        Me.Controls.Add(Me.op2)
        Me.Controls.Add(Me.op1)
        Me.Controls.Add(Me.txtque)
        Me.Controls.Add(Me.lblQno)
        Me.Name = "ExamVegetable"
        Me.Text = "ExamVegetable"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonnext As System.Windows.Forms.Button
    Friend WithEvents op3 As System.Windows.Forms.Button
    Friend WithEvents op2 As System.Windows.Forms.Button
    Friend WithEvents op1 As System.Windows.Forms.Button
    Friend WithEvents txtque As System.Windows.Forms.TextBox
    Friend WithEvents lblQno As System.Windows.Forms.Label
End Class
