using System.Collections.Generic;

namespace EsportsManager.DAL.Models
{
    public class League
    {
        public int LeagueId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }
        public string EventType { get; set; }
        public string Location { get; set; }
        public ICollection<Team> Teams { get; set; }
    }
}
