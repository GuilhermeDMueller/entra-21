
using Entra21.TryFor;

Console.WriteLine(@"-----------Menu----------
1 | Exercício01
2 | Exercício02
3 | Exercício03
4 | Exercício04
5 | Exercício05
6 | Exercício06
7 | Exercício07
8 | Exercício08
10| Exercício10
12| Exercício12

");
Console.Write("Informe a ação desejada: ");
int acao = Convert.ToInt32(Console.ReadLine());

if (acao == 1)
{
    TryForExercicio01 newExercicio = new TryForExercicio01();
    newExercicio.Executar();
}
else if (acao == 2)
{
    TryForExercicio02 oldExercicio = new TryForExercicio02();
    oldExercicio.Executar();
}
else if (acao == 3)
{
    TryForExercicio03 goodExercicio = new TryForExercicio03();
    goodExercicio.Executar();
}
else if (acao == 4)
{
    TryForExercicio04 bestExercicio = new TryForExercicio04();
    bestExercicio.Executar();
}
else if (acao == 5)
{
    TryForExercicio05 semIdeiaExercicio = new TryForExercicio05();
    semIdeiaExercicio.Executar();
}
else if (acao == 6)
{
    TryForExercicio06 chegaDeExercicio = new TryForExercicio06();
    chegaDeExercicio.Executar();
}
else if (acao == 7)
{
    TryForExercicio07 naoAcabaExercicio = new TryForExercicio07();
    naoAcabaExercicio.Executar();
}
else if (acao == 8)
{
    TryForExercicio08 twoExercicio = new TryForExercicio08();
    twoExercicio.Executar();
}
else if (acao == 10)
{
    TryForExercicio10 shadowExercicio = new TryForExercicio10();
    shadowExercicio.Executar();

}
else if (acao == 12)
{
    TryForExercicio12 sublimeExercicio = new TryForExercicio12();
    sublimeExercicio.Executar();
}