using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakthrough
{
    class Node
    {
        Node Parent;
        public List<Node> Children;
        public int[,] table = new int[8, 8];
        Boolean IsWhiteNode;
        public static int counter = 0;
        int id;
        int minimax;

        public Node(int[,] table, Node parent, Boolean iswhitenode)
        {
            this.Children = new List<Node>();
            this.id = counter;
            counter++;
            this.Parent = parent;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    this.table[i, j] = table[i, j];
                }
            }
            this.IsWhiteNode = iswhitenode;
        }

        public int getCounter()
        {
            return counter;
        }

        static int level = 0;

        //A fa maximum mélysége
        static int max_level = 4;

        public Node AddWhiteNode()
        {
            int[,] nextTable = new int[8, 8];
            Node Child;

            if (level == max_level)
                return null;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (this.table[i, j] == 2)
                    {
                        if (i>0)
                        {
                            //Ha a tábla bal szélén van
                            if (j == 0)
                            {
                                //Egyenes lépés
                                for (int z = 0; z < 8; z++)
                                {
                                    for (int w = 0; w < 8; w++)
                                    {
                                        nextTable[z, w] = this.table[z, w];
                                    }
                                }
                                if (this.table[i - 1, j] == 0) 
                                {
                                    nextTable[i, j] = 0;
                                    nextTable[i - 1, j] = 2;
                                    Child = new Node(nextTable, this, true);
                                    this.Children.Add(Child);
                                    level++;
                                    Child.AddBlackNode();
                                    level--;
                                }
                                if (level == max_level)
                                    return null;
                                //Jobbra-előre lépés
                                for (int z = 0; z < 8; z++)
                                {
                                    for (int w = 0; w < 8; w++)
                                    {
                                        nextTable[z, w] = this.table[z, w];
                                    }
                                }
                                if (this.table[i - 1, j+1] == 0 || this.table[i - 1, j + 1] == 1)
                                {
                                    nextTable[i, j] = 0;
                                    nextTable[i - 1, j + 1] = 2;
                                    Child = new Node(nextTable, this, true);
                                    this.Children.Add(Child);
                                    level++;
                                    Child.AddBlackNode();
                                    level--;
                                }
                                if (level == max_level)
                                    return null;
                            }
                            //Ha nincs a tábla egyik szélén sem
                            if (j > 0 && j < 7)
                            {
                                //Balra-előre lépés
                                for (int z = 0; z < 8; z++)
                                {
                                    for (int w = 0; w < 8; w++)
                                    {
                                        nextTable[z, w] = this.table[z, w];
                                    }
                                }
                                if (this.table[i - 1, j - 1] == 0 || this.table[i - 1, j - 1] == 1)
                                {
                                    nextTable[i, j] = 0;
                                    nextTable[i - 1, j - 1] = 2;
                                    Child = new Node(nextTable, this, true);
                                    this.Children.Add(Child);
                                    level++;
                                    Child.AddBlackNode();
                                    level--;
                                }
                                if (level == max_level)
                                    return null;
                                //Egyenes lépés
                                for (int z = 0; z < 8; z++)
                                {
                                    for (int w = 0; w < 8; w++)
                                    {
                                        nextTable[z, w] = this.table[z, w];
                                    }
                                }
                                if (this.table[i - 1, j] == 0)
                                {
                                    nextTable[i, j] = 0;
                                    nextTable[i - 1, j] = 2;
                                    Child = new Node(nextTable, this, true);
                                    this.Children.Add(Child);
                                    level++;
                                    Child.AddBlackNode();
                                    level--;
                                }
                                if (level == max_level)
                                    return null;
                                //Jobbra-előre lépés
                                for (int z = 0; z < 8; z++)
                                {
                                    for (int w = 0; w < 8; w++)
                                    {
                                        nextTable[z, w] = this.table[z, w];
                                    }
                                }
                                if (this.table[i - 1, j + 1] == 0 || this.table[i - 1, j + 1] == 1)
                                {
                                    nextTable[i, j] = 0;
                                    nextTable[i - 1, j + 1] = 2;
                                    Child = new Node(nextTable, this, true);
                                    this.Children.Add(Child);
                                    level++;
                                    Child.AddBlackNode();
                                    level--;
                                }
                                if (level == max_level)
                                    return null;
                            }
                            //Ha a tábla jobb szélén van
                            if (j == 7)
                            {
                                //Balra-előre lépés
                                for (int z = 0; z < 8; z++)
                                {
                                    for (int w = 0; w < 8; w++)
                                    {
                                        nextTable[z, w] = this.table[z, w];
                                    }
                                }
                                if (this.table[i - 1, j - 1] == 0 || this.table[i - 1, j - 1] == 1)
                                {
                                    nextTable[i, j] = 0;
                                    nextTable[i - 1, j - 1] = 2;
                                    Child = new Node(nextTable, this, true);
                                    this.Children.Add(Child);
                                    level++;
                                    Child.AddBlackNode();
                                    level--;
                                }
                                if (level == max_level)
                                    return null;
                                //Egyenes lépés
                                for (int z = 0; z < 8; z++)
                                {
                                    for (int w = 0; w < 8; w++)
                                    {
                                        nextTable[z, w] = this.table[z, w];
                                    }
                                }
                                if (this.table[i - 1, j] == 0)
                                {
                                    nextTable[i, j] = 0;
                                    nextTable[i - 1, j] = 2;
                                    Child = new Node(nextTable, this, true);
                                    this.Children.Add(Child);
                                    level++;
                                    Child.AddBlackNode();
                                    level--;
                                }
                                if (level == max_level)
                                    return null;
                            }
                        }
                    }
                }
            }
            return this;
        }

        public Node AddBlackNode()
        {
            int[,] nextTable = new int[8, 8];
            Node Child;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    nextTable[i, j] = this.table[i, j];
                }
            }

            //------------------------------------------------------------------------------------------------------------------
            if (level == max_level)
                return null;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (this.table[i, j] == 1)
                    {
                        if (i < 7)
                        {
                            //Ha a tábla bal szélén van
                            if (j == 0)
                            {
                                //Egyenes lépés
                                for (int z = 0; z < 8; z++)
                                {
                                    for (int w = 0; w < 8; w++)
                                    {
                                        nextTable[z, w] = this.table[z, w];
                                    }
                                }
                                if (this.table[i + 1, j] == 0)
                                {
                                    nextTable[i, j] = 0;
                                    nextTable[i + 1, j] = 1;
                                    Child = new Node(nextTable, this, false);
                                    this.Children.Add(Child);
                                    level++;
                                    Child.AddWhiteNode();
                                    level--;
                                }
                                if (level == max_level)
                                    return null;
                                //Jobbra-előre lépés
                                for (int z = 0; z < 8; z++)
                                {
                                    for (int w = 0; w < 8; w++)
                                    {
                                        nextTable[z, w] = this.table[z, w];
                                    }
                                }
                                if (this.table[i + 1, j + 1] == 0 || this.table[i + 1, j + 1] == 2)
                                {
                                    nextTable[i, j] = 0;
                                    nextTable[i + 1, j + 1] = 1;
                                    Child = new Node(nextTable, this, false);
                                    this.Children.Add(Child);
                                    level++;
                                    Child.AddWhiteNode();
                                    level--;
                                }
                                if (level == max_level)
                                    return null;
                            }
                            //Ha a nincs a tábla egyik szélén sem
                            if (j > 0 && j < 7)
                            {
                                //Egyenes lépés
                                for (int z = 0; z < 8; z++)
                                {
                                    for (int w = 0; w < 8; w++)
                                    {
                                        nextTable[z, w] = this.table[z, w];
                                    }
                                }
                                if (this.table[i + 1, j] == 0)
                                {
                                    nextTable[i, j] = 0;
                                    nextTable[i + 1, j] = 1;
                                    Child = new Node(nextTable, this, false);
                                    this.Children.Add(Child);
                                    level++;
                                    Child.AddWhiteNode();
                                    level--;
                                }
                                if (level == max_level)
                                    return null;
                                //Balra-előre lépés
                                for (int z = 0; z < 8; z++)
                                {
                                    for (int w = 0; w < 8; w++)
                                    {
                                        nextTable[z, w] = this.table[z, w];
                                    }
                                }
                                if (this.table[i + 1, j + 1] == 0 || this.table[i + 1, j + 1] == 2)
                                {
                                    nextTable[i, j] = 0;
                                    nextTable[i + 1, j + 1] = 1;
                                    Child = new Node(nextTable, this, false);
                                    this.Children.Add(Child);
                                    level++;
                                    Child.AddWhiteNode();
                                    level--;
                                }
                                if (level == max_level)
                                    return null;
                                //Jobbra-előre lépés
                                for (int z = 0; z < 8; z++)
                                {
                                    for (int w = 0; w < 8; w++)
                                    {
                                        nextTable[z, w] = this.table[z, w];
                                    }
                                }
                                if (this.table[i + 1, j - 1] == 0 || this.table[i + 1, j - 1] == 2)
                                {
                                    nextTable[i, j] = 0;
                                    nextTable[i + 1, j - 1] = 1;
                                    Child = new Node(nextTable, this, false);
                                    this.Children.Add(Child);
                                    level++;
                                    Child.AddWhiteNode();
                                    level--;
                                }
                                if (level == max_level)
                                    return null;
                            }
                            //Ha a tábla jobb szélén van
                            if (j == 7)
                            {
                                //Balra-előre lépés
                                for (int z = 0; z < 8; z++)
                                {
                                    for (int w = 0; w < 8; w++)
                                    {
                                        nextTable[z, w] = this.table[z, w];
                                    }
                                }
                                if (this.table[i + 1, j - 1] == 0 || this.table[i + 1, j - 1] == 2)
                                {
                                    nextTable[i, j] = 0;
                                    nextTable[i + 1, j - 1] = 1;
                                    Child = new Node(nextTable, this, false);
                                    this.Children.Add(Child);
                                    level++;
                                    Child.AddWhiteNode();
                                    level--;
                                }
                                if (level == max_level)
                                    return null;
                                //Egyenes lépés
                                for (int z = 0; z < 8; z++)
                                {
                                    for (int w = 0; w < 8; w++)
                                    {
                                        nextTable[z, w] = this.table[z, w];
                                    }
                                }
                                if (this.table[i + 1, j] == 0)
                                {
                                    nextTable[i, j] = 0;
                                    nextTable[i + 1, j] = 1;
                                    Child = new Node(nextTable, this, false);
                                    this.Children.Add(Child);
                                    level++;
                                    Child.AddWhiteNode();
                                    level--;
                                }
                                if (level == max_level)
                                    return null;
                            }
                        }
                    }
                }
            }
            return this;
        }
        
        public void PrintTree()
        {
            Console.WriteLine();
                if (this.Parent != null)
                    Console.WriteLine("Id: " + this.id + " | Szülő: " + this.Parent.id + " | " + (this.IsWhiteNode ? "Fekete" : "Fehér") + " | Minimax érték: " + this.minimax);
                else
                    Console.WriteLine("Id: " + this.id + " | " + (this.IsWhiteNode ? "Fekete" : "Fehér") + " | Minimax érték: " + this.minimax);

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (table[i,j]==0)
                        Console.Write(".");
                    if (table[i, j] == 1)
                        Console.Write("O");
                    if (table[i, j] == 2)
                        Console.Write("X");
                }
                Console.WriteLine();
            }
            if (this.Children.Count != 0)
            {
                for (int k = 0; k < this.Children.Count; k++)
                {
                    this.Children[k].PrintTree();
                }
            }
            else
                return;
        }

        public void addTerminalMinimaxValues()
        {
            if (this.Children.Count == 0)
            {
                this.minimax = calculateMiniMax();
            }
            else
            {
                foreach (Node item in this.Children)
                {
                    item.addTerminalMinimaxValues();
                }
            }
        }
        
        //Minimax számoló
        public int calculateMiniMax()
        {
            int mm = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    //Ha fekete bábut találunk egy helyen
                    if (this.table[i, j]==1)
                    {
                        switch (i)
                        {
                            case 0: { mm--; break; }
                            case 1: { mm--; break; }
                            case 2: { mm -= 2; break; }
                            case 3: { mm -= 3; break; }
                            case 4: { mm -= 4; break; }
                            case 5: { mm -= 5; break; }
                            case 6: { mm -= 6; break; }
                            case 7: { mm -= 99; break; }
                        }
                    }
                    //Ha fehér bábut találunk egy helyen
                    else
                    {
                        if (this.table[i, j] == 2)
                        {
                            switch (i)
                            {
                                case 0: { mm+= 99; break; }
                                case 1: { mm += 6; break; }
                                case 2: { mm += 5; break; }
                                case 3: { mm += 4; break; }
                                case 4: { mm += 3; break; }
                                case 5: { mm += 2; break; }
                                case 6: { mm++; break; }
                                case 7: { mm++; break; }
                            }
                        }
                    }
                }
            }
            return mm;
        }

        static int best_id;
        static int best_mm;
        static int old_best_mm;

        public int FillTreeWithMinimax()
        {
            if (this.Children.Count==0)
            {
                return this.minimax;
            }
            else
            {
                if (this.IsWhiteNode)
                {
                    best_mm = int.MaxValue;
                    old_best_mm = best_mm;
                    foreach (Node node in this.Children)
                    {
                        best_mm = Math.Min(best_mm, node.FillTreeWithMinimax());
                        this.minimax = best_mm;
                    }
                    return best_mm;
                }
                else
                {
                    best_mm = int.MinValue;
                    old_best_mm = best_mm;
                    foreach (Node node in this.Children)
                    {
                        best_mm = Math.Max(best_mm, node.FillTreeWithMinimax());
                        this.minimax = best_mm;
                    }
                    return best_mm;
                }
            }
        }

        public int getMinimaxByID(int id)
        {
            if (this.id == id)
                return this.minimax;
            else
            {
                foreach (Node item in this.Children)
                {
                    item.getMinimaxByID(id);
                }
            }
            return this.minimax;
        }

        static int[,] State = new int[8, 8];
        public int[,] getStateByID(int givenID)
        {
            if (this.id == givenID)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        State[i, j] = this.table[i, j];
                    }
                }
                return State;
            }
            else
            {
                if (this.Children.Count != 0)
                {
                    for (int k = 0; k < this.Children.Count; k++)
                    {
                        this.Children[k].getStateByID(givenID);
                    }
                }
            }
            return State;
        }

        List<int> Route = new List<int>();

        static int max_minimax = int.MinValue;
        public int getBestID()
        {
            if (this.Parent != null && this.Parent.id == 0)
            {
                if (this.minimax > max_minimax)
                {
                    max_minimax = this.minimax;
                    best_id = this.id;
                }
                return best_id;
            }
            else
            {
                if (this.Children.Count != 0)
                {
                    for (int k = 0; k < this.Children.Count; k++)
                    {
                        this.Children[k].getBestID();
                    }
                }
            }
            return best_id;
        }

    }
}
