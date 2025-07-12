// Crie um construtor que permita criar um carro somente usando os atributos : Modelo e Montadora (não
// use a palavra-chave this)

using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

Carro carro = new Carro("Onix", "GM");

Console.WriteLine($"A modelo do carro e {carro.Modelo} e a sua montadora e {carro.Montadora}");
Console.WriteLine($"E a sua velpcodade maxima e {carro.VelocidadeMaxima}");

public class Carro
{
    public Carro(string modelo, string montadora)
    {
        Modelo = modelo;
        Montadora = montadora;
        
    }
    public string? Modelo;
    public string? Montadora;

    public double VelocidadeMaxima(int Potencia )
    {
        Potencia = 120;
        return Potencia * 1.75;
    }
}

//Explique qual o comportamento ao usar este construtor para criar objetos do tipo Carro:
//Ao usar o construtor da classe carro, podemos passar valores diretamente na criacao do objeto.
//Isso permite inicializar os atributos "Modelo" e "Montadora"m de forma pratica e segura, garantindo que o objeto comecve com os dados necessarios.