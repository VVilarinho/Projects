using BGT.BGG.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BGT.BGG.API.Interfaces
{
    public interface ISearchProvider
    {
        /// <summary>
        /// Executes a search with an WildCard that will return one or many boardgames results 
        /// </summary>
        /// <param name="wildcardName"></param>
        /// <returns></returns>
        Task<(bool IsSuccess, IEnumerable<SearchResult> searchResults, string ErrorMessage)> SearchBoardgameAsync(string wildcard);

        /// <summary>
        /// Executes an search using the BoardGame ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<(bool IsSuccess, BoardGameInfo boardGameInfo, string ErrorMessage)> GetBoardgameAsync(int id);
    }
}
