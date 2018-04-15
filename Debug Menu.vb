Public Class Debug_Menu
    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim debugReport As Form
        debugReport = New frmDebugReport
        debugReport.Show()

    End Sub

    Private Sub btnFolder_Click(sender As Object, e As EventArgs) Handles btnFolder.Click
        Process.Start(My.Computer.FileSystem.CurrentDirectory)
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        System.Diagnostics.Process.Start("GamingETC Pricing Program Manual 2016.pdf")

    End Sub
End Class