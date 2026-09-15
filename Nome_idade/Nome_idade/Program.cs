using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nome_idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string  nome;//variavel cadeia
            int idade;// variavel inteira
            Console.WriteLine("Digite seu nome: ");//escreva
           nome = Console.ReadLine();//leia
            Console.WriteLine("digite sua idade");
            idade = int.Parse(Console.ReadLine());//
                                                  //converte o que digitar em inteiro
            Console.WriteLine("parabens " + nome + "voce acabou ganhar uma coca-cola");
            Console.WriteLine("\n voce possui " + idade+ "anos, beba mais  agua ");


        }
    }
}
