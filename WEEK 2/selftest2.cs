using System;

class Calculator
{
    private double _value;


    public Calculator(double initialValue)
    {
        _value = initialValue;
    }

    public double Add(double number)
    {
        return _value += number;
    }

    public double Subtract(double number)
    {
        return _value -= number;
    }

    public double Multiply(double number)
    {
        return _value *= number;
    }

    public double Divide(double number)
    {
        if (number == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return _value;
        }
        return _value /= number;
    }

    public double GetValue()
    {
        return _value;
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator(10);
        Console.WriteLine("Initial Value: " + calc.GetValue());

        Console.WriteLine("After Addition: " + calc.Add(5));
        Console.WriteLine("After Subtraction: " + calc.Subtract(3));
        Console.WriteLine("After Multiplication: " + calc.Multiply(4));
        Console.WriteLine("After Division: " + calc.Divide(2));
        Console.WriteLine("Final Value: " + calc.GetValue());
    }
}