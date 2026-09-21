using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reajuste_de_5_
{/*Faça um algoritmo que leia um valor qualquer e imprima na tela com um reajuste de 5%.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            double val, calulo;
            Console.WriteLine("digite o valor qualquer: ");
            val = int.Parse(Console.ReadLine());

            calulo = val * 1.05;
            Console.WriteLine("o valor é: "+ calulo);   
        }
    }
}
