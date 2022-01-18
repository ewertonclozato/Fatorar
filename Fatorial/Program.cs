using System;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número para fatorar:");
            var numFat = new NumeroFat(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine();

            Console.WriteLine($"Fatorial de: {numFat.Numero}\n");
            var fatorial = numFat.Numero;
            var result = numFat.Numero;


            for (int i = numFat.Numero - 1; i > 0; i--)
            {
                result *= i;
                Console.WriteLine($"{fatorial} x {i} = {result}");
                fatorial *= i;
            }

            Console.WriteLine();
            Console.Write($"Fatorial de {numFat.Numero} é: {numFat.MostrarResuldado(result.ToString())}\n");
        }

        public class NumeroFat
        {
            public NumeroFat(int numero)
            {
                this.Numero = numero;
            }
            public int Numero { get; set; }
            public string Resultado { get; set; }

            public string MostrarResuldado(string result)
            {
                this.Resultado = result;
                return Resultado;
            }
        }
    }
}