using System.Threading;
using BGT.Domain.Entities;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BGT.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<GameInfo> BoardGameInfos { get; set; }
        DbSet<PlayerInfo> PlayerInfos { get; set; }
        DbSet<GameEvent> GameEvents { get; set; }       
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}