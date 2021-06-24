using System;
using System.Globalization;

namespace uri1051
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double valorFinal = 0.0;

            if(salario < 2000.00)
            {
                valorFinal = 0.0;
            }
            else if (salario > 2000.01 && salario < 3000.00)
            {

                valorFinal = (salario - 3000.0) * 0.10 + 100.0 * 0.08;
               
            }
            else if(salario > 3000.01 && salario < 4500.00)
            {
                
                valorFinal = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;

            }
            else if(salario > 4500.00)
            {

                valorFinal = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;

            }
            else if(valorFinal == 0.0)
            {
                Console.WriteLine("Isento");
            }

            Console.WriteLine("R$ " + valorFinal.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}
