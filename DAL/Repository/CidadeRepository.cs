using DAL.Context;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DAL.Repository
{
    public class CidadeRepository : Repository<Cidade>, ICidadeRepository
    {
        public CidadeRepository(DbContext context) : base(context)
        {
        }

        public Cidade CidadeWithDetails(int id)
        {
            return EstoqueContext.Cidades.Include(c => c.Detalhes)
                .SingleOrDefault(c => c.Id == id);
        }

        public EstoqueContext EstoqueContext
        {
            get { return Context as EstoqueContext; }
        }
    }
}
