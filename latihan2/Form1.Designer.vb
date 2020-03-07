<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtID = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.rblevel = New System.Windows.Forms.Label
        Me.cources = New System.Windows.Forms.Label
        Me.txtname = New System.Windows.Forms.TextBox
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.txtcontact = New System.Windows.Forms.TextBox
        Me.rblow = New System.Windows.Forms.RadioButton
        Me.rbmedium = New System.Windows.Forms.RadioButton
        Me.rbhigh = New System.Windows.Forms.RadioButton
        Me.cbchoice = New System.Windows.Forms.ComboBox
        Me.btnCari = New System.Windows.Forms.Button
        Me.btnTambah = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtfind = New System.Windows.Forms.TextBox
        Me.btnReport = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(92, 72)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(15, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 55)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data Entry Cources , Classes and Certification Programs"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Student ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Student Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Contact"
        '
        'rblevel
        '
        Me.rblevel.AutoSize = True
        Me.rblevel.Location = New System.Drawing.Point(12, 180)
        Me.rblevel.Name = "rblevel"
        Me.rblevel.Size = New System.Drawing.Size(66, 13)
        Me.rblevel.TabIndex = 6
        Me.rblevel.Text = "Class Levels"
        '
        'cources
        '
        Me.cources.AutoSize = True
        Me.cources.Location = New System.Drawing.Point(12, 276)
        Me.cources.Name = "cources"
        Me.cources.Size = New System.Drawing.Size(107, 13)
        Me.cources.TabIndex = 7
        Me.cources.Text = "Choice Your Cources"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(90, 98)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(113, 20)
        Me.txtname.TabIndex = 8
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(92, 125)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(137, 20)
        Me.txtaddress.TabIndex = 9
        '
        'txtcontact
        '
        Me.txtcontact.Location = New System.Drawing.Point(92, 151)
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(124, 20)
        Me.txtcontact.TabIndex = 10
        '
        'rblow
        '
        Me.rblow.AutoSize = True
        Me.rblow.Location = New System.Drawing.Point(15, 201)
        Me.rblow.Name = "rblow"
        Me.rblow.Size = New System.Drawing.Size(74, 17)
        Me.rblow.TabIndex = 11
        Me.rblow.TabStop = True
        Me.rblow.Text = "Low-Level"
        Me.rblow.UseVisualStyleBackColor = True
        '
        'rbmedium
        '
        Me.rbmedium.AutoSize = True
        Me.rbmedium.Location = New System.Drawing.Point(15, 224)
        Me.rbmedium.Name = "rbmedium"
        Me.rbmedium.Size = New System.Drawing.Size(91, 17)
        Me.rbmedium.TabIndex = 12
        Me.rbmedium.TabStop = True
        Me.rbmedium.Text = "Medium-Level"
        Me.rbmedium.UseVisualStyleBackColor = True
        '
        'rbhigh
        '
        Me.rbhigh.AutoSize = True
        Me.rbhigh.Location = New System.Drawing.Point(15, 247)
        Me.rbhigh.Name = "rbhigh"
        Me.rbhigh.Size = New System.Drawing.Size(72, 17)
        Me.rbhigh.TabIndex = 13
        Me.rbhigh.TabStop = True
        Me.rbhigh.Text = "High-level"
        Me.rbhigh.UseVisualStyleBackColor = True
        '
        'cbchoice
        '
        Me.cbchoice.FormattingEnabled = True
        Me.cbchoice.Items.AddRange(New Object() {"Mobile Android ", "PHP Language ", "Java language ", "Python ", "MS Office", "VB.NET"})
        Me.cbchoice.Location = New System.Drawing.Point(15, 292)
        Me.cbchoice.Name = "cbchoice"
        Me.cbchoice.Size = New System.Drawing.Size(160, 21)
        Me.cbchoice.TabIndex = 14
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(208, 69)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(64, 25)
        Me.btnCari.TabIndex = 15
        Me.btnCari.Text = "search"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(12, 329)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(58, 25)
        Me.btnTambah.TabIndex = 16
        Me.btnTambah.Text = "Add"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(76, 329)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(54, 27)
        Me.btnUpdate.TabIndex = 17
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(136, 329)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(66, 27)
        Me.btnDelete.TabIndex = 18
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(208, 327)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(55, 27)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(15, 389)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(256, 27)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.DataGridView1.Location = New System.Drawing.Point(293, 69)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(626, 375)
        Me.DataGridView1.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(306, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Keywords"
        '
        'txtfind
        '
        Me.txtfind.Location = New System.Drawing.Point(383, 25)
        Me.txtfind.Name = "txtfind"
        Me.txtfind.Size = New System.Drawing.Size(334, 20)
        Me.txtfind.TabIndex = 23
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(107, 362)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(54, 21)
        Me.btnReport.TabIndex = 24
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(975, 517)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.txtfind)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.cbchoice)
        Me.Controls.Add(Me.rbhigh)
        Me.Controls.Add(Me.rbmedium)
        Me.Controls.Add(Me.rblow)
        Me.Controls.Add(Me.txtcontact)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.cources)
        Me.Controls.Add(Me.rblevel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtID)
        Me.Name = "Form1"
        Me.Text = "latihan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rblevel As System.Windows.Forms.Label
    Friend WithEvents cources As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtcontact As System.Windows.Forms.TextBox
    Friend WithEvents rblow As System.Windows.Forms.RadioButton
    Friend WithEvents rbmedium As System.Windows.Forms.RadioButton
    Friend WithEvents rbhigh As System.Windows.Forms.RadioButton
    Friend WithEvents cbchoice As System.Windows.Forms.ComboBox
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtfind As System.Windows.Forms.TextBox
    Friend WithEvents btnReport As System.Windows.Forms.Button

End Class
