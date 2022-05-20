using List8Ex.crs;
using System;

namespace List8Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cachorros");
            Cachorro Scooby = new Cachorro("dourado", "golden","Scooby", 27.5 );
            Cachorro Tobby = new Cachorro("preto", "poodle", "Tobby", 12.7 );
            Cachorro Luidge = new Cachorro("marrom", "labrador", "Luidge", 25.8 );

            Console.WriteLine($"O Cachorro 1 se chama {Scooby.Nome}, da raça {Scooby.Raca}, da cor {Scooby.Cor} e tem um peso de {Scooby.Peso}Kg");
            Scooby.comer("Frango");
            Scooby.latir();

            Console.WriteLine($"O Cachorro 2 se chama {Tobby.Nome}, da raça {Tobby.Raca}, da cor {Tobby.Cor} e tem um peso de {Tobby.Peso}Kg");
            Tobby.comer("Carne");
            Tobby.latir();

            Console.WriteLine($"O Cachorro 3 se chama {Luidge.Nome}, da raça {Luidge.Raca}, da cor {Luidge.Cor} e tem um peso de {Luidge.Peso}Kg");
            Luidge.comer("Carne com Batata");
            Luidge.latir();
        }
    }
}
