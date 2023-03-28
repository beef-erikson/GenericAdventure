﻿// See https://aka.ms/new-console-template for more information

using GenericAdventure.Actions;
using GenericAdventure.Characters;
using GenericAdventure.Map;
using GenericAdventure.Text;

Text.LoadLanguage(new English());

Console.WriteLine(Text.Language.ChooseYourName);

var name = Console.ReadLine();

if (name == string.Empty)
{
    name = Text.Language.DefaultName;
}

var player = new Player(name!);

Console.WriteLine(Text.Language.Welcome, player.Name);

var house = new House(player);
house.CreateRooms(3, 3);
house.DecorateRooms();

Actions.Instance.Register(new Go(house));
house.GoToStartingRoom();

var run = true;

Room lastRoom = null;

while (run)
{
    if (lastRoom != house.CurrentRoom)
    {
        Console.WriteLine(house.CurrentRoom.ToString());
        lastRoom = house.CurrentRoom;
    }
    
    Console.WriteLine(Text.Language.WhatToDo);

    var input = Console.ReadLine().ToLower();

    if (input == Text.Language.Quit)
    {
        run = false;
    }
    else
    {
        Actions.Instance.Execute(input.Split(" "));
    }
}