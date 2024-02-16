'Jaden Torres
'Assignment A3 and A4 for GUI
'Professor: Bruce Montgomery
'Class Name: Farm Burger Special
'Fair warning, I have no idea how to rename the entities listed below. I have searched high and low with no luck. I have made personal notes for each one.'
'Sources: https://www.tutorialspoint.com/vb.net/vb.net_button.htm'

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'This variable loads the form'
        PictureBox2.Visible = False 'Disables veggie burger'
        PictureBox1.Visible = False 'Disables prime burger'
        Label4.Visible = False 'Disables my pop up message'
        Label5.Visible = False 'Disables my pop up message'
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click 'This is my header'

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'This is my Select Meal button'
        Button1.Enabled = False 'Disables Prime button'
        Button2.Enabled = False 'Disables Veggie button'
        Button3.Enabled = False 'Disables Select Meal Button'
        PictureBox2.Visible = False 'Disables Veggie Picture'
        PictureBox1.Visible = False 'Disables Prime Picture'
        Label4.Visible = True 'Enables pop up message'
        Label5.Visible = True 'Enables pop up message'

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click 'This is my Directions label'

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click 'This is my Exit Window button'
        Close() 'Closes the program'
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click 'This is my Veggie Button'
        PictureBox2.Visible = True 'Enables Veggie Picture'
        PictureBox1.Visible = False 'Disables Prime Picture'
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click 'This is my Directions label'

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) 'This is my Prime Beef Picture'

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click 'This is my Veggie Picture'

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click ' This is my Prime Beef Button'
        PictureBox1.Visible = True 'Enables Prime Picture'
        PictureBox2.Visible = False 'Disables Veggie Picture'
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click 'This is my Prime Beef Picture'

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click 'This is my pop up label'

    End Sub
End Class
