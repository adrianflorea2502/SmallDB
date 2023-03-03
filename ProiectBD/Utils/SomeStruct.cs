using System;

namespace ProiectBD.Utils
{
    public struct StrangeGame
    {
        public int itemKey;
        public string name;
        public DateTime releaseDate;
        public int developer;
        public int publisher;
        public decimal price;
        public string rating;
        public string store_page;
    }
    public struct StrangeDev
    {
        public int itemKey;
        public string name;
        public string contact;
        public string country;
    }
    public struct StrangePub
    {
        public int itemKey;
        public string name;
        public string contact;
        public string country;
    }
}
