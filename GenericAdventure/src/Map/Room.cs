using System.Text;

namespace GenericAdventure.Map;
using Text;

public class Room
{
    public string Name { get; set; } = Text.Language.DefaultRoomName;
    public string Description { get; set; } = Text.Language.DefaultRoomDescription;

    public Dictionary<Directions, int> Neighbors { get; set; } = new()
    {
        { Directions.North, -1 },
        { Directions.East, -1 },
        { Directions.South, -1 },
        { Directions.West, -1 },
        { Directions.None, -1 }
    };
    
    public bool Visited { get; set; }

    public override string ToString()
    {
        var builder = new StringBuilder();

        if (Visited)
        {
            builder.Append(string.Format(Text.Language.RoomOld, Name));
        }
        else
        {
            builder.Append(string.Format(Text.Language.RoomNew, Name));
        }

        var names = Enum.GetNames(typeof(Directions));
        var directions = (
            from name in names
            where Neighbors[(Directions)Enum.Parse(typeof(Directions), name)] > -1
            select name.ToLower()
            ).ToArray();

        var description = string.Format(Description, Text.Language.JoinedWordList(directions, Text.Language.And));

        builder.Append(description);

        return builder.ToString();
    }
}