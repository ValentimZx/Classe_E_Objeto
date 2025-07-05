Console.WriteLine("## Metados ##");

MinhaClasse minhaClasse = new MinhaClasse();
minhaClasse.Saudacao();
minhaClasse.ExibitDataAtual();


Console.ReadKey();

class MinhaClasse
{
    public void Saudacao()
    {
        Console.WriteLine("seja Bem-Vindo");
        ExibitDataAtual();

    }

    public void ExibitDataAtual()
    {
        Console.WriteLine(DateTime.Now.ToShortDateString());
    }
}