Public Class coinslot
    Public Event coinreturnevent(d As Integer, q As Integer, di As Integer, n As Integer)
    Public Property quarters As Integer
    Public Property nickels As Integer
    Public Property dimes As Integer
    Public Property dollars As Integer
    Public ReadOnly Property total As Decimal
        Get
            Return dollars + quarters * 0.25 + dimes * 0.1 + nickels * 0.05
        End Get
    End Property
    Sub coinreturn()
        RaiseEvent coinreturnevent(dollars, quarters, dimes, nickels)
        quarters = 0
        nickels = 0
        dimes = 0
        dollars = 0
    End Sub
    Sub insertnickels()
        nickels = nickels + 1
    End Sub
    Sub insertquarter()
        quarters = quarters + 1
    End Sub
    Sub insertdimes()
        dimes = dimes + 1
    End Sub
    Sub insertdollars()
        dollars = dollars + 1
    End Sub
End Class
