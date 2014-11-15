Public Class Form1
    Dim total, tot1, tot2, tot3, tot4, tot5, tot6 As Double
    Dim tax As Double = 0.06
    Dim fittedsheets, pillows, pillowscases, flatsheets, comforter, sheets As Integer
    Dim cost As Double = 1.25
    Dim cost1 As Double = 1.75
    Dim cost2 As Double = 2.5
    Dim cost3 As Double = 2.5
    Dim cost4 As Double = 1.75    
    Dim cost5 As Double = 3.5

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If RadioButton1.Checked = True Then
            ListBox1.Items.Add("______________Input_______________")
            If RadioButton3.Checked = True Then
                ListBox1.Items.Add("Sheets =  " & TextBox3.Text)
            End If

            If RadioButton4.Checked = True Then
                ListBox1.Items.Add("Fitted Sheets =  " & TextBox4.Text)
            End If
            If RadioButton5.Checked = True Then
                ListBox1.Items.Add("Pillows =  " & TextBox5.Text)
            End If
            If RadioButton6.Checked = True Then
                ListBox1.Items.Add("Pillow Cases =  " & TextBox6.Text)
            End If
            If RadioButton7.Checked = True Then
                ListBox1.Items.Add("Flat Sheets =  " & TextBox7.Text)
            End If
            If RadioButton8.Checked = True Then
                ListBox1.Items.Add("Comforter =  " & TextBox8.Text)
            End If
        End If
    End Sub
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim x As String = ListBox1.SelectedItem
        x = ListBox1.SelectedItem
        deleteitems(x)
        TextBox2.Clear()
        TextBox2.Text = ""
        If RadioButton3.Checked = True Then
            TextBox3.Clear()
            sheets = 0
            TextBox3.Text = "0"
        End If
        If RadioButton4.Checked = True Then
            TextBox4.Clear()
            fittedsheets = 0
            TextBox4.Text = "0"
        End If
        If RadioButton5.Checked = True Then
            TextBox5.Clear()
            pillows = 0
            TextBox5.Text = "0"
        End If
        If RadioButton6.Checked = True Then
            TextBox6.Clear()
            pillowscases = 0
            TextBox6.Text = "0"
        End If
        If RadioButton7.Checked = True Then
            TextBox7.Clear()
            flatsheets = 0
            TextBox7.Text = "0"
        End If
        If RadioButton8.Checked = True Then
            TextBox8.Clear()
            comforter = 0
            TextBox8.Text = "0"
        End If
    End Sub
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If IsNumeric(TextBox3.Text) And RadioButton3.Checked = True And RadioButton1.Checked = True Then
            tot1 = CInt(sheets * cost) + CDbl(sheets * cost * tax)
            TextBox2.Text = FormatCurrency(tot1)
            ListBox2.Items.Add("Sheets Cost = " & FormatCurrency(tot1))
        End If
        If IsNumeric(TextBox4.Text) And RadioButton4.Checked = True And RadioButton1.Checked = True Then
            tot2 = CInt(fittedsheets * cost1) + CDbl(fittedsheets * cost1 * tax)
            TextBox2.Text = FormatCurrency(tot2)
            ListBox2.Items.Add("Fitted Sheets Cost = " & FormatCurrency(tot2))
        End If
        If IsNumeric(TextBox5.Text) And RadioButton5.Checked = True And RadioButton1.Checked = True Then
            tot3 = CInt(pillows * cost2) + CDbl(pillows * cost2 * tax)
            TextBox2.Text = FormatCurrency(tot3)
            ListBox2.Items.Add("Pillows Cost = " & FormatCurrency(tot3))
        End If
        If IsNumeric(TextBox6.Text) And RadioButton6.Checked = True And RadioButton1.Checked = True Then
            tot4 = CInt(pillowscases * cost3) + CDbl(pillowscases * cost3 * tax)
            TextBox2.Text = FormatCurrency(tot4)
            ListBox2.Items.Add("Pillow Cases Cost = " & FormatCurrency(tot4))
        End If
        If IsNumeric(TextBox7.Text) And RadioButton7.Checked = True And RadioButton1.Checked = True Then
            tot5 = CInt(flatsheets * cost4) + CDbl(flatsheets * cost4 * tax)
            TextBox2.Text = FormatCurrency(tot5)
            ListBox2.Items.Add("Flat Sheets Cost = " & FormatCurrency(tot5))
        End If
        If IsNumeric(TextBox8.Text) And RadioButton8.Checked = True And RadioButton1.Checked = True Then
            tot6 = CInt(comforter * cost5) + CDbl(comforter * cost5 * tax)
            TextBox2.Text = FormatCurrency(tot6)
            ListBox2.Items.Add("Comforters Cost = " & FormatCurrency(tot6))
        End If

        total = tot1 + tot2 + tot3 + tot4 + tot5 + tot6
        TextBox2.Text = FormatCurrency(total)

    End Sub
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call x("1")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call x("2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call x("3")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call x("4")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Call x("5")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Call x("6")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Call x("7")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Call x("8")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Call x("9")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Call x("0")
    End Sub
    '*****************Procedure*********************
    Sub x(ByVal y As Integer)
        If RadioButton3.Checked = True Then
            sheets = sheets & y
            TextBox3.Text = sheets
        End If
        If RadioButton4.Checked = True Then
            fittedsheets = fittedsheets & y
            TextBox4.Text = fittedsheets
        End If
        If RadioButton5.Checked = True Then
            pillows = pillows & y
            TextBox5.Text = pillows
        End If
        If RadioButton6.Checked = True Then
            pillowscases = pillowscases & y
            TextBox6.Text = pillowscases
        End If
        If RadioButton7.Checked = True Then
            flatsheets = flatsheets & y
            TextBox7.Text = flatsheets
        End If
        If RadioButton8.Checked = True Then
            comforter = comforter & y
            TextBox8.Text = comforter
        End If
    End Sub
    Sub deleteitems(ByVal x As String)
        ListBox1.Items.Remove(x)
        
    End Sub
End Class
