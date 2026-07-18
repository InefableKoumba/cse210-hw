using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new();
        Fraction f2 = new(3);
        Fraction f3 = new(5, 8);

        f1.setNumerator(2);
        f1.setDenominator(4);

        f2.setNumerator(1);
        f2.setDenominator(6);

        f3.setNumerator(7);
        f3.setDenominator(10);

        Console.WriteLine($"f1: {f1.GetFractionString()} = {f1.GetDecimalValue()}");
        Console.WriteLine($"f2: {f2.GetFractionString()} = {f2.GetDecimalValue()}");
        Console.WriteLine($"f3: {f3.GetFractionString()} = {f3.GetDecimalValue()}");
    }
}