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
using System.IO;
using System.Text.RegularExpressions;

namespace FinalCSharp
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            //Load HighScore
            AddList();
            //Load table
            ArrayList Total = LoadStatus();
            ChessBoard.Table = (int[,])Total[0];
            //Load data
            int[] arr = (int[])Total[1];
            Cons.LEVEL = arr[0];
            Cons.SCORE = arr[1];
            GameTime.percent = arr[2];
            Cons.HINT = arr[3];
        }
        public ArrayList LoadStatus()
        {
            string filename = "SaveStatus.txt";
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
        public ArrayList LoadDiem()
        {
            string filename = "SaveDiem.txt";
            ArrayList data = new ArrayList(); // ten + level +percent + score

            using (StreamReader sr = File.OpenText(filename))
            {

                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    data.Add(s);
                }
            }

            return data;
        }
        public void AddList()
        {
            listHighScore.Items.Clear();
            ArrayList data_raw = LoadDiem();
            ArrayList data = sort(data_raw).GetRange(0, 10);
            // ListView : XepHang, Ten, Level, Diem
            for (int i = 0; i < data.Count; i++)
            {
                string temp = (string)data[i];
                //Console.WriteLine(temp);
                string[] info = temp.Split(',');

                ListViewItem item = new ListViewItem();
                item.Text = (i + 1).ToString();
                item.SubItems.Add(info[0]);
                item.SubItems.Add(info[1]);
                item.SubItems.Add(info[2]);
                listHighScore.Items.Add(item);
            }
            listHighScore.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            listHighScore.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        public int max(ArrayList data, int type)
        {
            int Max = 0;
            int idxMax = 0;
            for (int i = 0; i < data.Count; i++)
            {
                string temp = (string)data[i];
                string[] info = temp.Split(',');
                int element = Int16.Parse(info[type]);
                if (element > Max)
                {
                    Max = element;
                    idxMax = i;
                }
            }
            return idxMax;
        }
        public ArrayList sort(ArrayList data)
        {
            ArrayList temp = (ArrayList)data.Clone(); // copy 
            ArrayList sorted = new ArrayList(); // mảng đã sắp xếp
            while (temp.Count != 0)
            {
                int idx = max(temp, 2);
                sorted.Add((string)temp[idx]);
                temp.RemoveAt(idx);
            }
            return sorted;

        }
        private void btn_ChoiMoi_Click(object sender, EventArgs e)
        {
            Cons.HINT = 2;
            Cons.SCORE = 0;
            Cons.LEVEL = 1;
            Cons.NEWGAME = true;
            Cons.END = false;
            this.Hide();
            Pikachu f = new Pikachu();
            f.ShowDialog();
            this.Close();
        }

        private void btn_TiepTuc_Click(object sender, EventArgs e)
        {
            Cons.NEWGAME = false;
            Cons.END = false;
            this.Hide();
            Pikachu f = new Pikachu();
            f.ShowDialog();
            this.Close();
        }

        private void btn_DiemCao_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = true;
            pnlMenu.BackgroundImage = null;
            pnlDiemCao.Visible = true;
        }

        private void btn_HuongDan_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = true;
            pnlDiemCao.Visible = false;
            pnlMenu.BackgroundImage = Image.FromFile("tutorial.jpg");
            pnlMenu.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
