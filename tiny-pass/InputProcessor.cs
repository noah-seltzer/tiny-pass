namespace tiny_pass;

public class InputProcessor
{
    void printMessage(String? message)
    {
        if (message == null)
        {
            return;
        } 
        Console.WriteLine(message);
        
    }
    public String getNextLine(String? message)
    {
        printMessage(message);
        return Console.ReadLine();
    }

    public String getNextLineSecret(String? message)
    {
        printMessage(message);
        string secret = null;
        while (true)
        {
            var key = System.Console.ReadKey(true);
            if (key.Key == ConsoleKey.Enter)
                break;
            secret += key.KeyChar;
        }
        return secret;
    }

    public char getNextChar(String? message, bool? intercept)
    {
        printMessage(message);
        return Console.ReadKey(intercept ??= false).KeyChar;
    }

    public void clearInput()
    {
        Console.Clear();
    }
    
    
}