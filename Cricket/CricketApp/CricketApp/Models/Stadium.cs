using System;
using System.Collections.Generic;

namespace CricketApp.Models
{
    public partial class Stadium
    {
        public int StadiumId { get; set; }
        public long? StadiumCount { get; set; }
        public string StadiumName { get; set; }
        public int? NoOfMatchesAllowed { get; set; }
    }
}
