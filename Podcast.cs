class Podcast
{
    private List<Episodio> episodios = new();

    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public string Nome { get; }
    public string Host { get; }

    public int TotalEpisodios => episodios.Count;   
    public void adicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void exibirDetalhes()
    {
        Console.WriteLine($"Podcast {Nome} apresentado por {Host}.\n");
        foreach(Episodio episodio in episodios.OrderBy(e => e.Ordem)){
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"Este podcast possui {TotalEpisodios} episódios.");
    }
}