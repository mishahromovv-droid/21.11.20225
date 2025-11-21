using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Привет! Как тебя зовут?");
        string name = Console.ReadLine();
        Console.WriteLine($"Рад тебя видеть, {name}!");
    }
}