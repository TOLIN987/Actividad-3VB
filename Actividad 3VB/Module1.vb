Imports System.Diagnostics.Eventing.Reader
Imports System.Globalization

Module Module1

    Sub Main()
        Dim num1 As Double
        Dim num2 As Double
        Dim Validation As Boolean = False
        While Validation = False
            Console.Write("Write the first number")
            Validation = Double.TryParse(Console.ReadLine(), num1)
            If Validation = False Then
                Console.WriteLine("Write a valid number")
            Else
                Exit While
            End If
        End While
        Validation = False
        While Validation = False
            Console.Write("Write the second number")
            Validation = Double.TryParse(Console.ReadLine(), num2)
            If Validation = False Then
                Console.WriteLine("Write a valid number")
            Else
                Exit While
            End If
        End While
        Dim numbers As Obtained_Number = New Operation(num1, num2)
        numbers.Addition()
        numbers.Multiplication()
        numbers.Substraction()
    End Sub

End Module
