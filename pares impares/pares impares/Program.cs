using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pares_impares
{//"crie um programa que armazene 20 numeros  e sepere os em dois arrays um com nuemeros pares e outros com nuemeros impares."

    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numero = new int[20];
            int[] pares = new int[20];
            int[ ] impares = new int[20];
            int contPares = 0;
            int contImpares = 0;
            
            for (int i = 0; i < numero.Length; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + "º número: ");
                numero[i] = int.Parse(Console.ReadLine());
                if (numero[i] % 2 == 0)
                {
                    pares[contPares] = numero[i];
                    contPares++;
                }
                else
                {
                    impares[contImpares] = numero[i];
                    contImpares++;
                }
            }
            Console.WriteLine("Números pares: " + contPares);
            Console.WriteLine("Números ímpares: " + contImpares);

        }
    }
}
