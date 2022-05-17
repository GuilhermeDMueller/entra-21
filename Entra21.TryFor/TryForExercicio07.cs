using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.TryFor
{
    internal class TryForExercicio07
    {
        public void Executar()
        {
            int indice = 0;
            double desconto = 150.00;
            double valor = 0;
            string nome = " ";
            int quantidade = 0;

            while (quantidade < 5)
            {
                Console.WriteLine("Informe o nome do produto: ");
                nome = Console.ReadLine();

                Console.WriteLine("Informe o valor do produto: ");
                valor = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe a quantidade do produto: ");
                quantidade = Convert.ToInt32(Console.ReadLine());

                indice = indice + 1;
            }
            double somaProduto = valor * quantidade;
            double valorDesconto = somaProduto - desconto;
            double mediaProduto = somaProduto - valorDesconto;
            Console.WriteLine("A venda dos produtos com o desconto teve resultado de: " + mediaProduto);
        }
    }
}
