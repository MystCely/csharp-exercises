namespace Oppgave2;

public class Input
{
    public int AskForInt(string question)
    {
        Console.WriteLine(question);
        string input = Console.ReadLine();
        return int.Parse(input);
    }
}