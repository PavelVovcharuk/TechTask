using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace trinagle
{
    class Program
    {
        static void Main(string[] args)
        {
           double  x1, x2, x3, y1, y2, y3;
            Console.Write("Enter coordinate x of dot A: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter coordinate y of dot A: ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter coordinate x of dot B: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter coordinate y of dot B: ");
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter coordinate x of dot C: ");
            x3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter coordinate y of dot C: ");
            y3 = Convert.ToDouble(Console.ReadLine());

            double AB, BC, AC;
            AB = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            BC = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
            AC = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));

            Console.WriteLine("Legth of AB is: " + AB);
            Console.WriteLine("Legth of BC is: " + BC);
            Console.WriteLine("Legth of AC is: " + AC);

            if ((AB == BC) && (BC == AC))
                Console.WriteLine("Thinagle is equilateral");
            else
            {
                Console.WriteLine("Thinagle is NOT equilateral");
            }

            if (((AB == BC) && (BC != AC)) || ((AB == AC) && (AC != BC )) || ((BC == AC) && (AC != AB)))
                Console.WriteLine("Thinagle is isosceles");
            else
            {
                Console.WriteLine("Thinagle is NOT isosceles");
            }

            if (Math.Pow(AB, 2) - (Math.Pow(BC, 2) + Math.Pow(AC, 2)) <= -0.5)
                Console.WriteLine("Thinagle is right");

            else if (Math.Pow(AC, 2) - (Math.Pow(AB, 2) + Math.Pow(BC, 2)) <= -0.5)
                Console.WriteLine("Thinagle is right");

            else if (Math.Pow(BC, 2) - (Math.Pow(AB, 2) + Math.Pow(AC, 2)) <= -0.5)
                Console.WriteLine("Thinagle is right");

            else
            {
                Console.WriteLine("Thinagle is NOT right");
            }

            double P = AB + BC + AC;
            Console.WriteLine("Perimeter: " + P);

            Console.WriteLine("Parity number is range from 0 to trinagle perimeter: ");
            for (double i = 0; i < P; i = i + 2)
            {
                
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}