using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dia_quente
{// crie um algoritimo que armazene as temperaturas de uma cidade durante uma semana 
    // informe o dia mais quente e o dia mais frio.
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] temperatura = new int[7];
            for (int i = 0; i < temperatura.Length; i++)
            {
                Console.Write($"Temperatura do dia {i + 1}: ");
                string entrada = Console.ReadLine();
                if (!int.TryParse(entrada, out temperatura[i]))
                {
                    Console.WriteLine("Entrada inválida. Digite um número inteiro.");
                    i--; // repetir este índice
                }
            }

            int indiceMax = 0, indiceMin = 0;
            for (int i = 1; i < temperatura.Length; i++)
            {
                if (temperatura[i] > temperatura[indiceMax]) indiceMax = i;
                if (temperatura[i] < temperatura[indiceMin]) indiceMin = i;
            }

            Console.WriteLine($"Dia mais quente: Dia {indiceMax + 1} com {temperatura[indiceMax]}°");
            Console.WriteLine($"Dia mais frio: Dia {indiceMin + 1} com {temperatura[indiceMin]}°");
        }
    }
}
