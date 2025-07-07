// c- Exiba os valores dos atributos no console para cada um dos objetos criados e chame o método Acelerar
// para cada objeto


Carro car1 = new Carro();

car1.Tipo = "SUV";
car1.Marca = "Ford";
car1.Modelo = "Ecosport";
car1.Ano = 2020;
car1.Potencia = 120;
Console.WriteLine($"{car1.Tipo}, {car1.Marca}, {car1.Modelo}, {car1.Ano}, {car1.Potencia}");
car1.Acelerar();

Carro car2 = new Carro();
car2.Tipo = "Sedan";
car2.Marca = "Chevrolet";
car2.Modelo = "Onix";
car2.Ano = 2018;
car2.Potencia = 110;
Console.WriteLine($"{car2.Tipo}, {car2.Marca}, {car2.Modelo}, {car2.Ano}, {car2.Potencia}");

car2.Acelerar();


public class Carro
{
    public string? Tipo;
    public string? Marca;
    public string? Modelo;
    public int Ano;
    public int Potencia;

    public void Acelerar()
    {
        Console.WriteLine("Acelerando...");
    }
}