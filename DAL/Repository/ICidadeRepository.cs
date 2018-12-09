using DAL.Entities;

namespace DAL.Repository
{
    public interface ICidadeRepository
    {
        Cidade CidadeWithDetails(int id);
    }
}
