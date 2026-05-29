using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividade_interface_classe_abstrata_logica.Models.Veiculos
{
    public class Carro : Veiculo, IBuzina
    {
        public Carro(string marca, string modelo, int velocidadeAtual) : base(marca, modelo, velocidadeAtual) { }
        public override void Acelerar() => VelocidadeAtual += 10;
        public void Buzinar() => Console.WriteLine("bo bo");

        public override void Frear() => VelocidadeAtual -= 5;
    }
}