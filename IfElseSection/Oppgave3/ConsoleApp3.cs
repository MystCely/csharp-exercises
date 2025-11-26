namespace Oppgave3;

public class ConsoleApp3
{
    public void Run()
    {
        var input = new Input3();
        int num1 = input.AskForInt("Give me a number: ");
        int num2 = input.AskForInt("Give me a second number: ");
        int result = num1 + num2;   
        
        If30(num1, num2, result);
        
    }
        private bool If30(int num1, int num2, int result)
        {
            
            if (num1 == 30 || num2 == 30 || result == 30)
            {
                Console.WriteLine("The method returns true");
                return true;
            } 
            
            Console.WriteLine("The method returns false");
            return false;
        }
}