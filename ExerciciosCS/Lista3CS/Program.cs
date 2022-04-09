using System;

namespace Lista3CS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            float altura,imc, peso;

            Console.WriteLine("insira seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("insira sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("insira sua altura: ");
            altura = float.Parse(Console.ReadLine());

            Console.WriteLine("insira seu peso: ");
            peso = float.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            Console.WriteLine("Olá " + nome + " vi que você tem: " + idade + " de idade. Seu IMC é:" + imc);
        }
    }
}
