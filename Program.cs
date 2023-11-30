using System;

class Program
{
    static Random random = new Random();

    public static void Main()
    {
        string[] names = { "Thomas Jefferson", "John Adams", "Horatio Gates", "George Rogers Clark" };
        string randomName = GetRandomName(names);
        Loading();
        Console.WriteLine($"Random Name is: {randomName}.");
    }

    public static string GetRandomName(string[] names)
    {
        string randomName = names[random.Next(names.Length)];
        return randomName;
    }
    public static void Loading()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}