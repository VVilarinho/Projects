using BGT.BGG.Domain.Entities;
using System.Collections.Generic;

namespace BGT.BGG.Extractor.Interfaces
{
    public interface ISearchAPIQueryHandler
    {
        (bool IsSuccess, IEnumerable<SearchResult> searchResults, string ErrorMessage) Search(string wildCard);
    }
}