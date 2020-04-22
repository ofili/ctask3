using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play a game");
                        Console.Write("What is your name? ");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("\nHi " + firstName + " let's play");
                        Console.Write("Pick a level. Easy = 1 | Medium = 2 | Hard = 3 : ");
                        int level = int.Parse(Console.ReadLine());

                        Levels:
                        if (level == 1)
                        {
                            goto Easy;
                        } else if (level == 2)
                        {
                            goto Medium;
                        } else if (level == 3) {
                            goto Hard;
                        } else
                        {
                            Console.WriteLine("You response is invalid. Try again");
                            goto Levels;
                        }



                        Easy:
                            Console.WriteLine(firstName + " you are playing Easy level");
                            Console.WriteLine("Instruction:");
                            Console.WriteLine("#1 Correctly guess a number between 1 and 10");
                            Console.WriteLine("#2 You have 6 guesses");


                            Random e = new Random();
                            while (true)
                            {
                                int randNumber = e.Next(1, 10);
                                int count = 0;
                                do
                                {
                                    Console.Write("Enter a number between 1 and 10 (Press 0 to quit): ");
                                    int input = int.Parse(Console.ReadLine());
                                    if (input == 0)
                                        return;
                                    else if (input < randNumber)
                                    {
                                        Console.WriteLine("Low number, try again.");
                                        ++count;
            							Console.WriteLine("You have " + (6 - count) + " remaining");
                                        continue;
                                    }
                                    else if (input > randNumber)
                                    {
                                        Console.WriteLine("High number, try again.");
                                        ++count;
            							Console.WriteLine("You have " + (6 - count) + " remaining");
                                        continue;
                                    }
                                    else
                                    {
                                        Console.WriteLine("You are right! The number was {0}!",randNumber);
                                        Console.WriteLine("It took you {0} {1}.\n", count,count == 1 ? "try" : "tries");
                                        break;
                                    }
                                } while (count < 6);
                                Console.WriteLine("\nGame over!");
                                Console.WriteLine(firstName +", thanks for playing");
                                return;
                            }

            		Medium:
                            Console.WriteLine(firstName + " your difficulty level is Medium");
                            Console.WriteLine("Instruction:");
                            Console.WriteLine("# Correctly guess a number between 1 and 20");
                            Console.WriteLine("# You have 3 trys");


                            Random m = new Random();
                            while (true)
                            {
                                int randNumber = m.Next(1, 20);
                                int count = 0;
                                do
                                {
                                    Console.Write("Enter a number between 1 and 20 (Press 0 to quit): ");
                                    int input = int.Parse(Console.ReadLine());
                                    if (input == 0)
                                        return;
                                    else if (input < randNumber)
                                    {
                                        Console.WriteLine("Low number, try again.");
                                        ++count;
                                        Console.WriteLine("You have " + (6 - count) + " remaining");
                                        continue;
                                    }
                                    else if (input > randNumber)
                                    {
                                        Console.WriteLine("High number, try again.");
                                        ++count;
                                        Console.WriteLine("You have " + (6 - count) + " remaining");
                                        continue;
                                    }
                                    else
                                    {
                                        Console.WriteLine("You are right! The number was {0}!",randNumber);
                                        Console.WriteLine("It took you {0} {1}.\n", count,count == 1 ? "try" : "tries");
                                        break;
                                    }
                                } while (count < 4);

                                Console.WriteLine("\nGame over!");
                                Console.WriteLine(firstName +", thanks for playing");
                                return;
                            }

            		Hard:
                            Console.WriteLine(firstName + " your difficulty level is Hard");
                            Console.WriteLine("Instruction:");
                            Console.WriteLine("# Correctly guess a number between 1 and 50");
                            Console.WriteLine("# You have 3 trys");


                            Random h = new Random();
                            while (true)
                            {
                                int randNumber = h.Next(1, 50);
                                int count = 0;
                                do
                                {
                                    Console.Write("Enter a number between 1 and 50 (Press 0 to quit): ");
                                    int input = int.Parse(Console.ReadLine());
                                    if (input == 0)
                                        return;
                                    else if (input < randNumber)
                                    {
                                        Console.WriteLine("Low number, try again.");
                                        ++count;
                                        Console.WriteLine("You have " + (6 - count) + " remaining");
                                        continue;
                                    }
                                    else if (input > randNumber)
                                    {
                                        Console.WriteLine("High number, try again.");
                                        ++count;
                                        Console.WriteLine("You have " + (6 - count) + " remaining");
                                        continue;
                                    }
                                    else
                                    {
                                        Console.WriteLine("You are right! The number was {0}!",randNumber);
                                        Console.WriteLine("It took you {0} {1}.\n", count,count == 1 ? "try" : "tries");
                                        break;
                                    }
                                } while (count < 3);

                                Console.WriteLine("\nGame over!");
                                Console.WriteLine(firstName +", thanks for playing");
                                return;
                            }
        }
    }
}