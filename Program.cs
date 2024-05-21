using Manipulando_NET.Models;
using System.Globalization;
using Newtonsoft.Json;

// Pessoa p1 = new Pessoa();
// p1.Nome = "Eduardo";
// p1.Sobrenome = "Santos";
// p1.Idade = 23;
// p1.Apresentar();
// sinal de "=" significa que está atribuindo / setando um valor, que é pego utilizando o get.

// instanciar uma classe é basicamente materializar uma classe para trabalhar com ela. Ex: existe a classe pessoa, mas ela precisa ser criada abaixo, variavel p1 do tipo pessoa irá criar uma nova pessoa().

// // no caso de uma quantidade maior de parametros, ou mais complexos, pode se colocar eles na frente igual exemplo abaixo.
// Pessoa p1 = new Pessoa(nome: "Eduardo", sobrenome: "Santos");
// Pessoa p2 = new Pessoa("Jose", "Bezerrra");
// // construtor dentro do parenteses pessoa, com ele criado pode se passar todos os valores dentro, como no exemplo acima

// Pessoa p2 = new Pessoa();
// p2.Nome = "José";         aqui é como estava antes do construtor ser criado
// p2.Sobrenome = "Bezerra";


// Curso cursoDeIngles = new Curso();
// cursoDeIngles.NomeCurso = "ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();


// string numero1 = "10";
// string numero2 = "20";
// string resultado = numero1 + numero2;
// Console.WriteLine(resultado);


// formatando valores monetários

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US"); // PARA MUDAR A CULTURA DO SISTEMA , AQUI JÁ ESTÁ NA PADRÃO

// decimal valorMonetario = 1582.40M;
// // representar valor em moeda do sistema, no caso desse pc aparece em dolar, :C (currency)
// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))); 
// // aqui para formatar para cultura especifica apenas nessa linha, ainda que a cultura do sistema seja outra

// representação em porcentagem

// double porcentagem = .3421;
// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));

// declarando um dateTime

// DateTime data = DateTime.Now;
// DateTime data = DateTime.Parse("32/04/2022 18:00"); // data invalida, retorna uma exceção

// string dataString = "2022-10-17 18:00";
// bool sucesso = DateTime.TryParseExact(dataString, 
//                        "yyyy-MM-dd HH:mm",
//                        CultureInfo.InvariantCulture, 
//                        DateTimeStyles.None, out DateTime data); // variavel local data
// if (sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {data}");
// }
// else 
// {
//     Console.WriteLine($"{dataString} não é uma data válida");
// }

// Console.WriteLine(data); // testar com data valida e invalida

// há diversas formatações para data e hora!!
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));

// leitura de um arquivo, jogou dentro de um array.

// tratando uma exceção com trycatch, é necessário tratar exceções em blocos de código que elas possam ocorrer, para evitar o programa de fechar nelas

// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt"); // // ler todos os arquivos

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// } // possivel ter varios catch para tratar diferentes exceções que venham do metodo ReadAllLines()
// catch (FileNotFoundException ex)
// {
//    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
// }
// catch (Exception ex)
// {   // realizar algum tratamento. ex: em alguma situação, mandar um email ou informação para servidor ou responsável
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally
// {  // vai executar esse bloco de código independente de ter tido uma exceção ou não.
//    // Ex: consulta no banco, faz-se uma conexão ao banco, mantém ela aberta, faz a consulta, retorna os dados, e depois fecha a conexão. Porém enqaunto ele segura a conexão, ele consome memória, entao ao se fazer a conexão independente de erro ou não, fecha-se a consulta
//    // outro exemplo: ao terminar algum processo, mandar um email para alguem, informando que terminou de ler ou realizar tal ação, informando se deu erro ou correu tudo bem.
//     Console.WriteLine("Chegou até aqui");
// }

// utilizando throw para tratamento de exceções
// new ExemploExcecao().Metodo1();

// // Tipos de coleções: FILAS

// Console.WriteLine("inicio fila");
// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }
// // remover um elemento da fila, sempre o primeiro. 
// // pensando em um menu poderia ser feito um consoleReadLine para digitar uma tecla e por exemplo atender um pedido, no caso o primeiro pedido.
// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(10);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

// // Tipos de coleções: PILHAS

// Console.WriteLine("inicio Pilha");
// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(8);
// pilha.Push(12);
// pilha.Push(16);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");
// pilha.Push(20);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// // Tipos de coleções: DICTIONARY  

// Dictionary<string, string> estados = new Dictionary<string, string>();

// // primeiro valor define a chave (poderia ser um valor inteiro), segundo valor é o valor em si que queremos.
// estados.Add("PE", "Pernambuco");
// estados.Add("SP", "São Paulo");
// estados.Add("BA", "Bahia");

// // deixar var para ele reconhecer automaticamente, ou escrever KeyValuePair<string, string> 
// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
// }

// // como obter o valor através da chave.

// Console.WriteLine(estados["PE"]);
// Console.WriteLine(estados["SP"]);
// Console.WriteLine(estados["BA"]);

// Console.WriteLine("------------");
// estados.Remove("BA");

// estados["PE"] = "Pernambuco - valor alterado";  // alterar um valor

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
// }

// string chave = "BA";
// Console.WriteLine($"Verificando o elemento: {chave}");

// if (estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//     Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
// }

// // Tuplas

// // representar nesse exemplo abaixo 3 tipos de informações, sendo elas um id, um nome e um sobrenome.

// (int, string, string, decimal) tupla = (1, "Eduardo", "Santos", 1.80M); // maneira mais recomendado

// // outras maneiras de criar uma tupla! 
// ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Eduardo", "Santos", 1.80M);
// var outroExemploTuplaCreate = Tuple.Create(1, "Eduardo", "Santos", 1.80M);

// Console.WriteLine($"Id: {tupla.Item1}");
// Console.WriteLine($"Nome: {tupla.Item2}");
// Console.WriteLine($"Sobrenome: {tupla.Item3}");
// Console.WriteLine($"Altura: {tupla.Item4}");


// LeituraArquivo arquivo = new LeituraArquivo();
// // retornando uma tupla através de um metodo.
// var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");
// // conceito de descarte, posso ter uma tupla que retorne 10 informações e no momento só usar 2 por exemplo
// // basta colocar um _ no lugar da informação, ex: var (sucesso, linhasArquivo, _)

// if (sucesso)
// {
//     Console.WriteLine("Quantidade de linhas do arquivo: " + quantidadeLinhas);
//     foreach (string linhas in linhasArquivo)
//     {
//         Console.WriteLine(linhas);
//     }
// }
// else 
// {
//     Console.WriteLine("Não foi possível ler o arquivo");
// }


// // Conceito de Desconstrutor: basicamente visa separar a construção dos objetos, em variáveis distintas uma da outra, semelhante ao feito com uma tupla.

// Pessoa p1 = new Pessoa("Eduardo", "Santos");

// (string nome, string sobrenome) = p1; // desconstrutor

// Console.WriteLine($"{nome} {sobrenome}");


// // IF ternário

// int numero = 15;
// bool ehPar = false;

// // agora utilizando o if ternário
// ehPar = numero % 2 == 0;                   // checa se o bool é verdadeiro, ? representa o if, : representa o else
// Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar"));

// // verificando se o resto da divisão é igual a zero, numero par.
// // para algo tão simples, acaba gastando muita linha e duplicando código. Solução, IF ternário
// if (numero % 2 == 0)
// {
//     Console.WriteLine($"O número {numero} é par");
// }
// else 
// {
//     Console.WriteLine($"O número {numero} é ímpar");
// }


// // Serialização na prática
// // fazer integração de dados de vendas para enviar para o cliente, no caso a seguir em Json.

// DateTime dataAtual = DateTime.Now; // ISO 8601 é responsável pela padronização de data entre sistemas

// List<Venda> listaVendas = new List<Venda>(); // agrupando vendas

// Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual); // objeto .NET
// Venda v2 = new Venda(2, "Software", 110.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented); // serializando para json, ler documentação do pacote!!

// File.WriteAllText("Arquivos/vendas.json", serializado); // jogando o objeto serializado dentro de um novo arquivo com o conteudo serializado.

// Console.WriteLine(serializado);


// Deserialização na prática

// seguinte cenário: nosso cliente tem um arquivo de vendas e precisamos que ele seja importado dentro de nosso sistema, transformando esse arquivo em um objeto .NET.
// Será sempre necessário ler o arquivo estudas suas propriedas, se está dentro de uma lista, identificar o tipo dos dados para criar uma classe.

string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " + 
                      $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}


