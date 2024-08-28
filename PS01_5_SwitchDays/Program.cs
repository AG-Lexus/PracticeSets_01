using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS01_5_SwitchDays
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a radius:");
            int radius = int.Parse(Console.ReadLine());
            Console.WriteLine("A: Compute Area");
            Console.WriteLine("P: Compute Perimeter");
            Console.WriteLine("X: Exit Applications");
            string letter = Console.ReadLine();

            switch (letter)
            {
                case "A":
                    double area = 3.14 * (radius * 2);
                    Console.WriteLine(area);
                    break;
                case "P":
                    double perimeter = 3.14 * radius;
                    Console.WriteLine(perimeter);
                    break;
                case "X":

                    break;



            }



        }

    }
}
