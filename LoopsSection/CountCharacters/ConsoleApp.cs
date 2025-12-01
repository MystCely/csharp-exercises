namespace CountCharacters;

public class ConsoleApp
{
    public void Run()
    {
        var range = 250;
        var counts = new int[range];
        string text = "something";
        while (!string.IsNullOrWhiteSpace(text))
        {
            text = Console.ReadLine();
            
            string lowerCaseText = text.ToLower();
            
            foreach (var character in lowerCaseText ?? string.Empty)
            {
                counts[(int)character]++;
            }

            int totalCount = counts.Sum();
            
            
            for (var i = 0; i < range; i++)
            {
                if (counts[i] > 0)
                {
                    var character = (char)i;
                    double percentage = (double)counts[i] / totalCount * 100; 
                    Console.WriteLine($"{character} - {percentage, 5:F2}%");
                }
            }
        }
    }
}