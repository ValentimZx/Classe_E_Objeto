
// a- Crie um objeto chevrolet e atribua os seguintes valores aos atributos : Sedan, Chevrolet , Onix, 2016, 110



Carro chervrolet = new Carro();

chervrolet.Tipo = "Sedan";
chervrolet.Marca = "Chevrolet";
chervrolet.Modelo = "Onix";
chervrolet.Ano = 2020;
chervrolet.Potencia = 110;

Console.WriteLine($"O carro do tipo {chervrolet.Tipo}, da Marca {chervrolet.Marca}, do seguinte Modelo {chervrolet.Modelo}, do Ano {chervrolet.Ano}, da Potencia {chervrolet.Potencia}");


public class Carro
{
    public string? Tipo;
    public string? Marca;
    public string? Modelo;
    public int Ano;
    public int Potencia;
}

