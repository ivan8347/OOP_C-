using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    internal class Fraction
    {
        private int integer;
        private int numerator;
        private int denominator;
    public int get_numerator()
        {
            return numerator;
        }
    public int get_ineger() { return integer; }
        public int get_denominator() {  return denominator; }
        public Fraction()
        {
            this.integer = 0;
            this.numerator = 0;
            this.denominator = 1;

            Console.WriteLine($"DefaultConstructor:\t  {this}"); 
   }
   public Fraction(int integer)
 {   this.integer = integer;
     this.denominator = 1;
    // Console.WriteLine($"SingleArgConstructor:\t {GetHashCode()ToString("X")}  {this}"); 
    // cout << "SingleArgConstructor:\t" << this << endl;

 }
  public Fraction(int numerator, int denominator)
        {
            this.integer = 0;
            this.numerator = numerator;
            this.denominator = denominator;
            Reduce();

           // cout << "Constructor:\t\t" << this << endl;
        }
  public Fraction(int integer, int numerator, int denominator)
        {
            this.integer  = integer;
            this.numerator = numerator;
            this.denominator = denominator;
            //cout << "Constructor : \t\t" << this << endl;
            Reduce();
        }

        public void Reduce()
        {

            int gcd = GCD(Math.Abs(numerator), Math.Abs(denominator));
            numerator /= gcd;
            denominator /= gcd;

            // Обеспечиваем, что знак у дроби у знаменателя
            if (denominator < 0)
            {
                integer = -integer;
                numerator = -numerator;
                denominator = -denominator;
            }
        }
        public int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
       public Fraction(Fraction other)
	{
		this.integer = other.integer;
		this.numerator = other.numerator;
		this.denominator = other.denominator;
		Console.WriteLine($"\t CopyConstructor : {this}");
	}
       // "="
        public object Clone()
        {
            return new Fraction(this);
        }
        
        public Fraction to_improper()
        {
            numerator += integer * denominator;
            integer = 0;
            return this;
        }
       public Fraction to_proper()
        {
            integer += numerator / denominator;
            numerator %= denominator;
            if (numerator < 0) numerator *= -1;
            return this;
        }
       public Fraction inverted()
        {
            this.to_improper();
            int temp = this.numerator;
            this.numerator = this.denominator;
            this.denominator = temp;
             return this;
        }
        // '*'
        public static Fraction operator *(Fraction left, Fraction right)
        {
            Fraction l = (Fraction)left.Clone();
            Fraction r = (Fraction)right.Clone();
            l.to_improper();
            r.to_improper();
            return new Fraction
            (
                l.get_numerator() *   r.get_numerator(),
                l.get_denominator() * r.get_denominator()
            ).to_proper();
            
        }
        //  '/'
       public static Fraction operator /( Fraction left,  Fraction right)
       {
            //Fraction l = (Fraction)left.Clone();
            //Fraction r = (Fraction)right.Clone();
            //return (l * r.inverted());
            return left * right.inverted();
        }

        //  "+"
       public static Fraction operator +(Fraction left, Fraction right)
        {
            Fraction l = (Fraction)left.Clone();
            Fraction r = (Fraction)right.Clone();
            l.to_improper();
            r.to_improper();
            return new Fraction
            (
                l.get_numerator() * r.get_denominator() +
                r.get_numerator() * l.get_denominator(),
                l.get_denominator() * r.get_denominator()
            ).to_proper();

        }
        public static Fraction operator -(Fraction left, Fraction right)
        {
            Fraction l = (Fraction)left.Clone();
            Fraction r = (Fraction)right.Clone();
            l.to_improper();
            r.to_improper();
            return new Fraction
            (
                l.get_numerator() * r.get_denominator() -
                r.get_numerator() * l.get_denominator(),
                l.get_denominator() * r.get_denominator()
            ).to_proper();
         }

        public void print()
        {

            Console.WriteLine($" {integer}({numerator}/{denominator})");
        }


        public override string ToString()
        {
            to_proper();
            if (integer != 0)
            {
                if (numerator != 0)
                    return $"{integer} {Math.Abs(numerator)}/{denominator}";
                else
                    return $"{integer}";
            }
            else
            {
                if (numerator != 0)
                    return $"{numerator}/{denominator}";
                else
                    return "0";
            }
        }



    }
}
