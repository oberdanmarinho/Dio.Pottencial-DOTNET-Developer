using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pottencial.Models
{
    public class Pessoa                     // CLASSE
    {
        public string Nome { get; set; }    // ATRIBUTOS
        public int Idade { get; set; }      // ATRIBUTOS

        public void Apresentar()            // METODO
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e eu tenho {Idade} anos!");
        }
    }
}