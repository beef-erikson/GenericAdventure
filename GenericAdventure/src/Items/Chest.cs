using System.Net.Mime;

namespace GenericAdventure.Items;
using Map;
using Text;

public class Chest : Item, IInventory
{
    private readonly House _house;
    private readonly Inventory _inventory = new();
    public override string Name => Text.Language.Chest;
    public bool locked = true;
    public int Total => _inventory.Total;

    public Chest(Item?[] items, House house)
    {
        CanTake = false;
        _house = house;

        foreach (var item in items)
        {
            Add(item);
        }
    }

    public override void Use(string source)
    {
        if (source == Text.Language.Key)
        {
            var items = InventoryList;

            if (locked)
            {
                Console.WriteLine(Text.Language.UnlockChest);
            }

            if (items.Length == 0)
            {
                Console.WriteLine(Text.Language.ChestEmpty);
            }
            else
            {
                Console.WriteLine(string.Format(Text.Language.ChestFound, Text.Language.JoinedWordList(items,
                    Text.Language.And)));

                foreach (var itemName in items)
                {
                    var item = Take(itemName);
                    _house.Player.Add(item);
                }
            }
        }
    }

    public void Add(Item item)
    {
        _inventory.Add(item);
    }

    public bool Contains(string itemName)
    {
        return _inventory.Contains(itemName);
    }

    public string[] InventoryList => _inventory.InventoryList;

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