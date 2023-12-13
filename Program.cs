Banda PTV = new Banda("Pierce The Veil");

Album albumDoPTV = new Album("Collide with the sky");


Musica musica1 = new Musica(PTV, "May these noises strartle you in your sleeping tonight")
{
    Duracao = 120,
    Disponivel = true,
};


Musica musica2 = new Musica(PTV, "Hell Above")
{
    Duracao = 354,
    Disponivel = false,
};


albumDoPTV.AdicionarMusica(musica1);
albumDoPTV.AdicionarMusica(musica2);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoPTV.ExibirMusicasDoalbum();
PTV.AcionarAlbum(albumDoPTV);
PTV.ExibirDiscografia();