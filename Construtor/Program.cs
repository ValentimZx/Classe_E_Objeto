using System.Diagnostics.CodeAnalysis;

Console.WriteLine("=== Construtor ===");

Aluno aluno = new Aluno("Nicolas", 21, "Masculino", "S");

//Operador Ternario (condifcao ? expressao1_se_true : expressao2_se_false)

Console.WriteLine(aluno.Nome == null ? "null" : aluno.Nome);
Console.WriteLine(aluno.Idade == 0 ? "0" : aluno.Idade);
Console.WriteLine(aluno.Sexo == null ? "null" : aluno.Sexo);
Console.WriteLine(aluno.Aprovado == null ? "null" : aluno.Aprovado);
string aprovado = Console.ReadLine();

Console.ReadKey();

public class Aluno
{
    public Aluno(string nome, int idade, string sexo, string aprovado)
    {
        Nome = nome;
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;
    }


    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
}
