using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /*1-	Faça um algoritmo que leia dois valores inteiros A e B, se os valores de A e B forem iguais, deverá somar os dois valores, 
caso contrário devera multiplicar A por B. Ao final de qualquer um dos cálculos deve-se atribuir o resultado a uma variável C e
imprimir seu valor na tela.
*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b ,c;

            Console.WriteLine("digite o valor: a");
            a =  int.Parse(Console.ReadLine());
            Console.WriteLine("digite o valor: b");
            b = int.Parse(Console.ReadLine());

            c = a + b;
            
            Console.Clear();
            Console.WriteLine("o valor de a e b: "+ c );



        }
    }
}
