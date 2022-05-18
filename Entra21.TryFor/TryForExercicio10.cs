using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.TryFor
{
    internal class TryForExercicio10
    {
        public void Executar()
        {
            Console.WriteLine("Informe o número desejado: ");
            int numero = Convert.ToInt32(Console.ReadLine());

           while (numero %2 == 0 )
            {
                Console.WriteLine(" " + numero - 2);
            }

           
        }
    }
}
