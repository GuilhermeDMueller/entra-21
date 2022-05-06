using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.WhileEA
{
    internal class WhileExercicios1
    {
        public void Executar()
        {
            double peso = 0;
            int quantidadePessoas = 0;

            while ((peso > 0) || (peso < 300))
            {
                Console.WriteLine("Informe o seu peso: ");
                peso = Convert.ToDouble(Console.ReadLine());

                quantidadePessoas = quantidadePessoas + 1;
            }
            
        }
    }
}
