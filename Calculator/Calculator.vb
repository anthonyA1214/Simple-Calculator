Public Class Calculator
    Private num1 As Double
    Private num2 As Double
    Private result As Double = 1.0E-29
    Private operatorr As String = ""
    Private isNewNumber As Boolean = True
    Private isDisplayText As Boolean = False

    Private Sub displayTextOn()
        txtBox.Font = New Font(txtBox.Font.FontFamily, 21.75, txtBox.Font.Style)
        txtBox.TextAlign = HorizontalAlignment.Center
        btnDivide.Enabled = False
        btnMultiply.Enabled = False
        btnMinus.Enabled = False
        btnPlus.Enabled = False
        reset()
        isDisplayText = True
    End Sub

    Private Sub displayTextOff()
        txtBox.Text = 0
        txtBox.Font = New Font(txtBox.Font.FontFamily, 27.75, txtBox.Font.Style)
        txtBox.TextAlign = HorizontalAlignment.Right
        btnDivide.Enabled = True
        btnMultiply.Enabled = True
        btnMinus.Enabled = True
        btnPlus.Enabled = True
        isDisplayText = False
    End Sub

    Private Sub reset()
        num1 = num2 = result = 0
        operatorr = ""
        txtBox.Text = "0"
        txtBox2.Clear()
        isNewNumber = True
    End Sub

    Private Sub Operation()
        If operatorr <> "" Then
            num2 = Double.Parse(txtBox.Text)
        End If
        Select Case operatorr
            Case "+"
                result = num1 + num2
            Case "–"
                result = num1 - num2
            Case "×"
                result = num1 * num2
            Case "÷"
                If num2 = 0 Then
                    displayTextOn()
                    txtBox.Text = "Cannot divide by zero"
                    isNewNumber = True
                    Return
                End If
                result = num1 / num2
        End Select
        txtBox.Text = result.ToString()
        txtBox2.Text = num1 & " " & operatorr & " " & num2 & " = " & result
        isNewNumber = True
    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        If isDisplayText Then
            displayTextOff()
            Return
        End If

        If operatorr <> "" AndAlso txtBox.Text <> result Then
            Operation()
            operatorr = ""
        End If
    End Sub

    Private Sub btnOperators_Click(sender As Object, e As EventArgs) Handles btnPlus.Click, btnMultiply.Click, btnMinus.Click, btnDivide.Click
        Dim btn As Guna.UI2.WinForms.Guna2Button = CType(sender, Guna.UI2.WinForms.Guna2Button)

        If operatorr <> "" AndAlso Not isNewNumber Then
            Operation()
            num1 = result
        Else
            num1 = Double.Parse(txtBox.Text)
        End If

        operatorr = btn.Text
        If Not isDisplayText Then
            txtBox2.Text = num1 & " " & btn.Text & " "
        End If
        isNewNumber = True
    End Sub

    Private Sub btnAllClear_Click(sender As Object, e As EventArgs) Handles btnAllClear.Click
        reset()
        displayTextOff()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If isDisplayText Then
            displayTextOff()
        End If

        If txtBox.Text = result Then
            Return
        End If

        If txtBox.Text.Length > 0 Then
            txtBox.Text = txtBox.Text.Remove(txtBox.Text.Length - 1, 1)
        End If

        If txtBox.Text = "" Then
            txtBox.Text = "0"
        End If
    End Sub

    Private Sub btnNums_Click(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn9.Click, btn8.Click, btn7.Click, btn6.Click, btn5.Click, btn4.Click, btn3.Click, btn2.Click
        Dim btn As Guna.UI2.WinForms.Guna2Button = CType(sender, Guna.UI2.WinForms.Guna2Button)
        If isDisplayText Then
            displayTextOff()
        End If

        If txtBox.Text = "0" OrElse isNewNumber Then
            txtBox.Text = btn.Text
            isNewNumber = False
        Else
            txtBox.Text += btn.Text
        End If
    End Sub

    Private Sub btnDot_Click(sender As Object, e As EventArgs) Handles btnDot.Click
        If isDisplayText Then
            displayTextOff()
        End If

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
