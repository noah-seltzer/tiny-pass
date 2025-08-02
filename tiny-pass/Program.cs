// See https://aka.ms/new-console-template for more information

Console.WriteLine("\"Press + to add a new item, any other key to search available secrets \"");

var key = Console.ReadKey(true);
if (key.KeyChar == '+') {
    Console.WriteLine("Enter secret name + ENTER");
    var name = Console.ReadLine();
    Console.Clear();
    Console.WriteLine($"Enter the secret value + ENTER");
    var value = Console.ReadLine();
    
    
    
    
}
Console.WriteLine($"got: {key.Key}");


