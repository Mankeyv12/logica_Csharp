using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {/*6-	Faça um algoritmo que leia o valor de um produto e determine o valor que deve ser pago, conforme a escolha da forma de pagamento
 pelo comprador e imprima na tela o valor final do produto a ser pago. Utilize os códigos da tabela de condições de pagamento para efetuar o cálculo adequado.
 
 Tabela de Código de Condições de Pagamento
 
 1 - À Vista em Dinheiro ou Pix, recebe 15% de desconto
 2 - À Vista no cartão de crédito, recebe 10% de desconto
 3 - Parcelado no cartão em duas vezes, preço normal do produto sem juros
 4 - Parcelado no cartão em três vezes ou mais, preço normal do produto mais juros de 10%
*/
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do produto: ");
            double valorProduto = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escolha a forma de pagamento:");
            Console.WriteLine("1 - À Vista em Dinheiro ou Pix (15% de desconto)");
            Console.WriteLine("2 - À Vista no cartão de crédito (10% de desconto)");
            Console.WriteLine("3 - Parcelado no cartão em duas vezes (preço normal)");
            Console.WriteLine("4 - Parcelado no cartão em três vezes ou mais (10% de juros)");
            int opcaoPagamento = Convert.ToInt32(Console.ReadLine());
            double valorFinal = 0;
            switch (opcaoPagamento)
            {
                case 1:
                    valorFinal = valorProduto * 0.85; // 15% de desconto
                    break;
                case 2:
                    valorFinal = valorProduto * 0.90; // 10% de desconto
                    break;
                case 3:
                    valorFinal = valorProduto; // preço normal
                    break;
                case 4:
                    valorFinal = valorProduto * 1.10; // 10% de juros
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    return;
            }
            Console.WriteLine($"O valor final a ser pago é: R$ {valorFinal:F2}"); 
        }
    }
}
