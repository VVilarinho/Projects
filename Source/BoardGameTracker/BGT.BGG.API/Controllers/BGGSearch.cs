using System.Threading.Tasks;
using BGT.BGG.API.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BGT.BGG.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BGGSearch : ControllerBase
    {
        private readonly ISearchProvider searchProvider;

        public BGGSearch(ISearchProvider searchProvider)
        {
            this.searchProvider = searchProvider;
        }

        [HttpGet("{wildCard}")]
        public async Task<IActionResult> Search(string wildCard)
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
