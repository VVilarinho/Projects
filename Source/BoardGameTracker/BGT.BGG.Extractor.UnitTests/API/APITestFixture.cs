using AutoMapper;
using System;
using Xunit;

namespace BGT.BGG.Extractor.UnitTests
{
    public sealed class APITestFixture : IDisposable
    {
        public APITestFixture()
        {
            //var configurationProvider = new MapperConfiguration(cfg =>
            //{
            //    cfg.AddProfile<MappingProfile>();
            //});

            //Mapper = configurationProvider.CreateMapper();
        }
        
        public IMapper Mapper { get; }

        public void Dispose()
        {
            
        }
    }

    [CollectionDefinition("APITests")]
    public class QueryCollection : ICollectionFixture<APITestFixture> { }
}