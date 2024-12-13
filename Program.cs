using System.ComponentModel.Design;
using System.Security.Cryptography;

namespace FootballGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartGame game = new StartGame();
            game.startGame();
        }

    }
}
class Team
{
    public string Name { get; set; }
    public int score { get; set; }

    public Team(string name)
    {
        Name = name;
        score = 0;
    }

}

class StartGame
{

    private Team playerTeam;
    private Team computerTeam;
    private Random random;

    public StartGame()
    {
        playerTeam = new Team("Dein Team");
        computerTeam = new Team("Computer Team");
        random = new Random();
    }

    public void startGame()
    {
        Console.WriteLine("Wilkommen beim besten Fussballspiel!");
        
       Console.WriteLine("Wähle dein Team aus: ");
        string playerTeamChoice = Console.ReadLine();
        Console.WriteLine($"Du hast {playerTeamChoice} als dein Team gewählt");

        
        Console.WriteLine("Wähle deinen Gegner aus: ");
        string computerTeamChoice = Console.ReadLine();
        Console.WriteLine($"Du hat {computerTeamChoice} als deinen Gegner gewählt");
        
        Console.WriteLine($"Du trittst gegen {computerTeamChoice} an. Wer als erster 3 Tore erzielt, hat das Spiel gewonnen.");
       

        while (playerTeam.score < 3 && computerTeam.score < 3)
        {
            Console.WriteLine("\nWähle eine Aktion:");  
            Console.WriteLine("1. Passen");
            Console.WriteLine("2. Schießen");
            Console.WriteLine("3. Verteidigen");
            Console.Write("Deine Wahl: ");
            
            int playerChoice = int.Parse(Console.ReadLine());
            int computerChoice = random.Next(1, 4);

            switch (playerChoice)
            {
                case 1:
                    Console.WriteLine("Du hast 'Passen' gewählt.");
                    Console.WriteLine("Wohin willst du passen?");
                    Console.WriteLine("Zurück zum Torwart: 1 | Nach aussen zum Flügelspieler: 2 | Nach vorne zum Stürmer: 3");
                    int passDirectionUser = int.Parse(Console.ReadLine());
                    int passCatchDirectionComputer = random.Next(1, 4);                    
                    
                    if (passDirectionUser == passCatchDirectionComputer)
                    {
                        Console.WriteLine("Fehlpass! Dein Pass wurde agbefangen");
                    }
                    else
                    {
                        Console.WriteLine("Was ein Ball!");
                    }
                        break;




                case 2:
                    Console.WriteLine("Du hast 'Schießen' gewählt.");
                    Console.WriteLine("In welche richtung willst du scheissen?");
                    Console.WriteLine("Links: 1 | Rechts: 2 | Mitte: 3");
                    int shootDirectionUser = int.Parse(Console.ReadLine());
                    int defendDirectionComputer = random.Next(1, 4);

                    if (shootDirectionUser == defendDirectionComputer)

                    {
                        Console.WriteLine("Dein Schuss wurde verteidigt");

                    }
                    else
                    {
                        Console.WriteLine("Du hast ein Tor erzielt");
                        playerTeam.score++;
                    }
                    break;

                case 3:
                    Console.WriteLine("Du hast 'Verteidigen' gewählt.");
                    Console.WriteLine("In welche richtung wllst du verteidigen");
                    Console.WriteLine("Links: 1 | Rechts: 2 | Mitte: 3");
                    int defendDirectionUser = int.Parse(Console.ReadLine());                    
                    int shootDirectionComputer = random.Next(1, 4);

                    if (defendDirectionUser == shootDirectionComputer)
                    {

                        Console.WriteLine("Du hast den Schuss verteidigt!");
                        
                    }

                    else
                    {
                        Console.WriteLine($"Falsche richtung! {computerTeamChoice} hat ein Tor erzielt");
                        computerTeam.score++;

                    }

                    break;

                default:
                    Console.WriteLine("Ungültige Wahl. Bitte wähle 1, 2 oder 3.");
                    continue;
            }
                        
            
                 
            
            Console.WriteLine($"Aktueller Punktestand: {playerTeam.Name}: {playerTeam.score} | {computerTeam.Name}: {computerTeam.score}");

        }


    }

    

}
        
        
        
        





























