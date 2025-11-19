namespace DatatypesVariable;

public class Input
{
    public static int AskForInteger(string question)
    {
        Console.Write(question + " ");
        string input = Console.ReadLine();
        return int.Parse(input);
    }
}