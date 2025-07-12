Console.WriteLine("Metados com retorno!\n");

Calculadora calc = new Calculadora();

var valor = calc.Somar(10, 10);
var valor1 =calc.Subtrair(10, 10);
var valleo2 =calc.Multiplicar(10, 10);
var valor3 = calc.Dividir(10, 10);

Console.WriteLine(valor);


Console.ReadKey();

public class Calculadora
{
    public int Somar(int n1, int n2)
    {
        return n1 + n2;
    }
    public int Subtrair(int n1, int n2)
    {
        return n1 - n2;
    }
    public int Multiplicar(int n1, int n2)
    {
        return n1 * n2;
    }
     public int Dividir(int n1, int n2)
    {
        return n1 / n2;
    }
    
}