using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.TryFor
{
    internal class TryForExercicio13
    {
        public void Executar()
        {
            int indice = 0;
            string nome = " ";
            int idade = 0;
            double peso = 0;
            string genero = " ";
            double altura = 0;
            int gols = 0;
            int cartaoAmarelo = 0;
            int cartaoVermelho = 0;

            Console.Clear();
            while (indice < 22)
            {
                Console.WriteLine("Informe o nome do jogador (a): ");
                nome = Console.ReadLine();

                Console.WriteLine("Informe a idade do jogador (a): ");
                idade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe o peso do jogador (a): ");
                peso = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe o sexo do jogador (a): ");
                genero = Console.ReadLine().ToLower();

                Console.WriteLine("Informe a altura do jogador (a): ");
                altura = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe a quantidade de gols que o jogador (a) marcou: ");
                gols = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe a quantidade de cartões amarelos que o jogador (a) recebeu: ");
                cartaoAmarelo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe a quantidade de cartões vermelhos que o jogador (a) recebeu: ");
                cartaoVermelho = Convert.ToInt32(Console.ReadLine());
            }
            double menorPeso = 125;
            if (peso < menorPeso)
            {
                menorPeso = peso;
            }
            
            double maiorPeso = 250;
            if (maiorPeso > peso)
            {
                maiorPeso = peso;
            }

            Console.Clear();    
            Console.WriteLine("O jogador (a) que tem o menor peso é: " + menorPeso);
            Console.WriteLine("O jogador (a) que tem o maior peso é: " + maiorPeso);
            Console.WriteLine("O jogador (a) que tem o menor nome é:");
        }
    }
}
