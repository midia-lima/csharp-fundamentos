string msgDeBoasVindas = "Boas vindas ao Screen Sound";
List<string> listaDasBandas = new List<string> { "U2", "Pity" };



void ExibirLogo()
{
	Console.WriteLine(@"
█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀");
	Console.WriteLine("\n" + msgDeBoasVindas);

}

void ExibirOpcoesDoMenu()
{
	ExibirLogo();
	Console.WriteLine("\nDigite 1 para registrar uma banda");
	Console.WriteLine("Digite 2 para mostrar todas as bandas");
	Console.WriteLine("Digite 3 para avaliar uma banda");
	Console.WriteLine("Digite 4 para exibir a média de uma banda");
	Console.WriteLine("Digite -1 para sair");

	Console.Write("\nDigite uma opção: ");

	string opcaoEscolhida = Console.ReadLine()!;
	int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

	switch (opcaoEscolhidaNumerica)
	{
		case 1:
			RegistrarBanda();
			break;
		case 2:
			MostrarBandasRegistradas();
			break;
		case 3:
			Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
			break;
		case 4:
			Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
			break;
		case -1:
			Console.WriteLine("Bye bye :) ");
			break;
		default:
			Console.WriteLine("Opção inválida");
			break;

	}



}

void RegistrarBanda()
{

	Console.Clear();
	Console.WriteLine("*************");
	Console.WriteLine("Registro de Bandas");
	Console.WriteLine("*************\n");
	Console.Write("Digite o nome da banda que deseja registrar: ");
	string nomeDaBanda = Console.ReadLine()!;
	listaDasBandas.Add(nomeDaBanda);
	Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
	Thread.Sleep(2000);
	Console.WriteLine();
	Console.Clear();
	ExibirOpcoesDoMenu();

}

void MostrarBandasRegistradas()
{

	Console.Clear();
	Console.WriteLine("********************");
	Console.WriteLine("Exibindo todas as bandas registradas");
	Console.WriteLine("********************\n");

	//for (int i = 0; i < listaDasBandas.Count; i++)
	//{
	//	Console.WriteLine($"Banda: {listaDasBandas[i]}");
	//}

	foreach (string banda in listaDasBandas)
	{
		Console.WriteLine($"Banda: {banda}");
	}

	Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
	Console.ReadKey();
	Console.Clear();
	ExibirOpcoesDoMenu();

}


ExibirOpcoesDoMenu();