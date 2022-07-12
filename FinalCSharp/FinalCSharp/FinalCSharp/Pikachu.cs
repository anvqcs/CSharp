using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace FinalCSharp
{
    public partial class Pikachu : Form
    {
        GameTime GT;
        ChessBoard CB;
        public Pikachu()
        {
            InitializeComponent();
            BGMusic.URL = @"E:\HocPhan\HocKy7\Csharp\CuoiKy\FinalCSharp\FinalCSharp\Resources\theme1.wav";
            BGMusic.settings.volume = 5;
            if (Cons.SOUND) { BGMusic.Ctlcontrols.play(); }
            NewGame();
        }
        public void NewGame()
        {
            Timer.Start();
            Cons.WIN = false;
            int i = 0;
            for (i = 0; i < 15; i++)
            {
                if (Cons.ARR_LEVEL[i, 0] == Cons.LEVEL)
                {
                    break;
                }
            }
            lb_Level.Text = "Màn " + i.ToString();
            GT = new GameTime(ptb_progressBar, lbPercent);
            Cons.WIDTH = Cons.ARR_LEVEL[i, 1];
            Cons.HEIGHT = Cons.ARR_LEVEL[i, 2];
            Cons.NUM_OF_TYPE = Cons.ARR_LEVEL[i, 3];
            if(Cons.HEIGHT < 8)
            {
                Cons.CHESS_WIDTH = 50;
                Cons.CHESS_HEIGHT = 60;
            }
            else
            {
                Cons.CHESS_WIDTH = 40;
                Cons.CHESS_HEIGHT = 50;
            }    
            CB = new ChessBoard(pnlChessBoard);
            pnlChessBoard.Location = new Point(this.ClientSize.Width / 2 - pnlChessBoard.Size.Width / 2 - 50,
                       this.ClientSize.Height / 2 - pnlChessBoard.Size.Height / 2 + 25);
            pnlChessBoard.Anchor = AnchorStyles.None;
        }

        int count = 0;
        private void Timer_Tick(object sender, EventArgs e)
        {
            if(Cons.END)
            {
                Timer.Stop();
                pic_Win.Visible = true;
                pnlChessBoard.Enabled = false;
                pnlThanhTich.Visible = true;
                pic_Accept.Visible = true;
                pnlThanhTich.Location = new Point(this.ClientSize.Width / 2 - pnlThanhTich.Size.Width / 2,
                       this.ClientSize.Height / 2 - pnlThanhTich.Size.Height / 2 + 25);
                lb_Score_TT.Text = Cons.SCORE.ToString();
            }
            else
            {
                lb_Score.Text = "SCORE : " + Cons.SCORE.ToString();
                lb_Hint.Text = Cons.HINT.ToString();
                if (Cons.HINT == 0)
                {
                    pic_GoiY.Enabled = false;
                }
                else
                {
                    pic_GoiY.Enabled = true;
                }
                count += 1;
                if (count % 5 == 0) { GT.UpdateLifeTime(); }
                if (Cons.WIN) { Cons.NEWGAME = true; NewGame(); }
                if (GameTime.percent == 0)
                {
                    if (Cons.SOUND) { DFSoundPlayer.media_lose.Play(); }
                    Timer.Stop();
                    Cons.GAME_OVER = true;
                    pnlChessBoard.Enabled = false;
                    pnlThanhTich.Visible = true;
                    pic_Accept.Visible = true;
                    pnlThanhTich.Location = new Point(this.ClientSize.Width / 2 - pnlThanhTich.Size.Width / 2,
                           this.ClientSize.Height / 2 - pnlThanhTich.Size.Height / 2 + 25);
                    lb_Score_TT.Text = Cons.SCORE.ToString();
                }
                if (CB.Checked())
                {
                    CB.ReLoadChessBoard();
                }
                CB.SaveStatus();
            }
        }

        public static int Count_AmThanh = 0, Count_DungLai = 0;
        private void pic_AmThanh_Click(object sender, EventArgs e)
        {
            Count_AmThanh += 1;
            if (Count_AmThanh % 2 == 1)
            {
                pic_AmThanh.BackgroundImage = Image.FromFile("sound_off.png");
                Cons.SOUND = false;
                BGMusic.Ctlcontrols.pause();
            }
            else
            {
                pic_AmThanh.BackgroundImage = Image.FromFile("sound.png");
                Cons.SOUND = true;
                BGMusic.Ctlcontrols.play();
            }
        }

        private void pic_TamDung_Click(object sender, EventArgs e)
        {
            Count_DungLai += 1;
            if (Count_DungLai % 2 == 1)
            {
                pic_TamDung.BackgroundImage = Image.FromFile("continue_new.png");
                pnlChessBoard.Enabled = false;
                Timer.Stop();
            }
            else
            {
                pic_TamDung.BackgroundImage = Image.FromFile("pause_new.png");
                pnlChessBoard.Enabled = true;
                Timer.Start();
            }
        }

        private void pic_GoiY_Click(object sender, EventArgs e)
        {
            CB.hint();
            Cons.HINT -= 1;
        }

        private void pic_Home_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            this.Hide();
            Menu f = new Menu();
            f.ShowDialog();
            this.Close();
        }
        private void pic_ChuDe_Click(object sender, EventArgs e)
        {
            pnlOption.Visible = false;
            pnl_ChuDe.Visible = true;
            pnl_ChuDe.Location = new Point(this.ClientSize.Width / 2 - pnl_ChuDe.Size.Width / 2,
                       this.ClientSize.Height / 2 - pnl_ChuDe.Size.Height / 2 + 25);
            Timer.Stop();
        }
        private void pic_Pokemon_Click(object sender, EventArgs e)
        {
            Cons.IMAGE = "Pokemon";
            Cons.NEWGAME = false;
            NewGame();
            pnlOption.Visible = true;
            pnl_ChuDe.Visible = false;
            Timer.Start();
        }

        private void pic_TraiCay_Click(object sender, EventArgs e)
        {
            Cons.IMAGE = "pic3";
            Cons.NEWGAME = false;
            NewGame();
            pnlOption.Visible = true;
            pnl_ChuDe.Visible = false;
            Timer.Start();
        }

        private void Pic_Food_Click(object sender, EventArgs e)
        {
            Cons.IMAGE = "pic2";
            Cons.NEWGAME = false;
            NewGame();
            pnlOption.Visible = true;
            pnl_ChuDe.Visible = false;
            Timer.Start();
        }

        private void btn_Out_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu f = new Menu();
            f.ShowDialog();
            this.Close();
        }

        public string[] SaveStatus()
        {
            int x = ChessBoard.Table.GetLength(0);
            int y = ChessBoard.Table.GetLength(1);
            string[] s = new string[x + 1];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (j == y - 1)
                        s[i] += ChessBoard.Table[i, j].ToString();
                    else
                    {
                        s[i] += ChessBoard.Table[i, j].ToString() + ",";
                    }
                }
            }
            int Hint = Cons.HINT;
            int Per = GameTime.percent;
            int Level = Cons.LEVEL;
            int Score = Cons.SCORE;
            string data = Level.ToString() + "," + Score.ToString() + "," + Per.ToString() + "," + Hint.ToString();
            s[x] += data;
            return s;
            //File.WriteAllLines(filename, s);
        }
        private void pic_SaveBanCo_Click(object sender, EventArgs e)
        {
            SaveFileDialog Sdlg = new SaveFileDialog();
            if (Sdlg.ShowDialog() == DialogResult.OK)
            {
                string[] S = SaveStatus();
                StreamWriter w = new StreamWriter(Sdlg.FileName);
                for (int i = 0; i < S.Length; i++)
                {
                    w.WriteLine(S[i]);
                }
                w.Dispose();
                w.Close();
            }
        }
        public ArrayList LoadStatus(string filename)
        {
            //string filename = "SaveStatus.txt";
            ArrayList data = new ArrayList();

            using (StreamReader sr = File.OpenText(filename))
            {
                string s = "";
                int k = 0;// index
                while ((s = sr.ReadLine()) != null)
                {
                    //Console.WriteLine(s);
                    string[] token = s.Split(',');
                    ArrayList total = new ArrayList();
                    int h = 0; // index
                    for (int j = 0; j < token.Length; j++)
                    {
                        //if (token[j] != " " && token[j] != "\n" && token[j] != "")
                        if (Regex.IsMatch(token[j], @"^\d+$"))
                        {
                            string temp = token[j]; // debug only
                            int element = Int32.Parse(temp);
                            total.Add(element);
                            //res[k, h] = x;
                            h++;
                        }
                    }
                    k++;
                    data.Add(total);
                }
            }
            //Trang Thai
            ArrayList Data_ = (ArrayList)data[data.Count - 1];
            int[] status = new int[4];
            for (int i = 0; i < Data_.Count; i++)
            {
                status[i] = (int)Data_[i];
            }
            //Table
            ArrayList y_temp = (ArrayList)data[0];
            int[,] res = new int[data.Count - 1, y_temp.Count];
            for (int i = 0; i < data.Count - 1; i++)
            {
                ArrayList temp = (ArrayList)data[i];
                for (int j = 0; j < temp.Count; j++)
                {
                    int a = (int)temp[j];
                    res[i, j] = a;
                }
            }
            ArrayList Total = new ArrayList();
            Total.Add(res);
            Total.Add(status);
            return Total;
        }

        private void pic_LoadBanCo_Click(object sender, EventArgs e)
        {
            Cons.NEWGAME = false;
            OpenFileDialog Dlg = new OpenFileDialog();
            if (Dlg.ShowDialog() == DialogResult.OK)
            {
                string FileName;

                FileName = Dlg.FileName;
                //Load table
                ArrayList Total = LoadStatus(FileName);
                ChessBoard.Table = (int[,])Total[0];
                //Load data
                int[] arr = (int[])Total[1];
                Cons.LEVEL = arr[0];
                Cons.SCORE = arr[1];
                GameTime.percent = arr[2];
                Cons.HINT = arr[3];
                NewGame();
            }
        }

        private void pic_BackColor_Click(object sender, EventArgs e)
        {
            ColorDialog Cdlg = new ColorDialog();
            if (Cdlg.ShowDialog() == DialogResult.OK)
            {
                Cons.BACK_COLOR = Cdlg.Color;
                Cons.NEWGAME = false;
                NewGame();
            }
        }

        private void pic_KetThuc_Click(object sender, EventArgs e)
        {
            Cons.NEWGAME = false;
            GameTime.percent = 0;
            GT = new GameTime(ptb_progressBar, lbPercent);
        }

        private void pic_Accept_Click(object sender, EventArgs e)
        {
            Cons.PLAYER_NAME = tb_User.Text;
            pic_Accept.Visible = false;
            CB.SaveDiem();
        }

        private void pic_Share_Click(object sender, EventArgs e)
        {
            var frm = pnlThanhTich;
            using (var bmp = new Bitmap(frm.Width, frm.Height))
            {
                frm.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                bmp.Save(@"E:\HocPhan\HocKy7\Csharp\CuoiKy\FinalCSharp\ngrok\host\background.jpg");
            }
            Process.Start("https://www.facebook.com/sharer/sharer.php?u=https%3A%2F%2Fe0ad-117-5-155-166.ngrok.io%2F&amp;src=sdkpreparse");
        }

    }
}
