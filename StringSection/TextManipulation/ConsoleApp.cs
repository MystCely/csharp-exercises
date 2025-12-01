namespace TextManipulation;

public class ConsoleApp
{
    public void Run()
    {
        var input = new Input();

        Console.WriteLine("Welcome to Text Manipulation!\nPlease choose between the two options:\n");
        
        string option = input.AskForInput("Option 1: Rotate Text\nOption 2: Change Word.");
        
        if (option != "1" && option != "2")
        {
            Console.WriteLine("\nYou didn't choose any of the valid options. Please choose 1 or 2 to continue.\nRestart the program to try again.");
            return;
        }
        
        string word = input.AskForInput("\nPlease choose the word:");

        if (option == "1")
        {
            var changedWord = RotateText(word);
            Console.WriteLine(changedWord);
        }
        else if (option == "2")
        {
            
            var changeWord = ChangeWord(word);
            Console.WriteLine($"\n{changeWord}");
            
        }
        
    }
    

    private string RotateText(string word)
    {
        char[] charArray = word.ToCharArray();
        Array.Reverse(charArray);
        
        string reversedString = new string(charArray);
        return reversedString;
    }

    private string ChangeWord(string word)
    {
        if (!word.Contains("E") && !word.Contains("e"))
        {
            Console.WriteLine("\nPlease choose a word with the letter E.");
            return word;
        } 
        
        word = word.Replace("E", "A"); 
        word = word.Replace("e", "a");

        return word;
    }

}