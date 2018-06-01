using System;
using System.Diagnostics;

public static class RealNumberExtension
{
    public static double Expreal(this int realNumber, RationalNumber r)
    {
        return Math.Pow(realNumber, (double)(r.numerator) / (double)r.denominator);
    }
}

public struct RationalNumber
{
    public int numerator;
    public int denominator;
    public RationalNumber(int numerator, int denominator)
    {
        this.numerator = numerator / GCD(numerator, denominator);
        this.denominator = denominator / GCD(numerator, denominator);
        if (this.denominator < 0)
        {
            this.denominator = -this.denominator;
            this.numerator = -this.numerator;
        }
    }

    static int GCD(int a, int b) => b == 0 ? Math.Abs(a) : GCD(Math.Abs(b), Math.Abs(a) % Math.Abs(b));


    public RationalNumber Add(RationalNumber r)
    {
        int numerator = this.numerator * r.denominator + r.numerator * this.denominator;
        int denominator = this.denominator * r.denominator;
        return new RationalNumber(numerator, denominator);
    }

    public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
    {
        return r1.Add(r2);
    }

    public RationalNumber Sub(RationalNumber r)
    {
        int numerator = this.numerator * r.denominator - r.numerator * this.denominator;
        int denominator = this.denominator * r.denominator;
        return new RationalNumber(numerator, denominator);
    }

    public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
    {
        return r1.Sub(r2);
    }

    public RationalNumber Mul(RationalNumber r)
    {
        int numerator = this.numerator * r.numerator;
        int denominator = this.denominator * r.denominator;
        return new RationalNumber(numerator, denominator);
    }

    public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
    {
        return r1.Mul(r2);
    }

    public RationalNumber Div(RationalNumber r)
    {
        int numerator = this.numerator * r.denominator;
        int denominator = this.denominator * r.numerator;

        return new RationalNumber(numerator, denominator);
    }

    public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
    {
        return r1.Div(r2);
    }

    public RationalNumber Abs()
    {
        return this.numerator < 0 ? new RationalNumber(-this.numerator, this.denominator) : new RationalNumber(this.numerator, this.denominator);
    }

    public RationalNumber Reduce()
    {
        return new RationalNumber(this.numerator, this.denominator);
    }

    public RationalNumber Exprational(int power)
    {
        this.numerator = (int)Math.Pow((double)this.numerator, (double)power);
        this.denominator = (int)Math.Pow((double)this.denominator, (double)power);
        return new RationalNumber(this.numerator, this.denominator);
    }

    public double Expreal(int baseNumber)
    {
        return Math.Pow(baseNumber, (double)numerator / (double)denominator);
    }
}