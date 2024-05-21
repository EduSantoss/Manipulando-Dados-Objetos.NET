using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manipulando_NET.Models
{
    public class Curso
    {
        public string NomeCurso { get; set; }
        public List<Pessoa> Alunos { get; set; }

        // public pode ser apagado em um método, nao faz parte da sua assinatura
        // void usado quando nao se vai ter algum retorno, nesse caso abaixo ele vai apenas adicionar um aluno.
        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }
        
        // aqui se quer retonar uma informação da quantidade de alunos quando for chamado.
        // para entender que o método está terminado e retorna algo, é necessario o return.
        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }
         
        // poderia botar para remover ou aluno, ou no caso abaixo, retornar o resultado do método, true se removeu e false se nao removeu. 
        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
          //  ou tira o return de cima e deixa só o de baixo
          //  return true; 
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de: {NomeCurso}");

            for (int count = 0; count < Alunos.Count; count++)
            {
                // passar concatenação dentro de uma variável string.
                // string texto = "N° " + count + " -> " + Alunos[count].NomeCompleto;

                // interpolação utiliza o simbolo de dolar, permitindo colocar em um unico texto tudo desejado
                string texto = $"N° {count + 1} -> {Alunos[count].NomeCompleto}";
                Console.WriteLine(texto);
            } 

            // foreach (Pessoa aluno in Alunos)
            // {
            //     Console.WriteLine(aluno.NomeCompleto);
            // }
        }
    }
}