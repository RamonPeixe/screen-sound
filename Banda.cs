class Banda
{
    private List<Album> albums = new List<Album>();

    public Banda(string nome)
    {
        Nome = nome;
    }

    public String Nome { get; }

    public void adicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void exibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}.");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal} segundos).");
        }
    }

}