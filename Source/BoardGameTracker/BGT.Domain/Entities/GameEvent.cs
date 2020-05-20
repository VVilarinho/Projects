using BGT.Domain.Common;
using System;
using System.Collections.Generic;

namespace BGT.Domain.Entities
{
    public class GameEvent : AuditableEntity
    {
        public long Id { get; set; }
        public string Location { get; set; }
        public int? PictureID { get; set; }
        public DateTime EventDay { get; set; }
        public GameInfo BoardGameInfo { get; set; }
        public List<PlayerInfo> Players { get; set; }
        public GameEventResult EventResult { get; set; }        
    }
}