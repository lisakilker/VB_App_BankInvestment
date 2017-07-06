Option Strict On

Public Class frmBankInvestment

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Clear()
        txtName.Focus()
        txtAccountNumber.Clear()
        txtDepositAmount.Clear()
        radSavings.Checked = False
        radOneYearCD.Checked = False
        radTwoYearCD.Checked = False
        radFiveYearCD.Checked = False
        lblDisplayProjection.Visible = False
        lblChecking.Visible = False
        lblSavings.Visible = False
        lblOneYearCD.Visible = False
        lblTwoYearCD.Visible = False
        lblFiveYearCD.Visible = False
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim objAccount As Account
        Dim objCD As CD
        Dim InputError As Boolean = False

        If txtName.TextLength < 1 Or txtName.Text < "A" Then
            MsgBox("Please enter your name", , "Entry Error")
            txtName.Clear()
            txtName.Focus()
            InputError = True

        ElseIf txtAccountNumber.MaskFull = False Then
            MsgBox("Please Enter Your Account Number as a Numeric Value", , "Entry Error")
            txtAccountNumber.Clear()
            txtAccountNumber.Focus()
            InputError = True

        ElseIf Not IsNumeric(txtDepositAmount.Text) Then
            MsgBox("Please Enter a Deposit Amount", , "Entry Error")
            txtDepositAmount.Clear()
            txtDepositAmount.Focus()
            InputError = True

        ElseIf Convert.ToInt32(txtDepositAmount.Text) < 1000 Or Convert.ToInt32(txtDepositAmount.Text) > 100000 Then
            MsgBox("Please Enter a Deposit Amount between $1,000 and $99,999", , "Entry Error")
            txtDepositAmount.Clear()
            txtDepositAmount.Focus()
            InputError = True
        End If

        If Not InputError Then

            If radChecking.Checked = True And radSavings.Checked = False And radOneYearCD.Checked = False And radTwoYearCD.Checked = False And radFiveYearCD.Checked = False Then
                objAccount = New Account(txtName.Text, txtAccountNumber.Text, txtDepositAmount.Text)
                lblDisplayProjection.Visible = True
                lblDisplayProjection.Text = "Your amount after one year, minus montly surcharges is: " & (objAccount.ComputeCosts()).ToString("C2")

            Else
                objCD = New CD(txtName.Text, txtAccountNumber.Text, txtDepositAmount.Text, radSavings.Checked, radOneYearCD.Checked, radTwoYearCD.Checked, radFiveYearCD.Checked)
                lblDisplayProjection.Visible = True
                lblDisplayProjection.Text = "Your projected account value after one year is: " & (objCD.ComputeCosts()).ToString("C2")
            End If
        End If

    End Sub

    Private Sub radChecking_CheckedChanged(sender As Object, e As EventArgs) Handles radChecking.CheckedChanged
        lblChecking.Visible = True
        lblSavings.Visible = False
        lblOneYearCD.Visible = False
        lblTwoYearCD.Visible = False
        lblFiveYearCD.Visible = False
    End Sub

    Private Sub radSavings_CheckedChanged(sender As Object, e As EventArgs) Handles radSavings.CheckedChanged
        lblSavings.Visible = True
        lblChecking.Visible = False
        lblOneYearCD.Visible = False
        lblTwoYearCD.Visible = False
        lblFiveYearCD.Visible = False
    End Sub

    Private Sub radOneYearCD_CheckedChanged(sender As Object, e As EventArgs) Handles radOneYearCD.CheckedChanged
        lblOneYearCD.Visible = True
        lblChecking.Visible = False
        lblSavings.Visible = False
        lblTwoYearCD.Visible = False
        lblFiveYearCD.Visible = False
    End Sub

    Private Sub radTwoYearCD_CheckedChanged(sender As Object, e As EventArgs) Handles radTwoYearCD.CheckedChanged
        lblTwoYearCD.Visible = True
        lblChecking.Visible = False
        lblSavings.Visible = False
        lblOneYearCD.Visible = False
        lblFiveYearCD.Visible = False
    End Sub

    Private Sub radFiveYearCD_CheckedChanged(sender As Object, e As EventArgs) Handles radFiveYearCD.CheckedChanged
        lblFiveYearCD.Visible = True
        lblChecking.Visible = False
        lblSavings.Visible = False
        lblOneYearCD.Visible = False
        lblTwoYearCD.Visible = False
    End Sub

End Class
