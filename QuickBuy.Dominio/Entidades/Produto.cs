﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public decimal preco { get; set; }

        public string nomeArquivo { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(nome))
                AdicionarCritica("Nome do produto não foi informado");

            if (string.IsNullOrEmpty(descricao))
                AdicionarCritica("Descrição não foi informado");
        }
    }
}
