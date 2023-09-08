using System;
using System.Diagnostics;
using System.Globalization;
using System.IO.Pipes;
using System.Threading.Tasks.Sources;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        double A, B, C;
        double delta, r1, r2;

        string[] valores = Console.ReadLine().Split(' ');
        A = double.Parse(valores[0],CultureInfo.InvariantCulture);
        B = double.Parse(valores[1],CultureInfo.InvariantCulture);
        C = double.Parse(valores[2], CultureInfo.InvariantCulture);

        delta = Math.Pow(B, 2) - (4 * A * C);

        if (delta < 0 || A == 0)
        {
            Console.WriteLine("Impossivel calcular");
        }
        else
        {
            r1 = (- B + Math.Sqrt(delta)) / (2 * A);
            r2 = (- B - Math.Sqrt(delta)) / (2 * A);

            Console.WriteLine($"R1 = {r1.ToString("F5",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"R2 = {r2.ToString("F5", CultureInfo.InvariantCulture)}");
        }
    }
}
