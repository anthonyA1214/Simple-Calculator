Public Class Calculator
	Public num1 As Double
	Public num2 As Double
	Public result As Double
	Public operatorr As String = ""

	Public Sub Operation()
		Select Case operatorr
			Case "+"
				result = num1 + num2
			Case "-"
				result = num1 - num2
			Case "*"
				result = num1 * num2
			Case "/"
				result = num1 / num2
		End Select
	End Sub

	Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
		If operatorr <> "" Then
			num2 = Double.Parse(txtBox.Text)
			Operation()
			txtBox.Text = result.ToString()
			txtBox2.Text = num1 & " " & operatorr & " " & num2 & " = " & result
			operatorr = ""
		End If
	End Sub

	Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
		If operatorr = "" Then
			num1 = Double.Parse(txtBox.Text)
			operatorr = "+"
			txtBox2.Text = num1 & " + "
			txtBox.Text = "0"
		Else
			operatorr = "+"
			txtBox2.Text = num1 & " + "
		End If
	End Sub

	Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
		If operatorr = "" Then
			num1 = Double.Parse(txtBox.Text)
			operatorr = "-"
			txtBox2.Text = num1 & " - "
			txtBox.Text = "0"
		Else
			operatorr = "-"
			txtBox2.Text = num1 & " - "
		End If
	End Sub

	Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
		If operatorr = "" Then
			num1 = Double.Parse(txtBox.Text)
			operatorr = "*"
			txtBox2.Text = num1 & " * "
			txtBox.Text = "0"
		Else
			operatorr = "*"
			txtBox2.Text = num1 & " * "
		End If
	End Sub

	Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
		If operatorr = "" Then
			num1 = Double.Parse(txtBox.Text)
			operatorr = "/"
			txtBox2.Text = num1 & " / "
			txtBox.Text = "0"
		Else
			operatorr = "/"
			txtBox2.Text = num1 & " / "
		End If
	End Sub

	Private Sub btnAllClear_Click(sender As Object, e As EventArgs) Handles btnAllClear.Click
		num1 = 0
		num2 = 0
		result = 0
		operatorr = ""
		txtBox.Text = "0"
		txtBox2.Clear()
	End Sub

	Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
		If txtBox.Text.Length > 0 Then
			txtBox.Text = txtBox.Text.Remove(txtBox.Text.Length - 1, 1)
		End If

		If txtBox.Text = "" Then
			txtBox.Text = "0"
		End If
	End Sub

	Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
		If txtBox.Text = "0" Then
			txtBox.Text = "0"
		Else
			txtBox.Text += "0"
		End If
	End Sub

	Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
		If txtBox.Text = "0" Then
			txtBox.Text = "1"
		Else
			txtBox.Text += "1"
		End If
	End Sub

	Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
		If txtBox.Text = "0" Then
			txtBox.Text = "2"
		Else
			txtBox.Text += "2"
		End If
	End Sub

	Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
		If txtBox.Text = "0" Then
			txtBox.Text = "3"
		Else
			txtBox.Text += "3"
		End If
	End Sub

	Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
		If txtBox.Text = "0" Then
			txtBox.Text = "4"
		Else
			txtBox.Text += "4"
		End If
	End Sub

	Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
		If txtBox.Text = "0" Then
			txtBox.Text = "5"
		Else
			txtBox.Text += "5"
		End If
	End Sub

	Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
		If txtBox.Text = "0" Then
			txtBox.Text = "6"
		Else
			txtBox.Text += "6"
		End If
	End Sub

	Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
		If txtBox.Text = "0" Then
			txtBox.Text = "7"
		Else
			txtBox.Text += "7"
		End If
	End Sub

	Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
		If txtBox.Text = "0" Then
			txtBox.Text = "8"
		Else
			txtBox.Text += "8"
		End If
	End Sub

	Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
		If txtBox.Text = "0" Then
			txtBox.Text = "9"
		Else
			txtBox.Text += "9"
		End If
	End Sub

	Private Sub btnDot_Click(sender As Object, e As EventArgs) Handles btnDot.Click
		If Not txtBox.Text.Contains(".") Then
			txtBox.Text += "."
		End If
	End Sub
End Class
