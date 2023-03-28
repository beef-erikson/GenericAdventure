namespace GenericAdventure.Map;

using GenericAdventure.Characters;

public partial class House
{
    private Player Player { get; }

    private readonly Random _random = new(1234);

    public House(Player player)
    {
        Player = player;
    }
}