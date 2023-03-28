namespace GenericAdventure.Text;

public class English : Language
{
    public English()
    {
        ChooseYourName = "Hello, what is your name?";
        DefaultName = "No Name";
        Welcome = "Welcome, {0}, to your generic adventure!";
        DefaultRoomName = "Room {0} {1},{2}";
        DefaultRoomDescription = "You are in a room with doors to the {0}.";
        ActionError = "You can't do that.";
    }
}