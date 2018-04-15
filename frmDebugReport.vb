
Imports System
Imports System.IO
Imports System.Collections
Imports System.IO.File
Imports System.IO.Compression

Public Class frmDebugReport
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim severity As String
        Dim description As String
        Dim now As String
        Dim directoryName As String
        Dim file As System.IO.StreamWriter


        now = DateTime.Now.ToString("yyyy.MM.dd HH.mm.ss")

        If rbLow.Checked Then
            severity = "LOW"
        ElseIf rbMed.Checked Then
            severity = "MEDIUM"
        Else
            severity = "HIGH"
        End If

        description = txtDesc.Text

        Dim FolderBrowserDialog1 As FolderBrowserDialog = New FolderBrowserDialog
        Dim result = MessageBox.Show("Are you ready to generate the report?", "Generate Report", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = MsgBoxResult.Yes Then
            If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
                directoryName = FolderBrowserDialog1.SelectedPath + "/bugReport." + severity + "." + now
                My.Computer.FileSystem.CreateDirectory(directoryName)
                Try
                    My.Computer.FileSystem.CopyFile("buyList.csv", directoryName + "/buyList.csv")
                    My.Computer.FileSystem.CopyFile("case prices.csv", directoryName + "/case prices.csv")
                    My.Computer.FileSystem.CopyFile("compiledList.csv", directoryName + "/compiledList.csv")
                    My.Computer.FileSystem.CopyFile("priceList.csv", directoryName + "/priceList.csv")
                    My.Computer.FileSystem.CopyFile("outputFile.html", directoryName + "/outputFile.html")

                    For Each foundFile As String In My.Computer.FileSystem.GetFiles(My.Computer.FileSystem.CurrentDirectory + "/CardLists")
                        My.Computer.FileSystem.CopyFile("CardLists/" + Path.GetFileName(foundFile), directoryName + "/" + Path.GetFileName(foundFile))
                    Next

                    file = My.Computer.FileSystem.OpenTextFileWriter(directoryName + "/Debug.txt", False)
                    file.WriteLine(now)
                    file.WriteLine(severity)
                    file.WriteLine(description)
                    file.Close()


                Catch
                    file = My.Computer.FileSystem.OpenTextFileWriter(directoryName + "/Debug.txt", False)
                    file.WriteLine(now)
                    file.WriteLine(severity)
                    file.WriteLine(description)
                    file.Close()
                End Try

                'ZipFile.CreateFromDirectory(directoryName, directoryName)

            End If
        End If

    End Sub
End Class