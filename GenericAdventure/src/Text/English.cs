namespace GenericAdventure.Text;

public class English : Language
{
    public English()
    {
        ChooseYourName = "Hello, what is your name?";
        DefaultName = "No Name";
        Welcome = "Welcome, {0}, to your generic adventure!";
        DefaultRoomName = "Room {0} ({1},{2})";
        DefaultRoomDescription = " You are in a {0} room with doors to the {1}.";
        ActionError = "You can't do that.";
        Go = "Go";
        GoError = "You can't go that way.";
        WhatToDo = "What do you want to do?";
        Quit = "quit";
        RoomNew = "You entered {0}.";
        RoomOld = "You return to {0}.";
        And = "and";
        Comma = ",";
        Space = " ";
        RoomDescriptions = new List<string>
        {
            "normal",
            "cold",
            "warm",
            "dark",
            "bright",
            "scary",
            "strange"
        };
        NoItem = "The item {0} doesn't appear to exist.";
        Backpack = "Backpack";
        BackpackError = "Your backpack seems to be empty.";
        BackpackDescription = "Your backpack contains: {0}";
        Chest = "chest";
        UnlockChest = "You use the key to unlock the chest.";
        Key = "key";
        ChestEmpty = "You peer inside the chest but find nothing inside.";
        ChestFound = "You look inside and find: {0}";
        Gold = "{0} gold {1}";
        Coin = "coin";
        Coins = Coin + "s";
        Plural = "s";
        Is = "is";
        Are = "are";
        TotalItems = "\nThere {0} {1} item{2} in the room: ";
        Period = ".";
        Take = "Take";
        TakeError = "There is nothing here to take.";
        NotTaken = "You can't take that.";
        TookDescription = "You took a {0}.";
        CantTakeDescription = "You can't take the {0}";
    }
}