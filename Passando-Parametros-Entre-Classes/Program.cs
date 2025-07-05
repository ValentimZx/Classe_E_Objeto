using System.Runtime.CompilerServices;

Console.WriteLine("=== Passando paeametros entre classes ===\n");

var aluno = new Aluno();
Console.WriteLine("Digite seu nome: ");

aluno.Nome = Console.ReadLine();

Console.WriteLine("Digite a sua idade: ");

aluno.Idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Qual seu sexo: ");
aluno.Sexo = Console.ReadLine();

Console.WriteLine("Foi aprovado: S/N");
aluno.Aprovado = Console.ReadLine();

Curso curso = new();
curso.Resultado(aluno.Nome, aluno.Idade, aluno.Sexo, aluno.Aprovado);




Console.ReadKey();

public class Aluno
{
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;

}

public class Curso
{
    public void Resultado(string nome, int idade, string sexo, string aprovado)
    {
        Console.WriteLine($"\nO aluno: {nome} do sexo: {sexo} com a idade: {idade} anos");
        if (aprovado == "S")
            Console.WriteLine($"\nO aluno  {nome} foi aprovado!");
        else
            Console.WriteLine($"\nAluno {nome} foi reprovado!");
    }
}