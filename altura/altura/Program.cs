using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace altura
{
    internal class Program
    {/*10 - Francisco tem 1,50m e cresce 2 centímetros por ano, enquanto Sara tem 1,10m e cresce 3 centímetros por ano. Faça um algoritmo que calcule e imprima na tela em quantos anos serão necessários para que Francisco seja maior que Sara.*/
        static void Main(string[] args)
        {
            double alturaFrancisco = 1.50;
            double alturaSara = 1.10;
            int anos = 0;
            while (alturaFrancisco <= alturaSara)
            {
                alturaFrancisco += 0.02; // Francisco cresce 2 cm por ano
                alturaSara += 0.03; // Sara cresce 3 cm por ano
                anos++;
            }
            Console.WriteLine($"Serão necessários {anos} anos para que Francisco seja maior que Sara.");
        }
    }
}
