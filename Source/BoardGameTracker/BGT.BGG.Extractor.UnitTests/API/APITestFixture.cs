using AutoMapper;
using BGT.BGG.Extractor.Interfaces;
using System;
using Xunit;

namespace BGT.BGG.Extractor.UnitTests
{
    public sealed class APITestFixture : IDisposable
    {

        public APITestFixture(ISearchAPIQueryHandler searchAPIQueryHandler)
        {

            this.searchAPIQueryHandler = searchAPIQueryHandler;
        }
        
        public ISearchAPIQueryHandler searchAPIQueryHandler { get; }

        public void Dispose()
        {
            
        }
    }

    [CollectionDefinition("APITests")]
    public class QueryCollection : ICollectionFixture<APITestFixture> { }
}