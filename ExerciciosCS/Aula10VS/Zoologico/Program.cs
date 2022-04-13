using System;
using System.Collections.Generic;
using Zoologico.src;

namespace Zoologico
{
    class Program
    {
        static void Main(string[] args)
        {
                        Console.WriteLine("Zoológico");

            List<Animal> animais = new List<Animal>(
                new Animal[]{
                    new Gato("Gata Kau", "Cinza", "Felino"),
                    new Cachorro("Cachorro Conceição", "Preto", "Canídio"),
                    new Cachorro("Cachorro Carvalho", "Branco", "Canídio"),
                    new Gato("Gata Zimerer", "Marrom", "Felino"),
                    new Macaco("Macaco Grillo", "Marrom", "Primata"),
                }
            );

            foreach (Animal animal in animais)
            {
                if (animal.Classificacao == "Canídio")
                {
                    Console.WriteLine($"{animal.Nome} é um {animal.Classificacao}");
                    animal.Comunicar("Au au!");
                } 
                else if (animal.Classificacao == "Felino")
                {
                    Console.WriteLine($"{animal.Nome} é um {animal.Classificacao}");
                    animal.Comunicar("Miau!");
                }
                else if (animal.Classificacao == "Primata")
                {
                    Console.WriteLine($"{animal.Nome} é um {animal.Classificacao}");
                    animal.Comunicar("Huhu HAHA!");
                }
            }

        
        }
    }
}
