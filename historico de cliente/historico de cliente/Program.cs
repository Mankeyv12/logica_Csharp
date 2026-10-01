using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace historico_de_cliente
{// desenvolva um programa que armazena  o historico de compra de 10 cliente e mostre o total gasto por cada cliente.
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cliente = new int[10];
            int totalGasto = 0;
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Digite o total gasto pelo cliente {i + 1}: ");
                cliente[i] = int.Parse(Console.ReadLine());
                totalGasto += cliente[i];
            }

            Console.WriteLine($"Total gasto pelos 10 clientes: {totalGasto}");

        }
    }
}
