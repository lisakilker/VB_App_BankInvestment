<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBankInvestment
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAccountNumber = New System.Windows.Forms.Label()
        Me.lblDisplayProjection = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblDepositAmount = New System.Windows.Forms.Label()
        Me.txtDepositAmount = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtAccountNumber = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblFiveYearCD = New System.Windows.Forms.Label()
        Me.lblTwoYearCD = New System.Windows.Forms.Label()
        Me.lblOneYearCD = New System.Windows.Forms.Label()
        Me.lblSavings = New System.Windows.Forms.Label()
        Me.lblChecking = New System.Windows.Forms.Label()
        Me.radChecking = New System.Windows.Forms.RadioButton()
        Me.radFiveYearCD = New System.Windows.Forms.RadioButton()
        Me.radTwoYearCD = New System.Windows.Forms.RadioButton()
        Me.radOneYearCD = New System.Windows.Forms.RadioButton()
        Me.radSavings = New System.Windows.Forms.RadioButton()
        Me.imgPicture = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.imgPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(15, 192)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(72, 15)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Your Name:"
        '
        'lblAccountNumber
        '
        Me.lblAccountNumber.AutoSize = True
        Me.lblAccountNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountNumber.Location = New System.Drawing.Point(15, 231)
        Me.lblAccountNumber.Name = "lblAccountNumber"
        Me.lblAccountNumber.Size = New System.Drawing.Size(101, 15)
        Me.lblAccountNumber.TabIndex = 1
        Me.lblAccountNumber.Text = "Account Number:"
        '
        'lblDisplayProjection
        '
        Me.lblDisplayProjection.AutoSize = True
        Me.lblDisplayProjection.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplayProjection.ForeColor = System.Drawing.Color.Red
        Me.lblDisplayProjection.Location = New System.Drawing.Point(121, 394)
        Me.lblDisplayProjection.Name = "lblDisplayProjection"
        Me.lblDisplayProjection.Size = New System.Drawing.Size(105, 15)
        Me.lblDisplayProjection.TabIndex = 20
        Me.lblDisplayProjection.Text = "Display Projection"
        Me.lblDisplayProjection.Visible = False
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(134, 186)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(159, 21)
        Me.txtName.TabIndex = 1
        '
        'lblDepositAmount
        '
        Me.lblDepositAmount.AutoSize = True
        Me.lblDepositAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepositAmount.Location = New System.Drawing.Point(15, 271)
        Me.lblDepositAmount.Name = "lblDepositAmount"
        Me.lblDepositAmount.Size = New System.Drawing.Size(97, 15)
        Me.lblDepositAmount.TabIndex = 8
        Me.lblDepositAmount.Text = "Deposit Amount:"
        '
        'txtDepositAmount
        '
        Me.txtDepositAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepositAmount.Location = New System.Drawing.Point(134, 265)
        Me.txtDepositAmount.Name = "txtDepositAmount"
        Me.txtDepositAmount.Size = New System.Drawing.Size(121, 21)
        Me.txtDepositAmount.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(143, 338)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(140, 39)
        Me.btnCalculate.TabIndex = 9
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(308, 338)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(129, 39)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(303, 36)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(191, 76)
        Me.lblTitle.TabIndex = 21
        Me.lblTitle.Text = "Investment" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Projection"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtAccountNumber
        '
        Me.txtAccountNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountNumber.Location = New System.Drawing.Point(134, 225)
        Me.txtAccountNumber.Mask = "00000"
        Me.txtAccountNumber.Name = "txtAccountNumber"
        Me.txtAccountNumber.Size = New System.Drawing.Size(41, 21)
        Me.txtAccountNumber.TabIndex = 2
        Me.txtAccountNumber.ValidatingType = GetType(Integer)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblFiveYearCD)
        Me.GroupBox2.Controls.Add(Me.lblTwoYearCD)
        Me.GroupBox2.Controls.Add(Me.lblOneYearCD)
        Me.GroupBox2.Controls.Add(Me.lblSavings)
        Me.GroupBox2.Controls.Add(Me.lblChecking)
        Me.GroupBox2.Controls.Add(Me.radChecking)
        Me.GroupBox2.Controls.Add(Me.radFiveYearCD)
        Me.GroupBox2.Controls.Add(Me.radTwoYearCD)
        Me.GroupBox2.Controls.Add(Me.radOneYearCD)
        Me.GroupBox2.Controls.Add(Me.radSavings)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(319, 178)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(243, 142)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Choose Account Type:"
        '
        'lblFiveYearCD
        '
        Me.lblFiveYearCD.AutoSize = True
        Me.lblFiveYearCD.ForeColor = System.Drawing.Color.Red
        Me.lblFiveYearCD.Location = New System.Drawing.Point(111, 118)
        Me.lblFiveYearCD.Name = "lblFiveYearCD"
        Me.lblFiveYearCD.Size = New System.Drawing.Size(126, 15)
        Me.lblFiveYearCD.TabIndex = 19
        Me.lblFiveYearCD.Text = "2.37% annual interest"
        Me.lblFiveYearCD.Visible = False
        '
        'lblTwoYearCD
        '
        Me.lblTwoYearCD.AutoSize = True
        Me.lblTwoYearCD.ForeColor = System.Drawing.Color.Red
        Me.lblTwoYearCD.Location = New System.Drawing.Point(111, 94)
        Me.lblTwoYearCD.Name = "lblTwoYearCD"
        Me.lblTwoYearCD.Size = New System.Drawing.Size(126, 15)
        Me.lblTwoYearCD.TabIndex = 18
        Me.lblTwoYearCD.Text = "2.30% annual interest"
        Me.lblTwoYearCD.Visible = False
        '
        'lblOneYearCD
        '
        Me.lblOneYearCD.AutoSize = True
        Me.lblOneYearCD.ForeColor = System.Drawing.Color.Red
        Me.lblOneYearCD.Location = New System.Drawing.Point(111, 70)
        Me.lblOneYearCD.Name = "lblOneYearCD"
        Me.lblOneYearCD.Size = New System.Drawing.Size(126, 15)
        Me.lblOneYearCD.TabIndex = 17
        Me.lblOneYearCD.Text = "1.85% annual interest"
        Me.lblOneYearCD.Visible = False
        '
        'lblSavings
        '
        Me.lblSavings.AutoSize = True
        Me.lblSavings.ForeColor = System.Drawing.Color.Red
        Me.lblSavings.Location = New System.Drawing.Point(111, 46)
        Me.lblSavings.Name = "lblSavings"
        Me.lblSavings.Size = New System.Drawing.Size(126, 15)
        Me.lblSavings.TabIndex = 16
        Me.lblSavings.Text = "1.75% annual interest"
        Me.lblSavings.Visible = False
        '
        'lblChecking
        '
        Me.lblChecking.AutoSize = True
        Me.lblChecking.ForeColor = System.Drawing.Color.Red
        Me.lblChecking.Location = New System.Drawing.Point(111, 22)
        Me.lblChecking.Name = "lblChecking"
        Me.lblChecking.Size = New System.Drawing.Size(107, 15)
        Me.lblChecking.TabIndex = 15
        Me.lblChecking.Text = "$25 per month fee"
        Me.lblChecking.Visible = False
        '
        'radChecking
        '
        Me.radChecking.AutoSize = True
        Me.radChecking.Checked = True
        Me.radChecking.Location = New System.Drawing.Point(6, 20)
        Me.radChecking.Name = "radChecking"
        Me.radChecking.Size = New System.Drawing.Size(76, 19)
        Me.radChecking.TabIndex = 4
        Me.radChecking.TabStop = True
        Me.radChecking.Text = "Checking"
        Me.radChecking.UseVisualStyleBackColor = True
        '
        'radFiveYearCD
        '
        Me.radFiveYearCD.AutoSize = True
        Me.radFiveYearCD.Location = New System.Drawing.Point(6, 116)
        Me.radFiveYearCD.Name = "radFiveYearCD"
        Me.radFiveYearCD.Size = New System.Drawing.Size(95, 19)
        Me.radFiveYearCD.TabIndex = 8
        Me.radFiveYearCD.TabStop = True
        Me.radFiveYearCD.Text = "Five Year CD"
        Me.radFiveYearCD.UseVisualStyleBackColor = True
        '
        'radTwoYearCD
        '
        Me.radTwoYearCD.AutoSize = True
        Me.radTwoYearCD.Location = New System.Drawing.Point(6, 92)
        Me.radTwoYearCD.Name = "radTwoYearCD"
        Me.radTwoYearCD.Size = New System.Drawing.Size(96, 19)
        Me.radTwoYearCD.TabIndex = 7
        Me.radTwoYearCD.TabStop = True
        Me.radTwoYearCD.Text = "Two Year CD"
        Me.radTwoYearCD.UseVisualStyleBackColor = True
        '
        'radOneYearCD
        '
        Me.radOneYearCD.AutoSize = True
        Me.radOneYearCD.Location = New System.Drawing.Point(6, 68)
        Me.radOneYearCD.Name = "radOneYearCD"
        Me.radOneYearCD.Size = New System.Drawing.Size(96, 19)
        Me.radOneYearCD.TabIndex = 6
        Me.radOneYearCD.TabStop = True
        Me.radOneYearCD.Text = "One Year CD"
        Me.radOneYearCD.UseVisualStyleBackColor = True
        '
        'radSavings
        '
        Me.radSavings.AutoSize = True
        Me.radSavings.Location = New System.Drawing.Point(6, 44)
        Me.radSavings.Name = "radSavings"
        Me.radSavings.Size = New System.Drawing.Size(68, 19)
        Me.radSavings.TabIndex = 5
        Me.radSavings.TabStop = True
        Me.radSavings.Text = "Savings"
        Me.radSavings.UseVisualStyleBackColor = True
        '
        'imgPicture
        '
        Me.imgPicture.Image = Global.BankInvestmentApplication.My.Resources.Resources.ase21
        Me.imgPicture.Location = New System.Drawing.Point(1, 2)
        Me.imgPicture.Name = "imgPicture"
        Me.imgPicture.Size = New System.Drawing.Size(225, 165)
        Me.imgPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgPicture.TabIndex = 16
        Me.imgPicture.TabStop = False
        '
        'frmBankInvestment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(581, 429)
        Me.Controls.Add(Me.imgPicture)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtAccountNumber)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtDepositAmount)
        Me.Controls.Add(Me.lblDepositAmount)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblDisplayProjection)
        Me.Controls.Add(Me.lblAccountNumber)
        Me.Controls.Add(Me.lblName)
        Me.Name = "frmBankInvestment"
        Me.Text = "Tenth Street Regional Bank"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.imgPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblAccountNumber As System.Windows.Forms.Label
    Friend WithEvents lblDisplayProjection As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblDepositAmount As System.Windows.Forms.Label
    Friend WithEvents txtDepositAmount As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents txtAccountNumber As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radChecking As System.Windows.Forms.RadioButton
    Friend WithEvents radFiveYearCD As System.Windows.Forms.RadioButton
    Friend WithEvents radTwoYearCD As System.Windows.Forms.RadioButton
    Friend WithEvents radOneYearCD As System.Windows.Forms.RadioButton
    Friend WithEvents radSavings As System.Windows.Forms.RadioButton
    Friend WithEvents lblFiveYearCD As System.Windows.Forms.Label
    Friend WithEvents lblTwoYearCD As System.Windows.Forms.Label
    Friend WithEvents lblOneYearCD As System.Windows.Forms.Label
    Friend WithEvents lblSavings As System.Windows.Forms.Label
    Friend WithEvents lblChecking As System.Windows.Forms.Label
    Friend WithEvents imgPicture As System.Windows.Forms.PictureBox

End Class
