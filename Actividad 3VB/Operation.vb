Friend Class Operation
    Inherits Obtained_Number
    Public Sub New(ByVal num1 As Double, ByVal num2 As Double)
        MyBase.New(num1, num2)
    End Sub

    Public Overrides Sub Addition()
        Console.WriteLine("The addition of {0} + {1} is {2}", num1, num2, (num1 + num2))
    End Sub

    Public Overrides Sub Multiplication()
        Console.WriteLine("The Multiplication of {0} * {1} is {2}", num1, num2, (num1 * num2))
    End Sub

    Public Overrides Sub Substraction()
        Console.WriteLine("The Substraction of {0} - {1} is {2}", num1, num2, (num1 - num2))
    End Sub
End Class
