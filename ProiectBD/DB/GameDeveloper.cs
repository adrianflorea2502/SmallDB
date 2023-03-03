using System;
using System.Collections.Generic;

#nullable disable

namespace ProiectBD.DB
{
    public partial class GameDeveloper
    {
        public int GameId { get; set; }
        public int DeveloperId { get; set; }

        public virtual Developer Developer { get; set; }
        public virtual Game Game { get; set; }
    }
}
