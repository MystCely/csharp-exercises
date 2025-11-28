namespace Oppgave2;

public class ConsoleApp
{
    public void Run()
    {
        var input = new Input();

        var inputNum = input.AskForInt("Choose a number between 1-7 to show which day.");
        
        switch (inputNum)
        {
            case 1:
                Console.WriteLine("1 is Monday");
                break;
            case 2:
                Console.WriteLine("2 is Tuesday");
                break;
            case 3:
                Console.WriteLine("3 is Wednesday");
                break;
            case 4:
                Console.WriteLine("4 is Thursday");
                break;
            case 5:
                Console.WriteLine("5 is Friday");
                break;
            case 6:
                Console.WriteLine("6 is Saturday");
                break;
            case 7:
                Console.WriteLine("7 is Sunday");
                break;
            default:
                Run();
                break;
        }
    }
}