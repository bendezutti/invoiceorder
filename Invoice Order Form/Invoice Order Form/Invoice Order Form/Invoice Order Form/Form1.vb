Public Class Form1
    Private Sub BtnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click

        Dim Address As String
        Dim City As String
        Dim ChairsPrice As Integer
        Dim Chairs As Integer
        Dim Sofa As Integer
        Dim SofasPrice As Integer
        Dim Name As String
        Dim Price As Double
        Dim SalesTax As Double
        Dim TotalPrice As Double



        InvoiceNumber(Name, City)
        listBox.Items.Add("")

        listBox.Items.Add("Name: " & Name)
        Address = CStr(txtAddress.Text)
        listBox.Items.Add("Address:" & Address)
        listBox.Items.Add("City: " & City)

        listBox.Items.Add("")
        listBox.Items.Add("")

        Chairs = CDbl(txtChairs.Text)
        ChairsPrice = 350 * Chairs
        listBox.Items.Add("Number of Chairs: " & Chairs)
        Sofa = CDbl(txtSofas.Text)
        listBox.Items.Add("Number of Sofas: " & Sofa)
        SofasPrice = 925 * Sofa

        listBox.Items.Add("")
        listBox.Items.Add("")

        Price = SofasPrice + ChairsPrice
        listBox.Items.Add("           Price:   " & Price.ToString("C"))

        SalesTax = Price * 0.05
        listBox.Items.Add("   Sales Tax:   " & SalesTax.ToString("C"))

        listBox.Items.Add("                     - - - - - - - - -")

        TotalPrice = Price + SalesTax
        listBox.Items.Add("Total Price:     " & TotalPrice.ToString("C"))

    End Sub

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Sub InvoiceNumber(ByRef Name As String, ByRef City As String)
        Dim InvoiceNumber As String
        Name = CStr(txtName.Text)
        City = CStr(txtCity.Text)
        InvoiceNumber = Name.ToUpper.Substring(0, 2) & City.Substring(13, 4)
        listBox.Items.Add("Invoice Number: " & InvoiceNumber)
    End Sub


    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        listBox.Items.Clear()
        txtAddress.Text = ""
        txtCity.Text = ""
        txtChairs.Text = ""
        txtSofas.Text = ""
        txtName.Text = ""
    End Sub
End Class
