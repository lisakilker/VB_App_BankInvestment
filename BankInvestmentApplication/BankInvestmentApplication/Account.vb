Option Strict On

Public Class Account

    Protected _strName As String
    Protected _intAccountNumber As Integer
    Protected _decDepositedAmount As Decimal
    Protected _strAccountType As String
    Protected _Checking As Boolean
    Protected _Savings As Boolean
    Protected _OneYearCD As Boolean
    Protected _TwoYearCD As Boolean
    Protected _FiveYearCD As Boolean
    Protected _decProjectionAmount As Decimal

    Dim objCalculateCostFile As CalculateCostFile

    Sub New(ByVal strName As String, ByVal intAccountNumber As String, ByVal decDepositedAmount As String)

        _strName = strName
        _intAccountNumber = Convert.ToInt32(intAccountNumber)
        _decDepositedAmount = Convert.ToDecimal(decDepositedAmount)


    End Sub

    Overridable Function ComputeCosts() As Decimal

        Dim _Checking As Boolean = True

        _decProjectionAmount = _decDepositedAmount - (25 * 12)

        objCalculateCostFile = New CalculateCostFile(_strName, _intAccountNumber, _decDepositedAmount, _Checking, _Savings, _OneYearCD, _TwoYearCD, _FiveYearCD, _decProjectionAmount)
        objCalculateCostFile.WriteRecord()

        Return _decProjectionAmount
    End Function
End Class
