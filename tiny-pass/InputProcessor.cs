namespace tiny_pass;

// Wraps Console
public class InputProcessor
{
    public void PrintMessage(String? message)
    {
        if (message == null)
        {
            return;
        } 
        Console.WriteLine(message);
        
    }
    public String? GetNextLine(String? message)
    {
        PrintMessage(message);
        return Console.ReadLine();
    }

    public String? GetNextLineSecret(String? message = null)
    {
        PrintMessage(message);
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

    public char GetNextChar(String? message = null, bool intercept = false)
    {
        PrintMessage(message);
        return Console.ReadKey(intercept).KeyChar;
    }

    public void ClearInput()
    {
        Console.Clear();
    }
}