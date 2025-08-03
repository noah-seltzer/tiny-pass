// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using tiny_pass;


var inputProcessor = new InputProcessor();
var key = inputProcessor.getNextChar("\"Press + to add a new item, any other key to search available secrets \"", true);
if (key == '+') {
    var name = inputProcessor.getNextLine("Enter secret name + ENTER");
    inputProcessor.clearInput();
    var secret = inputProcessor.getNextLineSecret("Enter secret value + ENTER");
    Console.WriteLine($"{name}{secret}");
}
else
{
    inputProcessor.clearInput();
    String[] secrets = ["secretA", "secretB"];
    
    

}
// Console.WriteLine($"got: {key}");


