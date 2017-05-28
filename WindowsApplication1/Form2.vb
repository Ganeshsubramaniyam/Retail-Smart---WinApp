Public Class Form2

    Sub display_data(ByVal dt1 As DataTable, ByVal date_str As String)
        DataGridView1.DataSource = dt1
        Label1.Text = "Sales On : " + date_str
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class