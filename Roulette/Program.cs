﻿using System.ComponentModel.Design;
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
int money = 100;
int bet = 0;
int betSpecific = -1;
int spin;
int spinNum = 0;
int spinMod;
int uniVal = 0;
string color = "ignore";
string input = "ignore";


while (userExit == false)
{
    if (repeatRoulette == false)
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine("------------------Welcome to the casino!------------------");
        Console.WriteLine("               What would you like to play?               ");
        Console.WriteLine();
        Console.WriteLine("                        -Roulette-                        ");
        Console.WriteLine();
        Console.WriteLine("                       -Coin  flip-                       ");
        Console.WriteLine();
        Console.WriteLine("                         -Plinko-                         ");
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
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
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
                            Console.WriteLine();
                            inQuestion = false;
                            extraQuestion = false;
                        } else
                        {
                            Console.WriteLine("Something went wrong, please try again") ;
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
        Console.WriteLine("");

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
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("You LOST!");
            }
            Console.WriteLine("Spin again?");
            inQuestion = true;
            input = Console.ReadLine();
            while (inQuestion == true)
            {
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
            Console.WriteLine();
        }
    }
}
