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
            Console.Clear();

           while (numero %2 == 0)
            {
                if (numero == 10)
                {
                    numero = numero - 2;
                    Console.WriteLine("Número: " + numero);
                }
            }

           
        }
    }
}
