using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String a = "q";
            while (a != "0" || a != "") {
                Console.Write("Zadacha: ");
                a = Console.ReadLine();
                switch (a)
                {
                    case "1":
                        one(); break;
                    default:
                        Console.WriteLine("Ne pravilni");
                        break;

                }

            }

        }
        static void one()
        {
            Console.Write("Kids: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Apples: ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(k / n);
        }
    }
}
