namespace Oppgave2;

public class Input2
{
    public int AskForInt(string question)
    {
        Console.Write(question);
        string input = Console.ReadLine();
        return int.Parse(input);
    }
}