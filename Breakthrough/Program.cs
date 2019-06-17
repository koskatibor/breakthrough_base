using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakthrough
{
    class Base
    {
        public int[,] table = new int[8, 8];

        public Base()
        {

        }

        public Base(int[,] table)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    this.table[i, j] = table[i, j];
                }
            }
        }

        public void PrintState()
        {
            Console.WriteLine("  ABCDEFGH");
            for (int i = 0; i < 8; i++)
            {
                switch (i)
                {
                    case 0: { Console.Write("8 "); break; }
                    case 1: { Console.Write("7 "); break; }
                    case 2: { Console.Write("6 "); break; }
                    case 3: { Console.Write("5 "); break; }
                    case 4: { Console.Write("4 "); break; }
                    case 5: { Console.Write("3 "); break; }
                    case 6: { Console.Write("2 "); break; }
                    case 7: { Console.Write("1 "); break; }
                }
                for (int j = 0; j < 8; j++)
                {
                    switch(table[i, j])
                    {
                        case 0: { Console.Write("."); break; }
                        case 1: { Console.Write("O"); break; }
                        case 2: { Console.Write("X"); break; }
                    }
                }
                Console.WriteLine();
            }
        }

        public void CreateStartState()
        {
            for (int i = 0; i < 8; i++)
            {
                table[0, i] = 1;
                table[1, i] = 1;
                table[6, i] = 2;
                table[7, i] = 2;
            }
        }

        public void CreateState()
        {
            String black;
            String white;
            String[] token;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    table[i, j] = 0; 
                }
            }

            Console.WriteLine("Adja meg a Fekete bábuk helyzetét (pl.: a8 b8 c8 d6 ...)");
            black = Console.ReadLine();

            token = black.Split(' ');

            for (int i = 0; i < token.Length; i++)
            {
                switch (token[i][0])
                {
                    case 'a':
                        {
                            if (token[i][1] == '8')
                                table[0, 0] = 1;
                            if (token[i][1] == '7')
                                table[1, 0] = 1;
                            if (token[i][1] == '6')
                                table[2, 0] = 1;
                            if (token[i][1] == '5')
                                table[3, 0] = 1;
                            if (token[i][1] == '4')
                                table[4, 0] = 1;
                            if (token[i][1] == '3')
                                table[5, 0] = 1;
                            if (token[i][1] == '2')
                                table[6, 0] = 1;
                            if (token[i][1] == '1')
                                table[7, 0] = 1;
                            break;
                        }
                    case 'b':
                        {
                            if (token[i][1] == '8')
                                table[0, 1] = 1;
                            if (token[i][1] == '7')
                                table[1, 1] = 1;
                            if (token[i][1] == '6')
                                table[2, 1] = 1;
                            if (token[i][1] == '5')
                                table[3, 1] = 1;
                            if (token[i][1] == '4')
                                table[4, 1] = 1;
                            if (token[i][1] == '3')
                                table[5, 1] = 1;
                            if (token[i][1] == '2')
                                table[6, 1] = 1;
                            if (token[i][1] == '1')
                                table[7, 1] = 1;
                            break;
                        }
                    case 'c':
                        {
                            if (token[i][1] == '8')
                                table[0, 2] = 1;
                            if (token[i][1] == '7')
                                table[1, 2] = 1;
                            if (token[i][1] == '6')
                                table[2, 2] = 1;
                            if (token[i][1] == '5')
                                table[3, 2] = 1;
                            if (token[i][1] == '4')
                                table[4, 2] = 1;
                            if (token[i][1] == '3')
                                table[5, 2] = 1;
                            if (token[i][1] == '2')
                                table[6, 2] = 1;
                            if (token[i][1] == '1')
                                table[7, 2] = 1;
                            break;
                        }
                    case 'd':
                        {
                            if (token[i][1] == '8')
                                table[0, 3] = 1;
                            if (token[i][1] == '7')
                                table[1, 3] = 1;
                            if (token[i][1] == '6')
                                table[2, 3] = 1;
                            if (token[i][1] == '5')
                                table[3, 3] = 1;
                            if (token[i][1] == '4')
                                table[4, 3] = 1;
                            if (token[i][1] == '3')
                                table[5, 3] = 1;
                            if (token[i][1] == '2')
                                table[6, 3] = 1;
                            if (token[i][1] == '1')
                                table[7, 3] = 1;
                            break;
                        }
                    case 'e':
                        {
                            if (token[i][1] == '8')
                                table[0, 4] = 1;
                            if (token[i][1] == '7')
                                table[1, 4] = 1;
                            if (token[i][1] == '6')
                                table[2, 4] = 1;
                            if (token[i][1] == '5')
                                table[3, 4] = 1;
                            if (token[i][1] == '4')
                                table[4, 4] = 1;
                            if (token[i][1] == '3')
                                table[5, 4] = 1;
                            if (token[i][1] == '2')
                                table[6, 4] = 1;
                            if (token[i][1] == '1')
                                table[7, 4] = 1;
                            break;
                        }
                    case 'f':
                        {
                            if (token[i][1] == '8')
                                table[0, 5] = 1;
                            if (token[i][1] == '7')
                                table[1, 5] = 1;
                            if (token[i][1] == '6')
                                table[2, 5] = 1;
                            if (token[i][1] == '5')
                                table[3, 5] = 1;
                            if (token[i][1] == '4')
                                table[4, 5] = 1;
                            if (token[i][1] == '3')
                                table[5, 5] = 1;
                            if (token[i][1] == '2')
                                table[6, 5] = 1;
                            if (token[i][1] == '1')
                                table[7, 5] = 1;
                            break;
                        }
                    case 'g':
                        {
                            if (token[i][1] == '8')
                                table[0, 6] = 1;
                            if (token[i][1] == '7')
                                table[1, 6] = 1;
                            if (token[i][1] == '6')
                                table[2, 6] = 1;
                            if (token[i][1] == '5')
                                table[3, 6] = 1;
                            if (token[i][1] == '4')
                                table[4, 6] = 1;
                            if (token[i][1] == '3')
                                table[5, 6] = 1;
                            if (token[i][1] == '2')
                                table[6, 6] = 1;
                            if (token[i][1] == '1')
                                table[7, 6] = 1;
                            break;
                        }
                    case 'h':
                        {
                            if (token[i][1] == '8')
                                table[0, 7] = 1;
                            if (token[i][1] == '7')
                                table[1, 7] = 1;
                            if (token[i][1] == '6')
                                table[2, 7] = 1;
                            if (token[i][1] == '5')
                                table[3, 7] = 1;
                            if (token[i][1] == '4')
                                table[4, 7] = 1;
                            if (token[i][1] == '3')
                                table[5, 7] = 1;
                            if (token[i][1] == '2')
                                table[6, 7] = 1;
                            if (token[i][1] == '1')
                                table[7, 7] = 1;
                            break;
                        }
                }
            }


            Console.WriteLine("Adja meg a Fehér bábuk helyzetét (pl.: a8 b8 c8 d6 ...)");
            white = Console.ReadLine();

            token = white.Split(' ');

            for (int i = 0; i < token.Length; i++)
            {
                switch (token[i][0])
                {
                    case 'a':
                        {
                            if (token[i][1] == '8')
                                table[0, 0] = 2;
                            if (token[i][1] == '7')
                                table[1, 0] = 2;
                            if (token[i][1] == '6')
                                table[2, 0] = 2;
                            if (token[i][1] == '5')
                                table[3, 0] = 2;
                            if (token[i][1] == '4')
                                table[4, 0] = 2;
                            if (token[i][1] == '3')
                                table[5, 0] = 2;
                            if (token[i][1] == '2')
                                table[6, 0] = 2;
                            if (token[i][1] == '1')
                                table[7, 0] = 2;
                            break;
                        }
                    case 'b':
                        {
                            if (token[i][1] == '8')
                                table[0, 1] = 2;
                            if (token[i][1] == '7')
                                table[1, 1] = 2;
                            if (token[i][1] == '6')
                                table[2, 1] = 2;
                            if (token[i][1] == '5')
                                table[3, 1] = 2;
                            if (token[i][1] == '4')
                                table[4, 1] = 2;
                            if (token[i][1] == '3')
                                table[5, 1] = 2;
                            if (token[i][1] == '2')
                                table[6, 1] = 2;
                            if (token[i][1] == '1')
                                table[7, 1] = 2;
                            break;
                        }
                    case 'c':
                        {
                            if (token[i][1] == '8')
                                table[0, 2] = 2;
                            if (token[i][1] == '7')
                                table[1, 2] = 2;
                            if (token[i][1] == '6')
                                table[2, 2] = 2;
                            if (token[i][1] == '5')
                                table[3, 2] = 2;
                            if (token[i][1] == '4')
                                table[4, 2] = 2;
                            if (token[i][1] == '3')
                                table[5, 2] = 2;
                            if (token[i][1] == '2')
                                table[6, 2] = 2;
                            if (token[i][1] == '1')
                                table[7, 2] = 2;
                            break;
                        }
                    case 'd':
                        {
                            if (token[i][1] == '8')
                                table[0, 3] = 2;
                            if (token[i][1] == '7')
                                table[1, 3] = 2;
                            if (token[i][1] == '6')
                                table[2, 3] = 2;
                            if (token[i][1] == '5')
                                table[3, 3] = 2;
                            if (token[i][1] == '4')
                                table[4, 3] = 2;
                            if (token[i][1] == '3')
                                table[5, 3] = 2;
                            if (token[i][1] == '2')
                                table[6, 3] = 2;
                            if (token[i][1] == '1')
                                table[7, 3] = 2;
                            break;
                        }
                    case 'e':
                        {
                            if (token[i][1] == '8')
                                table[0, 4] = 2;
                            if (token[i][1] == '7')
                                table[1, 4] = 2;
                            if (token[i][1] == '6')
                                table[2, 4] = 2;
                            if (token[i][1] == '5')
                                table[3, 4] = 2;
                            if (token[i][1] == '4')
                                table[4, 4] = 2;
                            if (token[i][1] == '3')
                                table[5, 4] = 2;
                            if (token[i][1] == '2')
                                table[6, 4] = 2;
                            if (token[i][1] == '1')
                                table[7, 4] = 2;
                            break;
                        }
                    case 'f':
                        {
                            if (token[i][1] == '8')
                                table[0, 5] = 2;
                            if (token[i][1] == '7')
                                table[1, 5] = 2;
                            if (token[i][1] == '6')
                                table[2, 5] = 2;
                            if (token[i][1] == '5')
                                table[3, 5] = 2;
                            if (token[i][1] == '4')
                                table[4, 5] = 2;
                            if (token[i][1] == '3')
                                table[5, 5] = 2;
                            if (token[i][1] == '2')
                                table[6, 5] = 2;
                            if (token[i][1] == '1')
                                table[7, 5] = 2;
                            break;
                        }
                    case 'g':
                        {
                            if (token[i][1] == '8')
                                table[0, 6] = 2;
                            if (token[i][1] == '7')
                                table[1, 6] = 2;
                            if (token[i][1] == '6')
                                table[2, 6] = 2;
                            if (token[i][1] == '5')
                                table[3, 6] = 2;
                            if (token[i][1] == '4')
                                table[4, 6] = 2;
                            if (token[i][1] == '3')
                                table[5, 6] = 2;
                            if (token[i][1] == '2')
                                table[6, 6] = 2;
                            if (token[i][1] == '1')
                                table[7, 6] = 2;
                            break;
                        }
                    case 'h':
                        {
                            if (token[i][1] == '8')
                                table[0, 7] = 2;
                            if (token[i][1] == '7')
                                table[1, 7] = 2;
                            if (token[i][1] == '6')
                                table[2, 7] = 2;
                            if (token[i][1] == '5')
                                table[3, 7] = 2;
                            if (token[i][1] == '4')
                                table[4, 7] = 2;
                            if (token[i][1] == '3')
                                table[5, 7] = 2;
                            if (token[i][1] == '2')
                                table[6, 7] = 2;
                            if (token[i][1] == '1')
                                table[7, 7] = 2;
                            break;
                        }
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Base Game = new Base();
            Game.CreateStartState();
            Game.PrintState();
            Console.WriteLine();
            Game.CreateState();
            Game.PrintState();

            Node root = new Node(Game.table, null, false);
            Console.WriteLine("Lépés-fa felépítése...");
            root.AddWhiteNode();
            Console.WriteLine("Kész a fa felépítése. Node-ok száma: " + root.getCounter());

            Console.WriteLine("Levélelemek Minimax értékének kiszámítása...");
            root.addTerminalMinimaxValues();

            Console.WriteLine("Fa feltöltése a minimax értékekkel...");
            Console.WriteLine("Legjobb minimax: " + root.FillTreeWithMinimax());

            Console.WriteLine("Legjobb lépés megkeresése...");
            Console.WriteLine("Best ID: " + root.getBestID());

            Console.WriteLine();

            Console.WriteLine("Ajnálott lépés: ");
            Game = new Base (root.getStateByID(root.getBestID()));
            Game.PrintState();
            Console.WriteLine();

            //root.PrintTree();

            Console.ReadKey();
        }
    }
}
