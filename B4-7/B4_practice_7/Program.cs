using System;

namespace B4_practice_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = 10;
            Console.WriteLine("Сгенерированный массив:");
            double[] a = new double[n];
            for (int i = 0; i < n; ++i)
            {
                a[i] = rnd.Next(-100, 100) * 1.0 / 10;
                Console.Write(a[i] + " ");
            }

            double p1, p2;
            p1 = 1; p2 = 1;
            for (int i = 0; i < n; ++i)
            {
                if (a[i] > 0)
                {
                    p1 *= a[i];
                }
                else if (a[i] < 0)
                {
                    p2 *= a[i];
                }
            }
            Console.Write("\nБольшее значение имеет ");
            if (p1 > p2)
            {
                Console.Write("P1");
            }
            else
            {
                Console.Write("P2");
            }
            Console.WriteLine("\nЗначение: " + Math.Max(Math.Abs(p2), p1));
        }
    }
}
