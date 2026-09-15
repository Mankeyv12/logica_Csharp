using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ano_bisexto
{
    /*6. ano bissexto
     determine se um ano é bissexto um  ano é bissexto 
    se for divisivel por 4, mas nao por 100 
    a nao ser seja divisivel por 400.
    entrada 2024
    saida ano bissexto
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            int ano;

            Console.WriteLine("
░█████╗░███╗░░██╗░█████╗░  ██████╗░██╗░██████╗░██████╗███████╗██╗░░██╗████████╗░█████╗░
██╔══██╗████╗░██║██╔══██╗  ██╔══██╗██║██╔════╝██╔════╝██╔════╝╚██╗██╔╝╚══██╔══╝██╔══██╗
███████║██╔██╗██║██║░░██║  ██████╦╝██║╚█████╗░╚█████╗░█████╗░░░╚███╔╝░░░░██║░░░██║░░██║
██╔══██║██║╚████║██║░░██║  ██╔══██╗██║░╚═══██╗░╚═══██╗██╔══╝░░░██╔██╗░░░░██║░░░██║░░██║
██║░░██║██║░╚███║╚█████╔╝  ██████╦╝██║██████╔╝██████╔╝███████╗██╔╝╚██╗░░░██║░░░╚█████╔╝
╚═╝░░╚═╝╚═╝░░╚══╝░╚════╝░  ╚═════╝░╚═╝╚═════╝░╚═════╝░╚══════╝╚═╝░░╚═╝░░░╚═╝░░░░╚════╝░");
            
            
            Console.WriteLine("digite o numero do ano: ");
            ano = int.Parse(Console.ReadLine());

            if(ano % 4 == 0 && ano % 100 != 0)
            {
                Console.WriteLine("ano bissexto");

            }else if (ano % 400 == 0)
            {
                Console.WriteLine("ano bissexto");
            }else

            {
                Console.WriteLine("nao bissexto");
                
                
                }


        }
    }
}
