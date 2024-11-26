using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace poo
{
    public class Pessoa
    {
        public string Nome {get; set;}
        public int Age {get; set;}
        public Pessoa ( string nome, int age)
        {
            Nome = nome;
            Age = age;
        }
        public Pessoa ()
        {
            Nome = "Sem nome";
            Age = 0;
        }

    }
}
