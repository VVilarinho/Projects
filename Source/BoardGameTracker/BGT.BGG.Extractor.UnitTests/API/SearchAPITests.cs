using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace BGT.BGG.Extractor.UnitTests.API
{
    [Collection("SearchAPITests")]
    public class SearchAPITests
    {
        [Fact]
        public async Task SearchHandler_ReturnRandomValues()
        {
            var handler = new SearchAPIQueryHandler();

            var (IsSuccess, searchResults, ErrorMessage) = await handler.SearchAsync(string.Empty);

            IsSuccess.ShouldBeTrue();
            ErrorMessage.ShouldBeEmpty();
            searchResults.ShouldNotBeEmpty();            
        }
    }
}