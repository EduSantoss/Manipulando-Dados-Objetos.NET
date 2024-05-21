using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manipulando_NET.Models
{
    public class Pessoa
    {
        // podem se ter mais de um construtor, construtor padrao para permitir o tipo de entrada vazia, ou que no caso vai receber algo de alguem ao digitar.
        public Pessoa()
        {

        }
        
        // construtor, mesmo nome da classe, não possui tipo de retorno.
        public Pessoa(string nome, string sobrenome)
        {
            // implementando o construtor, propriedade Nome precisa receber um nome como parametro e o mesmo para propriedade Sobrenome.
            Nome = nome;
            Sobrenome = sobrenome;
        }
        
        // ação inversa ao construtor sendo feita.
        public void Deconstruct(out string nome, out string sobrenome)
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }

        // esses são campos
        private string _nome;
        private int _idade;

        // validações no  get e set
        // estas são propriedades, propriedades precisam ter ou get ou set, ou os dois.
        public string Nome
        {
            //   get
            //   {
            //      return _nome.ToUpper();    
            //   } 
            get => _nome.ToUpper();
            // assim para ficar mais legivel, chamado de body expressions.

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }
        }

        public string Sobrenome { get; set; }
         
         // só get, utilizando a seta
      //  public string NomeCompleto { get => $"{Nome} {Sobrenome}";}
        // ou
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public int Idade
        {
            get => _idade;

            set
            {
              if (value < 0)
              {
                throw new ArgumentException("A idade não pode ser menor do que zero");
              }

              _idade = value;     
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
            // aqui entra o get, pegar o valor que for setado.
        }

    }
}