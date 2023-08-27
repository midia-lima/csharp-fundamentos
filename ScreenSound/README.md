## Tipos primitivos

[Tipos de dados](https://learn.microsoft.com/pt-br/previous-versions/visualstudio/visual-studio-2008/ms228360(v=vs.90)?redirectedfrom=MSDN)


## Classe

Uma classe "é um conjunto ou um conjunto de objetos que compartilham de propriedades e métodos em comum."

```cs
class Musica
{
	string nome;
	string artista;
	int duracao;
	bool disponivel;
}
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
