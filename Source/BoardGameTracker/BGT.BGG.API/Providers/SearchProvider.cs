using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using AutoMapper;
using BGT.BGG.Domain.Entities;
using Microsoft.Extensions.Configuration;
using BGT.BGG.API.Interfaces;
using BGT.BGG.Extractor.Interfaces;

namespace BGT.BGG.API.Providers
{
    public class SearchProvider : ISearchProvider
    {
        private readonly ISearchAPIQueryHandler searchHandler;
        private readonly IGameInfoApiQueryHandler gameInfoHandler;

        private readonly ILogger<SearchProvider> logger;
        private readonly IMapper mapper;

        public SearchProvider(ILogger<SearchProvider> logger,
            IMapper mapper,
            IConfiguration configuration,
            ISearchAPIQueryHandler searchHandler,
            IGameInfoApiQueryHandler gameInfoHandler
            )
        {
            this.logger = logger;
            this.mapper = mapper;

            this.searchHandler = searchHandler;
            this.gameInfoHandler = gameInfoHandler;

            var configTest = configuration.GetSection("BGGURLs");
        }

        public async Task<(bool IsSuccess, IEnumerable<SearchResult> searchResults, string ErrorMessage)> SearchBoardgameAsync()
        {
            logger?.LogInformation($"Empty Search for testing ");

            var result = await searchHandler.SearchAsync(string.Empty);

            return result;
        }

        public async Task<(bool IsSuccess, IEnumerable<SearchResult> searchResults, string ErrorMessage)> SearchBoardgameAsync(string wildcard)
        {
            try
            {
                logger?.LogInformation($"Searching for boardgames with wildcard: {wildcard}");

                var result = await searchHandler.SearchAsync(wildcard);

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

        public async Task<(bool IsSuccess, BoardGameInfo boardGameInfo, string ErrorMessage)> GetBoardgameAsync(string id)
        {
            try
            {
                logger?.LogInformation($"Searching for boardgame info: {id}");

                var result = await gameInfoHandler.SearchAsync(id);

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