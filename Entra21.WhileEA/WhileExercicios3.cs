using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.WhileEA
{
    internal class WhileExercicios3
    {
        public void Executar()
        {
            String nomeProduto = " ";
            double valorProduto = 0;
            int quantidadeProduto = 0;
            double valorTotal = 0;

            while (nomeProduto != "sair")
            {
                Console.WriteLine("Informe o nome do produto: ");
                nomeProduto = Console.ReadLine().ToLower().Trim();

                Console.Write("Informe o valor do produto: R$");
                valorProduto = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe a quantidade do produto: ");
                quantidadeProduto = Convert.ToInt32(Console.ReadLine());

            }
            valorTotal = valorTotal + valorProduto * quantidadeProduto;
            double valorDesconto = valorTotal * 0.05;
            double valorTotalDesconto = valorTotal - valorDesconto;
            Console.WriteLine("A venda total com o desconto foi: R$" + valorTotalDesconto);
        }
    }
}
