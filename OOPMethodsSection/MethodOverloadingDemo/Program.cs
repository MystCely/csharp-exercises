namespace MethodOverloadingDemo;

class Program
{
    static void Main(string[] args)
    {
        var welcome = new Welcome("Hei og velkommen! ");
        
        welcome.PrintWelcomeMsg();
        welcome.PrintWelcomeMsg("Du er flink!");
    }
}