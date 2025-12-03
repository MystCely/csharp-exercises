namespace MethodOverloadingDemo;

internal class Welcome
{

    public string Message;

    public Welcome(string message)
    {
        Message = message;
    }
    
    public void PrintWelcomeMsg(string compliment = "Du er snill!")
    {
        Console.WriteLine(Message + compliment);
    }
    
}