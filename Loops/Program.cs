using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //WhileLoop();
            //DoWhileLoop();
            //ForeachLoop();
            if (IsPriveNumber(6))
            {
                Console.WriteLine("This is a prive number.");
            }
            else
            {
                Console.WriteLine("This is not a prive number.");
            }
            Console.ReadLine();
        }
        private static bool IsPriveNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number%i==0)
                {
                    result = false;
                    i = number;
                }
                
            }
            return result;
        }
        private static void ForeachLoop()
        {
            string[] students2 = new string[3] { "Rıfat", "Orhan", "Mustafa" };
            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            }
            while (number >= 0);
        }

        private static void WhileLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Now number is {0}", number);
            Console.ReadLine();
        }

        private static void ForLoop()
        {
            for (int i = 1; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished!");
            for (int j = 100; j >= 0; j -= 2)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("Finished!");
        }
    }
}
