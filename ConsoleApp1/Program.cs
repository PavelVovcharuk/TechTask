using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double  x1, x2, x3, y1, y2, y3;
            Console.Write("Enter coordinate x of dot A:\n");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter coordinate y of dot A:\n");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter coordinate x of dot B:\n");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter coordinate y of dot B:\n");
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter coordinate x of dot C:\n");
            x3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter coordinate y of dot C:\n");
            y3 = Convert.ToDouble(Console.ReadLine());

            double AB, BC, AC;
            AB = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            BC = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
            AC = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));

            Console.WriteLine("\nLength of AB is: " + "'" + AB + "'");
            Console.WriteLine("Length of BC is: " + "'" + BC + "'");
            Console.WriteLine("Length of AC is: " + "'" + AC + "'");
            
            if ((AB == BC) && (BC == AC))
                Console.WriteLine("\nTriangle IS 'Equilateral'");

            else
            {
                Console.WriteLine("\nTriangle IS NOT 'Equilateral'");
            }

            if (((AB == BC) && (BC != AC)) || ((AB == AC) && (AC != BC )) || ((BC == AC) && (AC != AB)))
                Console.WriteLine("Triangle IS 'Isosceles'");
            else
            {
                Console.WriteLine("Triangle IS NOT 'Isosceles'");
            }

            if (Math.Pow(AB, 2) - (Math.Pow(BC, 2) + Math.Pow(AC, 2)) <= -0.2)
                Console.WriteLine("Triangle IS 'Right'");
            
            else if (Math.Pow(AC, 2) - (Math.Pow(AB, 2) + Math.Pow(BC, 2)) <= -0.2)
                    Console.WriteLine("Triangle IS 'Right'");
            
            else if (Math.Pow(BC, 2) - (Math.Pow(AB, 2) + Math.Pow(AC, 2)) <= -0.2)
                Console.WriteLine("Triangle IS 'Right'");

            else
            {
                Console.WriteLine("Triangle IS NOT 'Right'");
            }

            double P = AB + BC + AC;
            Console.WriteLine("\nPerimeter: " + "'" + P + "'");

            Console.WriteLine("\nParity number is range from 0 to triangle perimeter: ");
            for (double i = 0; i < P; i = i + 2)
            {
                
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
