using DAL.Context;

namespace DAL.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EstoqueContext _context;


        public UnitOfWork(EstoqueContext context)
        {
            _context = context;
            Estados = new EstadoRepository(_context);
            Cidades = new CidadeRepository(_context);
        }

        public ICidadeRepository Cidades { get; set; }
        public IEstadoRepository Estados { get; set; }


        public int Commit()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
