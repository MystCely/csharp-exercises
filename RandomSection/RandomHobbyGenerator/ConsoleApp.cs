namespace RandomHobbyGenerator;

public class ConsoleApp
{
    public void Run()
    {
        var input = new Input();

        string name = input.AskForName("\nWho would like a new hobby?");
        GiveRandomHobby(name);

    } 
    
    Random rand = new Random();
    private void GiveRandomHobby(string name)
    {
        var input = new Input();
        var randomNumber = rand.Next(0, 3);

        if (randomNumber == 0)
        {
            Console.WriteLine($"{name}, you like to pet Pandas! \n");
        }
        else if (randomNumber == 1)
        {
            Console.WriteLine($"{name} likes to go to the park. \n");
        }
        else
        {
            Console.WriteLine($"The phone possessed {name}. They're now obsessed with Facebook! \n");
        }

        string playAgain = input.AskToPlayAgain("\nPlay again?");

        switch (playAgain)
        {
         case "Yes":
             Run();
             break;
         case "No":
             break;
         default:
             Console.WriteLine("\nPlease answer with Yes/No");
             playAgain = input.AskToPlayAgain("\nPlay again?");

             if (playAgain == "Yes")
             {
                 Run();
             }
             break;
        }
    }
}