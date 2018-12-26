using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SnakeGame
{
	class Program
	{
		public static int score = 0;
		public static int totalGames = 0;
		public static int highScore = 0;
		public static int speed;
		public static int xHead = 50;
		public static int yHead = 10;
		public static int xApple;
		public static int yApple;
		public static int prevXHead;
		public static int prevYHead;
		public static int tailCount = 0;
		public static int l = 0;
		public static bool loss = false;
		public static char lastPressed;

		


		static void Processes()
		{
		  Random r = new Random();
		A:
			loss = false;
			score = 0;
			ConsoleKeyInfo n;
			int xHead = 50;
			int yHead = 10;
			int xApple;
			int yApple;
			int prevXHead = 0;
			int prevYHead = 0;
			int tailCount = 0;
			//  int l = 0;
			Console.SetCursorPosition(50, 10);
			Console.WriteLine("0");
			xApple = r.Next(2, 118);
			yApple = r.Next(2, 28);
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.SetCursorPosition(xApple, yApple);
			Console.WriteLine("@");
			while (true)//0's coordinate == X's coordinate
			{


				for (int i = 0; i <= 1000; i++)
				{


					n = Console.ReadKey();
					while (n.Key == ConsoleKey.D)             //max(x) = 120 && max(y) = 28;
					{                                      //min(x) = 1   && min(y) = 1;

						prevXHead = xHead;
						xHead++;
						Console.Clear();
						Console.ForegroundColor = ConsoleColor.Green;
						Console.SetCursorPosition(xHead, yHead);
						Console.WriteLine("0");
						switch (tailCount)
						{
							case 1:
								Console.SetCursorPosition(prevXHead, yHead);
								Console.WriteLine("X");
								break;
							case 2:

								if (lastPressed == 'w')
								{
									Console.SetCursorPosition(prevXHead, yHead);
									Console.WriteLine("X");
									Console.SetCursorPosition(prevXHead, prevYHead);
									Console.WriteLine("X");
								}
								if (lastPressed == 's')
								{
									Console.SetCursorPosition(prevXHead, yHead);
									Console.WriteLine("X");
									Console.SetCursorPosition(prevXHead, prevYHead);
									Console.WriteLine("X");
								}
								if (lastPressed != 'w' && lastPressed != 's')
								{
									Console.SetCursorPosition(prevXHead, yHead);
									Console.WriteLine("X");
									Console.SetCursorPosition(prevXHead - 1, yHead);
									Console.WriteLine("X");
								}

								break;
							case 3:
								Console.SetCursorPosition(prevXHead, yHead);
								Console.WriteLine("X");
								Console.SetCursorPosition(prevXHead - 1, yHead);
								Console.WriteLine("X");
								Console.SetCursorPosition(prevXHead - 2, yHead);
								Console.WriteLine("X");
								break;
							case 4:
								Console.SetCursorPosition(prevXHead, yHead);
								Console.WriteLine("X");
								Console.SetCursorPosition(prevXHead - 1, yHead);
								Console.WriteLine("X");
								Console.SetCursorPosition(prevXHead - 2, yHead);
								Console.WriteLine("X");
								Console.SetCursorPosition(prevXHead - 3, yHead);
								Console.WriteLine("X");
								break;

						}
						lastPressed = 'd';
						while (xHead != xApple || yHead != yApple)
						{
							Console.ForegroundColor = ConsoleColor.DarkRed;
							Console.SetCursorPosition(xApple, yApple);
							Console.WriteLine("@");
							break;
						}
						if (xHead == xApple && yHead == yApple)
						{
							tailCount++;
							xApple = r.Next(2, 118);
							yApple = r.Next(2, 28);
							Console.ForegroundColor = ConsoleColor.DarkRed;
							Console.SetCursorPosition(xApple, yApple);
							Console.WriteLine("@");
							score = score + 10;
						}
						/*if((xHead == prevXHead && y == prevYHead) || (xHead == prevXHead-1 && y == prevYHead) || (xHead == prevXHead-2 && yHead == prevYHead) || (xHead == prevXHead-3 && yHead == prevYHead))
                        {

                        }*/
						if (loss == false)
						{
							Console.ForegroundColor = ConsoleColor.Yellow;
							Console.SetCursorPosition(0, 0);
							Console.WriteLine("Score:" + score);
						}
						Thread.Sleep(100);
						if (Console.KeyAvailable)
						{
							break;

						}
						if (xHead == 119)
						{
							Console.ForegroundColor = ConsoleColor.Yellow;
							Console.WriteLine("GAME OVER");
							loss = true;
							Thread.Sleep(2000);
							Console.Clear();
							goto A;
						}

					}

					while (n.Key == ConsoleKey.W)
					{
						prevYHead = yHead;
						yHead--;
						Console.Clear();
						Console.Clear();
						Console.ForegroundColor = ConsoleColor.Green;
						Console.SetCursorPosition(xHead, yHead);
						Console.WriteLine("0");
						switch (tailCount)
						{
							case 1:

								Console.SetCursorPosition(xHead, prevYHead);
								Console.WriteLine("X");

								break;
							case 2:
								if (lastPressed == 'd')
								{
									Console.SetCursorPosition(xHead, prevYHead);
									Console.WriteLine("X");
									Console.SetCursorPosition(prevXHead, prevYHead);
									Console.WriteLine("X");

								}
								if (lastPressed != 'd' && lastPressed != 'a')
								{
									Console.SetCursorPosition(xHead, prevYHead);
									Console.WriteLine("X");
									Console.SetCursorPosition(xHead, prevYHead + 1);
									Console.WriteLine("X");
								}
								if (lastPressed == 'a')
								{
									Console.SetCursorPosition(xHead, prevYHead);
									Console.WriteLine("X");
									Console.SetCursorPosition(prevXHead, prevYHead);
									Console.WriteLine("X");

								}

								break;
							case 3:
								Console.SetCursorPosition(xHead, prevYHead);
								Console.WriteLine("X");
								Console.SetCursorPosition(xHead, prevYHead + 1);
								Console.WriteLine("X");
								Console.SetCursorPosition(xHead, prevYHead + 2);
								Console.WriteLine("X");
								break;
							case 4:
								Console.SetCursorPosition(xHead, prevYHead);
								Console.WriteLine("X");
								Console.SetCursorPosition(xHead, prevYHead + 1);
								Console.WriteLine("X");
								Console.SetCursorPosition(xHead, prevYHead + 2);
								Console.WriteLine("X");
								Console.SetCursorPosition(xHead, prevYHead + 3);
								Console.WriteLine("X");
								break;

						}
						lastPressed = 'w';
						while (xHead != xApple || yHead != yApple)
						{
							Console.ForegroundColor = ConsoleColor.DarkRed;
							Console.SetCursorPosition(xApple, yApple);
							Console.WriteLine("@");
							break;
						}
						if (xHead == xApple && yHead == yApple)
						{
							tailCount++;
							xApple = r.Next(2, 118);
							yApple = r.Next(2, 28);
							Console.ForegroundColor = ConsoleColor.DarkRed;
							Console.SetCursorPosition(xApple, yApple);
							Console.WriteLine("@");
							score = score + 10;
							/*Console.SetCursorPosition(x - 1, y - 1);
                            Console.WriteLine("X");*/
						}
						if (loss == false)
						{
							Console.ForegroundColor = ConsoleColor.Yellow;
							Console.SetCursorPosition(0, 0);
							Console.WriteLine("Score:" + score);
						}
						Thread.Sleep(100);
						if (Console.KeyAvailable)
						{
							break;

						}
						if (yHead == 1)
						{
							Console.ForegroundColor = ConsoleColor.Yellow;
							Console.WriteLine("GAME OVER");
							loss = true;
							Thread.Sleep(2000);
							Console.Clear();
							goto A;
						}
					}

					while (n.Key == ConsoleKey.A)
					{
						prevXHead = xHead;
						xHead--;
						Console.Clear();
						Console.ForegroundColor = ConsoleColor.Green;
						Console.SetCursorPosition(xHead, yHead);
						Console.WriteLine("0");
						switch (tailCount)
						{
							case 1:
								Console.SetCursorPosition(prevXHead, yHead);
								Console.WriteLine("X");
								break;
							case 2:
								if (lastPressed == 'w')
								{
									Console.SetCursorPosition(prevXHead, yHead);
									Console.WriteLine("X");
									Console.SetCursorPosition(prevXHead, prevYHead);
									Console.WriteLine("X");
								}
								if (lastPressed == 's')
								{
									Console.SetCursorPosition(prevXHead, yHead);
									Console.WriteLine("X");
									Console.SetCursorPosition(prevXHead, prevYHead);
									Console.WriteLine("X");
								}
								if (lastPressed != 'w' && lastPressed != 's')
								{
									Console.SetCursorPosition(prevXHead, yHead);
									Console.WriteLine("X");
									Console.SetCursorPosition(prevXHead + 1, yHead);
									Console.WriteLine("X");
								}
								break;
							case 3:
								Console.SetCursorPosition(prevXHead, yHead);
								Console.WriteLine("X");
								Console.SetCursorPosition(prevXHead + 1, yHead);
								Console.WriteLine("X");
								Console.SetCursorPosition(prevXHead + 2, yHead);
								Console.WriteLine("X");
								break;
							case 4:
								Console.SetCursorPosition(prevXHead, yHead);
								Console.WriteLine("X");
								Console.SetCursorPosition(prevXHead + 1, yHead);
								Console.WriteLine("X");
								Console.SetCursorPosition(prevXHead + 2, yHead);
								Console.WriteLine("X");
								Console.SetCursorPosition(prevXHead + 3, yHead);
								Console.WriteLine("X");
								break;

						}
						while (xHead != xApple || yHead != yApple)
						{
							Console.ForegroundColor = ConsoleColor.DarkRed;
							Console.SetCursorPosition(xApple, yApple);
							Console.WriteLine("@");
							break;
						}
						if (xHead == xApple && yHead == yApple)
						{
							tailCount++;
							xApple = r.Next(2, 118);
							yApple = r.Next(2, 28);
							Console.ForegroundColor = ConsoleColor.DarkRed;
							Console.SetCursorPosition(xApple, yApple);
							Console.WriteLine("@");
							score = score + 10;

						}
						if (loss == false)
						{
							Console.ForegroundColor = ConsoleColor.Yellow;
							Console.SetCursorPosition(0, 0);
							Console.WriteLine("Score:" + score);
						}
						Thread.Sleep(100);
						if (Console.KeyAvailable)
						{
							break;

						}
						if (xHead == 1)
						{
							Console.ForegroundColor = ConsoleColor.Yellow;
							Console.WriteLine("GAME OVER");
							loss = true;
							Thread.Sleep(2000);
							Console.Clear();
							goto A;
						}
						lastPressed = 'a';
					}

					while (n.Key == ConsoleKey.S)
					{
						prevYHead = yHead;
						yHead++;
						Console.Clear();
						Console.ForegroundColor = ConsoleColor.Green;
						Console.SetCursorPosition(xHead, yHead);
						Console.WriteLine("0");
						switch (tailCount)
						{
							case 1:
								Console.SetCursorPosition(xHead, prevYHead);
								Console.WriteLine("X");
								break;
							case 2:
								if (lastPressed == 'd')
								{
									Console.SetCursorPosition(xHead, prevYHead);
									Console.WriteLine("X");
									Console.SetCursorPosition(prevXHead, prevYHead);
									Console.WriteLine("X");
								}
								if (lastPressed == 'a')
								{
									Console.SetCursorPosition(xHead, prevYHead);
									Console.WriteLine("X");
									Console.SetCursorPosition(prevXHead, prevYHead);
									Console.WriteLine("X");
								}
								if (lastPressed != 'd' && lastPressed != 'a')
								{
									Console.SetCursorPosition(xHead, prevYHead);
									Console.WriteLine("X");
									Console.SetCursorPosition(xHead, prevYHead - 1);
									Console.WriteLine("X");
								}
								break;
							case 3:
								Console.SetCursorPosition(xHead, prevYHead);
								Console.WriteLine("X");
								Console.SetCursorPosition(xHead, prevYHead - 1);
								Console.WriteLine("X");
								Console.SetCursorPosition(xHead, prevYHead - 2);
								Console.WriteLine("X");
								break;
							case 4:
								Console.SetCursorPosition(xHead, prevYHead);
								Console.WriteLine("X");
								Console.SetCursorPosition(xHead, prevYHead - 1);
								Console.WriteLine("X");
								Console.SetCursorPosition(xHead, prevYHead - 2);
								Console.WriteLine("X");
								Console.SetCursorPosition(xHead, prevYHead - 3);
								Console.WriteLine("X");
								break;

						}
						lastPressed = 's';
						while (xHead != xApple || yHead != yApple)
						{
							Console.ForegroundColor = ConsoleColor.DarkRed;
							Console.SetCursorPosition(xApple, yApple);
							Console.WriteLine("@");
							break;
						}
						if (xHead == xApple && yHead == yApple)
						{
							tailCount++;
							xApple = r.Next(2, 118);
							yApple = r.Next(2, 28);
							Console.ForegroundColor = ConsoleColor.DarkRed;
							Console.SetCursorPosition(xApple, yApple);
							Console.WriteLine("@");
							score = score + 10;

						}
						if (loss == false)
						{
							Console.ForegroundColor = ConsoleColor.Yellow;
							Console.SetCursorPosition(0, 0);
							Console.WriteLine("Score:" + score);
						}

						Thread.Sleep(100);
						if (Console.KeyAvailable)
						{
							break;

						}
						if (yHead == 28)
						{
							Console.ForegroundColor = ConsoleColor.Yellow;
							Console.WriteLine("GAME OVER");
							loss = true;
							Thread.Sleep(2000);
							Console.Clear();
							goto A;
						}
					}



				}



			}
		}


		static void Apple()
		{


		}


		static void Main()
		{
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine("The Snake Game v0.1 by Kalin Lalov and Miro K.");
			Console.Title = "Snake";
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("To play, use the arrows or WASD!");
			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine("");
			};
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Press any key to play!");
			Console.ReadKey();
			Console.Clear();
			Processes();
		}

	}
}
