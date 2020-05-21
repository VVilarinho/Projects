using AutoMapper;
using BGT.BGG.Domain.Entities;
using BGT.BGG.Extractor.Interfaces;
using Microsoft.Extensions.Logging;

namespace BGT.BGG.Extractor
{
    public class GameInfoApiQueryHandler : IGameInfoApiQueryHandler
    {
        private readonly ILogger<SearchAPIQueryHandler> logger;
        private readonly IMapper mapper;

        public GameInfoApiQueryHandler(ILogger<SearchAPIQueryHandler> logger, IMapper mapper)
        {
            this.logger = logger;
            this.mapper = mapper;
        }

        public (bool IsSuccess, BoardGameInfo gameInfo, string ErrorMessage) Handle(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}