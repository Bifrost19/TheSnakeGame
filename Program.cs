using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace uprajnenie_pixels_
{
    class Program
    {
        public static int score = 0;
        public static int totalGames = 0;
        public static int highScore = 0;
        public static int speed;
        public static int x = 50;
        public static int y = 10;
        public static int x1;
        public static int y1;
        public static int x2;
        public static int y2;
        public static int z = 0;
        public static int l = 0;
        public static bool isThereDefeat = false;
        public static char m;


        static void prosesses()
        {
        A:
            isThereDefeat = false;
            score = 0;
            ConsoleKeyInfo n;
            int x = 50;
            int y = 10;
            int x1;
            int y1;
            int x2 = 0;
            int y2 = 0;
            int z = 0;
          //  int l = 0;
        Console.SetCursorPosition(50, 10);
            Console.WriteLine("0");
            Random r = new Random();
            x1 = r.Next(2, 118);
            Random r1 = new Random();
            y1 = r1.Next(2, 28);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(x1, y1);
            Console.WriteLine("@");
            while (true)//0's coordinate == X's coordinate
            {   

                
                for (int i = 0; i <= 1000; i++)
                {


                    n = Console.ReadKey();
                    while (n.Key == ConsoleKey.D)             //max(x) = 120 && max(y) = 28;
                    {                                      //min(x) = 1   && min(y) = 1;
                        
                        x2 = x;
                        x++;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine("0");
                        switch (z)
                        {
                            case 1:
                                Console.SetCursorPosition(x2, y);
                                Console.WriteLine("X");
                                break;
                            case 2:

                                if (m == 'w')
                                {
                                    Console.SetCursorPosition(x2, y);
                                    Console.WriteLine("X");
                                    Console.SetCursorPosition(x2, y2);
                                    Console.WriteLine("X");
                                }
                                if (m == 's')
                                {
                                    Console.SetCursorPosition(x2, y);
                                    Console.WriteLine("X");
                                    Console.SetCursorPosition(x2, y2);
                                    Console.WriteLine("X");
                                }
                                if (m != 'w' && m != 's')
                                {
                                    Console.SetCursorPosition(x2, y);
                                    Console.WriteLine("X");
                                    Console.SetCursorPosition(x2 - 1, y);
                                    Console.WriteLine("X");
                                }

                                break;
                            case 3:
                                Console.SetCursorPosition(x2, y);
                                Console.WriteLine("X");
                                Console.SetCursorPosition(x2 - 1, y);
                                Console.WriteLine("X");
                                Console.SetCursorPosition(x2 - 2, y);
                                Console.WriteLine("X");
                                break;
                            case 4:
                                Console.SetCursorPosition(x2, y);
                                Console.WriteLine("X");
                                Console.SetCursorPosition(x2 - 1, y);
                                Console.WriteLine("X");
                                Console.SetCursorPosition(x2 - 2, y);
                                Console.WriteLine("X");
                                Console.SetCursorPosition(x2 - 3, y);
                                Console.WriteLine("X");
                                break;

                        }
                        m = 'd';
                        while (x != x1 || y != y1)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.SetCursorPosition(x1, y1);
                            Console.WriteLine("@");
                            break;
                        }
                        if (x == x1 && y == y1)
                        {
                            z++;
                            Random r2 = new Random();
                            x1 = r2.Next(2, 118);
                            Random r3 = new Random();
                            y1 = r3.Next(2, 28);
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.SetCursorPosition(x1, y1);
                            Console.WriteLine("@");
                            score = score + 10;
                        }
                        /*if((x == x2 && y == y2) || (x == x2-1 && y == y2) || (x == x2-2 && y == y2) || (x == x2-3 && y == y2))
                        {

                        }*/
                        if (isThereDefeat == false)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.SetCursorPosition(0, 0);
                            Console.WriteLine("Score:" + score);
                        }
                        Thread.Sleep(200);
                        if(Console.KeyAvailable)
                        {
                            break;
                            
                        }
                        if (x == 119)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("GAME OVER");
                            isThereDefeat = true;
                            Thread.Sleep(2000);
                            Console.Clear();
                            goto A;
                        }
                        
                    }
                    
                    while (n.Key == ConsoleKey.W)
                    {
                        y2 = y;
                        y--;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine("0");
                        switch (z)
                        {
                            case 1:
                                
                                    Console.SetCursorPosition(x, y2);
                                    Console.WriteLine("X");
                                
                                break;
                            case 2:
                                if (m == 'd')
                                {
                                    Console.SetCursorPosition(x, y2);
                                    Console.WriteLine("X");
                                    Console.SetCursorPosition(x2, y2);
                                    Console.WriteLine("X");
                                    
                                }
                                if(m != 'd' && m != 'a')
                                {
                                    Console.SetCursorPosition(x, y2);
                                    Console.WriteLine("X");
                                    Console.SetCursorPosition(x, y2+1);
                                    Console.WriteLine("X");
                                }
                                if (m == 'a')
                                {
                                    Console.SetCursorPosition(x, y2);
                                    Console.WriteLine("X");
                                    Console.SetCursorPosition(x2, y2);
                                    Console.WriteLine("X");

                                }

                                break;
                            case 3:
                                Console.SetCursorPosition(x, y2);
                                Console.WriteLine("X");
                                Console.SetCursorPosition(x, y2 + 1);
                                Console.WriteLine("X");
                                Console.SetCursorPosition(x, y2 + 2);
                                Console.WriteLine("X");
                                break;
                            case 4:
                                Console.SetCursorPosition(x, y2);
                                Console.WriteLine("X");
                                Console.SetCursorPosition(x, y2 + 1);
                                Console.WriteLine("X");
                                Console.SetCursorPosition(x, y2 + 2);
                                Console.WriteLine("X");
                                Console.SetCursorPosition(x, y2 + 3);
                                Console.WriteLine("X");
                                break;

                        }
                        m = 'w';
                        while (x != x1 || y != y1)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.SetCursorPosition(x1, y1);
                            Console.WriteLine("@");
                            break;
                        }
                        if (x == x1 && y == y1)
                        {
                            z++;
                            Random r2 = new Random();
                            x1 = r2.Next(2, 118);
                            Random r3 = new Random();
                            y1 = r3.Next(2, 28);
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.SetCursorPosition(x1, y1);
                            Console.WriteLine("@");
                            score = score + 10;
                            /*Console.SetCursorPosition(x - 1, y - 1);
                            Console.WriteLine("X");*/
                        }
                        if (isThereDefeat == false)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.SetCursorPosition(0, 0);
                            Console.WriteLine("Score:" + score);
                        }
                        Thread.Sleep(200);
                        if (Console.KeyAvailable)
                        {
                            break;
                           
                        }
                        if (y == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("GAME OVER");
                            isThereDefeat = true;
                            Thread.Sleep(2000);
                            Console.Clear();
                            goto A;
                        }
                    }

                    while (n.Key == ConsoleKey.A)
                    {
                        x2 = x;
                        x--;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine("0");
                        switch (z)
                        {
                            case 1:
                                Console.SetCursorPosition(x2, y);
                                Console.WriteLine("X");
                                break;
                            case 2:
                                    if(m == 'w')
                                {
                                    Console.SetCursorPosition(x2, y);
                                    Console.WriteLine("X");
                                    Console.SetCursorPosition(x2 , y2);
                                    Console.WriteLine("X");
                                }
                                    if(m == 's')
                                {
                                    Console.SetCursorPosition(x2, y);
                                    Console.WriteLine("X");
                                    Console.SetCursorPosition(x2, y2);
                                    Console.WriteLine("X");
                                }
                                    if(m != 'w' && m != 's')
                                {
                                    Console.SetCursorPosition(x2, y);
                                    Console.WriteLine("X");
                                    Console.SetCursorPosition(x2 + 1, y);
                                    Console.WriteLine("X");
                                }
                                break;
                            case 3:
                                Console.SetCursorPosition(x2, y);
                                Console.WriteLine("X");
                                Console.SetCursorPosition(x2+1, y);
                                Console.WriteLine("X");
                                Console.SetCursorPosition(x2+2, y);
                                Console.WriteLine("X");
                                break;
                            case 4:
                                Console.SetCursorPosition(x2, y);
                                Console.WriteLine("X");
                                Console.SetCursorPosition(x2+1, y);
                                Console.WriteLine("X");
                                Console.SetCursorPosition(x2+2, y);
                                Console.WriteLine("X");
                                Console.SetCursorPosition(x2+3, y);
                                Console.WriteLine("X");
                                break;

                        }
                        while (x != x1 || y != y1)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.SetCursorPosition(x1, y1);
                            Console.WriteLine("@");
                            break;
                        }
                        if (x == x1 && y == y1)
                        {
                            z++;
                            Random r2 = new Random();
                            x1 = r2.Next(2, 118);
                            Random r3 = new Random();
                            y1 = r3.Next(2, 28);
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.SetCursorPosition(x1, y1);
                            Console.WriteLine("@");
                            score = score + 10;
                           
                        }
                        if (isThereDefeat == false)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.SetCursorPosition(0, 0);
                            Console.WriteLine("Score:" + score);
                        }
                        Thread.Sleep(200);
                        if (Console.KeyAvailable)
                        {
                            break;
                            
                        }
                        if (x == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("GAME OVER");
                            isThereDefeat = true;
                            Thread.Sleep(2000);
                            Console.Clear();
                            goto A;
                        }
                        m = 'a';
                    }

                    while (n.Key == ConsoleKey.S)
                    {
                        y2 = y;
                        y++; 
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine("0");
                        switch (z)
                        {
                            case 1:
                                Console.SetCursorPosition(x, y2);
                                Console.WriteLine("X");
                                break;
                            case 2:
                                if(m == 'd')
                                {
                                    Console.SetCursorPosition(x, y2);
                                    Console.WriteLine("X");
                                    Console.SetCursorPosition(x2 , y2);
                                    Console.WriteLine("X");
                                }
                                if(m == 'a')
                                {
                                    Console.SetCursorPosition(x, y2);
                                    Console.WriteLine("X");
                                    Console.SetCursorPosition(x2, y2);
                                    Console.WriteLine("X");
                                }
                                if(m !='d' && m !='a')
                                {
                                    Console.SetCursorPosition(x, y2);
                                    Console.WriteLine("X");
                                    Console.SetCursorPosition(x, y2 - 1);
                                    Console.WriteLine("X");
                                }
                                break;
                            case 3:
                                Console.SetCursorPosition(x, y2);
                                Console.WriteLine("X");
                                Console.SetCursorPosition(x, y2 - 1);
                                Console.WriteLine("X");
                                Console.SetCursorPosition(x, y2 - 2);
                                Console.WriteLine("X");
                                break;
                            case 4:
                                Console.SetCursorPosition(x, y2);
                                Console.WriteLine("X");
                                Console.SetCursorPosition(x, y2 - 1);
                                Console.WriteLine("X");
                                Console.SetCursorPosition(x, y2 - 2);
                                Console.WriteLine("X");
                                Console.SetCursorPosition(x, y2 - 3);
                                Console.WriteLine("X");
                                break;

                        }
                        m = 's';
                        while (x != x1 || y != y1)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.SetCursorPosition(x1, y1);
                            Console.WriteLine("@");
                            break;
                        }
                        if (x == x1 && y == y1)
                        {
                            z++;
                            Random r2 = new Random();
                            x1 = r2.Next(2, 118);
                            Random r3 = new Random();
                            y1 = r3.Next(2, 28);
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.SetCursorPosition(x1, y1);
                            Console.WriteLine("@");
                            score = score + 10;
                          
                        }
                        if (isThereDefeat == false)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.SetCursorPosition(0, 0);
                            Console.WriteLine("Score:" + score);
                        }
                        
                        Thread.Sleep(200);
                        if (Console.KeyAvailable)
                        {
                            break;
                            
                        }
                        if (y == 28)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("GAME OVER");
                            isThereDefeat = true;
                            Thread.Sleep(2000);
                            Console.Clear();
                            goto A;
                        }
                    }
                    


                }

                

            }
        }


        static void apple()
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
            { Console.WriteLine("");
            };
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press any key to play!");
            Console.ReadKey();
            Console.Clear();
            prosesses();
        }

    }
}
