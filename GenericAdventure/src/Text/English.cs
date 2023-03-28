namespace GenericAdventure.Text;

public class English : Language
{
    public English()
    {
        ChooseYourName = "Hello, what is your name?";
        DefaultName = "No Name";
        Welcome = "Welcome, {0}, to your generic adventure!";
    }
}