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
            indice = indice + 1;


            while (indice < quantidadeCarros)
            {
                Console.Write("Informe o modelo do carro: ");
                string modeloCarro = Console.ReadLine();

                Console.Write("Informe o valor do carro: ");
                double valorCarro = Convert.ToDouble(Console.ReadLine());

                Console.Write("Informe o ano do carro: ");
                int anoCarro = Convert.ToInt32(Console.ReadLine());

                int somaAno = anoCarro * quantidadeCarros;
                int mediaAno = somaAno / indice;

                double somaValor = valorCarro * quantidadeCarros;
                double mediaValor = somaValor / indice;
                

            }
            Console.WriteLine("A media de ano dos carros é :" + mediaAno);


        }

    }
}
