Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Price As Decimal
        Dim Quantity As Integer
        Dim Discount As Decimal
        Dim VAT As Decimal
        Dim TotalCost As Decimal


        Price = 10
        Quantity = 10
        Discount = 2
        VAT = 0.15

        'Total cost without discount
        TotalCost = Price * Quantity

        MsgBox("Total cost without discount is " & TotalCost)

        'Total Cost with Discount
        TotalCost = (Price - Discount) * Quantity

        MsgBox("Total cost with Discount is " & TotalCost)

        'Total cost with Discount including VAT
        TotalCost = (Price - Discount) * Quantity * VAT + (Price - Discount) * Quantity

        MsgBox("Total cost including vat is " & TotalCost)


    End Sub
End Class
