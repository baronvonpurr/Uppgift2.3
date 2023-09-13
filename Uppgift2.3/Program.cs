using System;

namespace Uppgift2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många meter kan du hoppa");
            double längd = double.Parse(Console.ReadLine());
            double skillnad = 2.45 - längd;
            Console.WriteLine("Det är " + skillnad + "meter kortare än rekordet på 2,45 meter!");
        }
    }
}