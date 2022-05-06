using Entra21.WhileEA;

Console.WriteLine(@"--------Menu--------
1 | Exercicio1");
Console.Write("Informe a ação desejada: ");
int menu = Convert.ToInt32(Console.ReadLine());

if (menu == 1)
{
    WhileExercicios1 newExercicio = new WhileExercicios1();
    newExercicio.Executar();
}
