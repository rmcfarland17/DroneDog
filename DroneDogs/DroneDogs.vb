Public Class DroneDogsOrder

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'Declare constants
        Const dblSalesTaxRate As Double = 0.07 'Sales tax
        Const dblHotDogCost As Double = 1.99   'Hot dog price

        'Declare variables 
        Dim intNumBeefDogs As Integer = 0   'Number of beef dogs
        Dim intNumPorkDogs As Integer = 0   'Number of pork dogs
        Dim intNumTurkeyDogs As Integer = 0 'Number of turkey dogs
        Dim intNumDogsTotal As Integer = 0  'Total number of dogs
        Dim dblOrderSubtotal As Double = 0.0
        Dim dblSalesTax As Double = 0.0
        Dim dblOrderTotal As Double = 0.0

        'Extract user typed quantities from text boxes and convert to integers
        If txtBeefDogs.Text <> "" Then
            intNumBeefDogs = Convert.ToInt32(txtBeefDogs.Text)
        End If
        If txtPorkDogs.Text <> "" Then
            intNumPorkDogs = Convert.ToInt32(txtPorkDogs.Text)
        End If
        If txtTurkeyDogs.Text <> "" Then
            intNumTurkeyDogs = Convert.ToInt32(txtTurkeyDogs.Text)
        End If

        'Calculate total number of hot dogs ordered
        intNumDogsTotal = intNumBeefDogs + intNumPorkDogs + intNumTurkeyDogs

        'Calculate subtotal, sales tax, and total amounts
        If intNumDogsTotal > 0 Then
            dblOrderSubtotal = intNumDogsTotal * dblHotDogCost
            dblSalesTax = dblOrderSubtotal * dblSalesTaxRate
            dblOrderTotal = dblOrderSubtotal + dblSalesTax

            'Convert numbers back to text and display in text boxes
            txtSubtotal.Text = dblOrderSubtotal.ToString("c2")
            txtSalesTax.Text = dblSalesTax.ToString("C2")
            txtTotalCost.Text = dblOrderTotal.ToString("C2")
        Else
            MsgBox("You didn't order anything!")
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Close form
        Me.Close()

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        'Display message box thanking the user
        MsgBox("Thank you for ordering your meal from DroneDogs!")

    End Sub

End Class
