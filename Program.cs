Album albumDoPTV = new Album();
albumDoPTV.Nome = "Collide with the sky";

Musica musica1 = new Musica();
musica1.Nome = "May these noises strartle you in your sleeping tonight";
musica1.Duracao = 120;

Musica musica2 = new Musica();
musica2.Nome = "Hell Above";
musica2.Duracao = 240;



albumDoPTV.AdicionarMusica(musica1);
albumDoPTV.AdicionarMusica(musica2);

albumDoPTV.ExibirMusicasDoalbum();