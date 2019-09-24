using System;

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
			MinValue = 1;
			MaxValue = 100;
			ComputerGuess = 0;
		}

		public void MakeComputerGuess()
		{
			if (Turns < 6)
			{
				Random rand = new Random ();
				int offset = rand.Next(-4, 4);
				int intialGuess = (MinValue + MaxValue) / 2;
				ComputerGuess = intialGuess + offset;
				if (ComputerGuess > MaxValue || ComputerGuess < MinValue)
				{
					ComputerGuess = intialGuess;
				}
				Turns++;
				Console.WriteLine("This is guess number " + Turns);	
				Console.WriteLine("My guess is: " + ComputerGuess);
				UpdateRange();
			}
			else
			{
				Console.WriteLine("You have defeated the mighty computer. You win, " + Name + "!");
				var arr = new[]
							{
							@"        _______________________         ",
							@"        |       .--.--.       |         ",
							@"        |  +   /|  |  |\   +  |         ",
							@"        | +{+  ||.-o-.||  +}+ |         ",
							@"        |  l   |/.-'-.\|   l  |         ",
							@"        |--+-------+-------+--|         ",
							@"        |  |.o. .o.|WwW WwW|  |         ",
							@"        |  |`;`o`;`| wWwWw |  |         ",
							@"        |  |  `;`  |   W   |  |         ",
							@"        ;  |-------|-------|  ;         ",
							@"         ; ; WwWWwW|.o..o. ; ;          ",
							@"          \ \ W  W |`;``;`/ /           ",
							@"           \ '. WwW|.o. .' /            ",
							@"            '. `.w | `;` .'             ",
							@"     *        '. `.|.` .'         *     ", 
							@"    \Y_O_U_     '. | .'     _W_I_N/     ",                          
							@"            \     '+'     /             ",
							@"              V_I_N_C_I_S               ",      
							};

				Console.WriteLine("\n\n");
				foreach(string line in arr )
				Console.WriteLine(line);
				Console.WriteLine("Lets play again");
				StartGame();
			}
		}

		public void UpdateRange()
		{
			Console.WriteLine("Is your number Higher, Lower or am I correct? Respond with an \"h\", \"l\" or \"c\"");
			string userFeedback = Console.ReadLine();

			if (userFeedback == "H" || userFeedback == "h")
			{
				if (Number > ComputerGuess)
				{
					MinValue = ComputerGuess;
				}
				else
				{
					Console.WriteLine("Why must you always lie.");
					var arr = new[]
								{
								@"	 ____________								",
								@"	|____________|_							",
								@"	||--------|| | _________		",
								@"	||- _     || |(CHEATER!)		",
								@"	||    - _ || | ---------		",
								@"	||       -|| |     //				",
								@"	||        || O\    __				",
								@"	||        ||  \\  (..)			",
								@"	||        ||   \\_|  |_			",
								@"	||        ||    \  \/  )		",
								@"	||        ||     :    :|		",
								@"	||        ||     :    :|		",
								@"	||        ||     :====:O		",
								@"	||        ||     (    )			",
								@"	||__@@@@__||     | `' |			",
								@"	|| @|..|@ ||     | || |			",
								@"	||O@`=='@O||     | || |			",
								@"	||_@\/\/@_||     |_||_|			",
								@"	 ________________(_)(_)     ",
								@"	/________________\----------\	",
								@"	|   GUILLOTINE   |-----------|",
								@"	|  OF CASTLE EPICODUS        |",
								@"	|____________________________|",   
								};

					Console.WriteLine("\n\n");
					foreach(string line in arr )
					Console.WriteLine(line);
					EndGame();
					return;
				}
			}
			else if (userFeedback == "L" || userFeedback == "l")
			{
				if (Number < ComputerGuess)
				{
				MaxValue = ComputerGuess;
				}
				else
				{
					Console.WriteLine("Why must you always lie.");
					var arr = new[]
								{
								@"	 ____________								",
								@"	|____________|_							",
								@"	||--------|| | _________		",
								@"	||- _     || |(CHEATER!)		",
								@"	||    - _ || | ---------		",
								@"	||       -|| |     //				",
								@"	||        || O\    __				",
								@"	||        ||  \\  (..)			",
								@"	||        ||   \\_|  |_			",
								@"	||        ||    \  \/  )		",
								@"	||        ||     :    :|		",
								@"	||        ||     :    :|		",
								@"	||        ||     :====:O		",
								@"	||        ||     (    )			",
								@"	||__@@@@__||     | `' |			",
								@"	|| @|..|@ ||     | || |			",
								@"	||O@`=='@O||     | || |			",
								@"	||_@\/\/@_||     |_||_|			",
								@"	 ________________(_)(_)     ",
								@"	/________________\----------\	",
								@"	|   GUILLOTINE   |-----------|",
								@"	|  OF CASTLE EPICODUS        |",
								@"	|____________________________|",     
								};

					Console.WriteLine("\n\n");
					foreach(string line in arr )
					Console.WriteLine(line);
					EndGame();
					return;
				}
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
					return;
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
			Console.WriteLine("You lost " + Name + ", you scruffy-looking nerf-herder.");
			var arr = new[]
            {
						@"888888888888888888888888888888888888888888888888888888888888",
						@"888888888888888888888888888888888888888888888888888888888888",
						@"8888888888888888888888888P''  ''9888888888888888888888888888",
						@"8888888888888888P'88888P          988888'9888888888888888888",
						@"8888888888888888  '9888            888P'  888888888888888888",
						@"888888888888888888bo '9  d8o  o8b  P' od88888888888888888888",
						@"888888888888888888888bob 98'  '8P dod88888888888888888888888",
						@"888888888888888888888888    db    88888888888888888888888888",
						@"88888888888888888888888888      8888888888888888888888888888",
						@"88888888888888888888888P'9bo  odP'98888888888888888888888888",
						@"88888888888888888888P' od88888888bo '98888888888888888888888",
						@"888888888888888888   d88888888888888b   88888888888888888888",
						@"8888888888888888888oo8888888888888888oo888888888888888888888",
						@"888888888888888888888888888888888888888888888888888888888888",         
            };
			Console.WriteLine("\n\n");
			foreach(string line in arr )
			Console.WriteLine(line);

			Console.WriteLine("Prepare to lose again loser!");
			StartGame();
			}

		public void StartGame()
		{
			Console.WriteLine("Enter your name: ");
			string userName = Console.ReadLine();
			Console.WriteLine("Enter a number between 1-100. I promise I won't peek!");
			int userNumber = int.Parse(Console.ReadLine());
			Game newGame = new Game(userName, userNumber);
			if (userNumber > 0 && userNumber < 101)
			{
				newGame.MakeComputerGuess();
			}
			else
			{
				Console.WriteLine("FOLLOW DIRECTIONS loser");
				var arr = new[]
							{
							@"                           zeeeeee-	",
							@"                          z$$$$$$'	",
							@"                         d$$$$$$'		",
							@"                        d$$$$$P			",
							@"                       d$$$$$P			",
							@"                      $$$$$$'				",
							@"                    .$$$$$$'				",
							@"                   .$$$$$$'					",
							@"                  4$$$$$$$$$$$$$'		",
							@"                 z$$$$$$$$$$$$$'		",
							@"                '''''''3$$$$$'			",
							@"                       z$$$$P				",
							@"                      d$$$$'				",
							@"                    .$$$$$'					",
							@"                   z$$$$$'					",
							@"                  z$$$$P						",
							@"                 d$$$$$$$$$$'				",
							@"                 *******$$$'				",
							@"                      .$$$'					",
							@"                     .$$'						",
							@"                    4$P'						",
							@"                   z$'							",
							@"                  zP								",
							@"                 z'									",
							@"                /    								",
							@"               ^										",
							@"              _											",
							@"            /   \										",
							@"           | x x |									",
							@"        \   \___/   /								",
							@"         \____|____/								",
							@"              |											",
							@"              |											",
							@"              |											",
							@"             / \										",
							@"            /   \										",
							@"          _/     \_									",       
							};
				Console.WriteLine("\n\n");
				foreach(string line in arr )
				Console.WriteLine(line);
				newGame.EndGame();
			}	
		}
}

public class Program
{
	static void Main()
	{
	// StartGame();
	
	// }
		Console.WriteLine("Enter your name: ");
		string userName = Console.ReadLine();
    Console.WriteLine("Enter a number between 1-100. I promise I won't peek! If I can't guess it in six turns, you win.");
		int userNumber = int.Parse(Console.ReadLine());
		Game newGame = new Game(userName, userNumber);
		if (userNumber > 0 && userNumber < 101)
		{
			newGame.MakeComputerGuess();
		}
		else
		{
			Console.WriteLine("FOLLOW DIRECTIONS loser");
			var arr = new[]
            {
						@"                           zeeeeee-	",
						@"                          z$$$$$$'	",
						@"                         d$$$$$$'		",
						@"                        d$$$$$P			",
						@"                       d$$$$$P			",
						@"                      $$$$$$'				",
						@"                    .$$$$$$'				",
						@"                   .$$$$$$'					",
						@"                  4$$$$$$$$$$$$$'		",
						@"                 z$$$$$$$$$$$$$'		",
						@"                '''''''3$$$$$'			",
						@"                       z$$$$P				",
						@"                      d$$$$'				",
						@"                    .$$$$$'					",
						@"                   z$$$$$'					",
						@"                  z$$$$P						",
						@"                 d$$$$$$$$$$'				",
						@"                 *******$$$'				",
						@"                      .$$$'					",
						@"                     .$$'						",
						@"                    4$P'						",
						@"                   z$'							",
						@"                  zP								",
						@"                 z'									",
						@"                /    								",
						@"               ^										",
						@"              _											",
						@"            /   \										",
						@"           | x x |									",
						@"        \   \___/   /								",
						@"         \____|____/								",
						@"              |											",
						@"              |											",
						@"              |											",
						@"             / \										",
						@"            /   \										",
						@"          _/     \_									",       
            };
			Console.WriteLine("\n\n");
			foreach(string line in arr )
			Console.WriteLine(line);
			newGame.EndGame();
		}	
	}
}





