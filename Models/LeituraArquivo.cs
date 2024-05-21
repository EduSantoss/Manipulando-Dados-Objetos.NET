using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manipulando_NET.Models
{
    public class LeituraArquivo
    {
        // Aqui não vai poder ser void, preciso de um retorno de 3 tipos diferentes!!! Tupla
        public (bool Sucesso, string[] LinhasArquivo, int QuantidadeLinhas) LerArquivo(String caminho)
        {   
            // Quer retonar 3 informações para quem chamou: se deu sucesso a leitura(bool), as linhas lidas(array strings), e quantas linhas existem no arquivo(int). Caso perfeito para usar tuplas.
            try
            {
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count());
            } // caso não dê sucesso, vai cair no catch.
            catch (Exception)
            {
                return(false, new string[0], 0);
            }
        }
    }
}