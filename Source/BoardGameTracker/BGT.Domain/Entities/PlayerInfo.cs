using BGT.Domain.Common;

namespace BGT.Domain.Entities
{
    public class PlayerInfo : AuditableEntity
    {
        public long Id { get; set; }
        public string PlayerName { get; set; }
    }
}