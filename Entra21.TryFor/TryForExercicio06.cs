using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.TryFor
{
    internal class TryForExercicio06
    {
        public void Executar()
        {
            double valorProduto = 0;
            string nomeProduto = " ";
            int quantidadeProduto = 0;
            double valorTotalProduto = 0;

            for (int indice = 0; nomeProduto != "sair"; indice = indice + 1 )
            {
                Console.WriteLine("Informe o nome do Produto: ");
                nomeProduto = Console.ReadLine();

                Console.WriteLine("Informe o valor do produto: ");
                valorProduto = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe a quantidade de produtos: ");
                quantidadeProduto = Convert.ToInt32(Console.ReadLine());

            }
            valorTotalProduto = valorTotalProduto + valorProduto * quantidadeProduto;
            double desconto = valorTotalProduto * 0.05;
            double valorDesconto = valorTotalProduto - desconto;
            Console.Write("O total da venda foi de: " + valorDesconto);
        }
    }
}
