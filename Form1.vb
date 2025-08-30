Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MembersTableAdapter.Fill(KarateDBDataSet.Members)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) 
        Try
            KarateMembersBindingSource.Filter = txtFilter.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
