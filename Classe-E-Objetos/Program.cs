Console.WriteLine("## Classe e objetos ##");

int x = 100;

Pessoa p1 = new Pessoa();
p1.nome = "Nicolas";
p1.idade = 21;
p1.sexo = "Masculino";

Console.WriteLine($"Meu nome e {p1.nome} e eu tenho {p1.idade} e sou do sexo {p1.sexo}");

Console.ReadKey();

class Pessoa
{
    public string? nome;
    public int idade;
    public string? sexo;
}