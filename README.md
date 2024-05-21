<h1>DIO | Resumo .NET e C# - Modulo 2</h1>

-> Manipulando dados e objetos _NET
[Digital Innovation One](https://www.dio.me/en).

## 📚 Documentação 
- [Documentação .NET](https://git-scm.com/doc)
- [Documentação C#](https://docs.github.com/pt)

## 💻 Resumos das Aulas

| Aulas | Resumos |
|-------|---------|
| Resumo sobre .NET | [Resumos]() |

### Propriedadades

-> É membro que oferece um mecanismo flexível para ler, gravar ou calcular o valor de um campo particular.

-> Quando modelamos uma classe, criamos propriedades como nome, idade, que podem receber valores.

-> Não podemos permitir que o usuário altere nossa classe, para isso encapsulamos o código, ou seja, evitar que para uma propriedade nome ele possa não colocar nada. Exemplo: proteção contra alterações numa conta corrente, usuário ir sacar e botar o valor qualquer que ele queira.

-> Propriedades sempre teram um get e set ou apenas um dos dois.

### Getters e Setters

-> Get é basicamente só a leitura dos dados, recebe os dados, obtém os dados.

-> Set é atribuir um valor, ou tentar atribuir um valor.

### Métodos

-> Um método é um bloco de código que contém uma série de instruções.

### Construtores

-> O construtor tem como finalidade atribuir valores para um objeto no momento de sua criação.

-> Permitem que o programador defina valores padrão, limite a instanciação e grave códigos flexíveis e fáceis de ler.

-> Basicamente instanciar uma classe, passar todos os valores em uma linha.

## Manipulando valores com C#

### Concatenação de Strings

-> Podemos formatar valores em diversas representações. Essa formatação de valores é conhecida por concatenação ou interpolação (maneira mais fácil e legivel, que utiliza $ no inicio).

### Representação Monetária e Data

-> Valor monetário deve ser passado em decimal, e para representar valor da moeda do sistema, utilizar o (currency) utilizando o C ou :C caso esteja em interpolação ($)

-> Pode se passar outro valor, de outra cultura, ao utilizar CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("Cultura desejada, ex: en-US, pt-BR");

-> Data basta utilizar a classe dateTime que possui uma vasta quantidade de opções e manipulações possíveis

### Exceptions

-> Os recursos de manipulação de exceção da linguagem C# ajudam você a lidar com quaisquer situações excepcionais ou inesperados que ocorram quando um programa for executar.

-> Exemplo: uma queda de internet ao realizar download de determinado arquivo, ou ainda, querer ler um arquivo de um relátorio que esteja em determinada pasta da rede, ela pode estar corrompida, nao existir mais, formato errado, acesso negado, etc.

-> Podem e devem ser tratadas para evitar que o programa se encerre. Para isso podemos utilizar do TryCatch para tratar e dar um destino/ resolução a exceção. 

-> Usar somente quando realmente necessário o tratamento, para não afetar perfomance do código.

### Coleções - FILA

-> Primeiro a entrar é o primeiro a sair, e ser atendido, ou seja, por ordem de chegada. 

-> FIFO: firts in first out.

### Coleções - PILHA

-> Último a chegar é o primeiro a sair, a ser retirado do topo, lembrar de uma pilha de livros.

-> LIFO: last in first out.

### Coleções - DICTIONARY

-> Um dictionary é uma coleção de chave-valor para armazenar valores únicos sem uma ordem específica.

-> Caso não sejam únicos, uma exceção será acionada!!!

-> Garante a integridade dos dados através da chave, aceitando apenas valores únicos.

### Tuplas

-> Fornecem uma sintaxe concisa para agrupar vários elementos de dados em uma estrutura de dados leve.

-> Não é uma coleção, mas pode conter dentro de si uma coleção, que seja de diferentes tipos também em uma mesma variável.

-> Muito útil para armazenar dados que possam ter variação no seu tipo de retorno, ou para armazenar informações de tipos diferentes que estejam co-relacionadas.

-> Pode utilizar na construção de um metódo (ver classe LeituraArquivo para entender).

### Desconstrutor

-> Visa separar a construção dos objetos, em variáveis distintas uma da outra, semelhante ao feito com uma tupla.

### Gerenciador de Pacotes

-> Um pacote é um conjunto de códigos úteis, que possibilita o compartilhamento e reuso do código. Ligado ao conceito de reuso da orientação a objetos.

-> Basicamente um pequeno projeto que resolve problemas, e ajuda em integrações. Ex: integração de algum aplicativo com o google maps, então basta baixar os pacotes disponibilizados pelo google para não ter que fazer do zero a integração.

-> Exemplo: estamos trabalhando com 5 sistemas distintos, com uma característica em comum de enviar email, então para evitar o duplicamento, basta reutilizar criando um pacote.

### Nuget

-> É um gerenciador de pacotes do .NET (outras linguagens tem outros, como o maven do java, npm do javascript), que permite que desenvolvedores compartilhem códigos e bibliotecas.

### Serialização de dados

-> O processo de serializar consiste em transformar objetos em fluxo de bytes para seu armazenamento ou transmissão, tanto enviando quanto recebendo dados (vide código, classe venda).

-> Ex: ao instanciar uma Pessoa esse estado só fica armazenado dentro do meu código, se quiser transmiter para outras aplicações ou armazenar o estado do objeto é necessário fazer o processo de serialização.

-> Ter um objeto Pessoa que será transmitido e transformado no que o destino ao qual será enviado aceita. Basicamente uma tradução.

-> Exemplo prático no código, serializar em Json (vide código).

#### JSON

-> JavaScript Notation Object é um formato de texto que segue a sintaxe do javascript, muito usado para transmitir dados entre aplicações.

-> Formato de texto que padroniza a escrita e a troca de dados, para que seja mais fácil representar um objeto e permitir que ele seja transmitido e entendido em diferentes linguagens e locais.

-> Exemplo: Possuir um sistema feito em .NET que realiza vendas, e elas precisam ser enviadas a um fornecedor que utiliza Java, pensando no caso de não haver intereção humana, uma maneira seria utilizar o Json para permitir a comunicação.

-> Comunicação de Front-end e back-end, sistemas dentro do próprio .NET, são algumas aplicações possíveis.

-> Utilizar Json viewer dentro do Codebeautify !!!

#### Atributos

-> Atribuir metadados para as classes e propriedades, passando valores ou alterando seu comportamento. Acrescendo informaçoes adicionais, comportamento.

-> Vide classe venda para entendimento, usada no recebimento do json com uma propriedade cujo nome não se encaixaria nos padrões de escrita do C#.



