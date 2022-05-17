using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.TryFor
{
    internal class TryForExercicio04
    {
        public void Executar()
        {
            double peso = 0;
            int indice = 0;
            while ((peso >= 0) && (peso < 300))
            {
                Console.WriteLine("Informe o seu peso: ");
                peso = Convert.ToDouble(Console.ReadLine());

                indice = indice + 1;
            }
            Console.WriteLine("O número de Pessoas que informaram o peso foi: " + indice);
        }
    }
}
