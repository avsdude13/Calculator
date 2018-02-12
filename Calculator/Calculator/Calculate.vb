'Program: Final Exam Calculator
'Programmer: Matt Kline
'Date 5/2/16
'Description: This program is a calculator that will keep track of 2 numbers and an operation and will calculate 
'             the operation on the given numbers. This program will also do 5 scientific calculations and allow 
'             the user to see their past calculations.

Public Class Calculator
    Private NumberOne, NumberTwo, Result As Decimal
    Private SignPositive As Boolean = True
    Private HasDecimalPoint As Boolean = False
    Private NumberTracker As Integer = 1
    Private NewDigit, ExistingDigits, EntireEntry, Operation As String
    Private Memory(20) As String
    Private CurrentLineTracker As Integer

    Private Sub ClearAllButton_Click(sender As Object, e As EventArgs) Handles ClearAllButton.Click
        'This sub will clear all of the variables that are being used to keep track of the data and clear the array that the values are being stored in

        Display.Clear()
        For index As Integer = 0 To CurrentLineTracker
            Memory(index) = Nothing
        Next
        NumberOne = Nothing
        NumberTwo = Nothing
        Result = Nothing
        Operation = Nothing
        ExistingDigits = Nothing
        SignPositive = True
        NumberTracker = 1
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        'This sub will clear all of the variables that are being used to keep track of the data

        Display.Clear()
        NumberOne = Nothing
        NumberTwo = Nothing
        Result = Nothing
        Operation = Nothing
        ExistingDigits = Nothing
        SignPositive = True
        NumberTracker = 1
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        'This sub will delete the last digit entered
        'Catch for doing operation with given answer
        If ExistingDigits = Nothing Then
            MessageBox.Show("No entry detected,Cannot Delete", "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf ExistingDigits <> Nothing Then
            ExistingDigits = ExistingDigits.Substring(0, ExistingDigits.Length - 1)
        End If

        Display.Text = ExistingDigits
    End Sub

    Private Sub SignButton_Click(sender As Object, e As EventArgs) Handles SignButton.Click
        If ExistingDigits = Nothing Then
            MessageBox.Show("No entry detected, Cannot change sign", "Cannot Change Sign", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf ExistingDigits <> Nothing Then
            If SignPositive Then
                ExistingDigits = ExistingDigits - (2 * ExistingDigits)
            Else
                ExistingDigits = ExistingDigits + (2 * ExistingDigits)
            End If
        End If

        Display.Text = ExistingDigits
    End Sub

    Private Sub SpecialtyOperations_Click(sender As Object, e As EventArgs) Handles PercentButton.Click, SquareRootButton.Click, SquareButton.Click, InverseButton.Click, SinButton.Click, CosButton.Click, TanButton.Click
        'This sub will process the specialty operations that only require one number to do the operation

        Dim OperationType As String = CType(sender, Button).Name

        'Catch for doing operation with given answer
        If ExistingDigits = Nothing Then
            NumberOne = Result
        ElseIf ExistingDigits <> Nothing Then
            NumberOne = Decimal.Parse(ExistingDigits)
        End If

        Select Case OperationType
            Case "PercentButton"
                Result = (NumberOne * 100)
                EntireEntry = NumberOne.ToString + " as a percent = " + Result.ToString + "%"
            Case "SquareRootButton"
                Result = Math.Sqrt(NumberOne)
                EntireEntry = "sqrt(" + NumberOne.ToString + ") = " + Result.ToString
            Case "SquareButton"
                Result = (NumberOne) ^ 2
                EntireEntry = NumberOne.ToString + "^2 = " + Result.ToString
            Case "InverseButton"
                Result = 1 / NumberOne
                EntireEntry = "Inverse of " + NumberOne.ToString + " = 1/" + NumberOne.ToString + " = " + Result.ToString
            Case "SinButton"
                Result = Math.Sin(NumberOne)
                EntireEntry = "Sin(" + NumberOne.ToString + ") = " + Result.ToString
            Case "CosButton"
                Result = Math.Sin(NumberOne)
                EntireEntry = "Cos(" + NumberOne.ToString + ") = " + Result.ToString
            Case "TanButton"
                Result = Math.Sin(NumberOne)
                EntireEntry = "Tan(" + NumberOne.ToString + ") = " + Result.ToString
        End Select

        Display.Text = Result.ToString
        ExistingDigits = Nothing
        HasDecimalPoint = False
        Memory(CurrentLineTracker) = EntireEntry
        NumberTracker = 1
        CurrentLineTracker += 1
    End Sub

    Private Sub Operations_Click(sender As Object, e As EventArgs) Handles DivisionButton.Click, MultiplicationButton.Click, SubtractionButton.Click, PlusButton.Click
        'This sub handles the basic 4 operations and will update the operation key

        Dim OperationType As String = CType(sender, Button).Name

        'Catch for doing operation with given answer
        If ExistingDigits = Nothing Then
            NumberOne = Result
        ElseIf ExistingDigits <> Nothing Then
            NumberOne = Decimal.Parse(ExistingDigits)
        End If

        Select Case OperationType
            Case "DivisionButton"
                Operation = " / "
                EntireEntry = NumberOne.ToString + Operation
            Case "MultiplicationButton"
                Operation = " * "
                EntireEntry = NumberOne.ToString + Operation
            Case "SubtractionButton"
                Operation = " - "
                EntireEntry = NumberOne.ToString + Operation
            Case "PlusButton"
                Operation = " + "
                EntireEntry = NumberOne.ToString + Operation
        End Select

        Display.Text = EntireEntry.ToString
        HasDecimalPoint = False
        ExistingDigits = Nothing
        NumberTracker = 2
    End Sub

    Private Sub EqualButton_Click(sender As Object, e As EventArgs) Handles EqualButton.Click
        'This sub will process the basic operations and display the result

        NumberTwo = Decimal.Parse(ExistingDigits)
        Display.Clear()

        Select Case Operation
            Case " / "
                Try
                    Result = NumberOne / NumberTwo
                Catch DivideByZero As Exception
                    MessageBox.Show("Divide By Zero", "Divide By Zero", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Case " * "
                Result = NumberOne * NumberTwo
            Case " - "
                Result = NumberOne - NumberTwo
            Case " + "
                Result = NumberOne + NumberTwo
        End Select

        Display.Text = Result.ToString
        ExistingDigits = Nothing
        HasDecimalPoint = False
        EntireEntry = EntireEntry + (NumberTwo.ToString) + " = " + (Result.ToString)
        Memory(CurrentLineTracker) = EntireEntry
        NumberTracker = 1
        CurrentLineTracker += 1
    End Sub

    Private Sub Digits_Click(sender As Object, e As EventArgs) Handles ButtonZero.Click, ButtonOne.Click, ButtonTwo.Click, ButtonThree.Click, ButtonFour.Click, ButtonFive.Click, ButtonSix.Click, ButtonSeven.Click, ButtonEight.Click, ButtonNine.Click, DecimalButton.Click
        'This sub takes entry for the digits and displays them as they are entered

        NewDigit = CType(sender, Button).Name
        Select Case NewDigit
            Case "ButtonZero"
                NewDigit = "0"
                ExistingDigits = ExistingDigits + NewDigit
            Case "ButtonOne"
                NewDigit = "1"
                ExistingDigits = ExistingDigits + NewDigit
            Case "ButtonTwo"
                NewDigit = "2"
                ExistingDigits = ExistingDigits + NewDigit
            Case "ButtonThree"
                NewDigit = "3"
                ExistingDigits = ExistingDigits + NewDigit
            Case "ButtonFour"
                NewDigit = "4"
                ExistingDigits = ExistingDigits + NewDigit
            Case "ButtonFive"
                NewDigit = "5"
                ExistingDigits = ExistingDigits + NewDigit
            Case "ButtonSix"
                NewDigit = "6"
                ExistingDigits = ExistingDigits + NewDigit
            Case "ButtonSeven"
                NewDigit = "7"
                ExistingDigits = ExistingDigits + NewDigit
            Case "ButtonEight"
                NewDigit = "8"
                ExistingDigits = ExistingDigits + NewDigit
            Case "ButtonNine"
                NewDigit = "9"
                ExistingDigits = ExistingDigits + NewDigit
            Case "DecimalButton"
                If ExistingDigits = Nothing Then
                    NewDigit = "0."
                    ExistingDigits = ExistingDigits + NewDigit
                    HasDecimalPoint = True
                ElseIf HasDecimalPoint Then
                    MessageBox.Show("Only one Decimal Point is allowed", "Cannot Add Decimal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    NewDigit = "."
                    HasDecimalPoint = True
                    ExistingDigits = ExistingDigits + NewDigit
                End If
        End Select
        Display.Text = ExistingDigits
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub PrintResultsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintResultsToolStripMenuItem.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'This sub is responsible for printing the array storing data 

        Dim HeadingFont As New Font("Arial", 14, FontStyle.Bold)
        Dim PrintFont As New Font("Arial", 12)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim LeftAligned As Single = e.MarginBounds.Left
        Dim Centered As Single = 300
        Dim CenteredOffset As Single = 330
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        Dim FontSizeF As New SizeF

        e.Graphics.DrawString("Calculator Entries", HeadingFont, Brushes.Black, Centered, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle
        e.Graphics.DrawString("By Matt Kline", PrintFont, Brushes.Black, CenteredOffset, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle * 2

        For Each LineTracker As String In Memory
            e.Graphics.DrawString(LineTracker, PrintFont, Brushes.Black, LeftAligned, VerticalPrintLocationSingle)
            VerticalPrintLocationSingle += LineHeightSingle * 2
        Next
    End Sub

    Private Sub SendToFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SendToFileToolStripMenuItem.Click
        'This sub will read all of the memory array and create a file for the data

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim StreamWriter As New System.IO.StreamWriter(SaveFileDialog1.FileName)
            StreamWriter.WriteLine("Calculator Entries")
            StreamWriter.WriteLine("By: Matt Kline")
            StreamWriter.WriteLine("")
            For Each LineTracker As String In Memory
                StreamWriter.WriteLine(LineTracker)
            Next
            StreamWriter.Close()
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        about.ShowDialog()
    End Sub
End Class
