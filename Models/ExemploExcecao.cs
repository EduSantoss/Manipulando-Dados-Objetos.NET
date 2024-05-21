using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manipulando_NET.Models
{
    public class ExemploExcecao
    {

        public void Metodo1()
        {
            try
            {
                Metodo2();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exceção tratada" + ex.StackTrace); // stackTrace, caminho feito ate o tratamento da exceção
            }

        }
        public void Metodo2()
        {
            Metodo3();
        }
        public void Metodo3()
        {  // ou aqui ou lá em cima, trataria de qualquer jeito
            // try
            // {
            //    
            // }
            // catch (Exception)
            // {
            //     Console.WriteLine("Exceção tratada");
            // } 
            Metodo4();
        }
        public void Metodo4()
        {   // gera uma exceção e joga ela para o bloco anterior resolver, por isso na execução o erro é lido de baixo para cima
            throw new Exception("Ocorreu uma exceção");
        }


    }

}