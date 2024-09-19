bool inRoulette = false;
bool userExit = false;
bool inDebt = false;
bool inQuestion = false;
bool repeatRoulette = false;
int money = 100;
int bet = 0;
int betSpecific = -1;
int spin;
int spinNum = 0;
int spinMod;
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
        Console.WriteLine("                  1           2         3                 ");
        Console.WriteLine("               -Custom-    -Black-    -Red-               ");
        Console.WriteLine();
        Console.WriteLine();
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
        while (inQuestion = true)
        {
            if (repeatRoulette == true)
            {
                Console.WriteLine("-------------------------Roulette-------------------------");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("             -What would you like to bet on?-             ");
                Console.WriteLine();
                Console.WriteLine("                  1           2         3                 ");
                Console.WriteLine("               -Custom-    -Black-    -Red-               ");
                Console.WriteLine();
                Console.WriteLine();
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
                repeatRoulette = false;
            }
            color = Console.ReadLine();
            if (color == "1") 
            {
                Console.WriteLine("                       Which Number?                       ");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                input = Console.ReadLine();
                betSpecific = Convert.ToInt32(input);
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
            }
            Console.WriteLine("                        How much?");
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
            input = Console.ReadLine();
            if (money >= bet)
            {
            bet = Convert.ToInt32(input);
            money = money - bet;
            } else
            {
                Console.WriteLine("Not enough money!");
            }
            
            
            
            
            Random rand = new Random();
            spin = rand.Next(250, 350);
            spinNum = rand.Next(0, 37);
            for (int i = 0; i < spin; i++) {
                spinMod = spinNum % 2;
                if (spinMod == 0 && spinNum != 0)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                } else if (spinMod == 1 && spinNum != 0)
                {
                    Console.BackgroundColor= ConsoleColor.Black;
                } else if (spinNum == 0)  
                {
                    Console.BackgroundColor= ConsoleColor.Green;
                }
                Console.WriteLine(spinNum);
                Console.BackgroundColor = ConsoleColor.Black;
                spinNum++;
                if (spinNum > 36)
                {
                    spinNum = 0;
                }
            }
            Console.WriteLine();
            spinMod = spinNum % 2;
            if (spinMod == 1 && spinNum != 0)
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            else if (spinMod == 0 && spinNum != 0)
            {
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else if (spinNum == 0)
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }
            Console.WriteLine(spinNum);
            if (spinMod == 0 && color == "2" && spinNum != 0)
            {
                money = money + bet * 2;
                Console.WriteLine("You WON!   +" + bet + " C");
            }
            else if (spinMod == 1 && color == "3" && spinNum != 0)
            {
                money = money + bet * 2;
                Console.WriteLine("You WON!   +" + bet + " C");
            }
            else if (spinNum == betSpecific && color == "0")
            {
                money = money + bet * 10;
                Console.WriteLine("You WON!   +" + bet + " C");
            }
            else 
            { 
            Console.BackgroundColor= ConsoleColor.Black;
            Console.WriteLine("You LOST!");
            }
            Console.WriteLine("Spin again?");
            input = Console.ReadLine();
            if (input == "yes" || input == "y" || input == "Yes" || input == "Y") 
            {
                inQuestion = false;
                repeatRoulette = true;
            } else
            {
                inQuestion = false;
                inRoulette = false;
            }
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
        }
    }
}