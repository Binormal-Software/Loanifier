Public Class LoanCalculator

    Private Sub Calculate(sender As Object, e As EventArgs) Handles CalculateButton.Click, CalculateToolButton.Click, CalculateToolStripMenuItem.Click
        Try

            DisplayListBox.Items.Clear()

            If CDec(YearlyInterestTextBox.Text) > 1 Or CDec(YearlyInterestTextBox.Text) < 0 Then
                Throw New ArgumentOutOfRangeException
            End If

            Dim newLoan As Loan

            If LoanTypeCheckBox.Checked Then
                newLoan = New SimpleInterestLoan()
            Else
                newLoan = New Loan()
            End If

            newLoan.LoanAmount = CDec(LoanAmountTextBox.Text)
            newLoan.AnnualPercentageRate = CDec(YearlyInterestTextBox.Text)
            newLoan.LoanLength = CDec(YearTextBox.Text)

            DisplayListBox.Items.Add("Month" & vbTab & "Monthly Payment" & vbTab & "Ending Balance")
            For i As Integer = 1 To newLoan.LoanLength * 12
                DisplayListBox.Items.Add(i & vbTab & Math.Round(newLoan.CalculateMonthlyPayment, 6) & vbTab & Math.Round(newLoan.GetEndingBalance(i), 6))
            Next

        Catch ex As InvalidCastException
            MessageBox.Show(My.Resources.InvalidInputString, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As ArgumentOutOfRangeException
            MessageBox.Show(My.Resources.OutOfRangeString, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show(My.Resources.UnknownErrorString & ex.Message & ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Clear(sender As Object, e As EventArgs) Handles ClearButton.Click, ClearEntriesToolStripMenuItem.Click, NewEntryToolButton.Click
        LoanAmountTextBox.Clear()
        YearTextBox.Clear()
        YearlyInterestTextBox.Clear()
        DisplayListBox.Items.Clear()
    End Sub

    Private Sub ExitProgram(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click, ExitToolButton.Click
        Close()
    End Sub

    Private Sub About(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show(My.Resources.AboutString, "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class
