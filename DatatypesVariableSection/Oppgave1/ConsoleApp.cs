namespace Oppgave1;

public class ConsoleApp
{
    public static void Run()
    {
        int number1 = Input.AskForInteger("Pick a number:");
        int number2 = Input.AskForInteger("Pick a second number:");
        
        Console.WriteLine($"{number1} + {number2} = {number1 + number2}");

    }
}