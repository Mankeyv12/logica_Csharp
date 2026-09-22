using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valor_b_por_a
{
    /*7-  Faça um algoritmo que receba um valor A e B, e troque o valor de A por B e o valor de B por A e imprima na tela os valores.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de A:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B:");
            double b = double.Parse(Console.ReadLine());

            // Troca os valores
            double temp = a;
            a = b;
            b = temp;

            Console.WriteLine("Após a troca:");
            Console.WriteLine("Valor de A: " + a);
            Console.WriteLine("Valor de B: " + b);
        }
    }
}
