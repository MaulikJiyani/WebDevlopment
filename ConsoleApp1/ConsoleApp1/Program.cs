using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Which country you flied from:");
            string country = Console.ReadLine();

            Console.Write("How many bag you had with you:");
            int bag = Console.Read();
            Console.ReadLine();

            Console.Write("what was the total weight of your luggage :");
            float weight = Console.Read();
            float weight1 = weight / bag;
            Console.ReadLine();

            Console.Write("I flew from " +country+ " having " +bag+" bags with average weight of "+weight1+ " kg");

            Console.ReadKey();
        }
    }
}
