Public Class SimpleInterestLoan
    Inherits Loan

    Public Overrides Function CalculateMonthlyPayment() 'P = principle, R = interest rate, N = time
        Return (LoanAmount * (1 + AnnualPercentageRate * LoanLength)) / (12 * LoanLength)
    End Function

    Public Overrides Function GetEndingBalance(ByVal numberOfMonths)
        Return (LoanAmount - (CalculateMonthlyPayment() - (LoanAmount * AnnualPercentageRate) / 12) * numberOfMonths)
    End Function

End Class
