using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividade_interface_classe_abstrata_logica.Models.Veiculos
{
    public class Moto : Veiculo, IBuzina
    {
        public Moto(string marca, string modelo, int velocidadeAtual) : base(marca, modelo, velocidadeAtual) { }
        public override void Acelerar() => VelocidadeAtual += 15;
        public void Buzinar() => Console.WriteLine("bi bi");
        public override void Frear() => VelocidadeAtual -= 7;
    }
}