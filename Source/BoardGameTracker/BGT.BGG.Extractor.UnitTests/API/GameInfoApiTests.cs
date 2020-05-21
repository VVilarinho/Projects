using AutoMapper;
using System.Threading.Tasks;
using Xunit;

namespace BGT.BGG.Extractor.UnitTests
{
    [Collection("GameInfoTests")]
    public class GameInfoApiTests
    {
        private readonly IMapper _mapper;

        public GameInfoApiTests(APITestFixture fixture)
        {
            _mapper = fixture.Mapper;
        }

        [Fact]
        public async Task Handle_ReturnsCorrectVmAndListCount()
        {

        }
    }
}
