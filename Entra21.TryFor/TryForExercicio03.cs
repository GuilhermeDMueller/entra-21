using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.TryFor
{
    internal class TryForExercicio03
    {
        public void Executar()
        {
            int idade = 0;

            for (int indice = 0; idade < 128;)
            {
                Console.WriteLine("Informe a sua Idade: ");
                idade = Convert.ToInt32(Console.ReadLine());

                indice = indice + 1;
            }
        }
    }
}
