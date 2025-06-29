Console.WriteLine("## Classe e objetos ##\n");

int x = 100;

Pessoa p1 = new Pessoa();
p1.nome = "Nicolas";
p1.idade = 21;
p1.sexo = "Masculino";

Console.WriteLine($"Meu nome e {p1.nome}, eu tenho {p1.idade} anos e sou do sexo {p1.sexo}\n");

Pessoa p2 = p1;

// Pessoa p2 = new Pessoa();
// p2.nome = "Julia";
// p2.idade = 18;
// p2.sexo = "Feminino";

Console.WriteLine($"Eu sou o {p2.nome}, tenho {p2.idade} anos e meu sexo e {p2.sexo}");


Console.ReadKey();

class Pessoa
{
    public string? nome;
    public int idade;
    public string? sexo;
}