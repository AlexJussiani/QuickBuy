using QuickBuy.Dominio.Contrato;
using QuickBuy.Dominio.Entidades;
using QuickBuy.Repositorio.Contexto;

namespace QuickBuy.Repositorio.Repositorios
{
    public class IngredienteRepositorio : BaseRepositorio<Ingrediente>, IIngredienteRepositorio { 

        public IngredienteRepositorio(QuickBuyContexto quickBuyContexto): base(quickBuyContexto)
        {

        }
    }
}
