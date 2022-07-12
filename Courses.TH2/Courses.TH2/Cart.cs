using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Courses.TH2
{
    public partial class Cart : Form
    {

        public static DataTable DT_History = new DataTable();
        public static int DonHang = 0;
        public Cart()
        {
            InitializeComponent();
            LoadGioHang();
        }
        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 F = new Form1();
            F.ShowDialog();
            this.Close();
        }

        private void btn_LichSu_Click(object sender, EventArgs e)
        {
            this.Hide();
            History F = new History();
            F.ShowDialog();
            this.Close();
        }
        double Tong = 0;
        void LoadGioHang()
        {
            //double Tong = 0;
            foreach (DataRow row in Form1.Table.Rows)
            {
                string Ma = row["Ma"].ToString();
                Ctrl_Cart ctrl_ = new Ctrl_Cart();
                ctrl_.IconSP = Image.FromFile(Application.StartupPath + "\\Image\\" + Ma + ".jpg");
                ctrl_.TenSP = row["Ten"].ToString();
                ctrl_.GiaSP = row["Gia"].ToString();
                ctrl_.SoLuong = row["So Luong"].ToString();
                LayoutPanel.Controls.Add(ctrl_);
                string Gia_str = row["Gia"].ToString();
                int SoLuong = Int32.Parse(row["So Luong"].ToString());
                int Gia = Int32.Parse(Gia_str.Replace(".", ""));
                Tong +=  SoLuong * Gia;
            }
            LayoutPanel.Controls.Add(pn_DatHang);
            lb_TongTien.Text = String.Format("{0:0,0}", Tong);
        }

        private void btn_GiamGia_Click(object sender, EventArgs e)
        {
            string GiamGia_str = tb_GiamGia.Text;
            if (GiamGia_str == "GiamGia5") { lb_Giam.Text = "5%"; }
            else if (GiamGia_str == "GiamGia10") { lb_Giam.Text = "10%"; }
            else if (GiamGia_str == "GiamGia15") { lb_Giam.Text = "15%"; }
            else if (GiamGia_str == "GiamGia20") { lb_Giam.Text = "20%"; }
            else if (GiamGia_str == "GiamGia25") { lb_Giam.Text = "25%"; }
            else
            {
                lb_Giam.Text = "0%";
                MessageBox.Show("Mã giảm giá không hợp lệ!", "Thông báo");
            }
            int Ship = Int32.Parse(lb_Ship.Text.Replace(".", ""));
            int GiamGia = Int32.Parse(lb_Giam.Text.Replace("%", ""));
            double ThanhToan = Tong - Tong * GiamGia / 100 + Ship;
            lb_Thanhtoan.Text = String.Format("{0:0,0}", ThanhToan).Replace(",", ".");
        }
        
        void CreateDT_Donhang()
        {
            DT_History.Columns.Add("MaDH", typeof(string));
            DT_History.Columns.Add("MaSP", typeof(string));
            DT_History.Columns.Add("TenSP", typeof(string));
            DT_History.Columns.Add("Gia", typeof(string));
            DT_History.Columns.Add("So Luong", typeof(string));
            DT_History.Columns.Add("Thanh Toan", typeof(string));
            DT_History.Columns.Add("Trang Thai", typeof(string));
            DT_History.Columns.Add("Ho Ten", typeof(string));
            DT_History.Columns.Add("Gioi Tinh", typeof(string));
            DT_History.Columns.Add("SoDT", typeof(string));
            DT_History.Columns.Add("Dia Chi", typeof(string));
            DT_History.Columns.Add("Ngay Dat Hang", typeof(string));
            DT_History.Columns.Add("Ly Do", typeof(string));

            DT_History.Rows.Add("DH20", "1", "Apple Watch S6 40mm viền nhôm dây cao su", "10.191.000", "1", "10.191.000", "Đang Giao Hàng", "Nguyen Van A", "Anh", "1111", "Ha Tinh", "06 November 2021 10:35:07 AM", "");
            DT_History.Rows.Add("DH14", "1", "Apple Watch S6 40mm viền nhôm dây cao su", "10.191.000", "1", "10.191.000", "Đang Giao Hàng", "Nguyen Van A", "Anh", "1111", "Ha Tinh", "06 October 2021 10:35:07 AM", "");
            DT_History.Rows.Add("DH16", "1", "Apple Watch S6 40mm viền nhôm dây cao su", "10.191.000", "1", "10.191.000", "Đang Giao Hàng", "Nguyen Van A", "Anh", "1111", "Ha Tinh", "30 October 2021 10:35:07 AM", "");
            DT_History.Rows.Add("DH18", "1", "Apple Watch S6 40mm viền nhôm dây cao su", "10.191.000", "1", "10.191.000", "Đang Giao Hàng", "Nguyen Van A", "Anh", "1111", "Ha Tinh", "04 November 2021 10:35:07 AM", "");
            DT_History.Rows.Add("DH15", "1", "Apple Watch S6 40mm viền nhôm dây cao su", "10.191.000", "1", "10.191.000", "Đang Giao Hàng", "Nguyen Van A", "Anh", "1111", "Ha Tinh", "24 October 2021 10:35:07 AM", "");
            DT_History.Rows.Add("DH17", "1", "Apple Watch S6 40mm viền nhôm dây cao su", "10.191.000", "1", "10.191.000", "Đang Giao Hàng", "Nguyen Van A", "Anh", "1111", "Ha Tinh", "28 October 2021 10:35:07 AM", "");
        }


        private void btn_DatHang_Click(object sender, EventArgs e)
        {
            DonHang += 1;
            if (DonHang == 1) { CreateDT_Donhang(); }
            string MaDH = "DH" + DonHang.ToString();
            foreach (DataRow row in Form1.Table.Rows)
            {
                string TrangThai = "Đang Giao Hàng";
                string MaSP = row["Ma"].ToString();
                string TenSP = row["Ten"].ToString();
                string Gia = row["Gia"].ToString();
                string SoLuong = row["So Luong"].ToString();
                string ThanhToan = lb_Thanhtoan.Text;
                string HoTen = tb_Hoten.Text;
                string SoDT = tb_SoDT.Text;
                string DiaChi = tb_DiaChi.Text;
                string GioiTinh = "";
                string LyDo = "";
                DateTime now = DateTime.Now;
                string NgayDatHang = now.ToString("dd MMMM yyyy hh:mm:ss tt");
                //DateTime date = new DateTime(2019, 11, 12, 22, 45, 12, 004);
                // converting to string format
                //string NgayDatHang = date.ToString("dd/MM/yyyy HH:mm:ss");

                if (rb_Nam.Checked == true) { GioiTinh = "Anh"; }
                else { GioiTinh = "Chị"; }
                if (tb_Hoten.Text.Length == 0 || tb_SoDT.Text.Length == 0 || tb_DiaChi.Text.Length == 0)
                {
                    //MessageBox.Show("Vui lòng nhập thông tin đầy đủ", "Thông báo");
                    int h = 0;
                }
                DT_History.Rows.Add(MaDH, MaSP, TenSP, Gia, SoLuong, ThanhToan, TrangThai, HoTen, GioiTinh, SoDT, DiaChi, NgayDatHang, LyDo);
            }
            // Cập nhật hàng tồn kho
            foreach (DataRow row in Form1.Table.Rows)
            {
                string MaSP = row["Ma"].ToString();
                DataRow[] dr = Form1.DT.Select("Ma='" + MaSP + "'");
                int Kho = Int32.Parse(dr[0]["Kho"].ToString()) - Int32.Parse(row["So Luong"].ToString());
                dr[0]["Kho"] = Kho.ToString();
                Form1.DT.AcceptChanges();
            }
            MessageBox.Show("Bạn đã đặt hàng thành công", "Thông báo");
            Form1.Table.Clear();
        }
    }
}
