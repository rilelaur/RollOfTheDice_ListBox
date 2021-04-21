'Laura Riley
'RCET 0265
'Spring 2021
'Roll Of The Dice
'https://github.com/rilelaur/RollOfTheDice_ListBox.git

Public Class RollOfTheDiceForm

    'Closes the form
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    'Clears the list box
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        RollOfTheDiceListBox.Items.Clear()
    End Sub

    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click
        Dim roll(12) As Integer
        Dim number As String = ""
        Dim rolledRow As String = ""

        RollOfTheDiceListBox.Items.Add(StrDup(38, " ") & "Roll of the dice")

        'rolls the dice 1000 times and increments whichever number that is generated
        For i = 1 To 1000
            roll(RandomNumber(6) + RandomNumber(6)) += 1
        Next

        'writes the line above the row
        RollOfTheDiceListBox.Items.Add(StrDup(94, "-"))

        'generates the number row
        For i = 2 To 12
            number &= i.ToString.PadLeft(7) & "|"
        Next

        'writes the number row
        RollOfTheDiceListBox.Items.Add(number)

        'starts a new line and then writes a line of dashes
        RollOfTheDiceListBox.Items.Add(StrDup(94, "-"))

        'fills the array for the "rolled" amount
        For i = 2 To roll.GetUpperBound(0)
            rolledRow &= roll(i).ToString.PadLeft(7) & "|"
        Next

        'writes the rolled numbers line
        RollOfTheDiceListBox.Items.Add(rolledRow)

    End Sub

    'Generates a random number
    Function RandomNumber(maxNumber As Integer) As Integer
        Randomize(DateTime.Now.Millisecond)
        Return CInt(Math.Ceiling(Rnd() * maxNumber))
    End Function

End Class
