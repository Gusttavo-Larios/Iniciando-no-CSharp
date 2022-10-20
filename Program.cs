//Importando classe de um namespace
using fundamentos.Models;

//Instanciando classe no C#
Pessoa pessoa = new Pessoa();//Conveção -> Nome de varivável camelCase

pessoa.Nome = "Maria";
pessoa.Idade = 40;
pessoa.Altura = 1.90M;//Tipo de dado -> Decimal apresenta precisão de casas decimais
pessoa.Apresentar();