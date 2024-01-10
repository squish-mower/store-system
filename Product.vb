Public Class Product
    Private _name As String
    Private _price As Double

    Public Sub New(name As String, price As Double)
        _name = name
        _price = price
    End Sub

    Public ReadOnly Property Name As String
        Get
            Return _name
        End Get
    End Property

    Public ReadOnly Property Price As Double
        Get
            Return _price
        End Get
    End Property
End Class
