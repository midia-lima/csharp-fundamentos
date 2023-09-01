using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
	public class Podcast
	{
		private List<Episodio> episodios = new List<Episodio>();
		public string Host { get; set; }
		public string Nome { get; set; }
		public int TotalEpisodios { get; set; }

		public Podcast(string host, string nome, int totalEpisodios)
		{
			Host = host;
			Nome = nome;
			TotalEpisodios = totalEpisodios;
		}

		public void AdicionarEpisodio(Episodio episodio)
		{
			episodios.Add(episodio);
		}

		public void ExibirDetalhes()
		{
			Console.WriteLine($"Host: {Host}");
			Console.WriteLine($"Podcast: {Nome}");
			

			foreach (var episodio in episodios)
			{
				Console.WriteLine($"Episódio: {episodio.Titulo}");
                Console.WriteLine($"Duração: {episodio.Duracao}");
            }
			Console.WriteLine($"Total de Episodios: {TotalEpisodios}");

		}

	}
}
