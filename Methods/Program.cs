﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //int number1;
            //int number2 = 30;
            //var result = Add2(20);
            //var result1 = Add3(out number1, number2);
            //Console.WriteLine(result);
            //Console.WriteLine(result1);
            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 5));
            Console.WriteLine(Add4(2, 3, 4, 5, 6, 7));
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }
        //void git şuraya şunu yap
        //işlem yapılacaksa dönecek olan değer türüne göre static devamı
        static int Add2(int number1, int number2=30)
        {
            var result = number1 + number2;
            return result;
        }
        static int Add3(out int number1, int number2)
        {
            number1 = 30;
            var result = number1 + number2;
            return result;
        }
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
        static int Add4(int number,params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
