using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Ingrediente : Entidade
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public decimal preco { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(nome))
                AdicionarCritica("Nome do Ingrediente não foi informado");

            if (string.IsNullOrEmpty(preco.ToString()))
                AdicionarCritica("Preço não foi informado");
        }
    }
}
