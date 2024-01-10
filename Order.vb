Public Class Order
    Private _orderId As Integer
    Private _shoppingCart As ShoppingCart

    Public Sub New(orderId As Integer, shoppingCart As ShoppingCart)
        _orderId = orderId
        _shoppingCart = shoppingCart
    End Sub

    Public ReadOnly Property OrderId As Integer
        Get
            Return _orderId
        End Get
    End Property

    Public ReadOnly Property ShoppingCart As ShoppingCart
        Get
            Return _shoppingCart
        End Get
    End Property
End Class
