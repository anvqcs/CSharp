using System;
using System.Drawing;
using System.Windows.Forms;

namespace Courses.TH01
{
    public partial class fAccount : Form
    {
        public fAccount()
        {
            InitializeComponent();

            if (fAccount.NgonNgu == "Tiếng Việt")
            {
                //Panel Thong tin ca nhan
                lb_Info.Text = "Thông tin cá nhân";
                lb_DiaChi.Text = "Địa chỉ :";
                lb_SinhNhat.Text = "Sinh nhật :";
                lb_GioiTinh.Text = "Giới tính :";
                lb_SoDT.Text = "Số điện thoại :";
                btnCaiDat.Text = "Cài đặt";
                btnChinhSua.Text = "Chỉnh sửa";
                //Panel Gioi thieu ve ban
                lb_GioiThieu.Text = "Giới thiệu về bạn";
                lb_HoTen_2.Text = "Họ tên :";
                lb_GioiTinh_2.Text = "Giới tính :";
                lb_NgaySinh_2.Text = "Ngày sinh :";
                lb_DiaChi2.Text = "Địa chỉ :";
                lb_SoDT2.Text = "Số điện thoại :";
                //Panel Cai dat
                lb_CaiDat_3.Text = "Cài đặt";
                lbQuocGia.Text = "Quốc gia :";
                lbNgonNgu.Text = "Ngôn ngữ :";
                btnDangXuat.Text = "Đăng xuất";
                lb_ChonNgonNgu.Text = "Chọn ngôn ngữ";
                lb_MauSac_3.Text = "Màu sắc :";
                btn_MauSac_3.Text = "Chọn màu";
            }   
            else
            {
                //Panel Thong tin ca nhan
                lb_Info.Text = "Information";
                lb_DiaChi.Text = "Address :";
                lb_SinhNhat.Text = "Birthday :";
                lb_GioiTinh.Text = "Gender :";
                lb_SoDT.Text = "Phone number :";
                btnCaiDat.Text = "Setting";
                btnChinhSua.Text = "Edit";
                //Panel Gioi thieu ve ban
                lb_GioiThieu.Text = "Introduce";
                lb_HoTen_2.Text = "Name :";
                lb_GioiTinh_2.Text = "Gender :";
                lb_NgaySinh_2.Text = "Birthday :";
                lb_DiaChi2.Text = "Address :";
                lb_SoDT2.Text = "Phone number :";
                //Panel Cai dat
                lb_CaiDat_3.Text = "Setting";
                lbQuocGia.Text = "The country :";
                lbNgonNgu.Text = "Language :";
                btnDangXuat.Text = "Log out";
                lb_ChonNgonNgu.Text = "Choose language";
                lb_MauSac_3.Text = "Color :";
                btn_MauSac_3.Text = "Edit color";
            }
            panel4.BackColor = fAccount.MauNen;
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            pnAccount.Visible = false;
            pnGioiThieu.Visible = true;

        }

        public static string Hoten = "Võ Quốc An";
        private void btnBack_Click(object sender, EventArgs e)
        {
            pnAccount.Visible = true;
            pnGioiThieu.Visible = false;
            lbHoTen.Text = tbHoTen.Text;
            lbDiaChi.Text = tbDiaChi.Text;
            lbSinhNhat.Text = tbNgaySinh.Text;
            lbGioiTinh.Text = cbGioiTinh.Text;
            lbSoDT.Text = tbSoDT.Text;
            lbEmail.Text = tbEmail.Text;
            Hoten = tbHoTen.Text;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            this.Close();
        }

        private void btnHoatDong_Click(object sender, EventArgs e)
        {
            this.Hide();
            fActivity F = new fActivity();
            F.ShowDialog();
            this.Close();
        }
        public static OpenFileDialog of = new OpenFileDialog();
        private void pbAvatar_Click(object sender, EventArgs e)
        {
            of.ShowDialog();
            pbAvatar.BackgroundImage = new Bitmap(of.FileName);
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            pnAccount.Visible = false;
            pnCaiDat.Visible = true;
        }

        private void btnBack_CaiDat_Click(object sender, EventArgs e)
        {
            pnAccount.Visible = true;
            pnCaiDat.Visible = false;
        }

        public static string NgonNgu = "Tiếng Việt";
        private void btnTiengViet_Click(object sender, EventArgs e)
        {
            btnNgonNgu.Text = "Tiếng Việt";
            fAccount.NgonNgu = "Tiếng Việt";
            pnNgonNgu.Visible = false;
        }

        private void btnEnglish_Click(object sender, EventArgs e)
        {
            btnNgonNgu.Text = "English";
            fAccount.NgonNgu = "English";
            pnNgonNgu.Visible = false;
        }

        private void btnNgonNgu_Click(object sender, EventArgs e)
        {
            pnNgonNgu.Visible = true;
        }

        public static ColorDialog Cl = new ColorDialog();
        public static Color MauNen = Color.LightSeaGreen;
        private void btn_MauSac_3_Click(object sender, EventArgs e)
        {
            Cl.ShowDialog();
            MauNen = Cl.Color;
        }
    }
}
