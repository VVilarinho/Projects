using BGT.Domain.Entities;
using BGT.Infrastructure.Persistence;
using IdentityServer4.EntityFramework.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Moq;
using Shouldly;
using System;
using System.Threading.Tasks;
using Xunit;

namespace BGT.Infrastructure.IntegrationTests.Persistence
{
    public class ApplicationDbContextTests : IDisposable
    {
        private readonly string _gameId;
        private readonly DateTime _dateTime;
        private readonly Mock<IDateTime> _dateTimeMock;
        private readonly Mock<ICurrentUserService> _currentUserServiceMock;
        private readonly ApplicationDbContext _sut;

        public ApplicationDbContextTests()
        {
            _dateTime = new DateTime(3001, 1, 1);
            _dateTimeMock = new Mock<IDateTime>();
            _dateTimeMock.Setup(m => m.Now).Returns(_dateTime);

            _gameId = "1";
            _currentUserServiceMock = new Mock<ICurrentUserService>();
            _currentUserServiceMock.Setup(m => m.UserId).Returns(_gameId);



            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;



            var operationalStoreOptions = Options.Create(
                new OperationalStoreOptions
                {
                    DeviceFlowCodes = new TableConfiguration("DeviceCodes"),
                    PersistedGrants = new TableConfiguration("PersistedGrants")
                });



            _sut = new ApplicationDbContext(options, operationalStoreOptions, _currentUserServiceMock.Object, _dateTimeMock.Object);


            _sut.BoardGameInfos.Add(new BoardGameInfo
            {
                GameId = 1,
                GameName = "Do this thing."
            });


            _sut.SaveChanges();
        }

        [Fact]
        public async Task SaveChangesAsync_GivenNewTodoItem_ShouldSetCreatedProperties()
        {
            var item = new BoardGameInfo
            {
                GameId = 2,
                GameName = "This thing is done.",
            };

            _sut.BoardGameInfos.Add(item);

            await _sut.SaveChangesAsync();

            item.Created.ShouldBe(_dateTime);
            item.CreatedBy.ShouldBe(_gameId);
        }

        [Fact]
        public async Task SaveChangesAsync_GivenExistingTodoItem_ShouldSetLastModifiedProperties()
        {
            long id = 1;

            var item = await _sut.BoardGameInfos.FindAsync(id);

            //item.Done = true;

            await _sut.SaveChangesAsync();

            item.LastModified.ShouldNotBeNull();
            item.LastModified.ShouldBe(_dateTime);
            item.LastModifiedBy.ShouldBe(_gameId);
        }

        public void Dispose()
        {
            _sut?.Dispose();
        }
    }
}
