using System;

namespace L5IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            float altura, imc, peso;

            Console.WriteLine("insira seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("insira sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("insira sua altura: ");
            altura = float.Parse(Console.ReadLine());

            Console.WriteLine("insira seu peso: ");
            peso = (float) Convert.ToDouble(Console.ReadLine());

            imc = peso / (altura * altura);

            Console.Write("Olá, " + nome + " você tem: " + idade + " de idade.Seu IMC é: " + imc + " e você está ");

            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if(imc < 25)
            {
                Console.WriteLine("Peso Normal");
            }
            else if(imc < 30)
            {
                Console.WriteLine("Sobrepeso");
            }
            else
            {
                Console.WriteLine("Obesidade");
            }
            
        }
    }
}
