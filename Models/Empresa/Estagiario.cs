using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividade_interface_classe_abstrata_logica.Models.Empresa
{
    public class Estagiario : Funcionario, IRelatorio
    {
        public Estagiario(string nome, decimal salarioBase) : base(nome, salarioBase)
        {
        }

        public override decimal CalcularSalario()
        {
            return SalarioBase;
        }

        public void ExibirRelatorio()
        {
            Console.WriteLine(@$"
Cargo: {GetType().Name}
Salário Base: R${SalarioBase:F2} - Bônus: sem bônus
Salário com bônus: R${CalcularSalario():F2}
");
        }
    }
}