bool inRoulette = false;
bool userExit = false;
bool inDebt = false;
int money = 100;
int bet = 0;
string input;

while (userExit == false)
{
    Console.BackgroundColor = ConsoleColor.Black;
    Console.WriteLine("------------------Welcome to the casino!------------------");
    Console.WriteLine("               What would you like to play?               ");
    Console.WriteLine();
    Console.WriteLine("                        -Roulette-                        ");
    Console.WriteLine();
    Console.WriteLine("                      - Placeholder-                      ");
    Console.WriteLine();
    Console.WriteLine("                      - Placeholder-                      ");
    Console.WriteLine();
    Console.WriteLine("                          -Exit-                          ");
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    if (money >= 0)
    {
        Console.BackgroundColor = ConsoleColor.DarkGreen;
    }
    else
    {
        Console.BackgroundColor = ConsoleColor.Red;
    }
    Console.WriteLine("Money: " + money);
    input = Console.ReadLine();
    if (input == "Roulette") 
    {
        
    }
}