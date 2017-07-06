Option Strict On
Public Class CD

    Inherits Account

    Dim objCalculateCostFile As CalculateCostFile

    Sub New(ByVal Name As String, ByVal AccountNumber As String,
             ByVal DepositedAmounted As String, ByVal Savings As Boolean, ByVal OneYearCD As Boolean,
             ByVal TwoYearCD As Boolean, ByVal FiveYearCD As Boolean)

        MyBase.New(Name, AccountNumber, DepositedAmounted)

        _Savings = Savings
        _OneYearCD = OneYearCD
        _TwoYearCD = TwoYearCD
        _FiveYearCD = FiveYearCD

    End Sub

    Overrides Function ComputeCosts() As Decimal

        Const cdecSavingsInterest As Decimal = 0.0175D
        Const cdecOneYearCDInterest As Decimal = 0.0185D
        Const cdecTwoYearCDInterest As Decimal = 0.023D
        Const cdecFiveYearCDInterest As Decimal = 0.0237D

        If _Savings Then
            _decProjectionAmount = _decDepositedAmount + (cdecSavingsInterest * _decDepositedAmount)

        ElseIf _OneYearCD Then
            _decProjectionAmount = _decDepositedAmount + (cdecOneYearCDInterest * _decDepositedAmount)

        ElseIf _TwoYearCD Then
            _decProjectionAmount = _decDepositedAmount + (cdecTwoYearCDInterest * _decDepositedAmount)

        ElseIf _FiveYearCD Then
            _decProjectionAmount = _decDepositedAmount + (cdecFiveYearCDInterest * _decDepositedAmount)
        End If

        objCalculateCostFile = New CalculateCostFile(_strName, _intAccountNumber, _decDepositedAmount, _Checking, _Savings, _OneYearCD, _TwoYearCD, _FiveYearCD, _decProjectionAmount)
        objCalculateCostFile.WriteRecord()

        Return _decProjectionAmount
    End Function

End Class
