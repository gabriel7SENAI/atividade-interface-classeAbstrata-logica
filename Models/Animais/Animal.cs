using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividade_interface_classe_abstrata_logica.Models.Animais
{
    public abstract class Animal : IComportamento
    {
        protected Animal(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Comer() => Console.WriteLine($"{Nome} comeu");
        public void Dormir() => Console.WriteLine($"{Nome} dormiu");
        public virtual void EmitirSom() { }
    }
}