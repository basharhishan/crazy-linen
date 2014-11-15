Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Form2
    Dim dbCon As MySqlConnection
    Dim strQuery As String = ""
    Dim SQLCmd As MySqlCommand
    Dim dr As MySqlDataReader
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GetDBData()
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim oExcel As Object
        Dim oBook As Object
        Dim oSheet As Object

        'Start a new workbook in Excel
        oExcel = CreateObject("Excel.Application")
        oBook = oExcel.Workbooks.Add


        'Add data to cells of the first worksheet in the new workbook
        oSheet = oBook.Worksheets(1)
        oSheet.Range("A1").Value = "Last Name"
        oSheet.Range("B1").Value = "First Name"
        oSheet.Range("A1:B1").Font.Bold = True
        oSheet.Range("A2").Value = "Doe"
        oSheet.Range("B2").Value = "John"

        'Save the Workbook and Quit Excel
        oBook.SaveAs "C:\Book1.xls"
        oExcel.Quit()
    End Sub
End Class