using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcular_desconto
{
    internal class Program
        //calcular desconto
        //um produto com preço acima de 100 reais tem desconto de 10% casp cpmtrario o desconto é de 5%
        // dado o preço calcule o valor do desconto
    {
        static void Main(string[] args)
        {
            double valor, desconto;
            Console.WriteLine("valor total da compra");
            valor = int.Parse(Console.ReadLine());
            if(valor > 100  )
            {
                desconto = valor * 0.10;
                Console.WriteLine(desconto + "reais de desconto");
            }
            else
            {
                desconto = valor * 0.05;
                Console.WriteLine(desconto + " reais de desconto");
            }
        }
    }
}
