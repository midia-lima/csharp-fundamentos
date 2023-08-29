﻿class Musica
{
	public string Nome { get; set; }
	public string Artista { get; set; }
	public int Duracao { get; set; }
	public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A musica {Nome} pertence à banda {Artista}";

	public void ExibirFichaTecnica()
	{
		Console.WriteLine($"Nome: {Nome}");
		Console.WriteLine($"Artista: {Artista}");
		Console.WriteLine($"Duracao: {Duracao}");
		Console.WriteLine($"Disponivel: {Disponivel}");

		if (Disponivel)
		{
			Console.WriteLine("Disponível no plano");
		}
		else
		{
			Console.WriteLine("Adquira o plano Plus+");
		}
	}
}