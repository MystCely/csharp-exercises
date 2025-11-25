namespace Oppgave2;

public class ConsoleApp2
{
    public void Run()
    {
        var input = new Input2();
        int num1 = input.AskForInt("Give me a number: ");
        int num2 = input.AskForInt("Give me a second number: ");

        if (num1 == num2)
        {
            var multiplyNum = num1 * num2;
            Console.WriteLine($"The numbers are equal");
            Console.WriteLine($"{num1} multiplied by {num2} is {multiplyNum}");
        }
        else
        {
            var addedNum = num1 + num2;
            Console.WriteLine("The numbers are NOT equal");
            Console.WriteLine($"{num1} added to {num2} is {addedNum}");
        }
    }
}