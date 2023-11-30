using DungeonMaster;

try
{
    var game = new Game();
    await game.Run();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
