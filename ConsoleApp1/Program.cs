using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibrary1;


namespace ConsoleApp1
{
   public class Program 
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
                Console.WriteLine("1. Hit   2. Exit");
                Console.WriteLine("");

                var bbb = Console.ReadLine();


                void e()
                {
                    if (bbb == "2")
                    {
                        Console.WriteLine("are you sure you want to exit ? '1: Yes   2: No' ");
                        var ccc = Console.ReadLine();
                        if (ccc == "1")
                        {
                            Console.WriteLine("exiting");
                            for (var i = 0; i < 20000; i++)
                            {
                                Console.Write("😢");
                            }
                            Environment.Exit(0);
                        }
                        else if (ccc == "2")
                        {
                            DoStuff();
                        }
                        else
                        {
                            e();
                        }
                    }

                }
                e();


                //hit
                if (bbb == "1")
                {
                    _gameSession.CurrentPlayer.HitPoints = _gameSession.CurrentPlayer.HitPoints + 10;
                    Console.WriteLine("");

                    Console.WriteLine("Name: " + " " + _gameSession.CurrentPlayer.Name);
                    Console.WriteLine("Character: " + " " + _gameSession.CurrentPlayer.CharacterClass);
                    Console.WriteLine("Hit Points: " + " " + _gameSession.CurrentPlayer.HitPoints);
                    Console.WriteLine("Gold: " + " " + _gameSession.CurrentPlayer.Gold);
                    Console.WriteLine("Experience Points: " + " " + _gameSession.CurrentPlayer.ExperiencePoints);
                    Console.WriteLine("Level: " + " " + _gameSession.CurrentPlayer.Level);

                    Console.WriteLine(""); Console.WriteLine("");
                    DoStuff();
                }

                else
                {
                    Console.WriteLine("invalid");
                    DoStuff();
                }

               
             
            }
                
                DoStuff();
        }
    }
}
