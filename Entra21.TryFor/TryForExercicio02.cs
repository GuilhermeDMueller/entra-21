using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.TryFor
{
    internal class TryForExercicio02
    {
        public void Executar()
        {
            int indice = 0;
            
            for (string nome = " "; nome != "fim";)
            { 
                Console.WriteLine("Informe o seu nome: ");
                nome = Console.ReadLine();

                indice = indice + 1;
            }
            Console.WriteLine("O número de pessoas que informaram o nome é: " + indice);
        }
    }
}
