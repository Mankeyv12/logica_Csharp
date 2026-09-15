
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //crie um algoritimo para cadastro de produto:
            // codigo,fabricante, categoria,preço, estoque,valor total
            //em estoque
            int codigo, estoque;
            string fabricante, categoria;
            double preco, total;
            Console.WriteLine("digite o codigo: ");
                codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o fabricante: ");
            fabricante = Console.ReadLine();
            Console.WriteLine("digite a categoria: ");
            categoria = Console.ReadLine();
            Console.WriteLine("digite o preço: ");
            preco = double.Parse(Console.ReadLine());
            Console.WriteLine("digite o estoque: ");
            estoque = int.Parse(Console.ReadLine());
            total = preco * estoque;
                
            Console.WriteLine("o valor total em estoque é "+ total);

           













        }
    }
}
