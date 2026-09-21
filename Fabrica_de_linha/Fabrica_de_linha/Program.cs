using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica_de_linha
{
    internal class Program
    {
        //uma fabrica tem uma linha de produção capaz de produzir 400 peças/dia.
        //um funcionario controla a qualidade,
        //cadastrando o numero da peça e o seu estado ( aprovado ou reprovado)
        //criar um programa para cadastrar o controle de qualidade e imprimir o total de peças
        //aprovadas e reprovadas no final do dia
        static void Main(string[] args)
        {
           
            int numpçs ,pçs = 1, pçsaprov=0,pçsreprov=0;
            string estado;


            while (pçs <= 40)
            {
                Console.WriteLine("digite o numero da " + pçs + "peça: ");

                numpçs = int.Parse(Console.ReadLine());

                Console.WriteLine("digitese peça foi aprovada ou reprovada  a para aprovada / f para reprovada");
                estado = Console.ReadLine();

                if (estado == "a")
                {

                    pçsaprov++;

                }
                else
                {

                    pçsreprov++;

                }
                pçs++;

            }
                
                Console.WriteLine("total de peças aprovadas "+pçsaprov);
                Console.WriteLine("total de peças reprovadas "+pçsreprov);


            



        }
    }
}
