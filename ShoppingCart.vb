Public Class ShoppingCart
    Private _products As New Dictionary(Of Product, Integer)

    Public Sub AddProduct(product As Product, quantity As Integer)
        If _products.ContainsKey(product) Then
            _products(product) += quantity
        Else
            _products(product) = quantity
        End If
    End Sub

    Public Function CalculateTotal() As Double
        Dim total As Double = 0
        For Each entry In _products
            total += entry.Key.Price * entry.Value
        Next
        Return total
    End Function
End Class
