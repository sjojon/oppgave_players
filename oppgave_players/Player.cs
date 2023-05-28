using System.Xml.Linq;

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

        public string GetMatchInfo(Player opponent)
        {
            //string result = $"{Name} Vs. {opponent.Name}: {Points} -  {opponent.Points}";
            //return result;

            int scoreDifference = Points - opponent.Points;
            string result = $"{Name} vs. {opponent.Name}: Score difference: {scoreDifference}";
            return result;
        }
    }
}