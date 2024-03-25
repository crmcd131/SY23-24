Public Class TermsAndConditionsForm
    Private Sub btnAgree_Click(sender As Object, e As EventArgs) Handles btnAgree.Click
        ' Handle agreement
        MessageBox.Show("You have agreed to the terms and conditions.", "Agreement Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' Add code here to proceed after agreement
        Me.Close()
    End Sub

    Private Sub btnDecline_Click(sender As Object, e As EventArgs) Handles btnDecline.Click
        ' Handle disagreement
        MessageBox.Show("You have declined the terms and conditions.", "Agreement Declined", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' Add code here for handling disagreement
        Me.Close()
    End Sub
End Class