Public Class Loan

    Private decLoanAmount As Decimal
    Private decAPR As Decimal
    Private decLoanLength As Decimal


    Public Sub New()
        LoanAmount = 0
        AnnualPercentageRate = 0
        LoanLength = 0
    End Sub

    Public Sub New(ByVal newLoanAmount As Decimal, ByVal newAPR As Decimal, ByVal newLoanLength As Decimal)
        LoanAmount = newLoanAmount
        AnnualPercentageRate = newAPR
        LoanLength = newLoanLength
    End Sub


    Public Property LoanAmount() As Decimal
        Get
            Return decLoanAmount
        End Get
        Set(ByVal newLoanAmount As Decimal)
            decLoanAmount = newLoanAmount
        End Set
    End Property

    Public Property AnnualPercentageRate() As Decimal
        Get
            Return decAPR
        End Get
        Set(ByVal newAPR As Decimal)
            decAPR = newAPR
        End Set
    End Property

    Public Property LoanLength() As Decimal
        Get
            Return decLoanLength
        End Get
        Set(ByVal newLoanLength As Decimal)
            decLoanLength = newLoanLength
        End Set
    End Property

    Public Overridable Function CalculateMonthlyPayment() 'P = principle, R = interest rate, N = time
        Return (((AnnualPercentageRate / 12) * LoanAmount) / (1 - Math.Pow(1 + AnnualPercentageRate / 12, -LoanLength * 12)))
    End Function

    Public Overridable Function GetEndingBalance(ByVal numberOfMonths)
        Return Math.Pow(1 + AnnualPercentageRate / 12, numberOfMonths) * LoanAmount - ((Math.Pow(1 + AnnualPercentageRate / 12, numberOfMonths) - 1) / (AnnualPercentageRate / 12)) * CalculateMonthlyPayment()

    End Function

End Class
