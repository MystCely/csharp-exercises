namespace RandomHobbyGenerator;

public class ConsoleApp
{
    public void Run()
    {
        var input = new Input();

        string name = input.AskForName("Who would like a new hobby?");

        GiveRandomHobby(name);

    }
        private void GiveRandomHobby(string name)
        {
            Random rand = new Random();
            var randomNumber = rand.Next(0, 3);

            if (randomNumber == 0)
            {
                Console.WriteLine($"{name}, you like to pet Pandas!");
            }
            else if (randomNumber == 1)
            {
                Console.WriteLine($"{name} likes to go to the park.");
            }
            else
            {
                Console.WriteLine($"The phone possessed {name}. They're now obsessed with Facebook!");
            }
        }
}