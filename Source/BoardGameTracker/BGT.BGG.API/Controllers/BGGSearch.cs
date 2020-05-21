using System.Threading.Tasks;
using BGT.BGG.API.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BGT.BGG.API.Controllers
{
    [ApiController]
    [Route("api/Search")]
    public class BGGSearch : ControllerBase
    {
        private readonly ISearchProvider searchProvider;

        public BGGSearch(ISearchProvider searchProvider)
        {
            this.searchProvider = searchProvider;
        }

        public async Task<IActionResult> SearchAsync()
        {
            var all = await searchProvider.SearchBoardgameAsync();

            if (all.IsSuccess)
            {
                return Ok(all.searchResults);
            }
            return NotFound(all.ErrorMessage);
        }


        [HttpGet("{wildCard}")]
        public async Task<IActionResult> SearchAsync(string wildCard)
        {
            var result = await searchProvider.SearchBoardgameAsync(wildCard);

            if (result.IsSuccess)
            {
                return Ok(result.searchResults);
            }
            return NotFound(result.ErrorMessage);
        }
    }
}
