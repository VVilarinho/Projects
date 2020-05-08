using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using AutoMapper;
using BGT.BGG.Domain.Entities;
using Microsoft.Extensions.Configuration;

namespace BGT.BGG.API.Providers
{
    public class SearchProvider: IServiceProvider
    {

        private readonly Extractor.SearchAPI searchAPI;
        private readonly Extractor.GameInfoApi gameInfoApi;

        private readonly ILogger<SearchProvider> logger;
        private readonly IMapper mapper;

        public SearchProvider(ILogger<SearchProvider> logger, IMapper mapper, IConfiguration configuration)
        {
            this.logger = logger;
            this.mapper = mapper;

            var configTest= configuration.GetSection("BGGURLs");
        }

        public async Task<(bool IsSuccess, IEnumerable<SearchResult> searchResults, string ErrorMessage)> SearchBoardgameAsync(string wildcard)
        {
            try
            {
                logger?.LogInformation($"Searching for boardgames with wildcard: {wildcard}");

                var result = searchAPI.Search(wildcard);

                if (result.IsSuccess && result.searchResults != null)
                {
                    logger?.LogInformation("Results found");
                    
                    //var result = mapper.Map<Product>(product);

                    return (true, result.searchResults, null);
                }
                return (false, null, "Not found");
            }
            catch (Exception ex)
            {
                logger?.LogError(ex.ToString());

                return (false, null, ex.Message);
            }
        }

        public async Task<(bool IsSuccess, BoardGameInfo boardGameInfo, string ErrorMessage)> GetBoardgameAsync(int id)
        {
            try
            {
                logger?.LogInformation($"Searching for boardgame info: {id}");

                var result = gameInfoApi.GetBoardGameInfo(id);

                if (result.IsSuccess && result.gameInfo != null)
                {
                    logger?.LogInformation("Results found");

                    //var result = mapper.Map<Product>(product);

                    return (true, result.gameInfo, null);
                }
                return (false, null, "Not found");
            }
            catch (Exception ex)
            {
                logger?.LogError(ex.ToString());

                return (false, null, ex.Message);
            }
        }

        public object GetService(Type serviceType)
        {
            throw new NotImplementedException();
        }
    }
}
