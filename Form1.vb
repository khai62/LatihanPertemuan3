Imports System.Reflection.Metadata.Ecma335

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim grade, ket As String

        TextBox9.Text = 0.1 * Val(TextBox1.Text) + 0.2 * Val(TextBox2.Text) + 0.3 * Val(TextBox3.Text) + 0.4 * Val(TextBox4.Text)
        grade = ""
        ket = ""
        If TextBox9.Text >= 79 Then
            grade = "A"
            ket = "Lulus"
        ElseIf TextBox9.Text >= 69 Then
            grade = "B"
            ket = "Lulus"
        ElseIf TextBox9.Text >= 59 Then
            grade = "C"
            ket = "Lulus"
        ElseIf TextBox9.Text >= 40 Then
            grade = "D"
            ket = "Lulus"
        Else
            grade = "E"
            ket = "Gagal"
        End If
        TextBox10.Text = grade
        TextBox11.Text = ket
        TextBox5.Text = (TextBox1.Text * 0.1)
        TextBox6.Text = (TextBox2.Text * 0.2)
        TextBox7.Text = (TextBox3.Text * 0.3)
        TextBox8.Text = (TextBox4.Text * 0.4)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub
End Class
