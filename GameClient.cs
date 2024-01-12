using GameStore.Client.Models;

namespace GameStore.Client;

public static class GameClient
{
    private static readonly List<Game> games = new()
    {
new Game(){
Id = 1,
Name = "The Witcher 3: Wild",
Genre = "Adventure",
Price = 19.99M,
ReleaseDate = new DateTime(1991, 2, 2)
},
new Game(){
Id = 2,
Name = "Street Fighter II",
Genre = "Fighting",
Price = 59.99M,
ReleaseDate = new DateTime(1991, 2, 2)
},
new Game(){
Id = 3,
Name = "FIFA 23",
Genre = "Sports",
Price = 69.99M,
ReleaseDate = new DateTime(1991, 2, 2)
},
};
    public static Game[] GetGames()
    {
        return games.ToArray();
    }
    public static void AddGame(Game game){
        game.Id = games.Max(game  => game.Id) + 1;
        games.Add(game);
    }
}