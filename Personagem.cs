using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace poo
{
    public class Personagem
    {
        public string Nome {get; set;}
        public int Vida {get; set;}

        public int Ataque {get; set;}

        public int Defesa { get; set;}

        public Personagem( string nome, int vida, int ataque, int defesa){
            Nome = nome;
            Vida = vida;
            Ataque = ataque;
            Defesa = defesa;
        }
        public void Atacar(Personagem alvo){
           int dano = Math.Max(Ataque - alvo.Defesa, 0);
            alvo.Vida -= dano;

            Console.WriteLine($"{Nome} atacou {alvo.Nome}");

            if ( alvo.Vida <= 0){
                Console.WriteLine("O alvo foi derrotado");
            }
            else{
                Console.WriteLine("Você não derrotou o alvo");
            }
           
        }
    }
}