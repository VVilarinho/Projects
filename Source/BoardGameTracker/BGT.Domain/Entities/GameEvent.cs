using System;
using System.Collections.Generic;

namespace BGT.Domain.Entities
{
    public class GameEvent
    {
        public int GameEventID { get; set; }
        public BoardGameInfo BoardGameInfo { get; set; }
        public List<PlayerInfo> Players { get; set; }
        public int MyProperty { get; set; }
        public string Location { get; set; }
        public DateTime EventDay { get; set; }
        public int PictureID { get; set; } 
        public GameEventResult EventResult { get; set; }        
    }
}
