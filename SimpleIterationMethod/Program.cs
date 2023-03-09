using System;

namespace SimpleIterationMethod
{
    internal class Program
    {
        private static double F(double x) => Math.Pow(x, 3) - 5 * Math.Pow(x, 2) - 4 * x + 20;
        private static double G(double x) => Math.Pow(5 * Math.Pow(x, 2) + 4 * x - 20, (double)1 / 3);

        public static void Main(string[] args)
        {
            Console.WriteLine("F(x) => Math.Pow(x, 3) - 5 * Math.Pow(x, 2) - 4 * x + 20");
            double eps = 1e-3;
            Console.WriteLine("Please enter epsilon:");
            eps = Double.Parse(Console.ReadLine());
            double xn = 5.5;
            Console.WriteLine($"Xn = {xn}");
            double xnplus1;
            int i = 1;
            while (true)
            {
                xnplus1 = G(xn);
                if (Math.Abs(xnplus1 - xn) < eps)
                {
                    break;
                }

                xn = xnplus1;
                Console.WriteLine($"{i}-th iteration: {xnplus1} {F(xnplus1)}");
                i++;
            }
        }
    }
}