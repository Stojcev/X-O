using System;

namespace XsoTocka
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] pozicii = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            int turn = 0;
            bool pobedil = false;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Player 1: X\tPlayer 2: O");
                if (turn % 2 == 0)
                {
                    Console.WriteLine("Player 1 turn.\n");
                }
                else
                {
                    Console.WriteLine("Player 2 turn.\n");
                }
                tabela(pozicii);
                vnesiIzbor();
                int izbor = vnesiIzbor();
                if (pozicii[izbor] != 'X' && pozicii[izbor] != 'O')
                {
                    if (turn % 2 == 0)
                    {
                        pozicii[izbor] = 'X';
                    }
                    else
                    {
                        pozicii[izbor] = 'O';
                    }
                }
                pobedil = daliPobedil(pozicii);
                Console.Clear();
                tabela(pozicii);
                if (pobedil)
                {
                    if (turn % 2 == 0)
                    {
                        Console.WriteLine("Player 1 wins.");
                    }
                    else
                    {
                        Console.WriteLine("Player 2 wins.");
                    }
                    break;
                }
                turn++;
                if (turn == 9)
                {
                    Console.WriteLine("The game is tied, bether luck next time.");
                    break;
                }
            }
        }

        public static bool daliPobedil(char[] pozicii)
        {
            if (pozicii[1] == pozicii[2] && pozicii[2] == pozicii[3])
            {
                return true;
            }
            else if (pozicii[4] == pozicii[5] && pozicii[5] == pozicii[6])
            {
                return true;
            }
            else if (pozicii[7] == pozicii[8] && pozicii[8] == pozicii[9])
            {
                return true;
            }
            else if (pozicii[1] == pozicii[4] && pozicii[4] == pozicii[7])
            {
                return true;
            }

            else if (pozicii[2] == pozicii[5] && pozicii[5] == pozicii[8])
            {
                return true;
            }

            else if (pozicii[3] == pozicii[6] && pozicii[6] == pozicii[9])
            {
                return true;
            }
            else if (pozicii[1] == pozicii[5] && pozicii[5] == pozicii[9])
            {
                return true;
            }
            else if (pozicii[3] == pozicii[5] && pozicii[5] == pozicii[7])
            {
                return true;
            }

            return false;
        }

        public static void tabela(char[] pozicii)
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", pozicii[1], pozicii[2], pozicii[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", pozicii[4], pozicii[5], pozicii[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", pozicii[7], pozicii[8], pozicii[9]);
            Console.WriteLine("     |     |      ");
        }

        public static int vnesiIzbor()
        {
                int izbor = int.Parse(Console.ReadLine());

            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine("Ne dobra pozicija ne li si igral do sea X/O!");
                izbor = int.Parse(Console.ReadLine());
            }
                
            //izbor < 1 || izbor > 9
            return izbor;
        }
    }
}
