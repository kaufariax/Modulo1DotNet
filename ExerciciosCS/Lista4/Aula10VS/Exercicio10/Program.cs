using System;
using Exercicio10.SRC;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Formas Geométricas");
            
            Quadrado quadrado1 = new Quadrado("Quadrado", 10, 10);
            Console.WriteLine($"A base do {quadrado1.Nome} é {quadrado1.Base} e a altura é {quadrado1.Altura}\n A área é {quadrado1.CalcularArea()}");
            
            Triangulo triangulo1 = new Triangulo("Triangulo", 10, 15);
            Console.WriteLine($"A base do {triangulo1.Nome} é {triangulo1.Base} e a altura é {triangulo1.Altura}\n A área é {triangulo1.CalcularArea()}");

            Retangulo retangulo1 = new Retangulo("Retangulo", 10, 15);
            Console.WriteLine($"A base do {retangulo1.Nome} é {retangulo1.Base} e a altura é {retangulo1.Altura}\n A área é {retangulo1.CalcularArea()}");
        }
    }
}
