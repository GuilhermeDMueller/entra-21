using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.TryFor
{
    internal class TryForExercicio01
    {
        public void Executar()
        {

            for (int indice = 0; indice < 13; indice = indice + 1)
            {
                Console.WriteLine("Informe o nome da peça: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Informe o valor da peça: ");
                double valorPeca = Convert.ToDouble(Console.ReadLine());

            }
        }
    }
}
