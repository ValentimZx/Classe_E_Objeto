// e- Crie um construtor na classe Carro que vai permitir criar objetos inicializando os valores dos atributos :
// modelo, montadora, marco, ano e potencia (use a palavra this para identificar a instância da classe)

Carro carro = new Carro("Chevrolet", "Onix", "Sedan", 2020, 100);

carro.Exibir();




public class Carro
{
    public Carro(string marca, string modelo, string tipo, int ano, int potencia)
    {
        this.Marca = marca;
        this.Modelo = modelo;
        this.Tipo = tipo;
        this.Ano = ano;
        this.Potencia = potencia;
    }
    public string Marca;
    public string Modelo;
    public string Tipo;
    public int Ano;
    public int Potencia;

    public void ExibirInformacoes()
    {

        Console.WriteLine("Marca: " + this.Marca);
        Console.WriteLine("Modelo: " + this.Modelo);
        Console.WriteLine("Tipo: " + this.Tipo);
        Console.WriteLine("Ano: " + this.Ano);
        Console.WriteLine("Potencia: " + this.Potencia);
    }
    public void Exibir()
    {
        ExibirInformacoes();
    }
}