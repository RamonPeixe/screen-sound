class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;

    }

    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A música {Nome} pertence a banda {Artista.Nome}.";
    public Genero Genero { get; set; }

    public void exibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao} segundos");
        Console.WriteLine(DescricaoResumida);
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        }
        else { Console.WriteLine("Adquira o plano Plus+."); }
    }
}

