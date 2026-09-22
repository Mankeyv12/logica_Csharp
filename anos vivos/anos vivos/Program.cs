using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anos_vivos
{
    /*-  Faça um algoritmo que leia o ano em que uma pessoa nasceu, imprima na tela quantos anos, meses e dias essa pessoa ja viveu. Leve em */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o ano de nascimento: ");
            int anoNascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o mês de nascimento: ");
            int mesNascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o dia de nascimento: ");
            int diaNascimento = int.Parse(Console.ReadLine());
            DateTime dataNascimento = new DateTime(anoNascimento, mesNascimento, diaNascimento);
            DateTime dataAtual = DateTime.Now;
            TimeSpan tempoVivo = dataAtual - dataNascimento;
            int anosVivos = (int)(tempoVivo.Days / 365.25);
            int mesesVivos = (int)((tempoVivo.Days % 365.25) / 30.44);
            int diasVivos = (int)((tempoVivo.Days % 365.25) % 30.44);
            Console.WriteLine($"Você já viveu {anosVivos} anos, {mesesVivos} meses e {diasVivos} dias.");
        }
    }
}
