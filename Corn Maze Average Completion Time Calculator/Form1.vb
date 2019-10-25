'Program Name: Corn Maze Average Time
'Author: Daiki Naruke
'Date: 10/25/19
'Description: This program asks the user for the completion times of each team member for up to 10 team members
'and then calculates the average completion time for the team.
Public Class frmCornMaze
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblAvgCompletionTime.Click

    End Sub

    Private Sub btnTimes_Click(sender As Object, e As EventArgs) Handles btnTimes.Click

        'Variables needed for the program
        Dim strCompletionTime As String = ""
        Dim decCompletionTime As Decimal
        Dim decTotalCompletionTime As Decimal = 0
        Dim avgCompletionTime As Decimal
        Dim strInputMessage As String = "Enter in the completion time for team member #"
        Dim strInputHeading As String = "Completion Times"
        Dim strCancelClicked As String = ""
        Dim intMaxEntries As Integer = 10
        Dim intNumberOfEntries As Integer = 1

        strCompletionTime = InputBox(strInputMessage & intNumberOfEntries, strInputHeading)
        'This statement is priming the loop

        'Complicated Do Until Loop with if statements to check to see if the user entered in a negative 
        'number or something that is not a number. If the user enters in a negative number or a non number,
        'errors are thrown out. If the user enters In a positive number, than a body
        'of statements exectues that adds the user input to decTotalCompletionTime, increases 
        'intNumberOfEntries, and adds the user input into the list box. The Do Until Loop exectues
        'until the number of entries becomes greater than the max number of entries or until the user 
        'clicks cancel in which case if at least one time was entered, the average would be calculated
        Do Until intNumberOfEntries > intMaxEntries Or strCompletionTime = strCancelClicked
            If (IsNumeric(strCompletionTime)) Then
                decCompletionTime = Convert.ToDecimal(strCompletionTime)
                If (decCompletionTime > 0) Then
                    decTotalCompletionTime = decTotalCompletionTime + decCompletionTime
                    intNumberOfEntries = intNumberOfEntries + 1
                    lstTimes.Items.Add(decCompletionTime)
                Else MsgBox("Please enter in a postive number.",, "User Input Error")
                End If
            Else MsgBox("Please enter in a number.",, "User Input Error")
            End If

            'If statement that checks to make sure intNumberOfEntries is less than or equal to intMaxEntries.
            'As long as that is true, it will keep putting up the input box and take values and assign it to
            'strCompletionTime. It is less than or equal to because, at this point in the code 
            'intNumberOfEntries will be one more than the number of entries entered. So, you want it to stop
            'reading values (the code in the if statement), when intNumberOfEntries is 11 (when 10 values have
            'been entered), and since we already had an intMaxEntries as 10, we wanted to use that, so if we 
            'use 10, then it will be less the than or equal to to. make it stop when intNumberOfEntries is 11.
            If (intNumberOfEntries <= intMaxEntries) Then
                strCompletionTime = InputBox(strInputMessage & intNumberOfEntries, strInputHeading)
            End If
        Loop

        'If statement to check to make sure that intNumberOfEntries is greater than one. (If at least one 
        'value was entered in, then intNumberOfEntries would be 2) If nothing was entered, it will throw
        'out an error. If at least one item was entered, it would calculate the average and display it on
        'on the screen.
        If (intNumberOfEntries > 1) Then
            avgCompletionTime = decTotalCompletionTime / (intNumberOfEntries - 1)
            lblAvgCompletionTime.Text = "Average completion time for the team is " & avgCompletionTime & " minutes"
        Else
            MsgBox("No time entered.",, "User Input Error")
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'When the Exit button is clicked, this procedure closes the application.
        Close()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        'When the Clear button is clicked, the first procedure clears the items in the listbox, and the 
        'second procedure sets the text back to what it was at the beginning, thus clearing the actual 
        'average completion time..
        lstTimes.Items.Clear()
        lblAvgCompletionTime.Text = "Average completion time for the team is "

    End Sub
End Class
