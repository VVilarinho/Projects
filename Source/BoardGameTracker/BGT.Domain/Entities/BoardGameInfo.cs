using BGT.Domain.Common;

namespace BGT.Domain.Entities
{
    public class BoardGameInfo : AuditableEntity
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
    }
}
