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

            while ((peso > -1) && (peso < 301))
            {
                if (peso > 0)
                {
                    Console.WriteLine("Informe o seu peso: ");
                    peso = Convert.ToDouble(Console.ReadLine());
                }
                else if (peso < 300)
                {
                    Console.WriteLine("Informe o seu peso: ");
                    peso = Convert.ToDouble(Console.ReadLine());
                }
                quantidadePessoas = quantidadePessoas + 1;
            }
            Console.WriteLine("O número de pessoas que informaram o peso foi: " + quantidadePessoas);
            
        }
    }
}
