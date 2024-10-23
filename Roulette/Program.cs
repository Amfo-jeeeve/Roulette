using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Security.Cryptography;

int money = 100;
int loanedMoney;
int spinnedWheel;
spinnedWheel = 0;
int takenLoan = 0;
int takenLoan1 = 0;
int takenLoan2 = 0;
int takenLoan3 = 0;
int takenMoney;
int payLoan1 = Convert.ToInt32(takenLoan1);
int payLoan2 = Convert.ToInt32(takenLoan2);
int payLoan3 = Convert.ToInt32(takenLoan3);
int[] red = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
int[] black = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
int[] green = { 0 };

bool inCasino = false;
while (!inCasino)
{
    Console.WriteLine("[The Tolled Brig]");
    Console.WriteLine("Sounds of joyous laughter and gloomy tears fills the air as a brash brawl has sprawled unto a waitress whisked");
    Console.WriteLine("a hogshead of beer, the worn wooden floor dyed in pale ale and red. The Wheel of Dames rapidly clicks");
    Console.WriteLine("in enthralling rhythms as bystanders cheer bidders on, afflictive insults thrown athwart the ample room.");
    Console.WriteLine("Clinkety-clank noises of coins are heard from two nearby stalls, sharing the sign of C&C's thrifty mortgagee.");
    Console.WriteLine("Finally, in the gloomy, mostly quiet corner of the room, the bar with the name Ichor's bottles o'plenty");
    Console.WriteLine("comes across your line of sight, filled with suspicious people and those without vigour in their hearts.");
    Console.WriteLine("");
    Console.WriteLine("[1] Wheel of Dames");
    Console.WriteLine("[2] C&C's thrifty mortgagee");
    Console.WriteLine("[3] Ichor's bottles o'plenty");

    string whereAbouts = Console.ReadLine();
    Console.Clear();

    bool addictiveness = false;
    if (whereAbouts == "1" && addictiveness != true)
    {
        bool addictedRoulette = false;
        while (!addictedRoulette)
        {
            Console.WriteLine("[Wheel of Dames]");
            Console.WriteLine("You walk over to the Wheel of Dames, attended by several others, a lady dressed in white being the GM.");
            Console.WriteLine("It appears that the most recent round of betting has ended, as some are celebrating their profits");
            Console.WriteLine("while others are in despair, losing their mighty bets once more. There's double the reward for choosing");
            Console.WriteLine("either red or black, while green gives times the amount of tiles exempt of itself, yielding 36 times the");
            Console.WriteLine("amount. Another session of betting is coming up...");
            Console.WriteLine("Enter the betting? [Y/N]");
            string answer = Console.ReadLine();
            Console.Clear();
            if (answer == "Y")
            {   
                bool color = false;
                string chosenColor = "";
                while (!color)
                {
                    Console.WriteLine("Choose a color");
                    Console.WriteLine("[1] Red");
                    Console.WriteLine("[2] Black");
                    Console.WriteLine("[3] Green");
                    chosenColor = Console.ReadLine();

                    if (chosenColor == "1" || chosenColor == "2" || chosenColor == "3")
                    {
                        Console.Clear();
                        color = true;
                    }
                    else
                    {
                        Console.Clear();
                        color = false;
                    }
                }

                Console.WriteLine("You have " + money + " $");
                Console.WriteLine("How much do you want to bet?");
                string takeMoney = Console.ReadLine();
                takenMoney = Convert.ToInt32(takeMoney);
                money -= takenMoney;

                Console.Clear();

                Random random = new();
                for (int i = 0; i < 1; i++)
                {
                    bool Spin = false;
                    while (!Spin)
                    {

                        int answer1 = random.Next(0, 37);

                        if (red.Contains(answer1))
                        {
                            Console.WriteLine("Red " + answer1);
                            spinnedWheel += 1;
                            Spin = true;
                        }
                        else if (black.Contains(answer1))
                        {
                            Console.WriteLine("Black " + answer1);
                            spinnedWheel += 1;
                            Spin = true;
                        }
                        else if (green.Contains(answer1))
                        {
                            Console.WriteLine("Green " + answer1);
                            spinnedWheel += 1;
                            Spin = true;
                        }
                        Thread.Sleep(1500);
                        Console.Clear();

                        int giveMoney = takenMoney * 2;
                        int greengiveMoney = takenMoney * 36;

                        if (chosenColor == "1" && red.Contains(answer1))
                        {
                            Console.Clear();
                            Console.WriteLine("YOU WON " + giveMoney + " $");
                            money += giveMoney;
                        }
                        else if (chosenColor == "2" && black.Contains(answer1))
                        {
                            Console.Clear();
                            Console.WriteLine("YOU WON " + giveMoney + " $");
                            money += giveMoney;
                        }
                        else if (chosenColor == "3" && green.Contains(answer1))
                        {
                            Console.Clear();
                            Console.WriteLine("YOU WON " + greengiveMoney + " $");
                            money += greengiveMoney;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("YOU LOST...");
                        }

                    }
                }
            }
            else if (answer == "N")
            {
                Console.Clear();
                addictedRoulette = true;
            }
            else
            {
                Console.Clear();
            }

            if (money <= 0)
            {
                Console.Clear();
                Console.WriteLine("As you reach into your ol' trusty pouch for the yearned coins, you find a...");
                Console.WriteLine("... Long-snouted little critter covered in a coat of black, fluffy fur grasping your coins from within your pouch?");
                Console.WriteLine("");
                Console.WriteLine("But before you can take a closer look at this remarkable creature, it suddenly disappears right in front of your eyes...");
                Console.WriteLine("You can only hear the noise of sniffling grow fainter as the creature scrams further into the crowds...");
                Thread.Sleep(15000);
                Console.Clear();
                addictedRoulette = true;
            }
        }
    }
    
    if (whereAbouts == "2" || addictiveness == true)
    {
        bool takeLoan = false;

        while (!takeLoan)
        {
            Console.WriteLine("[C&C's thrifty mortgagee]");
            Console.WriteLine("[1] Take a loan");
            Console.WriteLine("[2] Pay off a loan");
            Console.WriteLine("[3] Leave");
            string answer = Console.ReadLine();
            Console.Clear();

            if (answer == "1")
            {
                bool loan = false;

                while (!loan)
                {
                    Console.WriteLine("Insert amount to loan, maximum is 3 loans each for a certain amount under 200 $.");
                    loanedMoney = int.Parse(Console.ReadLine());

                    if (loanedMoney <= 200 && takenLoan < 3)
                    {
                        takenLoan += 1;
                        money += loanedMoney;


                        Console.Clear();
                        loan = true;
                        if (takenLoan > 3)
                        {
                            Console.WriteLine("Don't even try.");
                            Thread.Sleep(3000);
                            Console.Clear();
                            loan = true;

                        }
                    }
                    else
                    {
                        Console.Clear();
                    }
                    if (takenLoan == 1)
                    {
                        payLoan1 = Convert.ToInt32(loanedMoney);
                    }
                    else if (takenLoan == 2)
                    {
                        payLoan2 = Convert.ToInt32(loanedMoney);
                    }
                    else if (takenLoan == 3)
                    {
                        payLoan3 = Convert.ToInt32(loanedMoney);
                    }
                }
            }
            else if (answer == "2")
            {
                bool payingLoan = false;

                while (!payingLoan)
                {
                    if (spinnedWheel >= 1)
                    {
                        payLoan1 = (int)Math.Ceiling((double)payLoan1 * 1.05);
                        payLoan2 = (int)Math.Ceiling((double)payLoan2 * 1.05);
                        payLoan3 = (int)Math.Ceiling((double)payLoan3 * 1.05);
                        spinnedWheel -= 1;
                    }

                    if (payLoan1 != takenLoan1 && payLoan1 != 0)
                    {
                        Console.WriteLine("[1] " + payLoan1 +" $");
                    }
                    else if (payLoan1 == takenLoan1 || payLoan1 == 0)
                    {
                        payLoan1 = 0;
                        Console.WriteLine("[///]");
                    }

                    if (payLoan2 != takenLoan2 && payLoan2 != 0)
                    {
                        Console.WriteLine("[2] " + payLoan2 + " $");
                    }
                    else if (payLoan2 == takenLoan2 || payLoan2 == 0)
                    {
                        payLoan2 = 0;
                        Console.WriteLine("[///]");
                    }

                    if (payLoan3 != takenLoan3 && payLoan3 != 0)
                    {
                        Console.WriteLine("[3] " + payLoan3 + " $");
                    }
                    else if (payLoan3 == takenLoan3 || payLoan3 == 0)
                    {
                        payLoan3 = 0;
                        Console.WriteLine("[///]");
                    }
                    Console.WriteLine("[4] Go back");

                    string chosenLoan = Console.ReadLine();
                    Console.Clear();

                    if (chosenLoan == "1" && money >= payLoan1)
                    {
                        takenLoan -= 1;
                        money -= payLoan1;
                        payLoan1 = 0;
                        payingLoan = true;
                    }
                    else if (chosenLoan == "2" && money >= payLoan2)
                    {
                        takenLoan -= 1;
                        money -= payLoan2;
                        payLoan2 = 0;
                        payingLoan = true;
                    }
                    else if (chosenLoan == "3" && money >= payLoan3)
                    {
                        takenLoan -= 1;
                        money -= payLoan3;
                        payLoan3 = 0;
                        payingLoan = true;
                    }
                    else if (chosenLoan == "4")
                    {
                        Console.Clear();
                        payingLoan = true;
                    } else
                    {
                        Console.Clear();
                        payingLoan = false;
                    }
            }
        }
                else if (answer == "3")
                {
                    Console.Clear();
                    takeLoan = true;
                }
        }
    }
    
    if (whereAbouts == "3" && addictiveness != true)
    {
        bool gettingDrunk = false;

        while (!gettingDrunk)
        {
            Console.WriteLine("[Ichor's bottles o'plenty]");
            Console.WriteLine("[1] Approach the bartender");
            Console.WriteLine("[2] Leave");
            string answer = Console.ReadLine();
            Console.Clear();

            if (answer == "1")
            {
                bool drunkard = false;

                while (!drunkard)
                {
                    Console.WriteLine("The bartender gives a curt glance as you approach before returning their gaze to polishing the held glass with a sullied rag,");
                    Console.WriteLine("tranquil from the lousy atmosphere. Not long after, the stultified voice of the bartender encroaches, ");
                    Console.WriteLine("|Make your picking, we've got liquor for all your needs... Loosen up, it's on the house.|");
                    Console.WriteLine("A parchment with a selection of hard liquor rolls out to your side of the counter, written in pitched ink.");
                    Console.WriteLine("");
                    Console.WriteLine("@-----------------------------------@");
                    Console.WriteLine("[1] Berry Ocky Rot     [8] Rum");
                    Console.WriteLine("[2] Brandy             [9] Whiskey");
                    Console.WriteLine("[3] Butterbeer         [10] Wine");
                    Console.WriteLine("[4] Daisyroot Draught");
                    Console.WriteLine("[5] Gin");
                    Console.WriteLine("[6] Lobe-Blaster");
                    Console.WriteLine("[7] Mead");
                    Console.WriteLine("@-----------------------------------@");
                    Console.WriteLine("");
                    Console.WriteLine("[11] Leave");
                    string chosenDrink = Console.ReadLine();

                    if (chosenDrink != "11")
                    {
                        Console.Clear();
                        if (chosenDrink == "1")
                        {
                            Console.WriteLine("One sip of it later, the taste of fermented berries still remains...");
                        }
                        else if (chosenDrink == "2")
                        {
                            Console.WriteLine("The familiar flavour of non-descript Brandy spreads, licking your tongue with new sensations...");
                        }
                        else if (chosenDrink == "3")
                        {
                            Console.WriteLine("It tastes slightly like less-sickly butterscotch..?");
                        }
                        else if (chosenDrink == "4")
                        {
                            Console.WriteLine("Smells like daisies, tastes like beverage...");
                        }
                        else if (chosenDrink == "5")
                        {
                            Console.WriteLine("A strong stinge hits your nostrils and tastebuds, a potent beverage...");
                        }
                        else if (chosenDrink == "6")
                        {
                            Console.WriteLine("NEURON ACTIVATION");
                        }
                        else if (chosenDrink == "7")
                        {
                            Console.WriteLine("Tastes like oaked honey... Sweet at best but strong in flavour...");
                        }
                        else if (chosenDrink == "8")
                        {
                            Console.WriteLine("Very sweet, with a sliver of vanilla...");
                        }
                        else if (chosenDrink == "9")
                        {
                            Console.WriteLine("Smokey with a few flavours...");
                        }
                        else if (chosenDrink == "10")
                        {
                            Console.WriteLine("Dry... Like, really dry for some reason. Who even drinks this..?");
                        }

                        Thread.Sleep(5000);
                        Console.Clear();
                        drunkard = false;
                    }
                    else if (chosenDrink == "11")
                    {
                        Console.Clear();
                        drunkard = true;
                    }
                    else
                    {
                        Console.Clear();
                        drunkard = false;
                    }
                }
            } else if (answer == "2")
            {
                Console.Clear();
                gettingDrunk = true;
            } else
            {
                Console.Clear();
            }
        }
    }
}