namespace FootballGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
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

class startGame
{

    private Team playerTeam;
    private Team computerTeam;
    private Random random;

    public startGame()
    {
        playerTeam = new Team("Dein Team");
        computerTeam = new Team("Computer Team");
        random = new Random();
    }

    public void StartGame()
    {
        Console.WriteLine("Wilkommen beim besten Fussballspiel!");
        Console.WriteLine("Du trittst gegen das Computer-Team an. Wer als erster 3 Tore erzielt, hat das Spiel gewonnen.");

        while (playerTeam.score < 3 && computerTeam.score < 3)

        {
            Console.WriteLine("\nWähle eine Aktion:");
            Console.WriteLine("1. Passen");
            Console.WriteLine("2. Schießen");
            Console.WriteLine("3. Verteidigen");
            Console.Write("Deine Wahl: ");

            int playerchoice = int.Parse(Console.ReadLine());
            int computerChoise = random.Next(1, 4);

            switch (playerchoice)
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
                    Console.WriteLine("Das Computer-Team hat 'Passen' gewählt.");
                    break;
                case 2:
                    Console.WriteLine("Das Computer-Team hat 'Schießen' gewählt.");
                    break;
                case 3:
                    Console.WriteLine("Das Computer-Team hat 'Verteidigen' gewählt.");
                    break;
            }
        }

        Console.WriteLine("Das Spiel ist beendet.");
    }
}



























