using BGT.BGG.Domain.Entities;
using BGT.BGG.Extractor.Interfaces;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using AutoMapper;
using BGT.BGG.Extractor.BGGSchema.SearchResult;

namespace BGT.BGG.Extractor
{
    public class SearchAPIQueryHandler : ISearchAPIQueryHandler
    {
        private readonly IMapper mapper;
        private static readonly HttpClient client = new HttpClient();

        public SearchAPIQueryHandler()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Boardgame, SearchResult>());
            mapper = new Mapper(config);
        }

        public async Task<(bool IsSuccess, IEnumerable<SearchResult> searchResults, string ErrorMessage)> SearchAsync(string wildCard)
        {
            if (string.IsNullOrEmpty(wildCard))
            {
                client.DefaultRequestHeaders.Accept.Clear();

                var msg = await client.GetStringAsync("http://www.boardgamegeek.com/xmlapi/search?search=Gloomhaven");

                var searchResults = XMLTools.DeSerializeSearch<Boardgames>(msg);

                var result = mapper.Map<IEnumerable<SearchResult>>(searchResults.Boardgame);

                return (true, result, string.Empty);
            }

            throw new System.NotImplementedException();
        }
    }
}