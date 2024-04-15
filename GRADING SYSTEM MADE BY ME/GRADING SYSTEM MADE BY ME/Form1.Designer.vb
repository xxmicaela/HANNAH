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
        Me.lbName = New System.Windows.Forms.Label()
        Me.lbCourse = New System.Windows.Forms.Label()
        Me.lbPrelim = New System.Windows.Forms.Label()
        Me.lbMidterm = New System.Windows.Forms.Label()
        Me.lbSemi = New System.Windows.Forms.Label()
        Me.lbFinal = New System.Windows.Forms.Label()
        Me.lbAverage = New System.Windows.Forms.Label()
        Me.lbRemarks = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.txtPrelim = New System.Windows.Forms.TextBox()
        Me.txtMidterm = New System.Windows.Forms.TextBox()
        Me.txtSemi = New System.Windows.Forms.TextBox()
        Me.txtFinal = New System.Windows.Forms.TextBox()
        Me.Groupbox1 = New System.Windows.Forms.GroupBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.txtAverage = New System.Windows.Forms.TextBox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName.Location = New System.Drawing.Point(129, 43)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(60, 21)
        Me.lbName.TabIndex = 0
        Me.lbName.Text = "Name:"
        '
        'lbCourse
        '
        Me.lbCourse.AutoSize = True
        Me.lbCourse.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCourse.Location = New System.Drawing.Point(12, 76)
        Me.lbCourse.Name = "lbCourse"
        Me.lbCourse.Size = New System.Drawing.Size(177, 21)
        Me.lbCourse.TabIndex = 1
        Me.lbCourse.Text = "Course/Year/Section:"
        '
        'lbPrelim
        '
        Me.lbPrelim.AutoSize = True
        Me.lbPrelim.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPrelim.Location = New System.Drawing.Point(43, 140)
        Me.lbPrelim.Name = "lbPrelim"
        Me.lbPrelim.Size = New System.Drawing.Size(146, 18)
        Me.lbPrelim.TabIndex = 2
        Me.lbPrelim.Text = "PRELIM GRADE:"
        '
        'lbMidterm
        '
        Me.lbMidterm.AutoSize = True
        Me.lbMidterm.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMidterm.Location = New System.Drawing.Point(43, 174)
        Me.lbMidterm.Name = "lbMidterm"
        Me.lbMidterm.Size = New System.Drawing.Size(163, 18)
        Me.lbMidterm.TabIndex = 3
        Me.lbMidterm.Text = "MIDTERM GRADE:"
        '
        'lbSemi
        '
        Me.lbSemi.AutoSize = True
        Me.lbSemi.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSemi.Location = New System.Drawing.Point(43, 206)
        Me.lbSemi.Name = "lbSemi"
        Me.lbSemi.Size = New System.Drawing.Size(163, 21)
        Me.lbSemi.TabIndex = 4
        Me.lbSemi.Text = "SEMI-FINAL GRADE:"
        '
        'lbFinal
        '
        Me.lbFinal.AutoSize = True
        Me.lbFinal.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFinal.Location = New System.Drawing.Point(43, 241)
        Me.lbFinal.Name = "lbFinal"
        Me.lbFinal.Size = New System.Drawing.Size(133, 18)
        Me.lbFinal.TabIndex = 5
        Me.lbFinal.Text = "FINAL GRADE:"
        '
        'lbAverage
        '
        Me.lbAverage.AutoSize = True
        Me.lbAverage.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAverage.Location = New System.Drawing.Point(206, 315)
        Me.lbAverage.Name = "lbAverage"
        Me.lbAverage.Size = New System.Drawing.Size(97, 18)
        Me.lbAverage.TabIndex = 6
        Me.lbAverage.Text = "AVERAGE:"
        '
        'lbRemarks
        '
        Me.lbRemarks.AutoSize = True
        Me.lbRemarks.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRemarks.Location = New System.Drawing.Point(205, 355)
        Me.lbRemarks.Name = "lbRemarks"
        Me.lbRemarks.Size = New System.Drawing.Size(98, 18)
        Me.lbRemarks.TabIndex = 7
        Me.lbRemarks.Text = "REMARKS:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(195, 45)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(307, 20)
        Me.txtName.TabIndex = 8
        '
        'txtCourse
        '
        Me.txtCourse.Location = New System.Drawing.Point(195, 78)
        Me.txtCourse.Multiline = True
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(307, 20)
        Me.txtCourse.TabIndex = 9
        '
        'txtPrelim
        '
        Me.txtPrelim.Location = New System.Drawing.Point(208, 138)
        Me.txtPrelim.Multiline = True
        Me.txtPrelim.Name = "txtPrelim"
        Me.txtPrelim.Size = New System.Drawing.Size(143, 20)
        Me.txtPrelim.TabIndex = 10
        '
        'txtMidterm
        '
        Me.txtMidterm.Location = New System.Drawing.Point(208, 172)
        Me.txtMidterm.Multiline = True
        Me.txtMidterm.Name = "txtMidterm"
        Me.txtMidterm.Size = New System.Drawing.Size(143, 20)
        Me.txtMidterm.TabIndex = 11
        '
        'txtSemi
        '
        Me.txtSemi.Location = New System.Drawing.Point(208, 208)
        Me.txtSemi.Multiline = True
        Me.txtSemi.Name = "txtSemi"
        Me.txtSemi.Size = New System.Drawing.Size(143, 20)
        Me.txtSemi.TabIndex = 12
        '
        'txtFinal
        '
        Me.txtFinal.Location = New System.Drawing.Point(208, 242)
        Me.txtFinal.Multiline = True
        Me.txtFinal.Name = "txtFinal"
        Me.txtFinal.Size = New System.Drawing.Size(143, 20)
        Me.txtFinal.TabIndex = 13
        '
        'Groupbox1
        '
        Me.Groupbox1.Location = New System.Drawing.Point(16, 32)
        Me.Groupbox1.Name = "Groupbox1"
        Me.Groupbox1.Size = New System.Drawing.Size(501, 78)
        Me.Groupbox1.TabIndex = 14
        Me.Groupbox1.TabStop = False
        Me.Groupbox1.Text = "........."
        '
        'btnCompute
        '
        Me.btnCompute.BackColor = System.Drawing.Color.RosyBrown
        Me.btnCompute.Font = New System.Drawing.Font("Mongolian Baiti", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.Location = New System.Drawing.Point(362, 221)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(90, 41)
        Me.btnCompute.TabIndex = 15
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = False
        '
        'txtAverage
        '
        Me.txtAverage.Location = New System.Drawing.Point(309, 313)
        Me.txtAverage.Multiline = True
        Me.txtAverage.Name = "txtAverage"
        Me.txtAverage.Size = New System.Drawing.Size(143, 20)
        Me.txtAverage.TabIndex = 16
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(309, 355)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(143, 20)
        Me.txtRemarks.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.ClientSize = New System.Drawing.Size(571, 410)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.txtAverage)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.txtFinal)
        Me.Controls.Add(Me.txtSemi)
        Me.Controls.Add(Me.txtMidterm)
        Me.Controls.Add(Me.txtPrelim)
        Me.Controls.Add(Me.txtCourse)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lbRemarks)
        Me.Controls.Add(Me.lbAverage)
        Me.Controls.Add(Me.lbFinal)
        Me.Controls.Add(Me.lbSemi)
        Me.Controls.Add(Me.lbMidterm)
        Me.Controls.Add(Me.lbPrelim)
        Me.Controls.Add(Me.lbCourse)
        Me.Controls.Add(Me.lbName)
        Me.Controls.Add(Me.Groupbox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbName As System.Windows.Forms.Label
    Friend WithEvents lbCourse As System.Windows.Forms.Label
    Friend WithEvents lbPrelim As System.Windows.Forms.Label
    Friend WithEvents lbMidterm As System.Windows.Forms.Label
    Friend WithEvents lbSemi As System.Windows.Forms.Label
    Friend WithEvents lbFinal As System.Windows.Forms.Label
    Friend WithEvents lbAverage As System.Windows.Forms.Label
    Friend WithEvents lbRemarks As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtCourse As System.Windows.Forms.TextBox
    Friend WithEvents txtPrelim As System.Windows.Forms.TextBox
    Friend WithEvents txtMidterm As System.Windows.Forms.TextBox
    Friend WithEvents txtSemi As System.Windows.Forms.TextBox
    Friend WithEvents txtFinal As System.Windows.Forms.TextBox
    Friend WithEvents Groupbox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents txtAverage As System.Windows.Forms.TextBox
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox

End Class
