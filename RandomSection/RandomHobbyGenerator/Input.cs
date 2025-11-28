namespace RandomHobbyGenerator;

public class Input
{
    public string AskForName(string question)
    {
        Console.WriteLine(question);
        var input = Console.ReadLine();
        return input;
    }

    public string AskToPlayAgain(string question)
    {
        Console.WriteLine(question);
        var input = Console.ReadLine();
        return input;
    }
}