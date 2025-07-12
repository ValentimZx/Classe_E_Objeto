using System.Runtime.CompilerServices;

Console.WriteLine("=== Assinatura do metado - SObrecarga ===\n");

Email email = new Email();
email.Envair("empresa.com.br");
email.Envair("empresa.com.br", "Proposta comercial");
email.Envair("empresa.com.br", 2000);
email.Envair(200, "empresa.com.br");


Console.ReadKey();

public class Email
{
    public void Envair(string endereco)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine("Assunto padrao");

    }
    public void Envair(string endereco, string assunto)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"{assunto} padrao");

    }
    public void Envair(string endereco, decimal valor)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"{valor} padrao");

    }
         public void Envair(decimal valor, string endereco)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine("Pagamento de fornecedor");
        Console.WriteLine($"{valor} padrao");
        
    }
}