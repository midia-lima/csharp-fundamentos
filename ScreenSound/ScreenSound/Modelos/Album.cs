﻿namespace ScreenSound.Modelos;

class Album
{
	private List<Musica> musicas = new List<Musica>();
	public string Nome { get; set; }
	public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public Album(string nome)
    {
		Nome = nome;
    }

    public void AdicionarMusica(Musica musica)
	{
		musicas.Add(musica);
	}

	public void ExibirMusicaDoAlbum()
	{
		Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
		foreach (var musica in musicas)
		{
			Console.WriteLine($"Música: {musica.Nome}");
		}
		Console.WriteLine($"Para ouvir esse álbum inteiro você precisa de {DuracaoTotal}\n");

	}
}

