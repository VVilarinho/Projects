using BGT.Domain.Common;

namespace BGT.Domain.Entities
{
    public class GameInfo : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
