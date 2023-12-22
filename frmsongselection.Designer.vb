<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsongselection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmsongselection))
        Me.lblselectcategory = New System.Windows.Forms.Label()
        Me.Cmbsong = New System.Windows.Forms.ComboBox()
        Me.btnok = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblselectcategory
        '
        Me.lblselectcategory.AutoSize = True
        Me.lblselectcategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblselectcategory.Location = New System.Drawing.Point(494, 139)
        Me.lblselectcategory.Name = "lblselectcategory"
        Me.lblselectcategory.Size = New System.Drawing.Size(332, 46)
        Me.lblselectcategory.TabIndex = 0
        Me.lblselectcategory.Text = "Select Category:"
        '
        'Cmbsong
        '
        Me.Cmbsong.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbsong.FormattingEnabled = True
        Me.Cmbsong.Items.AddRange(New Object() {"Educational Songs", "Jingle Toons"})
        Me.Cmbsong.Location = New System.Drawing.Point(1100, 139)
        Me.Cmbsong.Name = "Cmbsong"
        Me.Cmbsong.Size = New System.Drawing.Size(320, 39)
        Me.Cmbsong.TabIndex = 1
        '
        'btnok
        '
        Me.btnok.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnok.Location = New System.Drawing.Point(829, 316)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(264, 118)
        Me.btnok.TabIndex = 2
        Me.btnok.Text = "OK"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'frmsongselection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1650, 684)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.Cmbsong)
        Me.Controls.Add(Me.lblselectcategory)
        Me.Name = "frmsongselection"
        Me.Text = "frmsongselection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblselectcategory As System.Windows.Forms.Label
    Friend WithEvents Cmbsong As System.Windows.Forms.ComboBox
    Friend WithEvents btnok As System.Windows.Forms.Button
End Class
