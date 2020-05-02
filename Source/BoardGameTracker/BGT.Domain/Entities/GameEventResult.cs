using BGT.Domain.Common;
using BGT.Domain.Enums;
using System;

namespace BGT.Domain.Entities
{
    public class GameEventResult : AuditableEntity
    {
        //How to organize the list of players/points/position
        public int WinnerPLayerID { get; set; }
        public int? NumberOfPoint { get; set; }
        //Maybe costume configuration for each type of game? Get that info from BGG or configure it
        // List of Points, calculations per type of Game, 


        //Start and stop maybe? 
        public TimeSpan? Timelapsed { get; set; }
        public GameResult GameResult { get; set; }
    }
}