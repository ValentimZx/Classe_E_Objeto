Console.WriteLine("=== Metados com Parametros ===\n ");

MinhaClasse minhaClasse = new MinhaClasse();

//Valores dos argumentos
minhaClasse.Saudacao("Nicolas", DateTime.Now.ToShortDateString());



Console.ReadKey();

public class MinhaClasse
{
    //Os parametros dos metados
    public void Saudacao(string nome, string data)
    {
        Console.WriteLine(nome);
        Console.WriteLine(data);
    }
}