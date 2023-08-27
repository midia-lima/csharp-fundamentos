string msgDeBoasVindas = "Boas vinda ao Cadastro de Mocidades";
List<string> listaDaMocidadeCadastrada = new List<string> { "Vitória", "Sofia" };


void ExibirLogo()
{
	Console.WriteLine(@"
░░█ █▀█ █░█ █▀▀ █▄░█ █▀   █░█ █ █░░ ▄▀█   ▄▀█ █▀█ ▄▀█ █▀▀ █░█ ▄▀█ █ ▄▀█
█▄█ █▄█ ▀▄▀ ██▄ █░▀█ ▄█   ▀▄▀ █ █▄▄ █▀█   █▀█ █▀▄ █▀█ █▄█ █▄█ █▀█ █ █▀█");
	Console.WriteLine("\n" + msgDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
	ExibirLogo();
	Console.WriteLine("\nDigite 1 para cadastrar um moço ou uma moça: ");
	Console.WriteLine("Digite 2 para mostrar toda a mocidade cadastrada: ");
	Console.WriteLine("Digite 0 para sair");

	Console.Write("\nDigite uma opção: ");

	string opcaoEscolhida = Console.ReadLine()!;
	int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

	switch (opcaoEscolhidaNumerica)
	{
		case 1:			
			CadastrarMocidade();
			break;
		case 2:
			MostrarMocidadeCadastrada();
			break;
		case 0:
			Console.WriteLine("Bye bye :) ");
			break;
		default:
			Console.WriteLine("Opção inválida");
			break;

	}
}

void CadastrarMocidade()
{
	Console.Clear();
	Console.WriteLine("********************");
	Console.WriteLine("Cadastro de Mocidade");
	Console.WriteLine("********************\n");
	Console.Write("Digite o nome do moço ou da moça que deseja cadastrar: ");
	string nomeDaMocidade = Console.ReadLine()!;
	listaDaMocidadeCadastrada.Add(nomeDaMocidade);
	Console.WriteLine($"{nomeDaMocidade} foi cadastrada com sucesso.");
	Thread.Sleep(2000);
	Console.WriteLine();
	Console.Clear();
	ExibirOpcoesDoMenu();
}

void MostrarMocidadeCadastrada()
{
	Console.Clear();
	Console.WriteLine("***************************************");
	Console.WriteLine("Exibindo todas as mocidades cadastradas");
	Console.WriteLine("***************************************\n");

	foreach (string mocidade in listaDaMocidadeCadastrada)
	{
		Console.WriteLine($"{mocidade}");
	}

	Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
	Console.ReadKey();
	Console.Clear();
	ExibirOpcoesDoMenu();
}


ExibirOpcoesDoMenu();

