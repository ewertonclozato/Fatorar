using System;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número para fatorar:");
            var numFat = new NumeroFat(int.Parse(Console.ReadLine()));
            Console.WriteLine();

            Console.WriteLine($"Fatorial de: {numFat.Numero}\n");

            numFat.Fat(numFat.Numero);

            Console.WriteLine();
            Console.Write($"Fatorial de {numFat.Numero} é: ");
            numFat.MostrarResuldado();
        }

        public class NumeroFat
        {
            public NumeroFat(int numero)
            {
                Numero = numero;
            }
            public int Numero { get; set; }
            public string Resultado { get; set; }

            public int Fat(int numero)
            {
                int result;
                if (numero <= 1)
                    result = 1;
                else
                    result = numero * Fat(numero - 1);


                Resultado = result.ToString();
                return result;
            }

            public void MostrarResuldado()
            {
                Console.WriteLine(Resultado);
            }
        }
    }
}
