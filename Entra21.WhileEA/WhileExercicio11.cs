using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.WhileEA
{
    internal class WhileExercicio11
    {
        public void Executar()
        {
            int numeroMenu = 0;

            Console.WriteLine("Informe o número1: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o número2: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(@"=__________MENU___________
1         |      Soma
2         |      Subtração
3         |      Multiplicação
4         |      Divisão
5         |      Sair");
            
            while (numeroMenu < 5)
            {
                Console.WriteLine("Informe a ação: ");
                int numeroAcao = Convert.ToInt32(Console.ReadLine());

            }
        }
    }
}
