namespace Oppgave3;

public class Input3
{
    public int AskForInt(string question)
    {
        Console.Write(question);
        string input = Console.ReadLine();
        return int.Parse(input);
    }
}