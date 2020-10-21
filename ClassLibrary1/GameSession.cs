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
            CurrentPlayer = new Class1();
            CurrentPlayer.Name = "Scott";
            CurrentPlayer.CharacterClass = "Fighter";
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.Gold = 1000000;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;

            Name = "JJ";
        }
    }
}
