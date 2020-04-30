using BGT.Domain.Common;

namespace BGT.Domain
{
    public class PlayerInfo : AuditableEntity
    {
        public string PlayerID { get; set; }

        public string PlayerName { get; set; }
    }
}