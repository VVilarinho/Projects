using Moq;
using Xunit;
using Shouldly;
using System.Linq;
using System.Threading.Tasks;
using BGT.BGG.Extractor.Interfaces;

namespace BGT.BGG.Extractor.UnitTests
{
    [Collection("GameInfoTests")]
    public class GameInfoApiTests
    {
        private readonly Mock<ISearchAPIQueryHandler> searchAPIQueryHandler;

        public GameInfoApiTests()
        {
            this.searchAPIQueryHandler = new Mock<ISearchAPIQueryHandler>();
            searchAPIQueryHandler.Setup(x => x.Search(It.IsAny<string>())).Returns(
                (   IsSuccess: true,
                    null,
                    ErrorMessage: string.Empty)
                );

            //this.searchAPIQueryHandler.Setup(m => m.).Returns(_userId);
        }

        [Fact]
        public async Task SearchHandler_ReturnDummyValue()
        {
            //int id = 1;

            //var result = searchAPIQueryHandler.Search(string.Empty);

            //result.IsSuccess.ShouldBeTrue();
            //result.ErrorMessage.ShouldBeEmpty();
            //result.searchResults.ShouldNotBeEmpty();
            //result.searchResults.FirstOrDefault().Id.ShouldBe(id);
        }
    }
}
