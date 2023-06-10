namespace Task3;

public class Fraction
{
    private long num;
    private long den;

    public long Num
    {
        get => num;
        set => num = value;
    }

    public long Den
    {
        get => den;
        set => den = value;
    }

    public static Fraction operator +(Fraction a)
    {
        return a;
    }
    
    public static Fraction operator -(Fraction a)
    {
        return new Fraction(-a.Num, a.Den);
    }
    
    public static Fraction operator +(Fraction a, Fraction b)
    {
        long newNum = a.Num * b.Den + b.Num * a.Den;
        long newDen = a.Den * b.Den;
        long maxDivider = Utils.Gcd(newNum, newDen);

        return new Fraction(newNum / maxDivider, newDen / maxDivider);
    }

    public static Fraction operator -(Fraction a, Fraction b)
    {
        return a + (-b);
    }

    public static Fraction operator *(Fraction a, Fraction b)
    {
        long newNum = a.Num * b.Num;
        long newDen = a.Den * b.Den;
        long maxDivider = Utils.Gcd(newNum, newDen);

        return new Fraction(newNum / maxDivider, newDen / maxDivider);
    }

    public static Fraction operator /(Fraction a, Fraction b)
    {
        if (b.Num == 0)
        {
            throw new DivideByZeroException();
        }
        
        long newNum = a.Num * b.Den;
        long newDen = a.Den * b.Num;
        long maxDivider = Utils.Gcd(newNum, newDen);
        
        return new Fraction(newNum / maxDivider, newDen / maxDivider);
    }

    public Fraction Sqr()
    {
        return new Fraction(num * num, den * den);
    }

    public override bool Equals(object? obj)
    {
        if (obj is Fraction other)
        {
            long first = this.Num * other.Den;
            long second = other.Num * this.Den;

            return first == second;
        }
        return false;
    }

    public override string ToString()
    {
        return $"{num} / {den}";
    }

    private void Reduce()
    {
        long maxDivider = Utils.Gcd(num < 0 ? -num : num, den);
        num /= maxDivider;
        den /= maxDivider;
    }

    public Fraction()
    {
        this.num = 0;
        this.den = 1;
    }

    public Fraction(long num)
    {
        this.num = num;
        this.den = 1;
    }
    
    public Fraction(long num, long den)
    {
        if (den == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.", nameof(den));
        }

        if (den < 0)
        {
            num *= -1;
            den *= -1;
        }
        
        this.num = num;
        this.den = den;
        
        Reduce();
    }
}