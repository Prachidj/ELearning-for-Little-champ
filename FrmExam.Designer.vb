<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExam
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmExam))
        Me.lblselectexam = New System.Windows.Forms.Label()
        Me.cmbexam = New System.Windows.Forms.ComboBox()
        Me.btnok = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblselectexam
        '
        Me.lblselectexam.AutoSize = True
        Me.lblselectexam.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblselectexam.Location = New System.Drawing.Point(126, 174)
        Me.lblselectexam.Name = "lblselectexam"
        Me.lblselectexam.Size = New System.Drawing.Size(278, 39)
        Me.lblselectexam.TabIndex = 0
        Me.lblselectexam.Text = "SELECT EXAM:"
        '
        'cmbexam
        '
        Me.cmbexam.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbexam.FormattingEnabled = True
        Me.cmbexam.Items.AddRange(New Object() {"Numbers", "COLORS", "FRUITS", "indiancurrency", "Birds"})
        Me.cmbexam.Location = New System.Drawing.Point(529, 167)
        Me.cmbexam.Name = "cmbexam"
        Me.cmbexam.Size = New System.Drawing.Size(456, 50)
        Me.cmbexam.TabIndex = 1
        '
        'btnok
        '
        Me.btnok.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnok.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnok.Location = New System.Drawing.Point(438, 361)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(190, 100)
        Me.btnok.TabIndex = 2
        Me.btnok.Text = "OK"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'FrmExam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1077, 697)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.cmbexam)
        Me.Controls.Add(Me.lblselectexam)
        Me.Name = "FrmExam"
        Me.Text = "FrmExam"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblselectexam As System.Windows.Forms.Label
    Friend WithEvents cmbexam As System.Windows.Forms.ComboBox
    Friend WithEvents btnok As System.Windows.Forms.Button
End Class
