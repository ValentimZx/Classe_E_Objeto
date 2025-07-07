
Carro carro1 = new Carro("Honda", "Civic", "Sedan", 2020, 150);
Carro carro2 = new Carro("Nissan", "GTR", "Esportivo", 2014, 500);

Console.WriteLine("\n Informacoes do carro 1:\t ");
carro1.Exibir();

Console.WriteLine("\nnformacoes do carro 2:\t ");
carro2.Exibir();

Console.WriteLine("\nAcelerando carros:\t ");
carro1.Acelerar(20);
carro2.Acelerar(30);

Console.WriteLine("\nInformacoes do carro 1 apos acelerar: ");
carro1.Exibir();
Console.WriteLine("\nInformacoes do carro 2 apos acelerar:");
carro2.Exibir();




public class Carro
{
    public string Marca;
    public string Modelo;
    public string Tipo;
    public int Ano;
    public int Potencia;

    public Carro(string marca, string modelo, string tipo, int ano, int potencia)
    {
        this.Marca = marca;
        this.Modelo = modelo;
        this.Tipo = tipo;
        this.Ano = ano;
        this.Potencia = potencia;
    }

    public void Acelerar(int incremento)
    {
        this.Potencia += incremento;
        Console.WriteLine($"\nO carro {this.Marca}, {this.Modelo} acelerou e agora tem {this.Potencia} cavalos\n");
    }
    public void ExibirInformacoes()
    {
        Console.WriteLine("Marca: " + this.Marca);
        Console.WriteLine("\nModelo: " + this.Modelo);
        Console.WriteLine("\nTipo: " + this.Tipo);
        Console.WriteLine("\nAno: " + this.Ano);
        Console.WriteLine("\nPotencia: " + this.Potencia);
    }
    public void Exibir()
    {
        ExibirInformacoes();
    }
}