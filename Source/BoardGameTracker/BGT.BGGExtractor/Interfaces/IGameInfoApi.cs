using BGT.BGG.Domain.Entities;

namespace BGT.BGG.Extractor.Interfaces
{
    public interface IGameInfoApiQueryHandler
    {
        (bool IsSuccess, BoardGameInfo gameInfo, string ErrorMessage) Handle(int id);
    }
}