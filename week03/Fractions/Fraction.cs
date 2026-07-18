public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        this._numerator = 1;
        this._denominator = 1;
    }

    public Fraction(int numerator)
    {
        this._numerator = numerator;
        this._denominator = 1;
    }
    public Fraction(int numerator, int denominator)
    {
        this._numerator = numerator;
        this._denominator = denominator;
    }

    public int getNumerator()
    {
        return _numerator;
    }
    public int getDenominator()
    {
        return _denominator;
    }
    public void setNumerator(int numerator)
    {
        this._numerator = numerator;
    }
    public void setDenominator(int denominator)
    {
        this._denominator = denominator;
    }

    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }
    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}