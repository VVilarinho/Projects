using BGT.BGG.Domain.Entities;
using System.Threading.Tasks;

namespace BGT.BGG.Extractor.Interfaces
{
    public interface IGameInfoApiQueryHandler
    {
        Task<(bool IsSuccess, BoardGameInfo gameInfo, string ErrorMessage)> SearchAsync(string id);
    }
}