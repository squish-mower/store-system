Module MainModule
    Sub Main()
        ' Create products
        Dim product1 As New Product("Laptop", 1000)
        Dim product2 As New Product("Smartphone", 500)
        Dim product3 As New Product("Headphones", 50)

        ' Create a customer
        Dim customer As New Customer("John Doe")

        ' Add products to the shopping cart
        Dim shoppingCart As New ShoppingCart()
        shoppingCart.AddProduct(product1, 2)
        shoppingCart.AddProduct(product2, 1)
        shoppingCart.AddProduct(product3, 3)

        ' Place an order
        Dim order As Order = customer.PlaceOrder(shoppingCart)

        ' Display order details
        customer.DisplayOrder(order)
    End Sub
End Module
