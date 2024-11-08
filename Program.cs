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

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
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
                    break;
            }
        


            }

        Console.WriteLine("Das Spiel wurde beendet");


    }
}

class Program
{
    public static void Main(string[] args)

    {
        FootballGame game = new FootballGame();
        game.StartGame();






    }

}












