using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subtrair
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, subtrair;

            Console.WriteLine("digite o primeiro numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo numero: ");
            num2 = int.Parse(Console.ReadLine());
            subtrair =num1 - num2;
            Console.WriteLine("o resultado da subtração é; "+ subtrair);





        }
    }
}
