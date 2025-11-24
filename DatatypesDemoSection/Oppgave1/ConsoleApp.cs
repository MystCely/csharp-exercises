namespace Oppgave1;

public class ConsoleApp
{
    public void PrintVariables()
    {
        int number = 1; // whole numbers
        long longNumber = 22123321312; // used for long numbers (like when you use userId)
        float floatNumber = 1.05F; // mostly used for when you need to prioritize performance (e.g. game dev)
        decimal decimalNumber = 1.12M; // use when you need to be very specific (e.g. money, finance, prices, etc.)
        double doubleNumber = 1.034; // no need to add D because it's the default -> also most generally used

        string username = "pandalover";
        char letter = 'p';
        bool isPandaCute = true;
        
        Console.WriteLine($"DATATYPES \nInt: {number}, Long: {longNumber}, Float: {floatNumber}, Decimal: {decimalNumber}, Double: {doubleNumber} \nString: {username}, Char: {letter}, Bool: isPandaCute = {isPandaCute}" );
    }
    
}