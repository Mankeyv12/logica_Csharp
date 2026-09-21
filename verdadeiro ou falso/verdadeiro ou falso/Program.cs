using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verdadeiro_ou_falso
{/*4-	Faça um algoritmo que leia dois valores booleanos (lógicos) e determine se ambos são VERDADEIRO ou FALSO.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            bool val1;
            bool val2; 
            Console.WriteLine("digite valor do val1 / true ou false: ");
                val1 = bool.Parse(Console.ReadLine());
            Console.WriteLine("digite valor do val1 / true ou false: ");
            val2 = bool.Parse(Console.ReadLine());
            if (val1 && val2)
            {
                Console.WriteLine("verdadeiro");

            }
            else if (val1 == true && val2 == false)
            {
                Console.WriteLine("falso");
            }
            else
            {
                Console.WriteLine("falso");
            }


        }
    }
}
