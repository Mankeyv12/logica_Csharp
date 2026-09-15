using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tempo;
            Console.WriteLine("digite o tempo da entrega: ");
            tempo = int.Parse(Console.ReadLine());
            if (tempo <= 15)
            {
                Console.WriteLine("entrega perfeita! bonus garantido.");
            }
            if (tempo >15 && tempo <30) {
                Console.WriteLine("pizza entregue a tempo, sem bonus");

            }
            if(tempo >= 30)
            {
                Console.WriteLine("a pizza esfriou! peter foi demitido!");
            }
        }
    }
}
