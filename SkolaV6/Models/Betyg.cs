using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SkolaV6.Models
{
    public partial class Betyg
    {
        public int BetygsId { get; set; }
        public int? Betyg1 { get; set; }
        public DateTime? BetygsDatum { get; set; }
        public int LärarId { get; set; }
        public int ElevId { get; set; }
        public int? KursId { get; set; }

        public virtual Elev Elev { get; set; }
        public virtual Kurser Kurs { get; set; }
        public virtual Personal Lärar { get; set; }
    }
}
