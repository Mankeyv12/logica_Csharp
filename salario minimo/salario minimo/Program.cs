using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salario_minimo
{
    /*2-	Faça um algoritmo que leia o valor do salário mínimo e o valor 
     * do salário de um usuário, calcule quantos salários mínimos esse 
 usuário ganha e imprima na tela o resultado. (Base para o Salário mínimo R$ 1.518,00).
*/
     
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario= 1518.00,salario_user,calculo;
            


            Console.WriteLine("digite o seu salario : ");
            salario_user = double.Parse(Console.ReadLine());
            calculo = salario_user / salario;
            Console.WriteLine("o salario é : " +calculo);


        }
    }
}
