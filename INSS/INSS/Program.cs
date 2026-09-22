using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
    internal class Program
    {/*11- Faça um algoritmo que efetue o cálculo do salário líquido de um professor. As informações fornecidas serão: valor da hora aula, número de aulas lecionadas no mês e percentual de desconto do INSS. Imprima na tela o salário líquido final.*/
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da hora aula: ");
            double valorHoraAula = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o número de aulas lecionadas no mês: ");
            int numeroAulas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o percentual de desconto do INSS (em %): ");
            double percentualDescontoINSS = Convert.ToDouble(Console.ReadLine());
            double salarioBruto = valorHoraAula * numeroAulas;
            double descontoINSS = salarioBruto * (percentualDescontoINSS / 100);
            double salarioLiquido = salarioBruto - descontoINSS;
            Console.WriteLine($"Salário Bruto: R$ {salarioBruto:F2}");
            Console.WriteLine($"Desconto INSS: R$ {descontoINSS:F2}");
            Console.WriteLine($"Salário Líquido: R$ {salarioLiquido:F2}");
            Console.ReadKey();

        }
    }
}
