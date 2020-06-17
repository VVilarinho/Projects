using BGT.BGG.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BGT.BGG.Extractor.Interfaces
{
    public interface ISearchAPIQueryHandler
    {
        Task<(bool IsSuccess, IEnumerable<SearchResult> searchResults, string ErrorMessage)> SearchAsync(string wildCard);
    }
}