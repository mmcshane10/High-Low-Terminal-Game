using System;
using System.Collections.Generic;

class Game
{
    public string Name;
    public int Number;
    public int Turns;
		public int MinValue;
		public int MaxValue;
		public int ComputerGuess;

    public Game(string name, int number)
		{
			Name = name;
			Number = number;
			Turns = 0;
			MinValue = 0;
			MaxValue = 100;
			ComputerGuess = 0;
		}

		public void MakeComputerGuess()
		{
			if (Turns < 5)
			{
				ComputerGuess = (MinValue + MaxValue) / 2;
				Console.WriteLine("My guess is: " + ComputerGuess);
				Turns++;
				Console.WriteLine("This is guesss number " + Turns);			
				UpdateRange();
			}
			else
			{
				Console.WriteLine("Even the blind squirrel finds a nut occasionally. You win, " + Name + "!");
			}
		}

		public void UpdateRange()
		{
			Console.WriteLine("Is the number Higher, Lower or am I correct? Respond with an \"h\", \"l\" or \"c\"");
			string userFeedback = Console.ReadLine();

			if (userFeedback == "H" || userFeedback == "h")
			{
				MinValue = ComputerGuess;
			}
			else if (userFeedback == "L" || userFeedback == "l")
			{
				MaxValue = ComputerGuess;
			}
			else if (userFeedback == "C" || userFeedback == "c")
			{
				if (Number == ComputerGuess)
				{
					EndGame();
					return;
				}
				else
				{
					Console.WriteLine("That wasn't your number, moron!");
					EndGame();
				}
			} 
			else
			{
				Console.WriteLine("That wasn't an approved entry, jackass. Try again: ");
				UpdateRange();
			}
			MakeComputerGuess();
		}
		public void EndGame()
		{
			Console.WriteLine("You Lost, you scruffy-looking nerf-herder.");
			// StartGame();
		}
		// public void StartGame()
		// {
		// Console.WriteLine("Enter your name: ");
		// string userName = Console.ReadLine();
    // Console.WriteLine("Enter a number between 1-100. I promise I won't peek!");
		// int userNumber = Int.Parse(Console.ReadLine());
		// Game newGame = new Game(userName, userNumber);
		// MakeComputerGuess();
		// }
}

public class Program
{
	static void Main()
	{
	// StartGame();
	
	// }
		Console.WriteLine("Enter your name: ");
		string userName = Console.ReadLine();
    Console.WriteLine("Enter a number between 1-100. I promise I won't peek! If I can't guess it in five turns, you  win.");
		int userNumber = int.Parse(Console.ReadLine());
		Game newGame = new Game(userName, userNumber);
		newGame.MakeComputerGuess();
	}
}





