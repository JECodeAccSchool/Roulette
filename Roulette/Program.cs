using System.ComponentModel.Design;
using System.Numerics;
using System.Reflection;
using System.Runtime.InteropServices;

bool inRoulette = false;
bool userExit = false;
bool inDebt = false;
bool inQuestion = false;
bool repeatRoulette = false;
bool isString = false;
bool inLoop = false;
bool extraQuestion = false;
bool inCoin = false;
int money = 0;
int bet = 0;
int betSpecific = -1;
int spin;
int spinNum = 0;
int spinMod;
int uniVal = 0;
int accs = 3;
int moneyHigh = money;
int rouletteTimes = 0;
int coinTimes = 0;
int iHigh = 0;
string color = "ignore";
string input = "ignore";


while (userExit == false)
{
    if (inDebt = true && accs <= 0)
    {
        userExit = true;
    }
    if (repeatRoulette == false && !(inDebt = true && accs <= 0))
    {
        if (money <= 0)
        {
            inDebt = true;
        }
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine("------------------Welcome to the casino!------------------");
        Console.WriteLine("               What would you like to play?               ");
        Console.WriteLine();
        Console.WriteLine("                       - Roulette -                       ");
        Console.WriteLine();
        Console.WriteLine("                         _ Coin _                         ");
        Console.WriteLine("                           flip                           ");
        Console.WriteLine();
        Console.WriteLine("                         _ Dice _                         ");
        Console.WriteLine("                           roll                           ");
        Console.WriteLine();
        Console.WriteLine("                         - Exit -                         ");
        Console.WriteLine();
        if (inDebt == true)
        {
            Console.WriteLine("[Loan] Loan 100$? -1 Account");
        }
        Console.WriteLine();
        Console.WriteLine("Accounts: " + accs);
        Console.WriteLine();
        if (money > 0)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Red;
            inDebt = true;
        }
        Console.WriteLine("Money: " + money);
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine("");


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
            else if ((input == "Loan" || input == "loan") && inDebt == true)
            {
                accs = accs - 1;
                money = money + 100;
                inQuestion = false;
                inDebt = false;
            }
            else if (input == "coin flip" || input == "Coin flip" || input == "coin Flip" || input == "Coin Flip")
            {
                inCoin = true;
                inQuestion = false;
            }
            else
            {
                Console.WriteLine("Something went wrong, please try again");
            }
        }
    }
    Console.BackgroundColor = ConsoleColor.Black;
    if (inRoulette == true || repeatRoulette == true)
    {
        Console.WriteLine("-------------------------Roulette-------------------------");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("             -What would you like to bet on?-             ");
        Console.WriteLine();
        Console.WriteLine("                  1          2         3                  ");
        Console.WriteLine("               -Custom-    -Red-    -Black-               ");
        Console.WriteLine("                 X30        X2        X2");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("[Exit]");
        Console.WriteLine();
        inQuestion = true;
        while (inQuestion == true)
        {
            color = Console.ReadLine();
            if (color == "1")
            {
                Console.WriteLine("                       Which Number?                       ");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("[Exit]");

                extraQuestion = true;
                while (extraQuestion == true)
                {
                    input = Console.ReadLine();
                    inLoop = true;
                    extraQuestion = true;
                    isString = false;


                    while (inLoop == true)
                    {
                        while (isString == false && inLoop == true)
                        {
                            for (int i = 0; i < input.Length; i++)
                            {

                                uniVal = (int)input[i];
                                if (uniVal > 57 || uniVal < 48)
                                {

                                    isString = true;
                                    i = input.Length;
                                }
                                inLoop = false;
                            }
                        }
                        inLoop = false;
                    }

                    if (isString == false)
                    {
                        betSpecific = Convert.ToInt32(input);
                        if (betSpecific >= 0 && betSpecific <= 36)
                        {
                            inQuestion = false;
                            extraQuestion = false;
                        }
                        else
                        {
                            Console.WriteLine("Something went wrong, please try again");
                        }
                    }
                    else if (input == "Exit" || input == "exit")
                    {
                        inQuestion = false;
                        extraQuestion = false;
                        inRoulette = false;
                        repeatRoulette = false;
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong, please try again");
                    }
                }
            }
            else if (color == "2" || color == "3")
            {
                inQuestion = false;
            }
            else if (color == "Exit" || color == "exit")
            {
                inRoulette = false;
                repeatRoulette = false;
                inQuestion = false;
            }
            else
            {
                Console.WriteLine("Something went wrong, please try again");
            }

        }
        if (inRoulette == true || repeatRoulette == true)
        {
            Console.WriteLine("                        How much?");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("[Exit]");
            Console.WriteLine();
            if (money > 0)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            Console.WriteLine("Money: " + money);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();

            inQuestion = true;
            while (inQuestion == true)
            {

                input = Console.ReadLine();
                inLoop = true;
                extraQuestion = true;
                isString = false;
                while (extraQuestion == true)
                {
                    while (inLoop == true)
                    {
                        while (isString == false && inLoop == true)
                        {
                            for (int i = 0; i < input.Length; i++)
                            {

                                uniVal = (int)input[i];
                                if (uniVal > 57 || uniVal < 48)
                                {

                                    isString = true;
                                    i = input.Length;
                                }
                                inLoop = false;
                            }
                        }
                        inLoop = false;
                    }

                    if (isString == false)
                    {

                        bet = Convert.ToInt32(input);
                        if (money >= bet)
                        {
                            money = money - bet;
                            inQuestion = false;
                            extraQuestion = false;
                        }
                        else if (money < bet)
                        {
                            Console.WriteLine("Not enough money!");
                            bet = 0;
                            extraQuestion = false;
                        }
                    }
                    else if (input == "Exit" || input == "exit")
                    {
                        inQuestion = false;
                        extraQuestion = false;
                        inRoulette = false;
                        repeatRoulette = false;
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong, please try again");
                        extraQuestion = false;
                    }
                }
            }


            if (inRoulette == true || repeatRoulette)
            {
                Random rand = new Random();
                spin = rand.Next(250, 350);
                spinNum = rand.Next(0, 37);
                for (int i = 0; i < spin; i++)
                {
                    spinMod = spinNum % 2;
                    if (spinMod == 0 && spinNum != 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                    else if (spinMod == 1 && spinNum != 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else if (spinNum == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                    }
                    Console.WriteLine(spinNum);
                    Console.BackgroundColor = ConsoleColor.Black;
                    spinNum++;
                    if (spinNum > 36)
                    {
                        spinNum = 0;
                    }
                    await Task.Delay(3);
                    if (i > 200)
                    {
                        await Task.Delay(i - 200);
                    }
                    Console.WriteLine();
                }
                spinMod = spinNum % 2;
                if (spinMod == 0 && spinNum != 0)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                else if (spinMod == 1 && spinNum != 0)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                }
                Console.WriteLine(spinNum);
                Console.BackgroundColor = ConsoleColor.Black;

                if (spinMod == 0 && color == "2" && spinNum != 0)
                {
                    money = money + bet * 2;
                    Console.WriteLine("You WON!   +" + bet + " $");
                }
                else if (spinMod == 1 && color == "3" && spinNum != 0)
                {
                    money = money + bet * 2;
                    Console.WriteLine("You WON!   +" + bet + " $");
                }
                else if (spinNum == betSpecific && color == "0")
                {
                    money = money + bet * 10;
                    Console.WriteLine("You WON!   +" + bet + " $");
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("You LOST!");
                }
                if (money > 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    inDebt = true;
                }
                Console.WriteLine("Money: " + money);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine();
                Console.WriteLine("Spin again?");
                inQuestion = true;
                if (money >= moneyHigh)
                {
                    moneyHigh = money;
                }
                rouletteTimes = rouletteTimes + 1;
                while (inQuestion == true)
                {
                    input = Console.ReadLine();
                    if (input == "yes" || input == "y" || input == "Yes" || input == "Y")
                    {
                        inQuestion = false;
                        repeatRoulette = true;

                    }
                    else if (input == "no" || input == "n" || input == "No" || input == "N")
                    {
                        inQuestion = false;
                        inRoulette = false;
                        repeatRoulette = false;
                    }
                    else
                    {
                        inQuestion = true;
                        Console.WriteLine("Something went wrong, please try again");
                    }
                }
            }
        }
    }
    while (inCoin == true)
    {
        Console.WriteLine("------------------------Coin flip-------------------------");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("             -What would you like to bet on?-             ");
        Console.WriteLine();
        Console.WriteLine("                      1          2                           ");
        Console.WriteLine("                   -Heads-    -Tails-                        ");
        Console.WriteLine("                      X2        X2                           ");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("[Exit]");
        Console.WriteLine();
        
        inQuestion = true;
        while (inQuestion == true)
        {
            color = Console.ReadLine();
            if (color == "1" || color == "2")
            {
                inQuestion = false;
            }
            else if (color == "exit" || color == "Exit")
            {
                inQuestion = false;
                inCoin = false;
            }
            else
            {
                Console.WriteLine("Something went wrong, please try again");
            }
        }
        Console.WriteLine("                        How much?");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("[Exit]");
        Console.WriteLine();
        if (money > 0)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Red;
        }
        Console.WriteLine("Money: " + money);
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine();
        inQuestion = true;
        while (inQuestion == true)
        {
            input = Console.ReadLine();
            inLoop = true;
            extraQuestion = true;
            isString = false;
            while (extraQuestion == true)
            {
                while (inLoop == true)
                {
                    while (isString == false && inLoop == true)
                    {
                        for (int i = 0; i < input.Length; i++)
                        {

                            uniVal = (int)input[i];
                            if (uniVal > 57 || uniVal < 48)
                            {

                                isString = true;
                                i = input.Length;
                            }
                            inLoop = false;
                        }
                    }
                    inLoop = false;
                }

                if (isString == false)
                {

                    bet = Convert.ToInt32(input);
                    if (money >= bet)
                    {
                        money = money - bet;
                        inQuestion = false;
                        extraQuestion = false;
                    }
                    else if (money < bet)
                    {
                        Console.WriteLine("Not enough money!");
                        bet = 0;
                        extraQuestion = false;
                    }
                }
                else if (input == "Exit" || input == "exit")
                {
                    inQuestion = false;
                    extraQuestion = false;
                    inRoulette = false;
                    repeatRoulette = false;
                }
                else
                {
                    Console.WriteLine("Something went wrong, please try again");
                    extraQuestion = false;
                }
            }
        }
        if (!(bet > 0))
        {
            Random rand = new Random();
            spin = rand.Next(40, 90);

            for (int i = 0; i < spin; i++)
            {

                spinMod = i % 2;
                if (spinMod == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("      --       ");
                    Console.WriteLine("   (      )    ");
                    Console.WriteLine(" (          )  ");
                    Console.WriteLine("               ");
                    Console.WriteLine("|    Heads   | ");
                    Console.WriteLine("               ");
                    Console.WriteLine(" (          )  ");
                    Console.WriteLine("   (      )    ");
                    Console.WriteLine("      --       ");
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("      --       ");
                    Console.WriteLine("   (      )    ");
                    Console.WriteLine(" (          )  ");
                    Console.WriteLine("               ");
                    Console.WriteLine("|    Tails   | ");
                    Console.WriteLine("               ");
                    Console.WriteLine(" (          )  ");
                    Console.WriteLine("   (      )    ");
                    Console.WriteLine("      --       ");
                    Console.WriteLine();
                    Console.WriteLine();

                }
                iHigh = i;

            }
            spinMod = iHigh % 2;
            if ((color == "1" && spinMod == 0) || (color == "2" && spinMod == 1))
            {
                money = money + bet * 2;
                Console.WriteLine("You WON!   +" + bet + " $");
            }
            else
            {
                Console.WriteLine("You LOST!");
            }
            Console.WriteLine("Toss again?");
            if (money > 0)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            Console.WriteLine("Money: " + money);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
            inQuestion = true;
            if (money >= moneyHigh)
            {
                moneyHigh = money;
            }
            coinTimes = coinTimes + 1;

            while (inQuestion == true)
            {
                input = Console.ReadLine();
                if (input == "yes" || input == "y" || input == "Yes" || input == "Y")
                {
                    inQuestion = false;


                }
                else if (input == "no" || input == "n" || input == "No" || input == "N")
                {
                    inQuestion = false;
                    inCoin = false;

                }
                else
                {
                    
                    Console.WriteLine("Something went wrong, please try again");
                }
            }
        }
    }
}
    Console.WriteLine("END");
    Console.WriteLine("Most money: " + moneyHigh);
    Console.WriteLine("Played roulette " + rouletteTimes + " times");
    Console.WriteLine("Flipped a coin " + coinTimes + " times");

    userExit = true;