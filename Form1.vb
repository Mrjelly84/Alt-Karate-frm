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

    Private Sub btnFilterByDate_Click(sender As Object, e As EventArgs) Handles btnFilterByDate.Click
        frmFilterByDates.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        Add_Member.ShowDialog()
    End Sub

    Private Sub FindMemberByNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindMemberByNameToolStripMenuItem.Click
        FindByName.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        Close()
    End Sub

    Private Sub UpdateDatabaseToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles UpdateDatabaseToolStripMenuItem6.Click
        Try
            MembersTableAdapter.Update(KarateDBDataSet.Members)
            MembersTableAdapter.Fill(KarateDBDataSet.Members)
        Catch ex As Exception
            MessageBox.Show(Me, "Error:" & ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
End Class
