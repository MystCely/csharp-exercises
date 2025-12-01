namespace Oppgave1;

public class ConsoleApp
{
    public void Run()
    {
        string text = "Terje is cool!";
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Number: {i}, Text: {text}");
        }
    }
}