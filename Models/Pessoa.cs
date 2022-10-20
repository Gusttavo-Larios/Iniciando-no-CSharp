using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Caminho lógico
namespace fundamentos.Models
{
    //Convenção -> Nome do arquivo e da classe devem ser iguais
    public class Pessoa//Conveção -> Nome de classe PascalCase
    {
        /*
        @ -> permite a utilização de palavras reservadas
        Exemplo: @class
        */

        //Propriedade em C#
        public string Nome//Conveção -> Nome de propriedade PascalCase
        {
            get;
            set;
        }

        public int Idade//Conveção -> Nome de propriedade PascalCase
        {
            get;
            set;
        }

        public string NomeRepresentanteLegalDaPessoaFisica { get; set; }//Conveção -> Nomes descritivos

        public decimal Altura { get; set; }

        //Métodos em C#
        public void Apresentar()//Conveção -> Nome de método PascalCase
        {
            DateTime DataAtual = DateTime.Now;//DateTime -> representa uma data 

            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Altura} de altura e {Idade} anos de idade em {DataAtual.ToString("dd/MM/yyyy")}");
        }
    }
}