using System;
using System.Collections.Generic;

namespace EsportsManager.DAL.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public DateTime DOB { get; set; }
        public int CountryId { get; set; }
        public int TeamId { get; set; }
        public string Position { get; set; }
        public int Stamina { get; set; }
        public int Mechanics { get; set; }
        public int Knowledge { get; set; }
        public int Leadership { get; set; }
        public int Teamwork { get; set; }
        public int Fortitude { get; set; }
        public int Discipline { get; set; }
        public int Charisma { get; set; }
        public int Happiness { get; set; }
        public int Fans { get; set; }
        public Team Team { get; set; }

        public ICollection<Language> Languages { get; set; }
        public ICollection<Trait> Traits { get; set; }

    }
}