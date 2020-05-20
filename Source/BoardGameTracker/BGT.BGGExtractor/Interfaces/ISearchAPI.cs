using BGT.BGG.Domain.Entities;
using System.Collections.Generic;

namespace BGT.BGG.Extractor.Interfaces
{
    public interface ISearchAPI
    {
        (bool IsSuccess, IEnumerable<SearchResult> searchResults, string ErrorMessage) Search(string wildCard);
    }
}