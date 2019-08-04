using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int id { get; set; }
        public DateTime dataPedido { get; set; }
        public int usuarioId { get; set; }
        public virtual Usuario usuario { get; set; }
        public DateTime dataPrecisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string  estado { get; set; }
        public string  cidade { get; set; }
        public string enderecoCompleto { get; set; }
        public int numeroEndereco { get; set; }
        public int formaPagamentoId { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }

        /// <summary>
        /// Pedido deve ter pelo menos um item de 
        /// pedido ou muitos itens de pedidos
        /// </summary>
        public virtual ICollection<ItemPedido> itensPedidos { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();
            if (!itensPedidos.Any())
                AdicionarCritica("Crítica - Pedido não pode ficar sem item de Pedido");
            if (string.IsNullOrEmpty(CEP))
            {
                AdicionarCritica("Crítica - CEP deve estar preenchido");
            }
            if (formaPagamentoId == 0)
            {
                AdicionarCritica("Crítica - Não foi informado a forma de pagamento");
            }
        }
    }
}
