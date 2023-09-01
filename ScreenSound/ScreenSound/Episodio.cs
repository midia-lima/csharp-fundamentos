using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
	public class Episodio
	{
		private List<string> convidados = new List<string>();

		public string Titulo { get; }
		public string Duracao { get; }		
		public int Ordem { get; set; }
		public string Resumo { get; set; }

		public Episodio(string titulo, string duracao)
		{
			Titulo = titulo;
			Duracao = duracao;
		}

		public void AdicionarConvidados(string convidado)
		{
			convidados.Add(convidado);

			foreach (var participante in convidados)
			{
				Console.WriteLine($"Convidado: {participante}");				
			}

		}
	}
}
