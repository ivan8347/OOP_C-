
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction = new Fraction();
            Fraction A = new Fraction(-18,7);
            Console.WriteLine($"\t A = {A}");
             //A.print();
            // object
            Fraction B = new Fraction(15,8,12);
            Console.WriteLine($"\t B = {B} \n");

            Fraction C = (Fraction)A.Clone();
           Console.WriteLine($"\t C = A = { C } \n" );
            Fraction D = A * B;
           Console.Write($"\t D = A * B = { D } \n\n" ); 
            Fraction F = A / B;                 
           Console.Write($"\t F = A / B = { F } \n\n" ); 
            Fraction K = A + B;                 
           Console.Write($"\t K = A + B = { K } \n\n" ); 
            Fraction G = D - B;                 
           Console.Write($"\t G = D - B = { G } \n\n" ); 
            A += B;
           Console.Write($"\t A+= B = { A } \n\n" ); 
            A -= B;
           Console.Write($"\t A-= B = { A } \n\n" );
            A *=  B;
           Console.Write($"\t A* = B = { A } \n\n" );
            A /= B;
           Console.Write($"\t A/= B = { A } \n\n" );
            
            
        }
    }
}
