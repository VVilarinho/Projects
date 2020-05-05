using BGT.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace BGT.Infrastructure.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<GameInfo> BoardGameInfos { get; set; }
        DbSet<PlayerInfo> PlayerInfos { get; set; }
        DbSet<GameEvent> GameEvents { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}