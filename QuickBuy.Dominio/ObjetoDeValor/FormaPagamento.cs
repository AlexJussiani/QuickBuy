using QuickBuy.Dominio.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.ObjetoDeValor
{
    public class FormaPagamento
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }

        public bool EhBoleto
        {
            get { return id == (int)TipoFormaPagamentoEnum.boleto; }
        }

        public bool EhCartao
        {
            get { return id == (int)TipoFormaPagamentoEnum.cartaoCredito; }
        }
        public bool EhDeposito
        {
            get { return id == (int)TipoFormaPagamentoEnum.deposito; }
        }

        public bool NaoFoiDefinido
        {
            get { return id == (int)TipoFormaPagamentoEnum.naoDefinido; }
        }
    }
}
