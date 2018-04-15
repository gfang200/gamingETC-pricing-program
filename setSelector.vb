Public Class setSelector
    Private Sub changeSet(Name As String)
        Dim fileRead As System.IO.StreamReader
        Dim fileWrite As System.IO.StreamWriter
        Dim currentLine As String
        Dim listOfLines As New ArrayList()

        fileRead = My.Computer.FileSystem.OpenTextFileReader("cardExtractor.py")

        Do While fileRead.Peek() > 0
            currentLine = fileRead.ReadLine
            If currentLine.Contains("searchSet =") Then
                listOfLines.Add("searchSet =""" + Name + """")
            Else
                listOfLines.Add(currentLine)
            End If
        Loop

        fileRead.Close()

        fileWrite = My.Computer.FileSystem.OpenTextFileWriter("cardExtractor.py", False)

        For Each line In listOfLines
            'MsgBox(line)
            fileWrite.WriteLine(line)
        Next

        fileWrite.Close()

    End Sub

    Public Sub ShellandWait(ByVal ProcessPath As String)
        Dim objProcess As System.Diagnostics.Process
        Try
            objProcess = New System.Diagnostics.Process()
            objProcess.StartInfo.FileName = ProcessPath
            objProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            objProcess.Start()

            'Wait until the process passes back an exit code 
            objProcess.WaitForExit()

            'Free resources associated with this process
            objProcess.Close()
        Catch
            MessageBox.Show("Could not start process " & ProcessPath, "Error")
        End Try
    End Sub

    Private Sub refreshListBox()
        lsbSets.Items.Clear()

        Dim fileRead As System.IO.StreamReader
        Dim currentLine As String
        Dim listOfLines As New ArrayList()

        fileRead = My.Computer.FileSystem.OpenTextFileReader("setList.txt")

        Do While fileRead.Peek() > 0
            currentLine = fileRead.ReadLine
            listOfLines.Add(currentLine)
        Loop

        For Each line In listOfLines
            lsbSets.Items.Add(line)
        Next

        lsbSets.Sorted = True

    End Sub

    Private Sub setSelector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshListBox()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        If lsbSets.SelectedItem = "" Then
            MessageBox.Show("Error! No set selected, please select a set and try again!")
            Exit Sub
        End If


        Dim result = MessageBox.Show("You are about to create " + lsbSets.SelectedItem + ".txt, this will overwrite any file currently named " + lsbSets.SelectedItem + ".txt, confirm?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = MsgBoxResult.Yes Then
            changeSet(lsbSets.SelectedItem)
            ShellandWait("cardExtractor.py")
            Form1.refreshListBox()
        End If


    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchValue As String
        searchValue = txtSearch.Text
        Dim searchedItems As ArrayList = New ArrayList
        refreshListBox()

        For Each item As String In lsbSets.Items
            If item.ToLower.Contains(searchValue.ToLower) Then
                searchedItems.Add(item)
            End If
        Next

        lsbSets.Items.Clear()
        For Each item As String In searchedItems
            lsbSets.Items.Add(item)
        Next

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        refreshListBox()
    End Sub

    Private Sub btnJson_Click(sender As Object, e As EventArgs) Handles btnJson.Click
        'dear person in the future, sorry i didnt modularize this code in seperate functions!
        Dim openFileDialog1 As New OpenFileDialog()
        Dim fullFileName As String
        Dim shortFileName As String

        openFileDialog1.Filter = "json files (*.json)|*.json|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            'MessageBox.Show(openFileDialog1.FileName)
            fullFileName = openFileDialog1.FileName
            shortFileName = openFileDialog1.SafeFileName
            If shortFileName = "AllSets.json" Then
                My.Computer.FileSystem.DeleteFile("AllSets.json")
                My.Computer.FileSystem.CopyFile(fullFileName, "AllSets.json")
                ShellandWait("setExtractor.py")
                refreshListBox()
            Else

                MessageBox.Show("Error! The selected file is not the correct JSON file, please ensure that the file is from mtgjson.com and is titled AllSets.json")
            End If

        End If
    End Sub
End Class