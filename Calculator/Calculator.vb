Public Class Calculator
    Private num1 As Double
    Private num2 As Double
    Private result As Double
    Private operatorr As String = ""
    Private isNewNumber As Boolean = True

    Private Sub Operation()
        If operatorr <> "" Then
            num2 = Double.Parse(txtBox.Text)
        End If
        Select Case operatorr
            Case "+"
                result = num1 + num2
            Case "−"
                result = num1 - num2
            Case "∗"
                result = num1 * num2
            Case "/"
                If num2 = 0 Then
                    MessageBox.Show("Division by zero is not allowed.")
                    Return
                End If
                result = num1 / num2
        End Select
        txtBox.Text = result.ToString()
        txtBox2.Text = num1 & " " & operatorr & " " & num2 & " = " & result
        isNewNumber = True
    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        If operatorr <> "" AndAlso txtBox.Text <> result Then
            Operation()
            operatorr = ""
        End If
    End Sub

    Private Sub btnOperators_Click(sender As Object, e As EventArgs) Handles btnPlus.Click, btnMultiply.Click, btnMinus.Click, btnDivide.Click
        Dim btn As Guna.UI2.WinForms.Guna2Button = CType(sender, Guna.UI2.WinForms.Guna2Button)
        If txtBox.Text = 0 Then
            Return
        End If

        If operatorr <> "" AndAlso txtBox.Text <> result Then
            Operation()
            num1 = result
        Else
            num1 = Double.Parse(txtBox.Text)
        End If

        operatorr = btn.Text
        txtBox2.Text = num1 & " " & btn.Text & " "
        isNewNumber = True
    End Sub

    Private Sub btnAllClear_Click(sender As Object, e As EventArgs) Handles btnAllClear.Click
        num1 = num2 = result = 0
        operatorr = ""
        txtBox.Text = "0"
        txtBox2.Clear()
        isNewNumber = True
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If txtBox.Text.Length > 0 Then
            txtBox.Text = txtBox.Text.Remove(txtBox.Text.Length - 1, 1)
        End If

        If txtBox.Text = "" Then
            txtBox.Text = "0"
        End If
    End Sub

    Private Sub btnNums_Click(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn9.Click, btn8.Click, btn7.Click, btn6.Click, btn5.Click, btn4.Click, btn3.Click, btn2.Click
        Dim btn As Guna.UI2.WinForms.Guna2Button = CType(sender, Guna.UI2.WinForms.Guna2Button)
        If txtBox.Text = "0" OrElse isNewNumber Then
            txtBox.Text = btn.Text
            isNewNumber = False
        Else
            txtBox.Text += btn.Text
        End If
    End Sub

    Private Sub btnDot_Click(sender As Object, e As EventArgs) Handles btnDot.Click
        If isNewNumber Then
            txtBox.Text = "0."
            isNewNumber = False
            Return
        End If

        If Not txtBox.Text.Contains(".") Then
            txtBox.Text += "."
        End If
    End Sub
End Class
