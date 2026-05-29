using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividade_interface_classe_abstrata_logica.Models.Empresa
{
    public class Gerente : Funcionario, IRelatorio
    {
        public Gerente(string nome, decimal salarioBase) : base(nome, salarioBase) { }
        public override decimal CalcularSalario()
        {
            return SalarioBase * 1.2m;
        }
        public void ExibirRelatorio()
        {
            Console.WriteLine(@$"
Cargo: {GetType().Name}
Salário Base: R${SalarioBase:F2} - Bônus: 20%
Salário com bônus: R${CalcularSalario():F2}
");
        }
    }
}