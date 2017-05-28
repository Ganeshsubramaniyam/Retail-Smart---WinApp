Public Class Form9
    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Normal
        Dim pi As Integer
        System.Threading.Thread.Sleep(10)
        For pi = 0 To 100
            ProgressBar1.Value = pi
            System.Threading.Thread.Sleep(5)
            If pi = 100 Then
                Me.Dispose()
            End If
        Next
    End Sub
End Class