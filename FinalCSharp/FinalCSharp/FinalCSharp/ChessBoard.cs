using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;

namespace FinalCSharp
{
    class ChessBoard
    {
        //private Color BackGround = Color.Bisque;
        public static PictureBox[] Pic;
        private Panel pnlChessBoard;
        public static int[,] Table;
        Queue ChosePokemon = new Queue();

        public ChessBoard(Panel pnlChessBoard)
        {
            this.pnlChessBoard = pnlChessBoard;
            if (Cons.NEWGAME) { DrawNewChessBoard(); }
            else { ResumeChessBoard(); }
        }

        public void DrawNewChessBoard()
        {
            pnlChessBoard.Controls.Clear();
            Pic = new PictureBox[Cons.HEIGHT * Cons.WIDTH];
            Table = new int[Cons.HEIGHT + 2, Cons.WIDTH + 2];
            //Luu cac o da sinh ra Pokemon
            HashSet<int> cellIndex = new HashSet<int>();
            //Random
            Random RD = new Random();
            int numOfCell = Cons.WIDTH * Cons.HEIGHT;
            for (int i = 0; i < numOfCell / 2; i++)
            {
                //Random Pokemon
                int typeOfPokemon = RD.Next(1, Cons.NUM_OF_TYPE + 1);

                // Cell chua Pokemon
                int cell1 = RD.Next(RD.Next(0, numOfCell + 1));
                while (cellIndex.Contains(cell1))
                    cell1 = RD.Next(RD.Next(0, numOfCell + 1));
                Table[cell1 / Cons.WIDTH + 1, cell1 % Cons.WIDTH + 1] = typeOfPokemon;
                cellIndex.Add(cell1);
                // Cell chua Pokemon
                int cell2 = RD.Next(RD.Next(0, numOfCell + 1));
                while (cellIndex.Contains(cell2))
                    cell2 = RD.Next(RD.Next(0, numOfCell + 1));
                Table[cell2 / Cons.WIDTH + 1, cell2 % Cons.WIDTH + 1] = typeOfPokemon;
                cellIndex.Add(cell2);
            }

            for (int i = 0; i < Cons.HEIGHT + 2; i++)
            {
                for (int j = 0; j < Cons.WIDTH + 2; j++)
                {
                    if (Table[i, j] != 0)
                    {
                        int idx = (i - 1) * Cons.WIDTH + j - 1;
                        Pic[idx] = new PictureBox();
                        Pic[idx].Width = Cons.CHESS_WIDTH;
                        Pic[idx].Height = Cons.CHESS_HEIGHT;
                        Pic[idx].Top = (i - 1) * Cons.CHESS_HEIGHT;
                        Pic[idx].Left = (j - 1) * Cons.CHESS_WIDTH;
                        Pic[idx].Click += PokemonClick;

                        string name = "pieces" + getCell(i, j).ToString() + ".png";
                        Pic[idx].BackgroundImageLayout = ImageLayout.Stretch;
                        Pic[idx].BackColor = Cons.BACK_COLOR;
                        Pic[idx].BackgroundImage = new Bitmap(Application.StartupPath + "\\" + Cons.IMAGE + "\\" + name);
                        pnlChessBoard.Controls.Add(Pic[idx]);
                    }
                }
            }
        }

        public void ResumeChessBoard()
        {
            pnlChessBoard.Controls.Clear();
            Pic = new PictureBox[Cons.HEIGHT * Cons.WIDTH];
            for (int i = 0; i < Cons.HEIGHT + 2; i++)
            {
                for (int j = 0; j < Cons.WIDTH + 2; j++)
                {
                    if (Table[i, j] != 0)
                    {
                        int idx = (i - 1) * Cons.WIDTH + j - 1;
                        Pic[idx] = new PictureBox();
                        Pic[idx].Width = Cons.CHESS_WIDTH;
                        Pic[idx].Height = Cons.CHESS_HEIGHT;
                        Pic[idx].Top = (i - 1) * Cons.CHESS_HEIGHT;
                        Pic[idx].Left = (j - 1) * Cons.CHESS_WIDTH;
                        Pic[idx].Click += PokemonClick;

                        string name = "pieces" + getCell(i, j).ToString() + ".png";
                        Pic[idx].BackgroundImageLayout = ImageLayout.Stretch;
                        Pic[idx].BackColor = Cons.BACK_COLOR;
                        Pic[idx].BackgroundImage = new Bitmap(Application.StartupPath + "\\" + Cons.IMAGE + "\\" + name);
                        pnlChessBoard.Controls.Add(Pic[idx]);
                    }
                }
            }
        }
        public void SaveStatus()
        {
            string filename = "SaveStatus.txt";
            int x = Table.GetLength(0);
            int y = Table.GetLength(1);
            string[] s = new string[x + 1];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (j == y - 1)
                        s[i] += Table[i, j].ToString();
                    else
                    {
                        s[i] += Table[i, j].ToString() + ",";
                    }
                }
            }
            int Hint = Cons.HINT;
            int Per = GameTime.percent;
            int Level = Cons.LEVEL;
            int Score = Cons.SCORE;
            string data = Level.ToString() + "," + Score.ToString() + "," + Per.ToString() + "," + Hint.ToString();
            s[x] += data;
            File.WriteAllLines(filename, s);
        }
        public void SaveDiem()
        {
            string User = Cons.PLAYER_NAME;
            int Level = Cons.LEVEL;
            int Score = Cons.SCORE;
            string filename = "SaveDiem.txt";

            //User, Level, Score
            string data = User + "," + Level.ToString() + "," + Score.ToString() + Environment.NewLine;
            //s.Write(data);
            File.AppendAllText(filename, data);
            //Console.WriteLine("Data has been save");
        }
        public void ReLoadChessBoard()
        {
            //pnlChessBoard.Controls.Clear();
            for (int i = 1; i < Cons.HEIGHT + 2; i++)
            {
                for (int j = 1; j < Cons.WIDTH + 2; j++)
                {
                    if (Table[i, j] != 0)
                    {
                        for (int k = i; k < Cons.HEIGHT + 2; k++)
                        {
                            for (int h = j + 1; h < Cons.WIDTH + 2; h++)
                            {
                                if (Table[k, h] != 0)
                                {
                                    if (Table[i, j] != Table[k, h])
                                    {
                                        //Index
                                        int idx = (i - 1) * Cons.WIDTH + j - 1;
                                        int index = (k - 1) * Cons.WIDTH + h - 1;
                                        //Swap table
                                        int temp = Table[k, h];
                                        Table[k, h] = Table[i, j];
                                        Table[i, j] = temp;
                                        //Swap image
                                        string name = "pieces" + getCell(i, j).ToString() + ".png";
                                        Pic[idx].BackgroundImage = new Bitmap(Application.StartupPath + "\\" + Cons.IMAGE + "\\" + name);
                                        name = "pieces" + getCell(k, h).ToString() + ".png";
                                        Pic[index].BackgroundImage = new Bitmap(Application.StartupPath + "\\" + Cons.IMAGE + "\\" + name);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public int getCell(int i, int j)
        {
            return Math.Abs(Table[i, j]);
        }

        public void PokemonClick(object sender, EventArgs e)
        {
            if (Cons.SOUND) { DFSoundPlayer.media_click.Play(); }
            PictureBox pic = (PictureBox)sender;
            ChosePokemon.Enqueue(pic);
            makeClickedCell(pic);
            if (ChosePokemon.Count == 2)
            {
                PictureBox pokemon1 = (PictureBox)ChosePokemon.Dequeue();
                PictureBox pokemon2 = (PictureBox)ChosePokemon.Dequeue();
                //
                int y1 = pokemon1.Location.X / Cons.CHESS_WIDTH + 1;
                int x1 = pokemon1.Location.Y / Cons.CHESS_HEIGHT + 1;
                int type1 = Table[x1, y1];
                Point P1 = new Point(x1, y1);
                //
                int x2 = pokemon2.Location.Y / Cons.CHESS_HEIGHT + 1;
                int y2 = pokemon2.Location.X / Cons.CHESS_WIDTH + 1;
                int type2 = Table[x2, y2];
                Point P2 = new Point(x2, y2);
                if (x1 == x2 && y1 == y2)
                {
                    pokemon1.BackColor = Cons.BACK_COLOR;
                }
                else
                {
                    if (type1 != type2)
                    {
                        if (Cons.SOUND) { DFSoundPlayer.media_nope.Play(); }
                        pokemon1.BackColor = Cons.BACK_COLOR;
                        pokemon2.BackColor = Cons.BACK_COLOR;
                    }
                    else
                    {
                        if (CheckPokemon(P1, P2))
                        {
                            if (Cons.SOUND) { DFSoundPlayer.media_pikachu.Play(); }
                            //MessageBox.Show(x1.ToString() + y1.ToString() + " " + x2.ToString() + y2.ToString());
                            Table[x1, y1] = 0;
                            pnlChessBoard.Controls.Remove(pokemon1);
                            Table[x2, y2] = 0;
                            pnlChessBoard.Controls.Remove(pokemon2);
                            Cons.SCORE = Cons.SCORE + 20 * Cons.LEVEL;
                            if (pnlChessBoard.Controls.Count == 0)
                            {
                                Cons.HINT += 1;
                                Cons.SCORE = Cons.SCORE + Cons.LEVEL * 1000;
                                Cons.LEVEL += 1;
                                Cons.WIN = true;
                                if(Cons.LEVEL == 15)
                                {
                                    Cons.LEVEL = 14;
                                    Cons.END = true;
                                    GameTime.percent = 0;
                                    if (Cons.SOUND) { DFSoundPlayer.media_win.Play(); }
                                    //MessageBox.Show("Cogatulation!");
                                    Cons.WIN = false;
                                }
                            }
                        }
                        else
                        {
                            if (Cons.SOUND) { DFSoundPlayer.media_nope.Play(); }
                            pokemon1.BackColor = Cons.BACK_COLOR;
                            pokemon2.BackColor = Cons.BACK_COLOR;
                        }
                    }
                }
            }
        }
        public void PokemonMouseLeave(object sender, EventArgs e)
        {
        }

        public void PokemonMouseHover(object sender, EventArgs e)
        {

        }
        public void makeClickedCell(PictureBox px)
        {
            px.BackColor = Color.Orange;
            //float ratio = 0.5f;

            ////convert image in picture to bitmap
            //Bitmap bmp = (Bitmap)px.Image;
            //for (int w = 0; w < bmp.Width; w++)
            //{
            //    for (int h = 0; h < bmp.Height; h++)
            //    {
            //        // get the pixel at position (w, h) of image
            //        Color c = bmp.GetPixel(w, h);
            //        // create new pixel
            //        Color newC = Color.FromArgb((int)(ratio * c.A), (int)(ratio * c.R), (int)(ratio * c.G), (int)(ratio * c.B));
            //        // change the value of pixel at posion (w, h)
            //        bmp.SetPixel(w, h, newC);
            //    }
            //}
            //// update image in picture box
            //px.Image = bmp;
        }

        // Luat Co
        public bool CheckPokemon(Point P1, Point P2)
        {
            // Check line
            if (P1.X == P2.X)
                if (checkLineX(P1.Y, P2.Y, P1.X))
                    return true;
            if (P1.Y == P2.Y)
                if (checkLineY(P1.X, P2.X, P1.Y))
                    return true;
            // Check Rectangle
            if (checkRectX(P1, P2) != -1)
                return true;
            if (checkRectY(P1, P2) != -1)
                return true;
            // Check more line
            if (checkMoreLineX(P1, P2, 1) != -1)
                return true;
            if (checkMoreLineX(P1, P2, -1) != -1)
                return true;
            if (checkMoreLineY(P1, P2, 1) != -1)
                return true;
            if (checkMoreLineY(P1, P2, -1) != -1)
                return true;
            return false;
        }
        // check with line x, from column y1 to y2
        private bool checkLineX(int y1, int y2, int x)
        {
            // find point have column max and min
            int min = Math.Min(y1, y2);
            int max = Math.Max(y1, y2);
            // run column
            for (int y = min + 1; y < max; y++)
            {
                if (Table[x, y] > 0)
                { // if see barrier then die
                    return false;
                }
            }
            // not die -> success
            return true;
        }

        private bool checkLineY(int x1, int x2, int y)
        {
            int min = Math.Min(x1, x2);
            int max = Math.Max(x1, x2);
            for (int x = min + 1; x < max; x++)
            {
                if (Table[x, y] > 0)
                {
                    return false;
                }
            }
            return true;
        }
        private int checkRectX(Point P1, Point P2)
        {
            // find point have y min and max
            Point pMin = P1, pMax = P2;
            if (P1.Y > P2.Y)
            {
                pMin = P2;
                pMax = P1;
            }
            for (int y = pMin.Y; y <= pMax.Y; y++)
            {
                //Check 2 line 
                if ((y == pMin.Y)
                    && checkLineY(pMin.X, pMax.X, pMin.Y)
                    && checkLineX(pMin.Y, pMax.Y, pMax.X))
                {
                    if (Table[pMax.X, pMin.Y] == 0)
                    {
                        return y;
                    }
                }
                if ((y == pMax.Y)
                    && checkLineX(pMin.Y, pMax.Y, pMin.X)
                    && checkLineY(pMin.X, pMax.X, pMax.Y))
                {
                    if (Table[pMin.X, pMax.Y] == 0)
                    {
                        return y;
                    }
                }
                //Check 3 line
                if ((y > pMin.Y) && (y < pMax.Y)
                    && checkLineX(pMin.Y, y, pMin.X)
                    && checkLineY(pMin.X, pMax.X, y)
                    && checkLineX(y, pMax.Y, pMax.X))
                {
                    if (Table[pMin.X, y] == 0 && Table[pMax.X, y] == 0)
                    {
                        return y;
                    }
                }
            }
            return -1;
        }
        private int checkRectY(Point P1, Point P2)
        {
            Point pMin = P1, pMax = P2;
            if (P1.X > P2.X)
            {
                pMin = P2;
                pMax = P1;
            }
            for (int x = pMin.X; x <= pMax.X; x++)
            {
                //Check 2 line 
                if ((x == pMin.X)
                    && checkLineX(pMin.Y, pMax.Y, pMin.X)
                    && checkLineY(pMin.X, pMax.X, pMax.Y))
                {
                    if (Table[pMin.X, pMax.Y] == 0)
                    {
                        return x;
                    }
                }
                if ((x == pMax.X)
                    && checkLineY(pMin.X, pMax.X, pMin.Y)
                    && checkLineX(pMin.Y, pMax.Y, pMax.X))
                {
                    if (Table[pMax.X, pMin.Y] == 0)
                    {
                        return x;
                    }
                }
                if ((x > pMin.X) && (x < pMax.X)
                    && checkLineY(pMin.X, x, pMin.Y)
                    && checkLineX(pMin.Y, pMax.Y, x)
                    && checkLineY(x, pMax.X, pMax.Y))
                {
                    if (Table[x, pMin.Y] == 0 && Table[x, pMax.Y] == 0)
                    {
                        return x;
                    }
                }
            }
            return -1;
        }
        private int checkMoreLineX(Point P1, Point P2, int type)
        {
            // find point have y min
            Point pMin = P1, pMax = P2;
            if (P1.Y > P2.Y)
            {
                pMin = P2;
                pMax = P1;
            }
            // find line and y begin
            int y = pMax.Y;
            if (type == 1)
            {
                if (checkLineX(pMin.Y, pMax.Y, pMin.X) && Table[pMin.X, pMax.Y] == 0 && pMin.Y != pMax.Y
                    || pMin.Y == pMax.Y)
                {
                    y += type;
                    while (Table[pMin.X, y] == 0
                            && Table[pMax.X, y] == 0)
                    {
                        if (checkLineY(pMin.X, pMax.X, y))
                        {
                            return y;
                        }
                        y += type;
                    }
                }
            }
            if (type == -1)
            {
                y = pMin.Y;
                if (checkLineX(pMin.Y, pMax.Y, pMax.X) && Table[pMax.X, pMin.Y] == 0 && pMin.Y != pMax.Y
                    || pMin.Y == pMax.Y)
                {
                    y += type;
                    while (Table[pMin.X, y] == 0
                            && Table[pMax.X, y] == 0)
                    {
                        if (checkLineY(pMin.X, pMax.X, y))
                        {
                            return y;
                        }
                        y += type;
                    }
                }
            }
            return -1;
        }

        private int checkMoreLineY(Point P1, Point P2, int type)
        {
            // find point have x min
            Point pMin = P1, pMax = P2;
            if (P1.X > P2.X)
            {
                pMin = P2;
                pMax = P1;
            }
            // find line and x begin
            int x = pMax.X;
            if (type == 1)
            {
                if (checkLineY(pMin.X, pMax.X, pMin.Y) && Table[pMax.X, pMin.Y] == 0 && pMin.X != pMax.X
                    || pMin.X == pMax.X)
                {
                    x += type;
                    while (Table[x, pMin.Y] == 0
                            && Table[x, pMax.Y] == 0)
                    {
                        if (checkLineX(pMin.Y, pMax.Y, x))
                        {
                            return x;
                        }
                        x += type;
                    }
                }
            }
            if (type == -1)
            {
                x = pMin.X;
                if (checkLineY(pMin.X, pMax.X, pMax.Y) && Table[pMin.X, pMax.Y] == 0 && pMin.X != pMax.X
                    || pMin.X == pMax.X)
                {
                    x += type;
                    while (Table[x, pMin.Y] == 0
                            && Table[x, pMax.Y] == 0)
                    {
                        if (checkLineX(pMin.Y, pMax.Y, x))
                        {
                            return x;
                        }
                        x += type;
                    }
                }
            }
            return -1;
        }

        public void hint()
        {

            ArrayList poke; // x,y, type
            ArrayList chessArray = new ArrayList();
            ArrayList res = new ArrayList();
            ArrayList res1 = new ArrayList();
            ArrayList res2 = new ArrayList();

            bool found = false;
            // 2 chiều to 1 chiều
            for (int i = 1; i < Cons.HEIGHT + 1; i++)
                for (int j = 1; j < Cons.WIDTH + 1; j++)
                {
                    if (Table[i, j] != 0)
                    {
                        poke = new ArrayList();
                        poke.Add(i);// x
                        poke.Add(j);// y
                        poke.Add(getCell(i, j)); // type
                        poke.Add((i - 1) * Cons.WIDTH + j - 1);
                        chessArray.Add((ArrayList)poke);
                    }
                }
            // find couple
            for (int i = 0; i < chessArray.Count; i++)
            {
                ArrayList poke1 = (ArrayList)chessArray[i];
                //Console.WriteLine(temp[0].ToString() + ";" + temp[1].ToString() + ";" + temp[2].ToString() + ";" + temp[3].ToString());
                for (int j = i + 1; j < chessArray.Count; j++)
                {
                    ArrayList poke2 = (ArrayList)chessArray[j];
                    Point p1 = new Point((int)poke1[0], (int)poke1[1]);
                    Point p2 = new Point((int)poke2[0], (int)poke2[1]);
                    if (CheckPokemon(p1, p2) == true && (int)poke1[2] == (int)poke2[2])
                    {
                        res1 = poke1;
                        res2 = poke2;
                        found = true;
                        break;
                    }
                    if (found == true)
                        break;
                }
            }
            if (found == true)
            {
                ArrayList idx1 = (ArrayList)res1;
                ArrayList idx2 = (ArrayList)res2;

                //MessageBox.Show(idx1[3].ToString() + ";" + idx2[3].ToString());
                makeClickedCell(Pic[(int)idx1[3]]);
                makeClickedCell(Pic[(int)idx2[3]]);
                Table[(int)idx1[0], (int)idx1[1]] = -Table[(int)idx1[0], (int)idx1[1]];
                Table[(int)idx2[0], (int)idx2[1]] = -Table[(int)idx2[0], (int)idx2[1]];
            }
            else
            {
                if (Cons.SOUND) { DFSoundPlayer.media_nope.Play(); }
            }
        }
        public bool Checked()
        {

            ArrayList poke; // x,y, type
            ArrayList chessArray = new ArrayList();
            ArrayList res = new ArrayList();
            ArrayList res1 = new ArrayList();
            ArrayList res2 = new ArrayList();

            bool found = false;
            // 2 chiều to 1 chiều
            for (int i = 1; i < Cons.HEIGHT + 1; i++)
                for (int j = 1; j < Cons.WIDTH + 1; j++)
                {
                    if (Table[i, j] != 0)
                    {
                        poke = new ArrayList();
                        poke.Add(i);// x
                        poke.Add(j);// y
                        poke.Add(getCell(i, j)); // type
                        poke.Add((i - 1) * Cons.WIDTH + j - 1);
                        chessArray.Add((ArrayList)poke);
                    }
                }
            // find couple
            for (int i = 0; i < chessArray.Count; i++)
            {
                ArrayList poke1 = (ArrayList)chessArray[i];
                //Console.WriteLine(temp[0].ToString() + ";" + temp[1].ToString() + ";" + temp[2].ToString() + ";" + temp[3].ToString());
                for (int j = i + 1; j < chessArray.Count; j++)
                {
                    ArrayList poke2 = (ArrayList)chessArray[j];
                    Point p1 = new Point((int)poke1[0], (int)poke1[1]);
                    Point p2 = new Point((int)poke2[0], (int)poke2[1]);
                    if (CheckPokemon(p1, p2) == true && (int)poke1[2] == (int)poke2[2])
                    {
                        res1 = poke1;
                        res2 = poke2;
                        found = true;
                        break;
                    }
                    if (found == true)
                        break;
                }
            }
            if (found == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
