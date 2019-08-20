using QuickBuy.Dominio.Contrato;
using QuickBuy.Dominio.Entidades;
using QuickBuy.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(QuickBuyContexto quickBuyContexto) : base(quickBuyContexto)
        {
        }

        public Usuario Obter(string email, string senha)
        {
            return quickBuyContexto.usuarios.FirstOrDefault(u => u.email == email && u.senha == senha);
        }
    }
}
