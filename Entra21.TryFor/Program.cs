
using Entra21.TryFor;

Console.WriteLine(@"-----------Menu----------
1 | Exercício01
");
Console.Write("Informe a ação desejada: ");
int acao = Convert.ToInt32(Console.ReadLine());

if (acao == 1)
{
    TryForExercicio01 newExercicio = new TryForExercicio01();
    newExercicio.Executar();
}

