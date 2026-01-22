/* 1. Enums
 * 2. Input & TryParse
 * 3. New Method "Choice"
 * 3. Random
 * 4. My choice and robot choice
 * 5. Scores system
 * 6. if - if else - else
 * 7. Leaderboard
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
            Console.WriteLine("Hallo");
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
            catch (System.ArgumentNullException)
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
            Random random = new Random();
            Werkzeuge robotChoice = (Werkzeuge)random.Next(1, 4);
            
            Console.WriteLine("Robot: {0}", robotChoice);

            if (werkzeug == robotChoice)
            {
                Console.WriteLine("Draw!");
                drawScore++;
            }
            else if (
                (werkzeug == Werkzeuge.Stein && robotChoice == Werkzeuge.Schere) ||
                (werkzeug == Werkzeuge.Schere && robotChoice == Werkzeuge.Papier) ||
                (werkzeug == Werkzeuge.Papier && robotChoice == Werkzeuge.Stein)
            )
            {
                Console.WriteLine("Won :)");
                playerScore++; 
            }
            else
            {
                Console.WriteLine("Lose :("); 
                robotScore++;
            }
            
            
            Console.WriteLine("\n=========LEADERBOARD=========");
            
            if (playerScore > robotScore)
            {
                Console.WriteLine("1st: Player {0}", playerScore);
                Console.WriteLine("2nd: Robot {0}", robotScore );
            }
            else if (robotScore > playerScore)
            {
                Console.WriteLine("1st: Robot {0}", robotScore);
                Console.WriteLine("2st: Player {0}", playerScore);
            }
            else
            {
                Console.WriteLine("1st: Player {0}", playerScore);
                Console.WriteLine("1st: Robot {0}", robotScore);
            }
            
            Console.WriteLine("=============================\n");
        }
        
        Console.WriteLine("App erfolgreich beendet");
    }
}
}
