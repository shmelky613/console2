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
            Console.WriteLine("Name: " + " " + _gameSession.CurrentPlayer.Name);
            Console.WriteLine("Character: " + " " + _gameSession.CurrentPlayer.CharacterClass);
            Console.WriteLine("Hit Points: " + " " + _gameSession.CurrentPlayer.HitPoints);
        
            Console.WriteLine("Gold: " + " " + _gameSession.CurrentPlayer.Gold);
            Console.WriteLine("Experience Points: " + " " + _gameSession.CurrentPlayer.ExperiencePoints);
            Console.WriteLine("Level: " + " " + _gameSession.CurrentPlayer.Level);

            Console.WriteLine("");
          

            void DoStuff()
            {
                Console.WriteLine("enter your choice");
                Console.WriteLine("1. hit");
                var bbb = Console.ReadLine();


                if (bbb == "HIT" || bbb == "hit")
                {
                    _gameSession.CurrentPlayer.HitPoints = _gameSession.CurrentPlayer.HitPoints + 10;
                    Console.WriteLine("");

                    Console.WriteLine("Name: " + " " + _gameSession.CurrentPlayer.Name);
                    Console.WriteLine("Character: " + " " + _gameSession.CurrentPlayer.CharacterClass);
                    Console.WriteLine("Hit Points: " + " " + _gameSession.CurrentPlayer.HitPoints);
                    Console.WriteLine(""); Console.WriteLine("");
                    DoStuff();
                }
                else
                {
                    Console.WriteLine("invalid");
                }
            }

            DoStuff();
        }
    }
}
