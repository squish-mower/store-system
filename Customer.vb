Public Class Customer
    Private _name As String
    Private _orders As New List(Of Order)
    Private Shared _orderIdCounter As Integer = 1

    Public Sub New(name As String)
        _name = name
    End Sub

    Public Function PlaceOrder(shoppingCart As ShoppingCart) As Order
        Dim orderId As Integer = _orderIdCounter
        _orderIdCounter += 1
        Dim order As New Order(orderId, shoppingCart)
        _orders.Add(order)
        Return order
    End Function

    Public Sub DisplayOrder(order As Order)
        Console.WriteLine($"Order for customer {_name}:")
        Console.WriteLine("Products in the order:")
        For Each entry In order.ShoppingCart.Products
            Console.WriteLine($"{entry.Key.Name} - Quantity: {entry.Value}")
        Next
        Console.WriteLine($"Total: ${order.ShoppingCart.CalculateTotal()}")
    End Sub
End Class
