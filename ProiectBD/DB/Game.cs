using System;
using System.Collections.Generic;

#nullable disable

namespace ProiectBD.DB
{
    public partial class Game
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int DeveloperId { get; set; }
        public int PublisherId { get; set; }
        public decimal? Price { get; set; }
        public string Rating { get; set; }
        public string StorePage { get; set; }
    }
}
