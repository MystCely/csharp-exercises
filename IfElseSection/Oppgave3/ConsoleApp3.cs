namespace Oppgave3;

public class ConsoleApp3
{
    public void Run()
    {
        var input = new Input3();
        bool methodTrue;
        int num1 = input.AskForInt("Give me a number: ");
        int num2 = input.AskForInt("Give me a second number: ");
        
        int result = num1 + num2;

        if (num1 == 30)
        {
            methodTrue = true;
            Console.WriteLine($"The number 1 is 30, so the method returns {methodTrue}");
        }
        else if (num2 == 30)
        {
            methodTrue = true;
            Console.WriteLine($"The number 2 is 30, so the method returns {methodTrue}");
        } else if (result == 30)
        {
            methodTrue = true;
            Console.WriteLine($"The sum of the numbers is 30, so the method returns {methodTrue}");
        }
        else
        {
            methodTrue = false;
            Console.WriteLine($"The method returns {methodTrue} because none of the conditions are met");
        }
    }
}