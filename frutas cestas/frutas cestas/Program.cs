using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frutas_cestas
{
    internal class Program
    {//"implemente um sistema que armazena as quantidades de 5 tipos de frutas em 3 cestas diferentes e calcule o total de frutas em cada cesta e o total de frutas de cada tipo."

        static void Main(string[] args)
        {
            int[]frutas = new int[5];
            int[] cestas = new int[3];
            int totalFrutas = 0;
            for (int i = 0; i < cestas.Length; i++)
            {
                Console.WriteLine($"Cesta {i + 1}:");
                for (int j = 0; j < frutas.Length; j++)
                {
                    Console.Write($"Digite a quantidade de frutas do tipo {j + 1}: ");
                    frutas[j] = int.Parse(Console.ReadLine());
                    cestas[i] += frutas[j];
                    totalFrutas += frutas[j];
                }
                Console.WriteLine($"Total de frutas na cesta {i + 1}: {cestas[i]}");
            }


        }
    }
}
