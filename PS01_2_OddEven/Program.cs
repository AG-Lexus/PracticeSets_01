using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS01_2_OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program determine if the number is positive or negative!");
            Console.WriteLine("Enter a number:");
            int user_input = Convert.ToInt32(Console.ReadLine());

            if (user_input >= 1)
            {
                Console.WriteLine($"The number {user_input} is positive!");
            }
            else
            {
                Console.WriteLine($"The number {user_input} is negative!");
            }


        }

    }
}
