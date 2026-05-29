using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividade_interface_classe_abstrata_logica.Models.Veiculos
{
    public abstract class Veiculo
    {
        protected Veiculo(string marca, string modelo, int velocidadeAtual)
        {
            Marca = marca;
            Modelo = modelo;
            VelocidadeAtual = velocidadeAtual;
        }


        private int velocidadeAtual;
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int VelocidadeAtual
        {
            get => velocidadeAtual; set
            {
                if (value >= 0)
                {
                    velocidadeAtual = value;
                }
                else { Console.WriteLine($"Proibido velocidade negativa. Velocidade de {GetType().Name} definida como 0."); }
            }
        }
        public abstract void Acelerar();
        public abstract void Frear();
    }
}