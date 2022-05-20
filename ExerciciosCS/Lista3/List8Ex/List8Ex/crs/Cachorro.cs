using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List8Ex.crs
{
    internal class Cachorro
    {

        public string Cor { get; set; }
        public string Raca { get; set; }
        public string Nome { get; set; }
        public double Peso { get; set; }

        public Cachorro(string _cor, string _raca, string _nome, double _peso)
        {
            Cor = _cor;
            Raca = _raca;
            Nome = _nome;
            Peso = _peso;
        }

        public void comer(string racao)
        {
            Console.WriteLine($"a ração que eu estou comendo é de {racao}");
        }
        public void latir()
        {
            Console.WriteLine("AUAUAUAUAUAUAU");
        }
    }
}
