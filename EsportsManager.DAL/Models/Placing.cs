namespace EsportsManager.DAL.Models
{
public class Placing
{
    public int PlacingId { get; set; }
    public int LeagueId { get; set; }
    public string Split { get; set; }
    public double Prize { get; set; }
    public int CP { get; set; } // Challenger Points
    public League League { get; set; }
}    
}
