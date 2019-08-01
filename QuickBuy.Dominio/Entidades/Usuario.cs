using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario
    {
        public int id { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string nome { get; set; }
        public string sobreNome { get; set; }


        /// <summary>
        /// Usuario pode ter nenhum ou muitos pedidos
        /// </summary>
        public ICollection<Pedido> pedidos { get; set; }
    }
}
