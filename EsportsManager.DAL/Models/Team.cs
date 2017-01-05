using System;
using System.Collections.Generic;

namespace EsportsManager.DAL.Models
{
    public class Team 
    {
        public int TeamId { get; set; }
        public int LeagueID { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public string Logo { get; set; }
        public string Owner { get; set; }
        public League League { get; set; }

        public ICollection<Sponsor> Sponsors { get; set; }
        public ICollection<Player> Players { get; set; }
        public ICollection<Staff> TeamStaff { get; set; }

    }
}
