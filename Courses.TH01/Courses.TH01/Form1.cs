using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Courses.TH01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (fAccount.NgonNgu == "Tiếng Việt")
            {
                //Panel Home
                lbXinChao.Text = "Xin chào, " + fAccount.Hoten;
                lbDichVu.Text = "Dịch vụ giúp việc";
                lbDonNha.Text = "Dọn dẹp nhà";
                lbMayLanh.Text = "Vệ sinh \n máy lạnh";
                lbGiatUi.Text = "Giặt ủi";
                lbDiCho.Text = "Đi chợ";
                lbNauAn.Text = "Nấu ăn";
                lbTongVeSinh.Text = "Tổng vệ sinh";
                //Panel dia chi lam viec
                lbDiaChi.Text = "Chọn địa chỉ làm việc";
                lbTinhThanh.Text = "Tỉnh thành :";
                lbQuanHuyen.Text = "Quận / huyện :";
                lbPhuongXa.Text = "Phường / xã :";
                lbSoNha.Text = "Số nhà, tên đường :";
                btnDongY_DiaChi.Text = "Đồng ý";
                // Panel tuy chon nguoi giup viec
                lbNguoiGiupViec.Text = "Tùy chọn người giúp việc";
                lbGioiTinh.Text = "Giới Tính :";
                rbnNam.Text = "Nam";
                rbnNu.Text = "Nữ";
                rbnAll.Text = "Tất cả";
                lbSoTuoi.Text = "Độ tuổi :";
                lbDoTuoiTu.Text = "Độ tuổi từ :";
                lbDen.Text = "Đến :";
                lbDanhGia.Text = "Đánh giá :";
                lbThoiGian.Text = "Thời gian làm việc";
                lbPhiDichVu.Text = "Phí dịch vụ :";
                btnDongY_NguoiGiupViec.Text = "Đồng ý";
                DatLich = "Bạn đã đặt dịch vụ thành công!";
                ThongBao = "Thông báo";
                DaDatLich = "Bạn đã đặt dịch vụ này!";
            }
            else
            {
                //Panel home
                lbXinChao.Text = "Hello, " + fAccount.Hoten;
                lbDichVu.Text = "Service";
                lbDonNha.Text = "Cleaning";
                lbMayLanh.Text = "A/C Service";
                lbGiatUi.Text = "Laundry";
                lbDiCho.Text = "Grocery\nAssistant";
                lbNauAn.Text = "Home\nCooking";
                lbTongVeSinh.Text = "Deep\nCleaning";
                //Panel dia chi lam viec
                lbDiaChi.Text = "Choose location";
                lbTinhThanh.Text = "Province :";
                lbQuanHuyen.Text = "District :";
                lbPhuongXa.Text = "Wards :";
                lbSoNha.Text = "House number, street name :";
                btnDongY_DiaChi.Text = "Confirm";
                //Panel tuy chon nguoi giup viec
                lbNguoiGiupViec.Text = "Choose Tasker";
                lbGioiTinh.Text = "Gender :";
                rbnNam.Text = "Male";
                rbnNu.Text = "Female";
                rbnAll.Text = "All";
                lbSoTuoi.Text = "Age :";
                lbDoTuoiTu.Text = "From :";
                lbDen.Text = "To :";
                lbDanhGia.Text = "Rate :";
                lbThoiGian.Text = "Working time";
                lbPhiDichVu.Text = "Price :";
                btnDongY_NguoiGiupViec.Text = "Confirm";
                DatLich = "You have successfully booked the service!";
                ThongBao = "Message";
                DaDatLich = "You have booked this service!";
            }



            panel2.BackColor = fAccount.MauNen;
        }
        public static string DonNha = "0";
        public static string MayLanh = "0";
        public static string GiatUi = "0";
        public static string DiCho = "0";
        public static string NauAn = "0";
        public static string TongVeSinh = "0";

        private void btnDonNha_Click(object sender, EventArgs e)
        {
            if (DonNha == "0")
            {
                DonNha = "200000";
                lb_Price.Text = "200000";
                pn_Home.Visible = false;
                pn_DiaChi.Visible = true;
            }
            else
            {
                MessageBox.Show(DaDatLich, ThongBao);
            }    
            
        }

        private void btnMayLanh_Click(object sender, EventArgs e)
        {
            if (MayLanh == "0")
            {
                MayLanh = "250000";
                lb_Price.Text = "250000";
                pn_Home.Visible = false;
                pn_DiaChi.Visible = true;
            }
            else
            {
                MessageBox.Show(DaDatLich, ThongBao);
            }
        }

        private void btnGiatUi_Click(object sender, EventArgs e)
        {
            if (GiatUi == "0")
            {
                GiatUi = "100000";
                lb_Price.Text = "100000";
                pn_Home.Visible = false;
                pn_DiaChi.Visible = true;
            }
            else
            {
                MessageBox.Show(DaDatLich, ThongBao);
            }
        }

        private void btnDiCho_Click(object sender, EventArgs e)
        {
            if (DiCho == "0")
            {
                DiCho = "150000";
                lb_Price.Text = "150000";
                pn_Home.Visible = false;
                pn_DiaChi.Visible = true;
            }
            else
            {
                MessageBox.Show(DaDatLich, ThongBao);
            }
        }

        private void btnNauAn_Click(object sender, EventArgs e)
        {
            if (NauAn == "0")
            {
                NauAn = "300000";
                lb_Price.Text = "300000";
                pn_Home.Visible = false;
                pn_DiaChi.Visible = true;
            }
            else
            {
                MessageBox.Show(DaDatLich, ThongBao);
            }
        }

        private void btnTongVeSinh_Click(object sender, EventArgs e)
        {
            if (TongVeSinh == "0")
            {
                TongVeSinh = "400000";
                lb_Price.Text = "400000";
                pn_Home.Visible = false;
                pn_DiaChi.Visible = true;
            }
            else
            {
                MessageBox.Show(DaDatLich, ThongBao);
            }
        }

        private void btn_back_DiaChi_Click(object sender, EventArgs e)
        {
            pn_Home.Visible = true;
            pn_DiaChi.Visible = false;
        }

        private void btnDongY_DiaChi_Click(object sender, EventArgs e)
        {
            pn_DiaChi.Visible = false;
            pn_NguoiGiupViec.Visible = true;
        }

        private void btn_back_NguoiGiupViec_Click(object sender, EventArgs e)
        {
            pn_DiaChi.Visible = true;
            pn_NguoiGiupViec.Visible = false;
        }

        public static string DaDatLich = "Bạn đã đặt dịch vụ này!";
        public static string DatLich = "Bạn đã đặt dịch vụ thành công!";
        public static string ThongBao = "Thông báo";
        private void btnDongY_NguoiGiupViec_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DatLich, ThongBao);
            pn_Home.Visible = true;
            pn_NguoiGiupViec.Visible = false;
        }

        private void btnHoatDong_Click(object sender, EventArgs e)
        {
            this.Hide();
            fActivity F = new fActivity();
            F.ShowDialog();
            this.Close();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            fAccount f = new fAccount();
            f.ShowDialog();
            this.Close();
        }
    }
}
