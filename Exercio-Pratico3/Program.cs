// b- Crie outro objeto ford e atribua os seguintes valores aos atributos: SUV, Ford, EcoSport, 2018, 120

Carro ford = new Carro();
ford.Tipo = "SUV";
ford.Marca = "Ford";
ford.Modelo = "Ecosport";
ford.Ano = 2018;
ford.Potencia = 110;

Console.WriteLine($"{ford.Tipo}, {ford.Marca}, {ford.Modelo}, {ford.Ano}, {ford.Potencia}");



public class Carro
{
    public string? Tipo;
    public string? Marca;
    public string? Modelo;
    public int Ano;
    public int Potencia;
}