using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;


namespace TheSnakeGame
{
	class Program
	{

		//vars:
		public static int score = 0;
		public static int totalGames = 0;
		public static int highScore = 0;
		public static int speed;
		public static char head = '0';
		public static string tail = "X";


		static void Main()
		{
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine("The Snake Game v0.1 by Kalin Lalov and Miro K.");
			Console.Title = "Snake";
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("To play, use the arrows or WASD!");
			for (int i = 0; i < 5; i++) { Console.WriteLine(""); };
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Press any key to play!");
			Console.ReadKey();
			Console.Clear();
		}
	}
}
