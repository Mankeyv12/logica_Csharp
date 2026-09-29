using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] estoque = new int[10];
            int max = int.MaxValue, min = int.MinValue,prodmax = 0, prodmin = 0;
            for (int i = 0; i < estoque.Length; i++)
            {
                Console.WriteLine("Digite a quantidade do produto " + (i + 1) + ":");
                
                estoque[i] = int.Parse(Console.ReadLine());
                if (estoque[i] > max)
                {
                    max = estoque[i];
                    prodmax = i + 1;
                }
                if (estoque[i] < min)
                {
                    min = estoque[i];
                    prodmin = i + 1;
                }
            }
Console.WriteLine("O produto com maior quantidade em estoque é o produto " + (prodmax + 1) + " com " + max + " unidades.");
            Console.WriteLine("O produto com menor quantidade em estoque é o produto " + (prodmin + 1)   + " com " + min + " unidades.");
            






        }
    }
}
