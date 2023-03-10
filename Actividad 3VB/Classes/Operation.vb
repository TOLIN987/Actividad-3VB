Friend Class Operation
    Inherits Obtained_Number
    Public Sub New(ByVal num1 As Double, ByVal num2 As Double)
        MyBase.New(num1, num2)
    End Sub

    Public Overrides Sub Addition()
        MyBase.Addition()
        Console.WriteLine(" {0} + {1} is {2}", num1, num2, (num1 + num2))
    End Sub

    Public Overrides Sub Multiplication()
        MyBase.Multiplication()
        Console.WriteLine(" {0} * {1} is {2}", num1, num2, (num1 * num2))
    End Sub

    Public Overrides Sub Substraction()
        MyBase.Substraction()
        Console.WriteLine(" {0} - {1} is {2}", num1, num2, (num1 - num2))
    End Sub
End Class
