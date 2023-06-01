class Album
{
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }

    public String Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void adicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void exibirMusicaDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum: {Nome}.\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"Duração do álbum: {DuracaoTotal} segundos");
    }
}
