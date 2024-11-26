using System.Threading.Tasks.Dataflow;

namespace poo;

class Program
{
    static void Main(string[] args)
    {
        Pessoa person1 = new Pessoa("Chayenne" , 12);
        Console.WriteLine(person1.Nome+ " idade: "+ person1.Age);

          Pessoa person2 = new Pessoa ("Igor", 56);
        Console.WriteLine(person2.Nome);
         Console.WriteLine(person2.Age);

    }
}
