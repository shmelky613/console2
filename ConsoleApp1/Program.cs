using System;
using ClassLibrary1;


namespace ConsoleApp1
{
    class Program 
    {
        private GameSession _gameSession;

        static void Main(string[] args)
        {
            

           var _gameSession = new GameSession();

            // DataContext = _gameSession;

            Console.WriteLine(_gameSession.CurrentPlayer.Name);
            Console.WriteLine(_gameSession.CurrentPlayer.CharacterClass);
            Console.WriteLine(_gameSession.CurrentPlayer.HitPoints);
            Console.WriteLine(_gameSession.CurrentPlayer.Gold);
            Console.WriteLine(_gameSession.CurrentPlayer.ExperiencePoints);
            Console.WriteLine(_gameSession.CurrentPlayer.Level);
        }
    }
}
