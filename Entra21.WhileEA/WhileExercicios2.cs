using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.WhileEA
{
    internal class WhileExercicios2
    {
        public void Executar()
        {
            int indice = 0;
            
            Console.Write("Digite a quantidade de carros desejada:  ");
            int quantidadeCarros = Convert.ToInt32(Console.ReadLine());          
            int mediaAno = 0;
            double mediaValor = 0;
            double valorTotalCarro = 0;
            int anoTotalCarro = 0;
            int totalCarrosG = 0;
            int totalCarrosA = 0;


            while (indice < quantidadeCarros)
            {
                Console.Write("Informe o modelo do carro: ");
                string modeloCarro = Console.ReadLine().ToUpper();

                Console.Write("Informe o valor do carro: ");
                double valorCarro = Convert.ToDouble(Console.ReadLine());

                Console.Write("Informe o ano do carro: ");
                int anoCarro = Convert.ToInt32(Console.ReadLine());

                if (modeloCarro.StartsWith("G"))
                {
                    totalCarrosG = totalCarrosG + 1;
                }
                else if (modeloCarro.StartsWith("A"))
                {
                    totalCarrosA = totalCarrosA + 1;
                }

                anoTotalCarro = anoTotalCarro + anoCarro;
                valorTotalCarro = valorTotalCarro + valorCarro;

                indice = indice + 1;
                

            }
            mediaAno = anoTotalCarro / quantidadeCarros;
            Console.WriteLine("A média de ano dos carros é: " + mediaAno);

            mediaValor = valorTotalCarro / quantidadeCarros;
            Console.WriteLine("A média do valor dos carros é: " + mediaValor);
        }

    }
}
