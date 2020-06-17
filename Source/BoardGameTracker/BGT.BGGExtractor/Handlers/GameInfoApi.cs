using BGT.BGG.Domain.Entities;
using BGT.BGG.Extractor.Interfaces;
using AutoMapper;
using System.Threading.Tasks;
using System.Net.Http;
using BGT.BGG.Extractor.BGGSchema.BoardgameResult;
using System.Linq;

namespace BGT.BGG.Extractor
{
    public class GameInfoApiQueryHandler : IGameInfoApiQueryHandler
    {
        private readonly IMapper mapper;
        private static readonly HttpClient client = new HttpClient();

        public GameInfoApiQueryHandler()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Boardgame, BoardGameInfo>()
                .ForMember(x => x.Description, y => y.MapFrom(z => z.Description))
                .ForMember(x => x.Name, y => y.MapFrom(z => z.Name.Text))
                );
            mapper = new Mapper(config);
        }

        public async Task<(bool IsSuccess, BoardGameInfo gameInfo, string ErrorMessage)> SearchAsync(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                client.DefaultRequestHeaders.Accept.Clear();

                var msg = await client.GetStringAsync("http://www.boardgamegeek.com/xmlapi/boardgame/214032");

                var searchResult = XMLTools.DeSerializeSearch<Boardgames>(msg);

                var result = mapper.Map<BoardGameInfo>(searchResult.Boardgame);

                return (true, result, string.Empty);
            }

            throw new System.NotImplementedException();
        }
    }
}