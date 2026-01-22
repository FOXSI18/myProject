/* 1. Enums
 * 2. Input & TryParse in try-catch
 * 3. New Method "Choice"
 * 4. KI - Robot choice
 * 5. Result
 * 6. Leaderboard
 * */

using System.Text.RegularExpressions;

enum Werkzeuge
{
    None,
    Stein,
    Schere,
    Papier,
}

namespace SchereSteinPapier
{
    
   class Programm
{
    
    static void Main(string[] args)
    {
        int gamesCounter = 0;
        int playerScore = 0, robotScore = 0, drawScore = 0;
        
        while (true)
        {
            Console.WriteLine("Games counter: {0}", gamesCounter);
            Console.WriteLine("[1] - Stein \n[2] - Schere \n[3] - Papier \n[0] - Exit\n\n");
            
            try
            {
                string userChoice = Regex.Replace(Console.ReadLine(), @"\s+", "");
                Werkzeuge werkzeug = Werkzeuge.None;
                
                if (userChoice == "0")
                    break;
            
                if (Enum.TryParse(userChoice, true, out Werkzeuge werkzeuge) && 
                    Enum.IsDefined(typeof(Werkzeuge), werkzeuge) && 
                    werkzeuge != Werkzeuge.None)
                {
                    Console.Clear();
                    Console.WriteLine("---------BATTLE-INFO---------");
                    Console.WriteLine("You: {0}", werkzeuge);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("! << << << ERROR >> >> >> !");
                    Console.WriteLine("Your choice is not defined\n");
                    continue;
                }
                
                Choice(werkzeuge, ref playerScore, ref robotScore, ref drawScore);
            }
            catch (ArgumentNullException)
            {
                Console.Clear();
                Console.WriteLine("! << << << ERROR >> >> >> !");
                Console.WriteLine("You can't pick a nullable\n");
                continue;
            }
            
            gamesCounter++;
        }
        
        
        static void Choice(Werkzeuge werkzeug, ref int playerScore, ref int robotScore, ref int drawScore)
        {
            var currentColor = Console.ForegroundColor; // Farbe von text
            Werkzeuge robotChoice;
            int steinSc = 0, schereSc = 0, papierSc = 0;


            if (werkzeug == Werkzeuge.Stein)
                ++steinSc;
            if (werkzeug == Werkzeuge.Schere)
                ++schereSc;
            if (werkzeug == Werkzeuge.Papier)
                ++papierSc;

            if (Random.Shared.Next(100) < 90) // Zu 90% trifft die KI eine random Wahl, zu 10% gewinnt sie garantiert
                robotChoice = (Werkzeuge)Random.Shared.Next(1, 4);
            else if (schereSc > papierSc ||schereSc > steinSc)
                robotChoice = Werkzeuge.Stein; // stein -> schere
            else if (papierSc > schereSc || papierSc > steinSc)
                robotChoice = Werkzeuge.Schere; // schere -> papier
            else if (steinSc > schereSc || steinSc > papierSc)
                robotChoice = Werkzeuge.Papier; // papier -> stein
            else
                return;

            
            Console.WriteLine("Robot: {0}", robotChoice);
  
            if (werkzeug == robotChoice)
            {
                Console.ForegroundColor = ConsoleColor.Yellow; // yellow
                Console.WriteLine("Draw!");
                Console.ForegroundColor = currentColor;
                drawScore++;
            }
            else if (
                (werkzeug == Werkzeuge.Stein && robotChoice == Werkzeuge.Schere) ||
                (werkzeug == Werkzeuge.Schere && robotChoice == Werkzeuge.Papier) ||
                (werkzeug == Werkzeuge.Papier && robotChoice == Werkzeuge.Stein)
            )
            {
                Console.ForegroundColor = ConsoleColor.Green; // green
                Console.WriteLine("You Won :)");
                Console.ForegroundColor = currentColor;
                playerScore++; 
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red; // red
                Console.WriteLine("You lose :(");
                Console.ForegroundColor = currentColor;
                robotScore++;
            }
            
            
            Console.WriteLine("\n=========LEADERBOARD=========");
            
            if (playerScore > robotScore)
            {
                Console.ForegroundColor = ConsoleColor.Green; // green
                Console.WriteLine("1st: Player {0}", playerScore);
                Console.ForegroundColor = currentColor;

                Console.WriteLine("2nd: Robot {0}", robotScore );
            }
            else if (robotScore > playerScore)
            {
                Console.WriteLine("1st: Robot {0}", robotScore);

                Console.ForegroundColor = ConsoleColor.Red; // red
                Console.WriteLine("2st: Player {0}", playerScore);
                Console.ForegroundColor = currentColor;
                }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow; // yellow
                Console.WriteLine("1st: Player {0}", playerScore);
                Console.ForegroundColor = currentColor;

                Console.WriteLine("1st: Robot {0}", robotScore);
            }

            Console.WriteLine("=============================\n");
        }
        
        Console.WriteLine("App erfolgreich beendet");
    }
}
}
