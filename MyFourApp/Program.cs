namespace MyFourApp;

public static class App
{
    private static void PrintAndWait(string msg, int time)
    {
        Console.WriteLine(msg);
        Task.Delay(time).Wait();
        Console.Clear();
    }

    private static void LoadingTexts()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        PrintAndWait("Loading", 1000);
        PrintAndWait("Loading.", 1000);
        PrintAndWait("Loading..", 1000);
        PrintAndWait("Loading...", 1000);
        Console.ResetColor();
    }

    private static void GiveMeARandomNumber(int min, int max)
    {
        while (true)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("GiveMeARandomNumber\n");
            Console.ResetColor();
            var randomNumber = new Random().Next(min, max);
            Console.WriteLine($"The you random number is {randomNumber}\n take all key to new main menu");
            Console.ReadKey();
            MainMenu();
        }
    }

    private static void Calculator()
    {
        while (true)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Calculator\n");
            Console.ResetColor();
            Console.Write("Calculate: ");
            var input = Console.ReadLine();

            if (input != null)
            {
                if (input.ToLower() == "exit")
                {
                    MainMenu();
                }
                else
                {
                    string[] parts = input.Split(" ").ToArray();
                    int value1 = int.Parse(parts[0]);
                    int value2 = int.Parse(parts[2]);
                    int result = 0;
                    switch (parts[1])
                    {
                        case "+": result = value1 + value2; break;
                        case "-": result = value1 - value2; break;
                        case "*": result = value1 * value2; break;
                        case "/": result = value1 / value2; break;
                    }

                    Console.WriteLine($"The result is {result}\n take all key to new calculate!");
                    Console.ReadKey();
                }
            }
        }
    }

    private static void MainMenu()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("MainMenu\n");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Welcome to my study console project :)");
        Console.ResetColor();
        Console.WriteLine("\nPlease select a tool to use\n [1] This number it's par?\n [2] Give me a random number\n [3] Calculator");
        Console.Write("\nR: ");
        var input = Console.ReadLine();
        switch (input)
        {
            case "1": ThisNumberIsPar(); break;
            case "2": GiveMeARandomNumber(0, 100); break;
            case "3": Calculator(); break;
        }
    }

    private static void InitMenu()
    {
        LoadingTexts();
        MainMenu();
    }

    private static void ThisNumberIsPar()
    {
        while (true)
        {
            
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("ThisNumberIsPar?\n");
            Console.ResetColor();
            Console.Write("Insert number: ");
            var input = Console.ReadLine();
            if (input == "exit")
            {
                MainMenu();
            }
            if (input != "exit")
            {
                if (input != null && int.Parse(input) % 2 == 0)
                {
                    Console.WriteLine($"the number {input} it's par");
                }
                else
                {
                    Console.WriteLine($"the number {input} it's impar");
                }

                Task.Delay(1000).Wait();
                Console.Clear();
            }
            else
            {
                Main();
            }
        }
    }
    
    private static void Main()
    {
        MainMenu();
    }
}