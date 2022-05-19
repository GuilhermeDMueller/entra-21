using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.TryFor
{
    internal class TryForExercicio12
    {
        public void Executar()
        {
            int indice = 0;
            int numeroMenu = 0;
            int quantidadeBolos = 0;
            int quantidadeDoces = 0;
            int quantidadeSanduiches = 0;
            int quantidadePizzas = 0;
            double mediaProdutos = 0;
            double mediaBolos = 0;
            double mediaDoces = 0;
            double mediaSanduiches = 0;
            double mediaPizzas = 0;

            Console.WriteLine(@"----------------------------Menu----------------------------
Códigos   |   Tipos     |       nome                         |       Valor
1         | Bolos       | Bolo Brigadeiro                    | R$ 29.50
2         | Bolos       | Bolo Floresta Negra                | R$ 2.00
3         | Bolos       | Bolo Leite com Nutela              | R$ 29.23
4         | Bolos       | Bolo Mousse de Chocolate           | R$ 7.10
5         | Bolos       | Bolo Nega Maluca                   | R$ 19.33
6         | Doces       | Bomba de Creme                     | R$ 17.71
7         | Doces       | Bomba de Morango                   | R$ 4.82
8         | Sanduíches  | Filé-Mignon com Fritas e Chedar    | R$ 21.16
9         | Sanduíches  | Hambúrguer com Queijo, Champignom, | R$ 12.70
          |             | e Rúcula                           |
10        | Sanduíches  | Provoloe com Salame                | R$ 19.70
11        | Sanduíches  | Vegetariano de Beringela           | R$ 28.22
12        | Pizzas      | Calabresa                          | R$ 8,98
13        | Pizzas      | Napolitana                         | R$ 0.42
14        | Pizzas      | Peruana                            | R$ 18.36
15        | Pizzas      | Portuguesa                         | R$ 27.50
16                      | Sair");

            while ((numeroMenu != 16))
            {
                Console.WriteLine("Informe o Código: ");
                numeroMenu = Convert.ToInt32(Console.ReadLine());

                if (numeroMenu > 16)
                {
                    Console.WriteLine("Informe um código menor do que 16!");
                }
                else if ((numeroMenu >= 1) || (numeroMenu <= 5))
                {
                    quantidadeBolos = quantidadeBolos + 1;
                }
                else if ((numeroMenu == 6) || (numeroMenu == 7))
                {
                    quantidadeDoces = quantidadeDoces + 1;
                }
                else if ((numeroMenu >= 8)|| (numeroMenu <= 11))
                {
                    quantidadeSanduiches = quantidadeSanduiches + 1;
                }
                else if ((numeroMenu >= 12) || (numeroMenu <= 15))
                {
                    quantidadePizzas = quantidadePizzas + 1;
                }
            }
            mediaBolos = quantidadeBolos * 87.16;
            mediaDoces = quantidadeDoces * 22.53;
            mediaSanduiches = quantidadeSanduiches * 81.78;
            mediaPizzas = quantidadePizzas * 55.26;
            mediaProdutos = mediaBolos + mediaDoces + mediaSanduiches + mediaPizzas;
            Console.Clear();
            Console.WriteLine("A quantidade de bolos escolhidos foi: " + quantidadeBolos);
            Console.WriteLine("A quantidade de doces escolhidos foi: " + quantidadeDoces);
            Console.WriteLine("A quantidade de sanduíches escolhidos foi: " + quantidadeSanduiches);
            Console.WriteLine("A quantidade de pizzas escolhidas foi: " + quantidadePizzas);
            Console.WriteLine("A média dos produtos vendidos foi: " + mediaProdutos);
        }
    }
}
