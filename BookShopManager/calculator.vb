Public Class calculator

    Dim firstNum, operat, result

    Private Sub bt_zero_Click(sender As Object, e As EventArgs) Handles bt_zero.Click
        check()
        et_input.Text = et_input.Text & "0"
    End Sub

    Private Sub bt_one_Click(sender As Object, e As EventArgs) Handles bt_one.Click
        check()
        et_input.Text = et_input.Text & "1"
    End Sub

    Private Sub bt_two_Click(sender As Object, e As EventArgs) Handles bt_two.Click
        check()
        et_input.Text = et_input.Text & "2"
    End Sub

    Private Sub bt_three_Click(sender As Object, e As EventArgs) Handles bt_three.Click
        check()
        et_input.Text = et_input.Text & "3"
    End Sub

    Private Sub bt_four_Click(sender As Object, e As EventArgs) Handles bt_four.Click
        check()
        et_input.Text = et_input.Text & "4"
    End Sub

    Private Sub bt_five_Click(sender As Object, e As EventArgs) Handles bt_five.Click
        check()
        et_input.Text = et_input.Text & "5"
    End Sub

    Private Sub bt_six_Click(sender As Object, e As EventArgs) Handles bt_six.Click
        check()
        et_input.Text = et_input.Text & "6"
    End Sub

    Private Sub bt_seven_Click(sender As Object, e As EventArgs) Handles bt_seven.Click
        check()
        et_input.Text = et_input.Text & "7"
    End Sub

    Private Sub bt_eight_Click(sender As Object, e As EventArgs) Handles bt_eight.Click
        check()
        et_input.Text = et_input.Text & "8"
    End Sub

    Private Sub bt_nine_Click(sender As Object, e As EventArgs) Handles bt_nine.Click
        check()
        et_input.Text = et_input.Text & "9"
    End Sub

    Private Sub bt_add_Click(sender As Object, e As EventArgs) Handles bt_add.Click
        firstNum = Val(et_input.Text)
        et_input.Text = ""
        operat = "+"
        et_input.Text = operat
    End Sub

    Private Sub bt_subs_Click(sender As Object, e As EventArgs) Handles bt_subs.Click
        firstNum = Val(et_input.Text)
        et_input.Text = ""
        operat = "-"
        et_input.Text = operat
    End Sub

    Private Sub bt_mult_Click(sender As Object, e As EventArgs) Handles bt_mult.Click
        firstNum = Val(et_input.Text)
        et_input.Text = ""
        operat = "*"
        et_input.Text = operat
    End Sub

    Private Sub bt_div_Click(sender As Object, e As EventArgs) Handles bt_div.Click
        firstNum = Val(et_input.Text)
        et_input.Text = ""
        operat = "/"
        et_input.Text = operat
    End Sub

    Private Sub bt_point_Click(sender As Object, e As EventArgs) Handles bt_point.Click
        check()
        et_input.Text = et_input.Text & "."
    End Sub

    Private Sub et_input_Click(sender As Object, e As EventArgs) Handles et_input.Click
        et_input.SelectAll()
    End Sub

    Private Sub bt_equal_Click(sender As Object, e As EventArgs) Handles bt_equal.Click
        result = Val(et_input.Text)
        If operat = "+" Then
            result = firstNum + result
        End If
        If operat = "-" Then
            result = firstNum - result
        End If
        If operat = "*" Then
            result = firstNum * result
        End If
        If operat = "/" Then
            result = firstNum / result
        End If
        et_input.Text = result
    End Sub

    Private Sub bt_clear_Click(sender As Object, e As EventArgs) Handles bt_clear.Click
        et_input.Text = ""

    End Sub
    Public Sub check()
        If et_input.Text = "+" Then
            et_input.Text = ""
        ElseIf et_input.Text = "-" Then
            et_input.Text = ""
        ElseIf et_input.Text = "*" Then
            et_input.Text = ""
        ElseIf et_input.Text = "/" Then
            et_input.Text = ""
        End If
    End Sub
End Class
