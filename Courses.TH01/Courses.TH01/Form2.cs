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
    public partial class fActivity : Form
    {
        public fActivity()
        {
            InitializeComponent();
            lbDonNha.Text = Form1.DonNha;
            lbMayLanh.Text = Form1.MayLanh;
            lbGiatUi.Text = Form1.GiatUi;
            lbDiCho.Text = Form1.DiCho;
            lbNauAn.Text = Form1.NauAn;
            lbTongVeSinh.Text = Form1.TongVeSinh;
            if(fAccount.NgonNgu == "Tiếng Việt")
            {
                lbGioHang.Text = "Thông tin giỏ hàng";
                lbDichVu.Text = "Dịch vụ";
                lbGiaTien.Text = "Giá";
                lbDonNha_.Text = "Dọn dẹp nhà";
                lbMayLanh_.Text = "Vệ sinh máy lạnh";
                lbGiatUi_.Text = "Giặt ủi";
                lbDiCho_.Text = "Đi chợ";
                lbNauAn_.Text = "Nấu ăn";
                lbVeSinh_.Text = "Tổng vệ sinh";
                lbKhuyenMai_.Text = "Khuyễn mãi";
                btnThanhToan.Text = "Thanh toán";
            }    
            else
            {
                lbGioHang.Text = "Cart";
                lbDichVu.Text = "Service";
                lbGiaTien.Text = "Price";
                lbDonNha_.Text = "Cleaning";
                lbMayLanh_.Text = "A/C Service";
                lbGiatUi_.Text = "Laundry";
                lbDiCho_.Text = "Grocery Assistant";
                lbNauAn_.Text = "Home Cooking";
                lbVeSinh_.Text = "Deep Cleaning";
                lbKhuyenMai_.Text = "Promotion";
                btnThanhToan.Text = "Pay";
            }    
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int DonNha = Convert.ToInt32(lbDonNha.Text);
            int MayLanh = Convert.ToInt32(lbMayLanh.Text);
            int GiatUi = Convert.ToInt32(lbGiatUi.Text);
            int DiCho = Convert.ToInt32(lbDiCho.Text);
            int NauAn = Convert.ToInt32(lbNauAn.Text);
            int TongVeSinh = Convert.ToInt32(lbTongVeSinh.Text);
            int KhuyenMai = Convert.ToInt32(tbKhuyenMai.Text);
            int Tien;
            Tien = (DonNha + MayLanh + GiatUi + DiCho + NauAn + TongVeSinh) * (100 - KhuyenMai) / 100;
            //label_ThanhToan.Text = Tien.ToString();
            tbThanhToan.Text = String.Format("{0:0,0}", Tien);
            Form1.DonNha = "0";
            Form1.MayLanh = "0";
            Form1.GiatUi = "0";
            Form1.DiCho = "0";
            Form1.NauAn = "0";
            Form1.TongVeSinh = "0";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
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
