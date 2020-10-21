using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class GameSession
    {
        public string Name { get; set; }
        
        public Class1 CurrentPlayer { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Class1
            {
                Name = "Scott",
                CharacterClass = "Fighter",
                HitPoints = 10,
                Gold = 1000000,
                ExperiencePoints = 0,
                Level = 1
            };

            
        }
    }
}
