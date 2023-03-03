using System;
using System.Collections.Generic;

#nullable disable

namespace ProiectBD.DB
{
    public partial class Developer
    {
        public int DeveloperId { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Country { get; set; }
    }
}
