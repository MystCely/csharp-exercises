namespace Oppgave1;

public class ConsoleApp
{
    public void Run()
    {
        var input = new Input();
        int num1 = input.AskForInt("Give me a number: ");
        int num2 = input.AskForInt("Give me a second number: ");

        if (num1 == num2)
        {
            Console.WriteLine($"The numbers are equal");
        }
        else
        {
            Console.WriteLine("The numbers are NOT equal");
        }
        
        Console.WriteLine($"\nYour Numbers: \nNumber One: {num1}, Number Two: {num2}");
    }
}