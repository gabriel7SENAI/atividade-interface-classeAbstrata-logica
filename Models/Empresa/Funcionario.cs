using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividade_interface_classe_abstrata_logica.Models.Empresa
{
    public abstract class Funcionario
    {
        private decimal salarioBase;
        protected Funcionario(string nome, decimal salarioBase)
        {
            Nome = nome;
            SalarioBase = salarioBase;
        }
        public string Nome { get; set; }
        public decimal SalarioBase
        {
            get => salarioBase; set
            {
                if (value >= 0)
                {
                    salarioBase = value;
                }
                else { Console.WriteLine("Salário Deve ser maior que zero."); }
            }
        }
        public abstract decimal CalcularSalario();
    }
}