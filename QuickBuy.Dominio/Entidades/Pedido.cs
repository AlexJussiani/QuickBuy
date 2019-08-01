using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido
    {
        public int id { get; set; }
        public DateTime dataPedido { get; set; }
        public int usuarioId { get; set; }
        public DateTime dataPrecisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string  estado { get; set; }
        public string  cidade { get; set; }
        public string enderecoCompleto { get; set; }
        public int numeroEndereco { get; set; }
        public int formaPagamentoId { get; set; }
        public FormaPagamento formaPagamento { get; set; }

        /// <summary>
        /// Pedido deve ter pelo menos um item de 
        /// pedido ou muitos itens de pedidos
        /// </summary>
        public ICollection<ItemPedido> itensPedidos { get; set; }

    }
}
