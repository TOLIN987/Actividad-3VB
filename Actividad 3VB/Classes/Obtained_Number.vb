Public Class Obtained_Number

    Protected num1 As Double
    Protected num2 As Double

    Public Sub New(num1 As Double, num2 As Double)
        Me.num1 = num1
        Me.num2 = num2
    End Sub

    Public Overridable Sub Addition()
        Console.Write("The addition of")
    End Sub

    Public Overridable Sub Substraction()
        Console.WriteLine("The Substraction of")
    End Sub

    Public Overridable Sub Multiplication()
        Console.WriteLine("The Multiplication of")
    End Sub
End Class
