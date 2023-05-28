namespace oppgave_players
{
    internal class Player
    {
        public string Name { get; private set; }
        public int Points { get; private set; }

        public Player(string name, int points)
        {
            Name = name;
            Points = points;
        }

        public int Play(Player player)
        {
            var random = new Random();
            var number = random.Next(0, 2);
            if (number == 1)
            {
                player.Points++;
            }
            else
            {
                player.Points--;
            }

            return player.Points;
        }

        public static void ShowNameAndPoints(Player player)
        {
            Console.WriteLine($"Name: {player.Name}\nPoints: {player.Points}");
            Console.WriteLine();
        }
    }
}