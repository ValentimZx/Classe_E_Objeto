
Carro car1 = new Carro();

car1.Marca = "Chevrolet";
car1.Modelo = "Onix";
car1.Tipo = "Sedan";
car1.Ano = 2020;
car1.Potencia = 110;

Console.WriteLine($"{car1.Modelo}, {car1.Tipo}, {car1.Ano}, {car1.Potencia}");
car1.Acelerar(car1.Marca);





public class Carro
{
    public string? Marca;
    public string? Modelo;
    public string? Tipo;
    public int Ano;
    public int Potencia;

    public void Acelerar(string Marca)
    {
        Console.WriteLine($"Acelerando o meu {Marca}");
    }
}