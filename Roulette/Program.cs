bool inRoulette = false;
bool userExit = false;
bool inDebt = false;
bool inQuestion = false;
int money = 100;
int bet = 0;
int betSpecific;
int spin;
int spinNum = 0;
string color;
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
    Console.BackgroundColor = ConsoleColor.Black;
    inQuestion = true;
    while (inQuestion == true)
    {
        input = Console.ReadLine();
        if (input == "Roulette" || input == "roulette")
        {
            inRoulette = true;
            inQuestion = false;
        }
        else if (input == "Exit" || input == "exit")
        {
            userExit = true;
            inQuestion = false;
            Console.WriteLine("Goodbye!");
        }
        else
        {
            Console.WriteLine("Something went wrong, please try again");
        }
    }
    Console.BackgroundColor = ConsoleColor.Black;
    if (inRoulette == true)
    {
        Console.WriteLine("-------------------------Roulette-------------------------");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("             -What would you like to bet on?-             ");
        Console.WriteLine();
        Console.WriteLine("               -Custom-    -Black-    -Red-               ");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        while (inQuestion = true)
        {
            color = Console.ReadLine();
            if (color == "Custom" || color == "custom")
            {
                Console.WriteLine("                       Which Number?                       ");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                input = Console.ReadLine();
                betSpecific = Convert.ToInt32(input);
            }
            Console.WriteLine("                        How much?");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            input = Console.ReadLine();
            bet = Convert.ToInt32(input);
            
            
            Random rand = new Random();
            spin = rand.Next(250, 350);

            for (int i = 0; i < spin; i++) {
                if (spinNum )
                Console.WriteLine(spinNum);
            
            }
        }
    }
}