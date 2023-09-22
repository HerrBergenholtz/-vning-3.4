using System;

namespace Övning_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många poäng fick du på matte nationella?");
            int res = int.Parse(Console.ReadLine());
            if (res < 18)
            {
                Console.WriteLine("Du fick betyget F :(");
            }
            else if (res < 27)
            {
                Console.WriteLine("Du fick betyget E");
            }
            else if (res < 35)
            {
                Console.WriteLine("Du fick ett D");
            }
            else if (res < 46)
            {
                Console.WriteLine("Du fick ett C");
            }
            else if (res < 55)
            {
                Console.WriteLine("Du fick ett B");
            }
            else
            {
                Console.WriteLine("Du fick ett A :)");
            }
            Console.ReadKey();
        }
    }
}