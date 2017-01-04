namespace EsportsManager.DAL.Models
{
    public class Team 
    {
        public int TeamId { get; set; }

        public int LeagueID { get; set; }
        public League League { get; set; }

    }
}
