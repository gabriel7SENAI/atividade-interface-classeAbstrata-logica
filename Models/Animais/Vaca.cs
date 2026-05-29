using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividade_interface_classe_abstrata_logica.Models.Animais
{
    public class Vaca : Animal
    {
        public Vaca(string nome, int idade) : base(nome, idade) { }
        public override void EmitirSom()
        {
            System.Console.WriteLine("mu");
        }
    }
}