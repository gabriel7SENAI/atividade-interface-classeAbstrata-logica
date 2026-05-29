using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividade_interface_classe_abstrata_logica.Models.Pagamento
{
    public interface IPagamento
    {
        void Pagar(double valor);
    }
}