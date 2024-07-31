using System.Collections;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var dic = Environment.GetEnvironmentVariables();

foreach (DictionaryEntry entry in dic)
{
    Console.WriteLine($"{entry.Key}: {entry.Value}");
}