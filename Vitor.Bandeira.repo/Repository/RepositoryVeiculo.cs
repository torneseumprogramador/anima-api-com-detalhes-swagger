using Vitor.Bandeira.Context;
using Vitor.Bandeira.Models;

namespace Vitor.Bandeira.Repository
{
    public class RepositoryVeiculo : Repository<Veiculo>, IVeiculoRepository
    {
        public RepositoryVeiculo(AppDbContext context) : base(context)
        {
        }
    }
}