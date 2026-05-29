using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividade_interface_classe_abstrata_logica.Models.Pagamento
{
    public class PedidoOnline : Pedido
    {
        public PedidoOnline(int numero, double valorTotal, IPagamento formaDePagamento) : base(numero, valorTotal, formaDePagamento) { }

        public override void FinalizarPedido()
        {
            formaDePagamento.Pagar(ValorTotal);
        }
    }
}