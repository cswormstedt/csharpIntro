﻿using System;

namespace Treehouse.fitness{
    
	class Program
	{
		static void Main()
		{
            
            int runningTotal = 0;

            bool keepGoing = true;
            while(keepGoing)
            {
				// Prompt the user for minutes exercised
				Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");
				string entry = Console.ReadLine();

                if (entry == "quit")
                {
                    keepGoing = false;
                }
                else
                {
                    try
                    {
                        // Add minutes to exercise tool
                        int minutes = int.Parse(entry);

						if (minutes <= 0)
						{
							Console.WriteLine(minutes + " is not an accecptable input");
						}
						else if (minutes <= 10)
						{
							Console.WriteLine("better than nothing");
						}
						else if (minutes <= 30)
						{
							Console.WriteLine("NIOCE!");
						}
						else if (minutes <= 60)
						{
							Console.WriteLine("Wow good job!");
						}
						else
						{
							Console.WriteLine("Okay take a break");
						}

						runningTotal = runningTotal + minutes;

						
					}
                    catch(FormatException)
                    {
                        Console.WriteLine("That is not a valid input.");
                        continue;
                    }

					//Display total minutes exerciesd to the screen
					Console.WriteLine("You've entered " + entry + " minutes");

					
				}
				// Repeat until user quits 
			}
            Console.WriteLine("Goodbye");
		}
	}
}