using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividade_interface_classe_abstrata_logica.Models.Pagamento
{
    public abstract class Pedido
    {
        protected Pedido(int numero, double valorTotal, IPagamento formaDePagamento)
        {
            Numero = numero;
            ValorTotal = valorTotal;
            this.formaDePagamento = formaDePagamento;
        }

        protected IPagamento formaDePagamento;

        public int Numero { get; set; }
        public double ValorTotal { get; set; }
        public abstract void FinalizarPedido();
    }
}