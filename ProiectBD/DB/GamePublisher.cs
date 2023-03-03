using System;
using System.Collections.Generic;

#nullable disable

namespace ProiectBD.DB
{
    public partial class GamePublisher
    {
        public int GameId { get; set; }
        public int PublisherId { get; set; }

        public virtual Game Game { get; set; }
        public virtual Publisher Publisher { get; set; }
    }
}
