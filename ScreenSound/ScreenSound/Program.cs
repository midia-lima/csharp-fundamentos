Musica musicaUm = new Musica();
musicaUm.Nome = "Everybody's Changing";
musicaUm.Artista = "Keane";
musicaUm.Duracao = 335;
musicaUm.Disponivel = true;
Console.WriteLine(musicaUm.DescricaoResumida);


Musica musicaDois = new Musica();
musicaDois.Nome = "Unforgettable";
musicaDois.Artista = "Natalie Cole";
musicaDois.Duracao = 330;
musicaDois.Disponivel = false;	

musicaUm.ExibirFichaTecnica();
musicaDois.ExibirFichaTecnica();




