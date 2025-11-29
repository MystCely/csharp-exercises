namespace Oppgave2;

public class ConsoleApp
{
    public void Run()
    {
        string text = "Terje is cool!";
        char[] letters = text.ToCharArray();
        foreach (var letter in letters)
        {
            Console.WriteLine(letter);
        }
    }
}