namespace Oppgave1;

public class Input
{
    public int AskForInt(string question)
    {
        Console.Write(question);
        string input = Console.ReadLine();
        return int.Parse(input);
    }
}