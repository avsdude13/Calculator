Public Class Calculator
    Private NumberOne As Decimal
    Private NumberTwo As Decimal
    Private Operation As String
    Private NumberOneSignPositive As Boolean
    Private NumberTwoSignPositive As Boolean
    Private DecimalBoolean As Boolean
    Private NumberTracker As Integer = 1
    Private NewDigit As String
    Private ExistingDigits As String
    Private Output As String

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearAllButton.Click
        Display.Clear()
        ResetVariables()
    End Sub

    Private Sub SignButton_Click(sender As Object, e As EventArgs) Handles SignButton.Click
        If NumberTracker = 1 Then
            NumberOneSignPositive = False
        ElseIf NumberTracker = 2 Then
            NumberTwoSignPositive = False
        End If
    End Sub

    Private Sub SpecialtyOperations_Click(sender As Object, e As EventArgs) Handles PercentButton.Click, SquareRootButton.Click, InverseButton.Click
        Dim OperationType As String
        OperationType = CType(sender, Button).Name
        Select OperationType
            Case "PercentButton"
                DisplayResult((NumberOne * 100).ToString)
            Case "SquareRootButton"
                DisplayResult((Math.Sqrt(NumberOne)).ToString)
            Case "InverseButton"
                DisplayResult((1 / NumberOne).ToString)
        End Select
    End Sub

    Private Sub Operations_Click(sender As Object, e As EventArgs) Handles DivisionButton.Click, MultiplicationButton.Click, SubtractionButton.Click, PlusButton.Click
        'store operation as string
        'increment numbertracker
        'clear display
    End Sub

    Private Sub EqualButton_Click(sender As Object, e As EventArgs) Handles EqualButton.Click
        'take first number from mem, operation and second number from memory and do operation
        'save values, operator and result into output string
        'call display
        'call reset
    End Sub

    Private Sub Digits_Click(sender As Object, e As EventArgs) Handles ButtonZero.Click, ButtonOne.Click, ButtonTwo.Click, ButtonThree.Click, ButtonFour.Click, ButtonFive.Click, ButtonSix.Click, ButtonSeven.Click, ButtonEight.Click, ButtonNine.Click, DecimalButton.Click
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
                If DecimalBoolean = False Then
                    NewDigit = "."
                    ExistingDigits = ExistingDigits + NewDigit
                End If
        End Select
        Display.Text = ExistingDigits
    End Sub

    Function DisplayResult(ByRef TextToDisplay As String)
        Return Display.Text = TextToDisplay
    End Function

    Function ResetVariables() As Boolean
        NumberOne = 0
        NumberTwo = 0
        Operation = ""
        NumberOneSignPositive = True
        NumberTwoSignPositive = True
        NumberTracker = 1
        ExistingDigits = ""
        Return True
    End Function

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click

    End Sub
End Class
