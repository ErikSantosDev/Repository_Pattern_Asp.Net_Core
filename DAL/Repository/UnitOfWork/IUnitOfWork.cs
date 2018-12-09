namespace DAL.Repository
{
    public interface IUnitOfWork
    {
        ICidadeRepository Cidades { get; }
        IEstadoRepository Estados { get; }
        int Commit();
    }
}
