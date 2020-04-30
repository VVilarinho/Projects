using System.Threading;
using System.Threading.Tasks;

namespace BGT.Infrastructure.Interfaces
{
    public interface IApplicationDbContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}