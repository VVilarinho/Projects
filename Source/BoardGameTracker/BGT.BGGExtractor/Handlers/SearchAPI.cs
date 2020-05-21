using AutoMapper;
using BGT.BGG.Domain.Entities;
using BGT.BGG.Extractor.Interfaces;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BGT.BGG.Extractor
{
    public class SearchAPIQueryHandler : ISearchAPIQueryHandler
    {
        private readonly ILogger<SearchAPIQueryHandler> logger;
        private readonly IMapper mapper;

        public SearchAPIQueryHandler(ILogger<SearchAPIQueryHandler> logger, IMapper mapper)
        {
            this.logger = logger;
            this.mapper = mapper;
        }

        public (bool IsSuccess, IEnumerable<SearchResult> searchResults, string ErrorMessage) Search(string wildCard)
        {
            if (string.IsNullOrEmpty(wildCard))
            {
                return (true, searchResults:
                    new List<SearchResult> { new SearchResult() { Id = 1, Name = "DummySearch", YearPublished = "2020" } },
                    string.Empty);
            }

            throw new System.NotImplementedException();
        }
    }
}