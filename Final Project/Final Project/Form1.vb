Public Class Form1
    Dim tot1, tot2, tot3, tot4, tot5, tot6, tot7, tot8, tot9, tot10 As Double
    Dim tot11, tot12, tot13, tot14, tot15, tot16, tot17, tot18, tot19, tot20 As Double
    Dim total As Double = 0
    Dim tax As Double = 0.7
    Dim sheets As Integer
    Dim cost As Double = 1.25
    Dim fittedsheets As Integer
    Dim cost1 As Double = 1.75
    Dim pillows As Integer
    Dim cost2 As Double = 2.5
    Dim pillowscases As Integer
    Dim cost3 As Double = 2.5
    Dim flatsheets As Integer
    Dim cost4 As Double = 1.75
    Dim comforter As Integer
    Dim cost5 As Double = 3.5
    Dim kitchen As Integer
    Dim cost6 As Double = 2.25
    Dim bath As Integer
    Dim cost7 As Double = 3.25
    Dim handwash As Integer
    Dim cost8 As Double = 0.75
    Dim cleaning As Integer
    Dim cost9 As Double = 0.75
    Dim dining As Integer
    Dim cost10 As Double = 2.25
    Dim roomservice As Integer
    Dim cost11 As Double = 1.25
    Dim lounge As Integer
    Dim cost12 As Double = 0.75
    Dim pants As Integer
    Dim cost13 As Double = 6.75
    Dim shirts As Integer
    Dim cost14 As Double = 7.5
    Dim hats As Integer
    Dim cost15 As Double = 3.5
    Dim small As Integer
    Dim cost16 As Double = 5.75
    Dim large As Integer
    Dim cost17 As Double = 8.5
    Dim banquet As Integer
    Dim cost18 As Double = 8.5
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
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If RadioButton1.Checked = True Then
            ListBox1.Items.Add("_____________Input_____________")
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
            If RadioButton9.Checked = True Then
                ListBox1.Items.Add("Kitchen Towels =  " & TextBox9.Text)
            End If
            If RadioButton10.Checked = True Then
                ListBox1.Items.Add("Bath Towels =  " & TextBox10.Text)
            End If
            If RadioButton11.Checked = True Then
                ListBox1.Items.Add("Hand Wash Towels =  " & TextBox11.Text)
            End If
            If RadioButton12.Checked = True Then
                ListBox1.Items.Add("Cleaning Towels =  " & TextBox12.Text)
            End If
            If RadioButton13.Checked = True Then
                ListBox1.Items.Add("Dining Napkins =  " & TextBox13.Text)
            End If
            If RadioButton14.Checked = True Then
                ListBox1.Items.Add("Room Service Napkins =  " & TextBox14.Text)
            End If
            If RadioButton15.Checked = True Then
                ListBox1.Items.Add("Lounge Napkins =  " & TextBox15.Text)
            End If
            If RadioButton16.Checked = True Then
                ListBox1.Items.Add("Chef's Pants =  " & TextBox16.Text)
            End If
            If RadioButton17.Checked = True Then
                ListBox1.Items.Add("Chef's Shirts =  " & TextBox17.Text)
            End If
            If RadioButton18.Checked = True Then
                ListBox1.Items.Add("Chef's hats =  " & TextBox18.Text)
            End If
            If RadioButton19.Checked = True Then
                ListBox1.Items.Add("Small Table Clothes =  " & TextBox19.Text)
            End If
            If RadioButton20.Checked = True Then
                ListBox1.Items.Add("Large Table Clothes =  " & TextBox20.Text)
            End If
            If RadioButton21.Checked = True Then
                ListBox1.Items.Add("Banquet Table Clothes =  " & TextBox21.Text)
            End If
        ElseIf RadioButton2.Checked = True Then
            ListBox1.Items.Add("_____________Output_____________")
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
            If RadioButton9.Checked = True Then
                ListBox1.Items.Add("Kitchen Towels =  " & TextBox9.Text)
            End If
            If RadioButton10.Checked = True Then
                ListBox1.Items.Add("Bath Towels =  " & TextBox10.Text)
            End If
            If RadioButton11.Checked = True Then
                ListBox1.Items.Add("Hand Wash Towels =  " & TextBox11.Text)
            End If
            If RadioButton12.Checked = True Then
                ListBox1.Items.Add("Cleaning Towels =  " & TextBox12.Text)
            End If
            If RadioButton13.Checked = True Then
                ListBox1.Items.Add("Dining Napkins =  " & TextBox13.Text)
            End If
            If RadioButton14.Checked = True Then
                ListBox1.Items.Add("Room Service Napkins =  " & TextBox14.Text)
            End If
            If RadioButton15.Checked = True Then
                ListBox1.Items.Add("Lounge Napkins =  " & TextBox15.Text)
            End If
            If RadioButton16.Checked = True Then
                ListBox1.Items.Add("Chef's Pants =  " & TextBox16.Text)
            End If
            If RadioButton17.Checked = True Then
                ListBox1.Items.Add("Chef's Shirts =  " & TextBox17.Text)
            End If
            If RadioButton18.Checked = True Then
                ListBox1.Items.Add("Chef's hats =  " & TextBox18.Text)
            End If
            If RadioButton19.Checked = True Then
                ListBox1.Items.Add("Small Table Clothes =  " & TextBox19.Text)
            End If
            If RadioButton20.Checked = True Then
                ListBox1.Items.Add("Large Table Clothes =  " & TextBox20.Text)
            End If
            If RadioButton21.Checked = True Then
                ListBox1.Items.Add("Banquet Table Clothes =  " & TextBox21.Text)
            End If
        End If
    End Sub
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If ListBox1.SelectedIndex > -1 Then
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        End If
        If ListBox2.SelectedIndex > -1 Then
            ListBox2.Items.RemoveAt(ListBox2.SelectedIndex)
        End If
        If RadioButton3.Checked = True Then
            sheets = 0
            TextBox3.Text = "0"
            RadioButton3.Checked = False
        End If
        If RadioButton4.Checked = True Then
            fittedsheets = 0
            TextBox4.Text = "0"
            RadioButton4.Checked = False
        End If
        If RadioButton5.Checked = True Then
            pillows = 0
            TextBox5.Text = "0"
            RadioButton5.Checked = False
        End If
        If RadioButton6.Checked = True Then
            pillowscases = 0
            TextBox6.Text = "0"
            RadioButton6.Checked = False
        End If
        If RadioButton7.Checked = True Then
            flatsheets = 0
            TextBox7.Text = "0"
            RadioButton7.Checked = False
        End If
        If RadioButton8.Checked = True Then
            comforter = 0
            TextBox8.Text = "0"
            RadioButton8.Checked = False
        End If
        If RadioButton9.Checked = True Then
            kitchen = 0
            TextBox9.Text = "0"
            RadioButton9.Checked = False
        End If
        If RadioButton10.Checked = True Then
            bath = 0
            TextBox10.Text = "0"
            RadioButton10.Checked = False
        End If
        If RadioButton11.Checked = True Then
            handwash = 0
            TextBox11.Text = "0"
            RadioButton11.Checked = False
        End If
        If RadioButton12.Checked = True Then
            cleaning = 0
            TextBox12.Text = "0"
            RadioButton12.Checked = False
        End If
        If RadioButton13.Checked = True Then
            dining = 0
            TextBox13.Text = "0"
            RadioButton13.Checked = False
        End If
        If RadioButton14.Checked = True Then
            roomservice = 0
            TextBox14.Text = "0"
            RadioButton14.Checked = False
        End If
        If RadioButton15.Checked = True Then
            lounge = 0
            TextBox15.Text = "0"
            RadioButton15.Checked = False
        End If
        If RadioButton16.Checked = True Then
            pants = 0
            TextBox16.Text = "0"
            RadioButton16.Checked = False
        End If
        If RadioButton17.Checked = True Then
            shirts = 0
            TextBox17.Text = "0"
            RadioButton17.Checked = False
        End If
        If RadioButton18.Checked = True Then
            hats = 0
            TextBox18.Text = "0"
            RadioButton18.Checked = False
        End If
        If RadioButton19.Checked = True Then
            small = 0
            TextBox19.Text = "0"
            RadioButton19.Checked = False
        End If
        If RadioButton20.Checked = True Then
            large = 0
            TextBox20.Text = "0"
            RadioButton20.Checked = False
        End If
        If RadioButton21.Checked = True Then
            banquet = 0
            TextBox21.Text = "0"
            RadioButton21.Checked = False
        End If
    End Sub
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If RadioButton1.Checked = True Or RadioButton2.Checked = True Then
            If IsNumeric(TextBox3.Text) And RadioButton3.Checked = True Then
                tot1 = CInt(sheets * cost) + CDbl(sheets * cost * tax)
                ListBox2.Items.Add("Sheets Cost = " & FormatCurrency(Val(tot1)))
            End If
            If IsNumeric(TextBox4.Text) And RadioButton4.Checked = True Then
                tot2 = CInt(fittedsheets * cost1) + CDbl(fittedsheets * cost1 * tax)
                ListBox2.Items.Add("Fitted Sheets Cost = " & FormatCurrency(Val(tot2)))
            End If
            If IsNumeric(TextBox5.Text) And RadioButton5.Checked = True Then
                tot3 = CInt(pillows * cost2) + CDbl(pillows * cost2 * tax)
                ListBox2.Items.Add("Pillows Cost = " & FormatCurrency(Val(tot3)))
            End If
            If IsNumeric(TextBox6.Text) And RadioButton6.Checked = True Then
                tot4 = CInt(pillowscases * cost3) + CDbl(pillowscases * cost3 * tax)
                ListBox2.Items.Add("Pillow Cases Cost = " & FormatCurrency(Val(tot4)))
            End If
            If IsNumeric(TextBox7.Text) And RadioButton7.Checked = True Then
                tot5 = CInt(flatsheets * cost4) + CDbl(flatsheets * cost4 * tax)
                ListBox2.Items.Add("Flat Sheets Cost = " & FormatCurrency(Val(tot5)))
            End If
            If IsNumeric(TextBox8.Text) And RadioButton8.Checked = True Then
                tot6 = CInt(comforter * cost5) + CDbl(comforter * cost5 * tax)
                ListBox2.Items.Add("Comforters Cost = " & FormatCurrency(Val(tot6)))
            End If
            If IsNumeric(TextBox9.Text) And RadioButton9.Checked = True Then
                tot7 = CInt(kitchen * cost6) + CDbl(kitchen * cost6 * tax)
                ListBox2.Items.Add("Kitchen Towels Cost = " & FormatCurrency(Val(tot7)))
            End If
            If IsNumeric(TextBox10.Text) And RadioButton10.Checked = True Then
                tot8 = CInt(bath * cost7) + CDbl(bath * cost7 * tax)
                ListBox2.Items.Add("Bath Towels Cost = " & FormatCurrency(Val(tot8)))
            End If
            If IsNumeric(TextBox11.Text) And RadioButton11.Checked = True Then
                tot9 = CInt(handwash * cost8) + CDbl(handwash * cost8 * tax)
                ListBox2.Items.Add("Hand Wash Towels Cost = " & FormatCurrency(Val(tot9)))
            End If
            If IsNumeric(TextBox12.Text) And RadioButton12.Checked = True Then
                tot10 = CInt(cleaning * cost9) + CDbl(cleaning * cost9 * tax)
                ListBox2.Items.Add("Cleaning Towels Cost = " & FormatCurrency(Val(tot10)))
            End If
            If IsNumeric(TextBox13.Text) And RadioButton13.Checked = True Then
                tot11 = CInt(dining * cost10) + CDbl(dining * cost10 * tax)
                ListBox2.Items.Add("Dining Napkins Cost = " & FormatCurrency(Val(tot11)))
            End If
            If IsNumeric(TextBox14.Text) And RadioButton14.Checked = True Then
                tot12 = CInt(roomservice * cost11) + CDbl(roomservice * cost11 * tax)
                ListBox2.Items.Add("Room Service Napkins Cost = " & FormatCurrency(Val(tot12)))
            End If
            If IsNumeric(TextBox15.Text) And RadioButton15.Checked = True Then
                tot13 = CInt(lounge * cost12) + CDbl(lounge * cost12 * tax)
                ListBox2.Items.Add("Lounge Napkins Cost = " & FormatCurrency(Val(tot13)))
            End If
            If IsNumeric(TextBox16.Text) And RadioButton16.Checked = True Then
                tot14 = CInt(pants * cost13) + CDbl(pants * cost13 * tax)
                ListBox2.Items.Add("Chef's Pants Cost = " & FormatCurrency(Val(tot14)))
            End If
            If IsNumeric(TextBox17.Text) And RadioButton17.Checked = True Then
                tot15 = CInt(shirts * cost14) + CDbl(shirts * cost14 * tax)
                ListBox2.Items.Add("Chef's Shirts Cost = " & FormatCurrency(Val(tot15)))
            End If
            If IsNumeric(TextBox18.Text) And RadioButton18.Checked = True Then
                tot16 = CInt(hats * cost15) + CDbl(hats * cost15 * tax)
                ListBox2.Items.Add("Chef's Hats Cost = " & FormatCurrency(Val(tot16)))
            End If
            If IsNumeric(TextBox19.Text) And RadioButton19.Checked = True Then
                tot17 = CInt(small * cost16) + CDbl(small * cost16 * tax)
                ListBox2.Items.Add("Small Table Clothes Cost = " & FormatCurrency(Val(tot17)))
            End If
            If IsNumeric(TextBox20.Text) And RadioButton20.Checked = True Then
                tot18 = CInt(large * cost17) + CDbl(large * cost17 * tax)
                ListBox2.Items.Add("Large Table Clothes Cost = " & FormatCurrency(Val(tot18)))
            End If
            If IsNumeric(TextBox21.Text) And RadioButton21.Checked = True Then
                tot19 = CInt(banquet * cost18) + CDbl(banquet * cost18 * tax)
                ListBox2.Items.Add("Banquet Table Clothes Cost = " & FormatCurrency(Val(tot19)))
            End If
        End If
        Try
            For i As Integer = 0 To Me.ListBox2.Items.Count - 1
                ListBox2.SelectedIndex = i
                total = tot1 + Val(ListBox2.SelectedItem.ToString) +
                        tot2 + Val(ListBox2.SelectedItem.ToString) +
                        tot3 + Val(ListBox2.SelectedItem.ToString) +
                        tot4 + Val(ListBox2.SelectedItem.ToString) +
                        tot5 + Val(ListBox2.SelectedItem.ToString) +
                        tot6 + Val(ListBox2.SelectedItem.ToString) +
                        tot7 + Val(ListBox2.SelectedItem.ToString) +
                        tot8 + Val(ListBox2.SelectedItem.ToString) +
                        tot9 + Val(ListBox2.SelectedItem.ToString) +
                        tot10 + Val(ListBox2.SelectedItem.ToString) +
                        tot11 + Val(ListBox2.SelectedItem.ToString) +
                        tot12 + Val(ListBox2.SelectedItem.ToString) +
                        tot13 + Val(ListBox2.SelectedItem.ToString) +
                        tot14 + Val(ListBox2.SelectedItem.ToString) +
                        tot15 + Val(ListBox2.SelectedItem.ToString) +
                        tot16 + Val(ListBox2.SelectedItem.ToString) +
                        tot17 + Val(ListBox2.SelectedItem.ToString) +
                        tot18 + Val(ListBox2.SelectedItem.ToString) +
                        tot19 + Val(ListBox2.SelectedItem.ToString)
            Next i
            TextBox2.Text = FormatCurrency(total.ToString)
        Catch ex As Exception
        End Try

    End Sub
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Me.Close()
    End Sub
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        TextBox3.Clear()
        sheets = 0
        TextBox3.Text = "0"
        RadioButton3.Checked = False
        TextBox4.Clear()
        fittedsheets = 0
        TextBox4.Text = "0"
        RadioButton4.Checked = False
        TextBox5.Clear()
        pillows = 0
        TextBox5.Text = "0"
        RadioButton5.Checked = False
        TextBox6.Clear()
        pillowscases = 0
        TextBox6.Text = "0"
        RadioButton6.Checked = False
        TextBox7.Clear()
        flatsheets = 0
        TextBox7.Text = "0"
        RadioButton7.Checked = False
        TextBox8.Clear()
        comforter = 0
        TextBox8.Text = "0"
        RadioButton8.Checked = False
        TextBox9.Clear()
        kitchen = 0
        TextBox9.Text = "0"
        RadioButton9.Checked = False
        TextBox10.Clear()
        bath = 0
        TextBox10.Text = "0"
        RadioButton10.Checked = False
        TextBox11.Clear()
        handwash = 0
        TextBox11.Text = "0"
        RadioButton11.Checked = False
        TextBox12.Clear()
        cleaning = 0
        TextBox12.Text = "0"
        RadioButton12.Checked = False
        TextBox13.Clear()
        dining = 0
        TextBox13.Text = "0"
        RadioButton13.Checked = False
        TextBox14.Clear()
        roomservice = 0
        TextBox14.Text = "0"
        RadioButton14.Checked = False
        TextBox15.Clear()
        lounge = 0
        TextBox15.Text = "0"
        RadioButton15.Checked = False
        TextBox16.Clear()
        pants = 0
        TextBox16.Text = "0"
        RadioButton16.Checked = False
        TextBox17.Clear()
        shirts = 0
        TextBox17.Text = "0"
        RadioButton17.Checked = False
        TextBox18.Clear()
        hats = 0
        TextBox18.Text = "0"
        RadioButton18.Checked = False
        TextBox19.Clear()
        small = 0
        TextBox19.Text = "0"
        RadioButton19.Checked = False
        TextBox20.Clear()
        large = 0
        TextBox20.Text = "0"
        RadioButton20.Checked = False
        TextBox21.Clear()
        banquet = 0
        TextBox21.Text = "0"
        RadioButton21.Checked = False
    End Sub
    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        TextBox2.Text = "0"
        TextBox2.Clear()
        total = 0
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
        If RadioButton9.Checked = True Then
            kitchen = kitchen & y
            TextBox9.Text = kitchen
        End If
        If RadioButton10.Checked = True Then
            bath = bath & y
            TextBox10.Text = bath
        End If
        If RadioButton11.Checked = True Then
            handwash = handwash & y
            TextBox11.Text = handwash
        End If
        If RadioButton12.Checked = True Then
            cleaning = cleaning & y
            TextBox12.Text = cleaning
        End If
        If RadioButton13.Checked = True Then
            dining = dining & y
            TextBox13.Text = dining
        End If
        If RadioButton14.Checked = True Then
            roomservice = roomservice & y
            TextBox14.Text = roomservice
        End If
        If RadioButton15.Checked = True Then
            lounge = lounge & y
            TextBox15.Text = lounge
        End If
        If RadioButton16.Checked = True Then
            pants = pants & y
            TextBox16.Text = pants
        End If
        If RadioButton17.Checked = True Then
            shirts = shirts & y
            TextBox17.Text = shirts
        End If
        If RadioButton18.Checked = True Then
            hats = hats & y
            TextBox18.Text = hats
        End If
        If RadioButton19.Checked = True Then
            small = small & y
            TextBox19.Text = small
        End If
        If RadioButton20.Checked = True Then
            large = large & y
            TextBox20.Text = large
        End If
        If RadioButton21.Checked = True Then
            banquet = banquet & y
            TextBox21.Text = banquet
        End If
    End Sub
End Class

