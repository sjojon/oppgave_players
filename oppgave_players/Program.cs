using oppgave_players;

var random = new Random();
var players = new[]
{
    new Player("Per", 10),
    new Player("Pål", 10),
    new Player("Espen", 10)
};

for (var round = 1; round <= 10; round++)
{
    var playerIndex1 = random.Next(players.Length);
    var playerIndex2 = (playerIndex1 + 1 + random.Next(2)) % players.Length;
    var player1 = players[playerIndex1];
    var player2 = players[playerIndex2];
    player1.Play(player2);
}

for (int i = 0; i < players.Length; i++)
{
    for (int j = 0; j < players.Length; j++)
    {
        string matchInfo = players[i].GetMatchInfo(players[j]);
        Console.WriteLine(matchInfo);
    }
}

Console.WriteLine();
foreach (var player in players)
{
    Player.ShowNameAndPoints(player);
}