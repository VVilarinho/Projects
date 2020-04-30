﻿using BGT.Domain.Enums;
using System;

namespace BGT.Domain.Entities
{
    public class GameEventResult
    {
        public int WinnerPLayerID { get; set; }
        public int NumberOfPoint { get; set; }
        public TimeSpan Timelapsed { get; set; }
        public GameResult GameResult { get; set; }
    }
}