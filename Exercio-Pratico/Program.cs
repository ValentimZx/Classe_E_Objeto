// 1- Em um projeto console crie uma classe Carro contendo os atributos : modelo, montadora, marca, ano e
// potencia com os tipos de dados string, string, string, int e int.
// Crie também o comportamento Acelerar que não retorna nada e apenas exiba a mensagem “Acelerando...”


Console.WriteLine("Concessionaria");

Carro car1 = new Carro();
car1.Modelo = "onix";
car1.Montadora = "GM";
car1.Marca = "Chevrolet";
car1.Data = 2020;
car1.Potencia = 120;

Console.WriteLine($"\nO Carro do {car1.Modelo}, da Montadora {car1.Montadora}, da Marca {car1.Marca} do Ano {car1.Data} da potencia {car1.Potencia}\n");

car1.Acelerar();

Console.ReadKey();

public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Data;
    public int Potencia;

    public void Acelerar()
    {
        Console.WriteLine("Acelerando...");
    }
       
    
    
}
