Public Class Add_Member
    Dim id As Integer
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            KarateBindingSource.EndEdit()
            MembersTableAdapter1.Update(karateDBDataSet.Members)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Add_Member_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KarateBindingSource.AddNew()
        id = MembersTableAdapter1.GetNewMemberID()
        IDTextBox.Text = id.ToString()
    End Sub
End Class