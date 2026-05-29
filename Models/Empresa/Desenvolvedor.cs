using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividade_interface_classe_abstrata_logica.Models.Empresa
{
    public class Desenvolvedor : Funcionario, IRelatorio
    {
        public Desenvolvedor(string nome, decimal salarioBase) : base(nome, salarioBase) { }
        public override decimal CalcularSalario()
        {
            return SalarioBase * 1.1m;
        }
        public void ExibirRelatorio()
        {
            Console.WriteLine(@$"
Cargo: {GetType().Name}
Salário Base: R${SalarioBase:F2} - Bônus: 10%
Salário com bônus: R${CalcularSalario():F2}
");
        }
    }
}