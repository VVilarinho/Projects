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
        private readonly string userId;
        private readonly DateTime dateTime;

        private readonly Mock<IDateTime> dateTimeMock;
        private readonly Mock<ICurrentUserService> currentUserServiceMock;

        private readonly ApplicationDbContext sut;

        public ApplicationDbContextTests()
        {
            // Lets mock some base Data.
            dateTime = new DateTime(2020, 1, 1);
            dateTimeMock = new Mock<IDateTime>();
            dateTimeMock.Setup(m => m.Now).Returns(dateTime);

            userId = "CurrentUser";

            currentUserServiceMock = new Mock<ICurrentUserService>();
            currentUserServiceMock.Setup(m => m.UserId).Returns(userId);


            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var operationalStoreOptions = Options.Create(
                new OperationalStoreOptions
                {
                    DeviceFlowCodes = new TableConfiguration("DeviceCodes"),
                    PersistedGrants = new TableConfiguration("PersistedGrants")
                });

            sut = new ApplicationDbContext(options, operationalStoreOptions, currentUserServiceMock.Object, dateTimeMock.Object);

            sut.BoardGameInfos.Add(new GameInfo
            {
                Id = 1,
                Name = "Do this thing."
            });

            sut.SaveChanges();
        }

        [Fact]
        public async Task SaveChangesAsync_GivenNewTodoItem_ShouldSetCreatedProperties()
        {
            var item = new GameInfo
            {
                Id = 2,
                Name = "This thing is done.",
            };

            sut.BoardGameInfos.Add(item);

            await sut.SaveChangesAsync();

            item.Created.ShouldBe(dateTime);
            item.CreatedBy.ShouldBe(userId);
        }

        [Fact]
        public async Task SaveChangesAsync_GivenExistingTodoItem_ShouldSetLastModifiedProperties()
        {
            long id = 1;

            var item = await sut.BoardGameInfos.FindAsync(id);

            item.ReleaseYear = DateTime.Now.Year.ToString();

            await sut.SaveChangesAsync();

            item.ShouldNotBeNull();

            item.LastModified.ShouldNotBeNull();
            item.LastModified.ShouldBe(dateTime);
            item.LastModifiedBy.ShouldBe(userId);
        }

        [Fact]
        public async Task SaveChangesAsync_GivenExistingTodoItem_ShouldRemoveIt()
        {
            long id = 1;

            var item = await sut.BoardGameInfos.FindAsync(id);

            sut.BoardGameInfos.Remove(item);

            await sut.SaveChangesAsync();

            sut.BoardGameInfos.ShouldNotContain(item);
        }

        public void Dispose()
        {
            sut?.Dispose();
        }
    }
}