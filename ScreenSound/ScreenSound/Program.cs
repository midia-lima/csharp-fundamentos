Banda marron5 = new Banda("Marron 5");

Album albumSongsAboutJane = new Album("Songs About Jane");

Musica musicaUm = new Musica(marron5, "Harder to Breathe")
{
	Duracao = 253,
	Disponivel = true,
};

Musica musicaDois = new Musica(marron5, "This Love")
{
	Duracao = 326,
	Disponivel = false,
};


Genero nomeGenero = new Genero();
nomeGenero.NomeGenero = "Pop Rock";

albumSongsAboutJane.AdicionarMusica(musicaUm);
albumSongsAboutJane.AdicionarMusica(musicaDois);

marron5.AdicionarAlbum(albumSongsAboutJane);

musicaUm.ExibirFichaTecnica();
musicaDois.ExibirFichaTecnica();
albumSongsAboutJane.ExibirMusicaDoAlbum();
marron5.ExibirDiscografia();
nomeGenero.ExibirGenero();