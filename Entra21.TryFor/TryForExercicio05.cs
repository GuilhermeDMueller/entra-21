using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.TryFor
{
    internal class TryForExercicio05
    {
        public void Executar()
        {
            int carrosG = 0;
            int carrosA = 0;
            double totalValorCarro = 0;
            int totalAnoCarro = 0;
            double mediaValorCarro = 0;
            int mediaAnoCarro = 0;

            Console.WriteLine("Informe a quantidade de carros desejado: ");
            int quantidadeCarrosDesejada = Convert.ToInt32(Console.ReadLine());

            for (int indice = 0; indice < quantidadeCarrosDesejada; indice = indice + 1 )
            {
                Console.WriteLine("Informe o modelo do carro: ");
                string nomeCarro = Console.ReadLine();

                if (nomeCarro.StartsWith("G"))
                {
                    carrosG = carrosG + 1;
                }
                else if (nomeCarro.StartsWith("A"))
                {
                    carrosA = carrosA + 1;
                }

                Console.WriteLine("Informe o valor do carro: ");
                double valorCarro = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe o ano do carro: ");
                int anoCarro = Convert.ToInt32(Console.ReadLine());

                totalValorCarro = totalValorCarro + valorCarro;
                totalAnoCarro = totalAnoCarro + anoCarro;

            }
            Console.WriteLine("A média de anos de todos os carros é: " + mediaAnoCarro);
            mediaAnoCarro = totalAnoCarro / quantidadeCarrosDesejada;
            
            Console.WriteLine("A média de valor total dos carros é: " + mediaValorCarro);
            mediaValorCarro = totalValorCarro / quantidadeCarrosDesejada;
            
            Console.WriteLine("O número total de carros que começam com a letra G é: " + carrosG);
            Console.WriteLine("O número total de carros que começam coma a letra A é: " + carrosA);

        }
    }
}
