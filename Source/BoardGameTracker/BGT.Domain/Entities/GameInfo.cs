using BGT.Domain.Common;

namespace BGT.Domain.Entities
{
    public class GameInfo : AuditableEntity
    {        
        public long Id { get; set; }
        public int ListId { get; set; }

        public string Name { get; set; }
        public string Deescription { get; set; }
        public string ImageURL { get; set; }
        public string ReleaseYear { get; set; }
    }
}