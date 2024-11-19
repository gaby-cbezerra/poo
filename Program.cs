using System.Threading.Tasks.Dataflow;

namespace poo;

class Program
{
    static void Main(string[] args)
    {
        Personagem person1 = new Personagem("Gab", 200 , 50, 100);
        Personagem person2 = new Personagem("Dio", 150 , 60, 50);
        person1.Atacar(person2);


    }
}
