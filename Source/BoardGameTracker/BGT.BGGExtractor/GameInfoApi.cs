using AutoMapper;
using BGT.BGG.Domain.Entities;
using BGT.BGG.Extractor.Interfaces;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace BGT.BGG.Extractor
{
    public class GameInfoApi: IGameInfoApi
    {
        private readonly ILogger<SearchAPI> logger;
        private readonly IMapper mapper;

        public GameInfoApi(ILogger<SearchAPI> logger, IMapper mapper)
        {
            this.logger = logger;
            this.mapper = mapper;
        }

        public (bool IsSuccess, BoardGameInfo gameInfo, string ErrorMessage) GetBoardGameInfo(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}