using AutoMapper;
using BGT.BGG.Domain.Entities;
using BGT.BGG.Extractor.Interfaces;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BGT.BGG.Extractor
{
    public class SearchAPI : ISearchAPI
    {
        private readonly ILogger<SearchAPI> logger;
        private readonly IMapper mapper;

        public SearchAPI(ILogger<SearchAPI> logger, IMapper mapper)
        {
            this.logger = logger;
            this.mapper = mapper;
        }

        public (bool IsSuccess, IEnumerable<SearchResult> searchResults, string ErrorMessage) Search(string wildCard)
        {
            throw new System.NotImplementedException();
        }
    }
}