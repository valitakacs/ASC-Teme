using System;

namespace Moore_s_Law
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insereaza un numar: ");

            int n = int.Parse(Console.ReadLine());
            double year = Math.Log(n, 2) * 1.5;

            Console.WriteLine(year);

        }
    }
}
