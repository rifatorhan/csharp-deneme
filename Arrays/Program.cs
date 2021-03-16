using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "Rıfat";
            students[1] = "Orhan";
            students[2] = "Mustafa";

            string[] students2 = new string[3] { "Rıfat", "Orhan", "Mustafa"};

            string[] students3 = { "Rıfat", "Orhan", "Mustafa" };


            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            string[,] regions = new string[5,3]
            {
                {"İstanbul","İzmit","Balıkesir"},
                {"Ankara","Konya","Balıkesir"},
                {"Antalya","Adana","Mersin"},
                {"Rize","Trabzon","Samsun"},
                {"İzmir","Muğla","Manisa"}
            };
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j  <= regions.GetUpperBound(1); j ++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("*******");
            }
            Console.ReadLine();
        }
    }
}
