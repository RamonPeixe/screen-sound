Banda queen = new Banda("Queen");

Album albumDoQueen = new Album("A night at the opera");

Musica musica1 = new Musica(queen, "Love of my life")
{
    Duracao = 213,
    Disponivel = true,
};

Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = false,
};

albumDoQueen.adicionarMusica(musica1);
albumDoQueen.adicionarMusica(musica2);

musica1.exibirFichaTecnica();
musica2.exibirFichaTecnica();

queen.adicionarAlbum(albumDoQueen);
queen.exibirDiscografia();
albumDoQueen.exibirMusicaDoAlbum();


Console.WriteLine("\n\n*************");
Episodio ep1 = new(1, "Técnicas de facilitação", 45);
ep1.adicionarConvidado("Maria");
ep1.adicionarConvidado("Carlos");

Episodio ep2 = new(2, "Técnicas de aprendizado", 67);
ep2.adicionarConvidado("Fatima");
ep2.adicionarConvidado("Filippa");
ep2.adicionarConvidado("Bianca");

Podcast podcast = new("Podcast especial", "Ramon");
podcast.adicionarEpisodio(ep1);
podcast.adicionarEpisodio(ep2);
podcast.exibirDetalhes();