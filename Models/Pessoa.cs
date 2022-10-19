using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Caminho lógico
namespace fundamentos.Models
{
    public class Pessoa
    {
        /*
        @ -> permite a utilização de palavras reservadas
        Exemplo: @class
        */

        //Propriedade em C#
        public string Nome
        {
            get;
            set;
        }

        public int Idade
        {
            get;
            set;
        }


        //Métodos em C#
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos");
        }
    }
}