Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataconnectDataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.DataconnectDataSet.Table1)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PicPrevious.Click
        Table1BindingSource.MovePrevious()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PicNext.Click
        Table1BindingSource.MoveNext()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PicAdd.Click
        Table1BindingSource.AddNew()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PicSave.Click
        Table1BindingSource.EndEdit()
        Table1TableAdapter.Update(DataconnectDataSet.Table1)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PicDelete.Click
        Table1BindingSource.RemoveCurrent()

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PicExit.Click
        Me.Close()

    End Sub

    Private Sub PictureBoxSearch_Click(sender As Object, e As EventArgs) Handles PictureBoxSearch.Click
        Table1BindingSource.Filter = "Username ='" & txtSearch.Text & "'"
    End Sub

    Private Sub Form5_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form3.Show()
    End Sub
End Class