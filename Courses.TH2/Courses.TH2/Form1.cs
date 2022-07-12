using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Courses.TH2
{
    public partial class Form1 : Form
    {
        public static DataTable DT = new DataTable();
        public static DataTable Table = new DataTable();
        public static int LoadF1 = 0;
        public static ImageList imgList;
        public Form1()
        {
            InitializeComponent();
            if(LoadF1 == 0)
            {
                LoadDT();
                LoadImageList();
                LoadF1 += 1;
            }
            listView.SmallImageList = imgList;
        }

        void LoadDT()
        {
            DT.Columns.Add("Ma", typeof(string));
            DT.Columns.Add("Ten", typeof(string));
            DT.Columns.Add("Gia", typeof(string));
            DT.Columns.Add("Loai", typeof(string));
            DT.Columns.Add("Danh Gia", typeof(string));
            DT.Columns.Add("Kho", typeof(string));
            string TenFile = @"D:\Learn\UIT\Hoc Phan\Hoc Ky 7\CSharp\Courses.TH2\data.csv";
            StreamReader sr = new StreamReader(TenFile);
            string str;
            int count = 0;
            while ((str = sr.ReadLine()) != null)
            {
                count++;
                if (count != 1)
                {
                    string[] list_txt = str.Split(',');
                    DT.Rows.Add(list_txt[0], list_txt[1], list_txt[2], list_txt[3], list_txt[4], list_txt[5]);
                }
            }
            sr.Close();
            
        }

        void LoadImageList()
        {
            imgList = new ImageList() { ImageSize = new Size(56, 56) };
            for (int i = 1; i < 92; i++)
            {
                imgList.Images.Add(new Bitmap(Application.StartupPath + "\\Image\\" + i.ToString() + ".jpg"));
            }
        }


        private void pic_Options_Click(object sender, EventArgs e)
        {
            pn_Options.Visible = true;
        }

        private void pic_Options_01_Click(object sender, EventArgs e)
        {
            pn_Options.Visible = false;
        }

        private void btn_Cart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cart F = new Cart();
            F.ShowDialog();
            this.Close();
        }

        private void btn_DienThoai_Click(object sender, EventArgs e)
        {
            pn_Home.Visible = false;
            pn_DanhSach.Visible = true;
            listView.Items.Clear();
            int start = 46, end = 60;
            listView.SmallImageList = imgList;
            lb_NameSP.Text = "Điện Thoại";
            for (int i = start; i < end + 1; ++i)
            {
                DataRow[] dr = DT.Select("Ma='" + i.ToString() + "'");
                ListViewItem item = new ListViewItem();
                item.Text = dr[0]["Ten"].ToString();
                item.SubItems.Add(dr[0]["Gia"].ToString());
                item.ImageIndex = i - 1;
                listView.Items.Add(item);
            }

        }

        private void btn_Laptop_Click(object sender, EventArgs e)
        {
            pn_Home.Visible = false;
            pn_DanhSach.Visible = true;
            listView.Items.Clear();
            int start = 61, end = 75;
            listView.SmallImageList = imgList;
            lb_NameSP.Text = "Laptop";
            for (int i = start; i < end + 1; ++i)
            {
                DataRow[] dr = DT.Select("Ma='" + i.ToString() + "'");
                ListViewItem item = new ListViewItem();
                item.Text = dr[0]["Ten"].ToString();
                item.SubItems.Add(dr[0]["Gia"].ToString());
                item.ImageIndex = i - 1;
                listView.Items.Add(item);
            }
        }

        private void btn_Tablet_Click(object sender, EventArgs e)
        {
            pn_Home.Visible = false;
            pn_DanhSach.Visible = true;
            listView.Items.Clear();
            int start = 76, end = 91;
            listView.SmallImageList = imgList;
            lb_NameSP.Text = "Máy Tính Bảng";;
            for (int i = start; i < end + 1; ++i)
            {
                DataRow[] dr = DT.Select("Ma='" + i.ToString() + "'");
                ListViewItem item = new ListViewItem();
                item.Text = dr[0]["Ten"].ToString();
                item.SubItems.Add(dr[0]["Gia"].ToString());
                item.ImageIndex = i - 1;
                listView.Items.Add(item);
            }
        }

        private void btn_Watch_Click(object sender, EventArgs e)
        {
            pn_Home.Visible = false;
            pn_DanhSach.Visible = true;
            listView.Items.Clear();
            int start = 1, end = 15;
            listView.SmallImageList = imgList;
            lb_NameSP.Text = "Đồng Hồ";
            for (int i = start; i < end + 1; ++i)
            {
                DataRow[] dr = DT.Select("Ma='" + i.ToString() + "'");
                ListViewItem item = new ListViewItem();
                item.Text = dr[0]["Ten"].ToString();
                //item.SubItems.Add(dr[0]["Ten"].ToString());
                item.SubItems.Add(dr[0]["Gia"].ToString());
                item.ImageIndex = i - 1;
                listView.Items.Add(item);
            }
        }

        private void btn_PhuKien_Click(object sender, EventArgs e)
        {
            pn_Home.Visible = false;
            pn_DanhSach.Visible = true;
            listView.Items.Clear();
            int start = 31, end = 45;
            listView.SmallImageList = imgList;
            lb_NameSP.Text = "Chuột";
            for (int i = start; i < end + 1; ++i)
            {
                DataRow[] dr = DT.Select("Ma='" + i.ToString() + "'");
                ListViewItem item = new ListViewItem();
                item.Text = dr[0]["Ten"].ToString();
                item.SubItems.Add(dr[0]["Gia"].ToString());
                item.ImageIndex = i - 1;
                listView.Items.Add(item);
            }
        }

        private void btn_ManHinh_Click(object sender, EventArgs e)
        {
            pn_Home.Visible = false;
            pn_DanhSach.Visible = true;
            listView.Items.Clear();
            int start = 16, end = 30;
            listView.SmallImageList = imgList;
            lb_NameSP.Text = "Màn Hình Máy Tính";
            for (int i = start; i < end + 1; ++i)
            {
                DataRow[] dr = DT.Select("Ma='" + i.ToString() + "'");
                ListViewItem item = new ListViewItem();
                item.Text = dr[0]["Ten"].ToString();
                item.SubItems.Add(dr[0]["Gia"].ToString());
                item.ImageIndex = i - 1;
                listView.Items.Add(item);
            }
        }

        private void listView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            btn_ThemGioHang.Enabled = true;
            pn_DanhSach.Visible = false;
            pn_Info.Visible = true;
            //lb_Kho.Text = e.Item.Text;
            DataRow[] dr = DT.Select("Ten='" + e.Item.Text+ "'");
            lb_Name.Text = dr[0]["Ten"].ToString();
            string Ma = dr[0]["Ma"].ToString();
            string Gia = dr[0]["Gia"].ToString();
            lb_Gia.Text = Gia;
            float DanhGia = float.Parse(dr[0]["Danh Gia"].ToString());
            rStar_DanhGia.Value = DanhGia;

            string Kho = dr[0]["Kho"].ToString();
            lb_Kho.Text = Kho;
            nU_SoLuong.Maximum = Int32.Parse(Kho);
            if(Int32.Parse(Kho) == 0) { btn_ThemGioHang.Enabled = false; }
            pic_Info.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Image\\" + Ma + ".jpg");
        }
        void CreateTable()
        {
            Table.Columns.Add("Ma", typeof(string));
            Table.Columns.Add("Ten", typeof(string));
            Table.Columns.Add("Gia", typeof(string));
            Table.Columns.Add("Loai", typeof(string));
            Table.Columns.Add("Danh Gia", typeof(string));
            Table.Columns.Add("So Luong", typeof(string));
        }

        public static int count = 0;
        private void btn_ThemGioHang_Click(object sender, EventArgs e)
        {
            count += 1;
            if (count == 1) { CreateTable(); }
            string Ten = lb_Name.Text;
            string Gia = lb_Gia.Text;
            string DanhGia = rStar_DanhGia.Value.ToString();
            string SoLuong = nU_SoLuong.Value.ToString();

            DataRow[] dr = DT.Select("Ten='" + Ten + "'");
            string Ma = dr[0]["Ma"].ToString();
            string Loai = dr[0]["Loai"].ToString();
            Table.Rows.Add(Ma, Ten, Gia, Loai, DanhGia, SoLuong);
            MessageBox.Show("Thêm vào giỏ hàng thành công", "Thông báo");
            pn_Home.Visible = true;
            pn_Info.Visible = false;

        }

        string StringToLower(string str)
        {
            int l = str.Length, j;
            char[] arr = str.ToCharArray(0, l);
            //char ch;
            for (j = 0; j < l; j++)
            {
                arr[j] = Char.ToLower(arr[j]);
            }
            string t = new string(arr);
            return t;
        }
        string[] Search(string s)
        {
            string[] res = new string[91];
            int i = 0;
            res[i] = "-1";
            foreach (DataRow row in DT.Rows)
            {
                string q = StringToLower(row[1].ToString());
                if (q.Contains(s))
                {

                    //int index = Int16.Parse(row[0].ToString());
                    res[i] = row[0].ToString();
                    i += 1;
                }
            }
            return res;

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (tb_timkiem.Text != "")
            {
                string t = StringToLower(tb_timkiem.Text);
                string[] res = Search(t);
                if (res[0] == "-1")
                {
                    MessageBox.Show("NOT FOUND", "Thông báo");
                }
                else
                {
                    pn_Home.Visible = false;
                    pn_DanhSach.Visible = true;
                    listView.Items.Clear();
                    listView.LargeImageList = imgList;
                    foreach (string s in res)
                    {
                        if (s != null)
                        {
                            int index = Int32.Parse(s);
                            DataRow[] dr = DT.Select("Ma='" + s.ToString() + "'");
                            ListViewItem item = new ListViewItem();
                            item.Text = dr[0]["Ten"].ToString();
                            item.SubItems.Add(dr[0]["Gia"].ToString());
                            item.ImageIndex = index - 1;
                            listView.Items.Add(item);
                        }
                    }

                }
            }
        }

        private void btn_Back_DanhSach_Click(object sender, EventArgs e)
        {
            pn_Home.Visible = true;
            pn_DanhSach.Visible = false;
        }

        private void btn_Back_Info_Click(object sender, EventArgs e)
        {
            pn_DanhSach.Visible = true;
            pn_Info.Visible = false;
        }

        private void cb_Options_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_Options.Text == "Điện Thoại")
            {
                pn_Home.Visible = false;
                pn_DanhSach.Visible = true;
                listView.Items.Clear();
                int start = 46, end = 60;
                listView.SmallImageList = imgList;
                lb_NameSP.Text = "Điện Thoại";
                for (int i = start; i < end + 1; ++i)
                {
                    DataRow[] dr = DT.Select("Ma='" + i.ToString() + "'");
                    ListViewItem item = new ListViewItem();
                    item.Text = dr[0]["Ten"].ToString();
                    //item.SubItems.Add(dr[0]["Ten"].ToString());
                    item.SubItems.Add(dr[0]["Gia"].ToString());
                    item.ImageIndex = i - 1;
                    listView.Items.Add(item);
                }
            }
            else if(cb_Options.Text == "Laptop")
            {
                pn_Home.Visible = false;
                pn_DanhSach.Visible = true;
                listView.Items.Clear();
                int start = 61, end = 75;
                listView.LargeImageList = imgList;
                lb_NameSP.Text = "Laptop";
                for (int i = start; i < end + 1; ++i)
                {
                    DataRow[] dr = DT.Select("Ma='" + i.ToString() + "'");
                    ListViewItem item = new ListViewItem();
                    item.Text = dr[0]["Ten"].ToString();
                    //item.SubItems.Add(dr[0]["Ten"].ToString());
                    item.SubItems.Add(dr[0]["Gia"].ToString());
                    item.ImageIndex = i - 1;
                    listView.Items.Add(item);
                }
            }
            else if (cb_Options.Text == "Máy Tính Bảng")
            {
                pn_Home.Visible = false;
                pn_DanhSach.Visible = true;
                listView.Items.Clear();
                int start = 76, end = 91;
                listView.LargeImageList = imgList;
                lb_NameSP.Text = "Máy Tính Bảng"; ;
                for (int i = start; i < end + 1; ++i)
                {
                    DataRow[] dr = DT.Select("Ma='" + i.ToString() + "'");
                    ListViewItem item = new ListViewItem();
                    item.Text = dr[0]["Ten"].ToString();
                    //item.SubItems.Add(dr[0]["Ten"].ToString());
                    item.SubItems.Add(dr[0]["Gia"].ToString());
                    item.ImageIndex = i - 1;
                    listView.Items.Add(item);
                }
            }
            else if (cb_Options.Text == "Đồng Hồ")
            {
                pn_Home.Visible = false;
                pn_DanhSach.Visible = true;
                listView.Items.Clear();
                int start = 1, end = 15;
                listView.LargeImageList = imgList;
                lb_NameSP.Text = "Đồng Hồ";
                for (int i = start; i < end + 1; ++i)
                {
                    DataRow[] dr = DT.Select("Ma='" + i.ToString() + "'");
                    ListViewItem item = new ListViewItem();
                    item.Text = dr[0]["Ten"].ToString();
                    //item.SubItems.Add(dr[0]["Ten"].ToString());
                    item.SubItems.Add(dr[0]["Gia"].ToString());
                    item.ImageIndex = i - 1;
                    listView.Items.Add(item);
                }
            }
            else if (cb_Options.Text == "Chuột")
            {
                pn_Home.Visible = false;
                pn_DanhSach.Visible = true;
                listView.Items.Clear();
                int start = 31, end = 45;
                listView.LargeImageList = imgList;
                lb_NameSP.Text = "Chuột";
                for (int i = start; i < end + 1; ++i)
                {
                    DataRow[] dr = DT.Select("Ma='" + i.ToString() + "'");
                    ListViewItem item = new ListViewItem();
                    item.Text = dr[0]["Ten"].ToString();
                    //item.SubItems.Add(dr[0]["Ten"].ToString());
                    item.SubItems.Add(dr[0]["Gia"].ToString());
                    item.ImageIndex = i - 1;
                    listView.Items.Add(item);
                }
            }
            else if (cb_Options.Text == "Màn Hình Máy Tính")
            {
                pn_Home.Visible = false;
                pn_DanhSach.Visible = true;
                listView.Items.Clear();
                int start = 16, end = 30;
                listView.LargeImageList = imgList;
                lb_NameSP.Text = "Màn Hình Máy Tính";
                for (int i = start; i < end + 1; ++i)
                {
                    DataRow[] dr = DT.Select("Ma='" + i.ToString() + "'");
                    ListViewItem item = new ListViewItem();
                    item.Text = dr[0]["Ten"].ToString();
                    item.SubItems.Add(dr[0]["Gia"].ToString());
                    item.ImageIndex = i - 1;
                    listView.Items.Add(item);
                }
            }
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            this.Hide();
            History F = new History();
            F.ShowDialog();
            this.Close();
        }
    }
}
