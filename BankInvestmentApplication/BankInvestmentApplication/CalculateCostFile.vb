Option Strict On

Public Class CalculateCostFile

    Private _strName As String
    Private _intAccountNumber As Integer
    Private _decDepositedAmount As Decimal
    Private _strAccountType As String
    Private _Checking As Boolean
    Private _Savings As Boolean
    Private _OneYearCD As Boolean
    Private _TwoYearCD As Boolean
    Private _FiveYearCD As Boolean
    Private _decProjectionAmount As Decimal

    Sub New(ByVal Name As String, ByVal AccountNumber As Integer, ByVal DepositedAmount As Decimal,
             ByVal Checking As Boolean, ByVal Savings As Boolean,
            ByVal OneYearCD As Boolean, ByVal TwoYearCD As Boolean, ByVal FiveYearCD As Boolean, ByVal ProjectionAmount As Decimal)

        _strName = Name
        _intAccountNumber = AccountNumber
        _decDepositedAmount = Convert.ToInt32(DepositedAmount)
        _Checking = Checking
        _Savings = Savings
        _OneYearCD = OneYearCD
        _TwoYearCD = TwoYearCD
        _FiveYearCD = FiveYearCD
        _decProjectionAmount = Convert.ToInt32(ProjectionAmount)

        If _Checking Then
            _strAccountType = "Checking"
        End If

        If _Savings Then
            _strAccountType = "Savings"
        ElseIf _OneYearCD Then
            _strAccountType = "One Year CD"
        ElseIf _TwoYearCD Then
            _strAccountType = "Two Year CD"
        ElseIf _FiveYearCD Then
            _strAccountType = "Five Year CD"
        End If

    End Sub

    Sub WriteRecord()

        Dim strNameAndLocationOfFile As String = "C:\Users\LisaKilker\Documents\Visual Studio 2012\Projects\BankInvestmentApplication\bankaccountinfo.txt"

        Try
            Dim objWriter As IO.StreamWriter = IO.File.AppendText(strNameAndLocationOfFile)

            objWriter.Write(_strName & ",")
            objWriter.Write(_intAccountNumber & ",")
            objWriter.Write(_decDepositedAmount & ",")
            objWriter.Write(_strAccountType & ",")
            objWriter.WriteLine(_decProjectionAmount)
            objWriter.Close()

        Catch ex As Exception
            MsgBox("That File Does Not Exist", , "ERROR")
            Application.Exit()
        End Try

    End Sub
End Class
