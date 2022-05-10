using Entra21.WhileEA;

Console.WriteLine(@"--------Menu--------
1 | Exercicio1
2 | Exercicio2
3 | Exercicio3
11 | Exercicio11");
Console.Write("Informe a ação desejada: ");
int menu = Convert.ToInt32(Console.ReadLine());

if (menu == 1)
{
    WhileExercicios1 newExercicio = new WhileExercicios1();
    newExercicio.Executar();
}
else if (menu == 2)
{
    WhileExercicios2 bestExercicio = new WhileExercicios2();
    bestExercicio.Executar();
}
else if (menu == 3)
{
    WhileExercicios3 dorCabeça = new WhileExercicios3();
    dorCabeça.Executar();
}
else if (menu == 11)
{
    WhileExercicio11 goodExercicio = new WhileExercicio11();
    goodExercicio.Executar();
}