<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mainform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mainform))
        Me.btnrstud = New System.Windows.Forms.Button()
        Me.btnstudy = New System.Windows.Forms.Button()
        Me.btnkids = New System.Windows.Forms.Button()
        Me.btnexam = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnrstud
        '
        Me.btnrstud.Font = New System.Drawing.Font("Elephant", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrstud.ForeColor = System.Drawing.Color.Indigo
        Me.btnrstud.Location = New System.Drawing.Point(491, 12)
        Me.btnrstud.Name = "btnrstud"
        Me.btnrstud.Size = New System.Drawing.Size(299, 157)
        Me.btnrstud.TabIndex = 0
        Me.btnrstud.Text = "Student Registration"
        Me.btnrstud.UseVisualStyleBackColor = True
        '
        'btnstudy
        '
        Me.btnstudy.Font = New System.Drawing.Font("Elephant", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstudy.ForeColor = System.Drawing.Color.Red
        Me.btnstudy.Location = New System.Drawing.Point(804, 188)
        Me.btnstudy.Name = "btnstudy"
        Me.btnstudy.Size = New System.Drawing.Size(258, 143)
        Me.btnstudy.TabIndex = 1
        Me.btnstudy.Text = "Study"
        Me.btnstudy.UseVisualStyleBackColor = True
        '
        'btnkids
        '
        Me.btnkids.Font = New System.Drawing.Font("Elephant", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkids.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnkids.Location = New System.Drawing.Point(1065, 360)
        Me.btnkids.Name = "btnkids"
        Me.btnkids.Size = New System.Drawing.Size(265, 156)
        Me.btnkids.TabIndex = 2
        Me.btnkids.Text = "Kids Song"
        Me.btnkids.UseVisualStyleBackColor = True
        '
        'btnexam
        '
        Me.btnexam.Font = New System.Drawing.Font("Elephant", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexam.ForeColor = System.Drawing.Color.Purple
        Me.btnexam.Location = New System.Drawing.Point(1332, 535)
        Me.btnexam.Name = "btnexam"
        Me.btnexam.Size = New System.Drawing.Size(264, 147)
        Me.btnexam.TabIndex = 3
        Me.btnexam.Text = "Attend Exam"
        Me.btnexam.UseVisualStyleBackColor = True
        '
        'Mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1633, 723)
        Me.Controls.Add(Me.btnexam)
        Me.Controls.Add(Me.btnkids)
        Me.Controls.Add(Me.btnstudy)
        Me.Controls.Add(Me.btnrstud)
        Me.Name = "Mainform"
        Me.Text = "Mainform"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnrstud As System.Windows.Forms.Button
    Friend WithEvents btnstudy As System.Windows.Forms.Button
    Friend WithEvents btnkids As System.Windows.Forms.Button
    Friend WithEvents btnexam As System.Windows.Forms.Button
End Class
