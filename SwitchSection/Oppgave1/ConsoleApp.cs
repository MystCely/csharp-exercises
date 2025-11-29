namespace Oppgave1;

public class ConsoleApp
{
    public void Run()
    {
        Random rand = new Random();
        int randomNum = rand.Next(0, 8);

        switch (randomNum)
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
        }
    }
}