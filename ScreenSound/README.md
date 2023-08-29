## Tipos primitivos

[Tipos de dados](https://learn.microsoft.com/pt-br/previous-versions/visualstudio/visual-studio-2008/ms228360(v=vs.90)?redirectedfrom=MSDN)


## Classe

Uma classe "é um conjunto ou um conjunto de objetos que compartilham de propriedades e métodos em comum."

**Classe define**
- Estado
- Comportamento

```cs
class Musica
{
	string nome;
	string artista;
	int duracao;
	bool disponivel;
}
```

**Objeto é uma instância de uma classe**
- É possível criar várias instâncias
- Cada instância possui diferentes estados

```cs
Musica musicaUm = new Musica();
musicaUm.nome = "Everybody's Changing";
musicaUm.artista = "Keane";
musicaUm.duracao = 335;
musicaUm.disponivel = true;

Musica musicaDois = new Musica();
musicaDois.nome = "Unforgettable";
musicaDois.artista = "Natalie Cole";
musicaDois.duracao = 330;
musicaDois.disponivel = false;
```

## Modificadores de Acesso

Palavras chaves que declara o nível de acesso.

| Palavra Chave       | Aplicável para | Descrição |
| -----------         | -----------    | ----------|
| public              | Class, Membros | Sem restrição|
| protected           | Membros        | Acesso para classe e seus filhos|
| internal            | Class, Membros | Acesso para todos do mesmo Assembly|
| protected internal  | Membros        | Acesso para todos do mesmo Assembly e Classes filhas|
| private             | Membros        | Acesso somente para a classe|
| protected private   | Membros        | Acesso para classe e seus filhos|

## Métodos
Um método que representa um comportamento de qualquer objeto da classe

```cs
class Musica
{
	public string nome;
	public string artista;
	public int duracao;
	public bool disponivel;

	// Método
	public void ExibirFichaTecnica()
	{
		Console.WriteLine($"Nome: {nome}");
    Console.WriteLine($"Artista: {artista}");
		Console.WriteLine($"Duracao: {duracao}");
		Console.WriteLine($"Disponivel: {disponivel}");

		if (disponivel) 
		{
      Console.WriteLine("Disponível no plano");
    }
		else
		{
			Console.WriteLine("Adquira o plano Plus+");        
		}
	}
}
```

## Auto-Implemented Properties
**Atributo** é uma variável declarada dentro de uma classe que armazena dados associados a uma instância específica desta classe.

**Propriedade** é uma abstração que fornece um meio de acessar e modificar os valores dos atributos de uma classe, encapsulando a lógica de leitura e escrita.

Embora haja uma relação entre **atributos (fields)** e **propriedades (properties)** em C#, eles são conceitos distintos e oferecem diferentes recursos e funcionalidades para o desenvolvimento de classes e objetos.

Escreve: set

Lê: get

```cs
class Musica
{
	public string nome { get; set; }
	public string artista { get; set; }
	public int duracao { get; set; }
	public bool disponivel { get; set; }	
}
```

## Funções Lambda
Em C# chamamos a arrow function de Lambda




