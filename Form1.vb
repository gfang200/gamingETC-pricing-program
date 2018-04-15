Imports System
Imports System.IO
Imports System.Collections
Imports System.IO.File
Imports System.Web.Script.Serialization

Public Class Form1

    Public completed As Boolean = False

    Public Sub refreshListBox()
        lsbFiles.Items.Clear()

        For Each foundFile As String In My.Computer.FileSystem.GetFiles(My.Computer.FileSystem.CurrentDirectory + "/CardLists")

            lsbFiles.Items.Add(Path.GetFileName(foundFile))
        Next

        lsbFiles.Sorted = True

    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.DirectoryExists("cardLists") = False Then
            My.Computer.FileSystem.CreateDirectory("cardLists")
        End If
        refreshListBox()
        btnStep1.Enabled = False
        btnStep2.Enabled = False
        btnStep3.Enabled = False
        lblSeconds.Text = CStr((trkSpeed.Value / 1000) + 1)



    End Sub

    Private Function updateEstTime() As Double
        Dim currentFile As String
        Dim cardSpd As Double
        currentFile = lblSelectedFile.Text
        cardSpd = (trkSpeed.Value / 1000) + 1

        Dim lineCount = File.ReadAllLines("cardLists/" + currentFile).Length

        updateEstTime = (cardSpd * lineCount) / 60

    End Function

    Private Sub updateEstimate()
        If lblSelectedFile.Text <> "None" Then

            lblTotalMin.Text = CStr(updateEstTime())

        End If
    End Sub

    Private Sub trkSpeed_Scroll(sender As Object, e As EventArgs) Handles trkSpeed.Scroll



        lblSeconds.Text = (trkSpeed.Value / 1000) + 1

        updateEstimate()

    End Sub

    Private Sub btnSelectFile_Click(sender As Object, e As EventArgs) Handles btnSelectFile.Click

        If completed = True Then
            Dim result = MessageBox.Show("Warning, selecting a new file will restart the process. You will not be able to access the current output file. You will have an opportunity to save the output.", "Select File Anyways", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = MsgBoxResult.No Then
                Exit Sub
            End If
            saveFile()
            completed = False
        End If

        If lsbFiles.Items.Count() = 0 Then
            MsgBox("There are no files currently imported, please use the import file feature to import a new file.")
            Exit Sub
        End If

        If lsbFiles.SelectedItem = "" Then
            MsgBox("Please select a file")
            Exit Sub
        End If


        lblSelectedFile.Text = lsbFiles.SelectedItem
        changeToolsName(lsbFiles.SelectedItem)
        btnStep1.Enabled = True
        btnStep3.Enabled = False
        updateEstimate()
        'updateEstTime()


    End Sub

    Sub changeToolsName(name As String)
        Dim fileRead As System.IO.StreamReader
        Dim fileWrite As System.IO.StreamWriter
        Dim currentLine As String
        Dim listOfLines As New ArrayList()

        fileRead = My.Computer.FileSystem.OpenTextFileReader("tools.py")

        Do While fileRead.Peek() > 0
            currentLine = fileRead.ReadLine
            If currentLine.Contains("currentFile") Then
                listOfLines.Add("currentFile=""cardLists/" + name + """")
            Else
                listOfLines.Add(currentLine)
            End If
        Loop

        fileRead.Close()

        fileWrite = My.Computer.FileSystem.OpenTextFileWriter("tools.py", False)

        For Each line In listOfLines
            'MsgBox(line)
            fileWrite.WriteLine(line)
        Next

        fileWrite.Close()

    End Sub


    Sub changeAHKTime(time As Integer)
        'implement this later
        Dim fileRead As System.IO.StreamReader
        Dim fileWrite As System.IO.StreamWriter
        Dim currentLine As String
        Dim listOfLines As New ArrayList()

        fileRead = My.Computer.FileSystem.OpenTextFileReader("step2.ahk")

        Do While fileRead.Peek() > 0
            currentLine = fileRead.ReadLine
            If currentLine.Contains("sleepTime =") Then
                listOfLines.Add("sleepTime =" + CStr(time))
            Else
                listOfLines.Add(currentLine)
            End If
        Loop

        fileRead.Close()

        fileWrite = My.Computer.FileSystem.OpenTextFileWriter("step2.ahk", False)

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

    Private Sub btnStep1_Click(sender As Object, e As EventArgs) Handles btnStep1.Click
        'Dim obj As Object
        'Dim test As System.Diagnostics.Process

        'test = New System.Diagnostics.Process
        'test.StartInfo.FileName = "test.py"
        'test.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        'test.Start()
        'test.WaitForExit()
        'test.Close()


        'MsgBox(My.Computer.FileSystem.CurrentDirectory + "\step1.py")
        'obj = CreateObject("WScript.shell")
        'obj.run("step1.py")

        ShellandWait("step1.py")
        btnStep2.Enabled = True
        btnStep1.Enabled = False
        lsbFiles.Enabled = False
        btnSelectFile.Enabled = False

        btnImport.Enabled = False
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        btnSets.Enabled = False

    End Sub

    Private Sub btnStep2_Click(sender As Object, e As EventArgs) Handles btnStep2.Click

        'Dim obj As Object
        'MsgBox(My.Computer.FileSystem.CurrentDirectory + "\step1.py")
        'obj = CreateObject("WScript.shell")
        'obj.run("step2.ahk")

        trkSpeed.Enabled = False
        changeAHKTime(trkSpeed.Value)

        btnStep2.Enabled = False
        MsgBox("Please be patient for completion conformation! Estimated loading time is " + lblTotalMin.Text + " minutes.")
        'pgbLoad.Style = ProgressBarStyle.Marquee
        ShellandWait("step2.ahk")
        'pgbLoad.Style = ProgressBarStyle.Blocks
        'pgbLoad.Value = 0

        btnStep3.Enabled = True
    End Sub

    Private Sub btnStep3_Click(sender As Object, e As EventArgs) Handles btnStep3.Click
        Dim obj As Object

        'MsgBox(My.Computer.FileSystem.CurrentDirectory + "\step1.py")
        obj = CreateObject("WScript.shell")
        'obj.run("step3.py")
        ShellandWait("step3.py")
        'btnStep3.Enabled = False
        obj.run("outputFile.html")
        completed = True
        'Me.Close()

        btnSelectFile.Enabled = True
        lsbFiles.Enabled = True


    End Sub

    Private Sub saveFile()
        Dim FolderBrowserDialog1 As FolderBrowserDialog = New FolderBrowserDialog
        Dim randomValue As Integer
        Dim result = MessageBox.Show("Would you like to save the output?", "Save Output", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = MsgBoxResult.Yes Then
            If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
                Randomize()
                randomValue = CInt(Math.Floor((1000000 - 0 + 1) * Rnd()))
                My.Computer.FileSystem.CopyFile("outputFile.html", FolderBrowserDialog1.SelectedPath + "/outputFile" + CStr(randomValue) + ".html")
            End If
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If completed = False Then

            Dim result = MessageBox.Show("The program has not completed running, if you exit now, you will have to restart the entire process" & vbCrLf & "Confirm exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = MsgBoxResult.No Then
                e.Cancel = True 'cancel the form closing event
            End If
        Else
            saveFile()
        End If

    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        'dear person in the future, sorry i didnt modularize this code in seperate functions!
        Dim openFileDialog1 As New OpenFileDialog()
        Dim fullFileName As String
        Dim shortFileName As String

        openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            'MessageBox.Show(openFileDialog1.FileName)
            fullFileName = openFileDialog1.FileName
            shortFileName = openFileDialog1.SafeFileName
            If lsbFiles.Items.Contains(shortFileName) Then
                MessageBox.Show("Error! The selected file is already in the list of files, please use the 'update file' feature instead.")
            Else
                My.Computer.FileSystem.CopyFile(fullFileName, "CardLists/" + shortFileName)
                refreshListBox()
            End If

        End If


    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'dear person in the future, sorry i didnt modularize this code in seperate functions!
        Dim openFileDialog1 As New OpenFileDialog()
        Dim fullFileName As String
        Dim shortFileName As String

        openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            'MessageBox.Show(openFileDialog1.FileName)
            fullFileName = openFileDialog1.FileName
            shortFileName = openFileDialog1.SafeFileName
            If shortFileName = lblSelectedFile.Text Then
                My.Computer.FileSystem.DeleteFile("CardLists/" + shortFileName)
                My.Computer.FileSystem.CopyFile(fullFileName, "CardLists/" + shortFileName)
                refreshListBox()
            Else

                MessageBox.Show("Error! The selected file is not the same as the selected file, please use the 'import file' feature instead or rename the selected file.")
            End If

        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'dear person in the future, sorry i didnt modularize this code in seperate functions!
        Dim currentFile As String
        currentFile = lblSelectedFile.Text
        If currentFile = "None" Then
            MessageBox.Show("Error! No file selected, please use the select file button.")
            Exit Sub
        End If

        Dim result = MessageBox.Show("Are you sure you want to delete " + currentFile + "? This action cannot be undone.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = MsgBoxResult.Yes Then
            My.Computer.FileSystem.DeleteFile("CardLists/" + currentFile)
            lblSelectedFile.Text = "None"
            btnStep1.Enabled = False
            refreshListBox()
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MessageBox.Show("Program designed by George Fang for Michelle Cove at Gaming ETC 6/22/2016. Testing done by Oren Shoemaker, Connor Raftery, and Matt Smith.", "Credits")
    End Sub



    Private Sub btnSets_Click(sender As Object, e As EventArgs) Handles btnSets.Click
        'Dim json As New JavaScriptSerializer
        'Dim jsonOut As String = json.Serialize
        Dim form2 As Form
        form2 = New setSelector
        form2.Show()

    End Sub

    Private Sub lsbFiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsbFiles.SelectedIndexChanged
        'lblSelectedFile.Text = lsbFiles.SelectedItem
    End Sub

    Private Sub btnStocks_Click(sender As Object, e As EventArgs) Handles btnStocks.Click
        If lsbFiles.Items.Contains("case sheet.txt") Then
            ShellandWait("mtgStockQuer.py")
            MessageBox.Show("Success! mtgStocks imported into mtgStocks.txt")
            refreshListBox()

        Else
            MessageBox.Show("Error! this option requires 'case sheet.txt' to exist in the list of files, please make sure 'case sheet.txt' is imported and named 'case sheet.txt' (caps sensitive)")
        End If
    End Sub

    Private Sub btnDebug_Click(sender As Object, e As EventArgs) Handles btnDebug.Click
        Dim frmDebug As Form
        frmDebug = New Debug_Menu
        frmDebug.Show()
    End Sub

    Private Sub btnCase_Click(sender As Object, e As EventArgs) Handles btnCase.Click
        Dim result = MessageBox.Show("Are you sure you want to update case sheet.txt with the google doc? This will overwrite the current case sheet.txt file", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = MsgBoxResult.Yes Then
            ShellandWait("gdata.py")
            refreshListBox()
        End If


    End Sub
End Class
