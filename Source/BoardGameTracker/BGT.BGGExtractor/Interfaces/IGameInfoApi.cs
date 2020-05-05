using BGT.BGG.Domain.Entities;
using System.Collections.Generic;

namespace BGT.BGG.Extractor.Interfaces
{
    public interface IGameInfoApi
    {
        (bool IsSuccess, BoardGameInfo gameInfo, string ErrorMessage) GetBoardGameInfo(int id);
    }
}