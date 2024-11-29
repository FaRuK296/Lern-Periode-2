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
                    break;
                case 2:
                    Console.WriteLine("Du hast 'Schießen' gewählt.");
                    break;
                case 3:
                    Console.WriteLine("Du hast 'Verteidigen' gewählt.");
                    break;
                default:
                    Console.WriteLine("Ungültige Wahl. Bitte wähle 1, 2 oder 3.");
                    continue;
            }
            


            switch (computerChoice)
            {
                case 1:
                    Console.WriteLine($"{computerTeamChoice} hat 'Passen' gewählt.");
                    break;
                case 2:
                    Console.WriteLine($"{computerTeamChoice} hat 'Schießen' gewählt.");
                    break;
                case 3:
                    Console.WriteLine($"{computerTeamChoice} hat 'Verteidigen' gewählt.");
                    break;
            }
            // Spielregeln anwenden
            if (playerChoice == 2 && computerChoice == 1)
            {
                Console.WriteLine("Du hast ein Tor erzielt!");
                Console.WriteLine("--------------------------------------------------------");
                playerTeam.score++;
            }

            else if (computerChoice == 2 && playerChoice == 1)

            {
                Console.WriteLine($"{computerTeamChoice} hat ein Tor erzielt!");
                Console.WriteLine("--------------------------------------------------------");
                computerTeam.score++;
            }

            else if (playerChoice == 2 && computerChoice == 3)
            {

                Console.WriteLine("Was für eine Grätsche! Dein Schuss wurde verteidigt");
                Console.WriteLine("--------------------------------------------------------");
            }

            else if (computerChoice == 2 && playerChoice == 3)

            {                
                Console.WriteLine("Was für eine Grätsche! Du hast den Schuss verteidigt");
                Console.WriteLine("--------------------------------------------------------");

            }

            else
            {
                Console.WriteLine("Keine Tore in dieser Runde");
                Console.WriteLine("--------------------------------------------------------");
            }

            Console.WriteLine($"Aktueller Punktestand: {playerTeam.Name}: {playerTeam.score} | {computerTeam.Name}: {computerTeam.score}");

        }


    }

    

}
        
        
        
        





























