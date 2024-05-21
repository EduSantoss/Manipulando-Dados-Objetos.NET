using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Manipulando_NET.Models
{
    public class Venda
    {
        // comentado apenas para demonstrar a deserialização 

        // public Venda(int id, string produto, decimal preco, DateTime dataVenda)
        // {
        //     Id = id;
        //     Produto = produto;
        //     Preco = preco;
        //     DataVenda = dataVenda;
        // }


         // os nomes das propriedades precisam bater com o que vem do json
         // imaginar a situação que o nome da propriedade produto venha no json, Nome_Produto, não é viável colocar esse nome aqui devido as conveções do C#, e não podemos pedir ao cliente para alterar
         // solução: adicionar o using Newtonsoft.Json, outras situações podem ser um pouco diferentes, e a por último acrescentar acima da propriedade desejada a classe [JsonProperty("Nome_Produto")] no caso abaixo.
        public int Id { get; set; }

        // Nome disso é atributo, adicionando um metadado, acrescendo informaçoes adicionais, comportamento.
        [JsonProperty("Nome_Produto")] 
        public string Produto { get; set; }

        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
    }
}