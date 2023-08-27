## Dictionary<Key,Value>

Representa uma coleção de chaves e valores.

### Parâmetros
**Key**

O tipo das chaves no dicionário.

**Value**

O tipo dos valores no dicionário.

### Exemplo:

```cs
Dictionary<string, int> series = new Dictionary<string, int>();

series.Add("The Mentalist", 2008);
series.Add("Revenge", 2011);
series.Add("The Good Wife", 2009);
series.Add("Castle", 2009);
```

### Exemplo com List:
```cs
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();

bandasRegistradas.Add("Ana Castela", new List<int>());
bandasRegistradas.Add("Marília Mendonça", new List<int> { 10, 9, 8 });
```

## Dictionary<Key,Value>.ContainsKey(Key)

Determina se o Dictionary<Key,Value> atual contém a chave especificada.

### Parâmetros
A chave a ser localizada no Dictionary<Key,Value>

## PadLeft(params1, params2)

Use o método PadLeft() para preencher uma string com um caractere especificado à esquerda até o comprimento desejado.

### Parâmetros
___

**params1**

É o comprimento desejado da string resultante que inclui a string original e espaços de preenchimento adicionais.

**params2**

Um caractere de preenchimento

### Exemplo:
```cs
var message = "Teste";
var result = message.PadLeft(message.Length + 3);
Console.WriteLine(result);

```

```cs
var invoiceNumber = 1234;
var result = invoiceNumber.ToString().PadLeft(6, '0');
Console.WriteLine(result);
```

## ReadKey()

Faz o programa aguardar o pressionamento de uma tecla e impede a tela até que uma tecla seja pressionada.