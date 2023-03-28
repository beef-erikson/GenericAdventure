using System.Text;
using GenericAdventure.Items;

namespace GenericAdventure.Map;
using Text;
using Items;

public class Room : IInventory
{
    public string Name { get; set; } = Text.Language.DefaultRoomName;
    public string Description { get; set; } = Text.Language.DefaultRoomDescription;
    private readonly IInventory _inventory = new Inventory();
    public string[] InventoryList => _inventory.InventoryList;

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

        if (_inventory.Total > 0)
        {
            var items = _inventory.InventoryList;
            var pluralPre = items.Length > 1 ? Text.Language.Are : Text.Language.Is;
            var pluralPost = items.Length > 1 ? Text.Language.Plural : "";

            builder.Append(string.Format(Text.Language.TotalItems, pluralPre, items.Length, pluralPost));
            builder.Append(Text.Language.JoinedWordList(items, Text.Language.And) + Text.Language.Period);
        }
        
        return builder.ToString();
    }
    
    public int Total => _inventory.Total;

    public void Add(Item item)
    {
        _inventory.Add(item);
    }

    public bool Contains(string itemName)
    {
        return _inventory.Contains(itemName);
    }
    
    public Item? Find(string itemName)
    {
        return _inventory.Find(itemName);
    }

    public Item? Find(string itemName, bool remove)
    {
        return _inventory.Find(itemName, remove);
    }
    
    public void Remove(Item item)
    {
        _inventory.Remove(item);
    }

    public Item? Take(string itemName)
    {
        return _inventory.Take(itemName);
    }

    public void Use(string itemName, string source)
    {
        _inventory.Use(itemName, source);
    }
}