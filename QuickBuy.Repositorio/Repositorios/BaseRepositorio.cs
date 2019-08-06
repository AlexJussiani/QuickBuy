using QuickBuy.Dominio.Contrato;
using QuickBuy.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        protected readonly QuickBuyContexto quickBuyContexto;


        public BaseRepositorio(QuickBuyContexto quickBuyContexto)
        {
            this.quickBuyContexto = quickBuyContexto;
        }
        public void Adicionar(TEntity entity)
        {
            quickBuyContexto.Set<TEntity>().Add(entity);
            quickBuyContexto.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            quickBuyContexto.Set<TEntity>().Update(entity);
            quickBuyContexto.SaveChanges();
        }

        public TEntity ObterPorId(int id)
        {
            return quickBuyContexto.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return quickBuyContexto.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            quickBuyContexto.Remove(entity);
            quickBuyContexto.SaveChanges();
        }

        public void Dispose()
        {
            quickBuyContexto.Dispose();
        }
    }
}
