﻿using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace BGT.BGG.Extractor.UnitTests
{
    [Collection("GameInfoTests")]
    public class GameInfoApiTests
    {
        [Fact]
        public async Task SearchHandler_ReturnDummyValue()
        {
            var handler = new GameInfoApiQueryHandler();

            var (IsSuccess, searchResults, ErrorMessage) = await handler.SearchAsync(string.Empty);
            
            IsSuccess.ShouldBeTrue();
            ErrorMessage.ShouldBeEmpty();
            searchResults.ShouldNotBeNull();
        }
    }
}
