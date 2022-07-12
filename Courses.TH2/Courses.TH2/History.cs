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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
            ViHistory();
        }

        void ViHistory()
        {
            int Count = 0, Tien = 0, Count_Nhan = 0, Tien_Nhan = 0, Count_Huy = 0, Tien_Huy = 0, Count_Giao = 0, Tien_Giao = 0;
            View_History.Items.Clear();
            string MaDH = "";
            foreach (DataRow row in Cart.DT_History.Rows)
            {
                View_History.SmallImageList = img_List_History;
                string TrangThai = row["Trang Thai"].ToString();
                string Ma = row["MaDH"].ToString();
                string ThoiGian = row["Ngay Dat Hang"].ToString();
                int money = Int32.Parse(row["Thanh Toan"].ToString().Replace(".", ""));
                if (Ma != MaDH)
                {
                    Count += 1;
                    MaDH = Ma;
                    Tien += money;
                    ListViewItem item = new ListViewItem();
                    item.Text = "Đơn hàng : " + Ma.Replace("DH", "");
                    item.SubItems.Add(TrangThai);
                    item.SubItems.Add(ThoiGian);
                    if (TrangThai == "Đã Hủy" || TrangThai == "Đã Giao") { item.ImageIndex = 0; }
                    else { item.ImageIndex = 1; }
                    if (TrangThai == "Đã Hủy") { Count_Huy += 1; Tien_Huy += money; item.ForeColor = Color.Red; }
                    else if (TrangThai == "Đã Giao") { Count_Nhan += 1; Tien_Nhan += money; item.ForeColor = Color.Green; }
                    else if (TrangThai == "Đang Giao Hàng") { Count_Giao += 1; Tien_Giao += money; }
                    View_History.Items.Add(item);
                }
            }
            lb_SoDonHang.Text = "Có tổng cộng " + Count.ToString() + " đơn hàng";
            lb_Giao.Text = "Đang giao hàng : " + Count_Giao.ToString();
            lb_Nhan.Text = "Đã nhận :" + Count_Nhan.ToString();
            lb_Huy.Text = "Đã hủy :" + Count_Huy.ToString();

            lbTien.Text = String.Format("{0:0,0}", Tien);
            lbTienGiao.Text = String.Format("{0:0,0}", Tien_Giao);
            lbTienNhan.Text = String.Format("{0:0,0}", Tien_Nhan);
            lbTienHuy.Text = String.Format("{0:0,0}", Tien_Huy);
        }

        string MaDonHang = "";
        private void View_History_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            lPn_History.Controls.Clear();
            string MaDH = "DH" + e.Item.Text.Replace("Đơn hàng : ", "");
            MaDonHang = MaDH;
            DataRow[] dr = Cart.DT_History.Select("MaDH='" + MaDH + "'");
            lb_TrangThai.Text = dr[0]["Trang Thai"].ToString();
            //lb_TrangThai.Text = dr[0]["Ngay Dat Hang"].ToString();
            lb_HoaDon.Text = dr[0]["Thanh Toan"].ToString();
            tb_NguoiMuaHang.Text = dr[0]["Ho Ten"].ToString();
            lb_GioiTinh.Text = dr[0]["Gioi Tinh"].ToString();
            tb_DiaChi.Text = dr[0]["Dia Chi"].ToString();
            tb_SoDT.Text = dr[0]["SoDT"].ToString();
            NgayDatHang.Value = Convert.ToDateTime(dr[0]["Ngay Dat Hang"].ToString());
            if (dr[0]["Trang Thai"].ToString() == "Đang Giao Hàng")
            {
                btn_HoanTat.Enabled = true;
                btn_Cancel.Enabled = true;
            }    
            else
            {
                btn_HoanTat.Enabled = false;
                btn_Cancel.Enabled = false;
            }
            if (dr[0]["Ly Do"].ToString() != "") { lb_LyDo.Visible = true; }
            else { lb_LyDo.Visible = false; }
            foreach (DataRow row in dr)
            {
                string Ma = row["MaSP"].ToString();
                Ctrl_Cart ctrl_ = new Ctrl_Cart();
                ctrl_.IconSP = Image.FromFile(Application.StartupPath + "\\Image\\" + Ma + ".jpg");
                ctrl_.TenSP = row["TenSP"].ToString();
                ctrl_.GiaSP = row["Gia"].ToString();
                ctrl_.SoLuong = row["So Luong"].ToString();
                lPn_History.Controls.Add(ctrl_);
            }
            lPn_History.Controls.Add(pn_History_HoanTat_01);
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 F = new Form1();
            F.ShowDialog();
            this.Close();
        }

        private void btn_Cart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cart F = new Cart();
            F.ShowDialog();
            this.Close();
        }

        private void btn_HoanTat_Click(object sender, EventArgs e)
        {
            pnThongBao.Visible = true;
            pn_Accept.Visible = true;
        }

        private void btn_DaNhan_Click(object sender, EventArgs e)
        {
            DataRow[] dr = Cart.DT_History.Select("MaDH='" + MaDonHang + "'");
            foreach (DataRow row in dr)
            {
                row["Trang Thai"] = "Đã Giao";
            }
            lb_TrangThai.Text = "Đã Giao";
            Cart.DT_History.AcceptChanges();
            pnThongBao.Visible = false;
            pn_Accept.Visible = false;
            btn_HoanTat.Enabled = false;
            btn_Cancel.Enabled = false;
            ViHistory();
        }

        private void btn_ChuaNhan_Click(object sender, EventArgs e)
        {
            pnThongBao.Visible = false;
            pn_Accept.Visible = false;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            pnThongBao.Visible = true;
            pn_Huy.Visible = true;
        }

        private void btn_Accept_Cancel_Click(object sender, EventArgs e)
        {
            DataRow[] dr = Cart.DT_History.Select("MaDH='" + MaDonHang + "'");
            foreach (DataRow row in dr)
            {
                row["Trang Thai"] = "Đã Hủy";
                row["Ly Do"] = tb_LyDo.Text;
            }
            lb_TrangThai.Text = "Đã Hủy";
            lb_LyDo.Visible = true;
            lb_LyDo.Text = tb_LyDo.Text;
            Cart.DT_History.AcceptChanges();
            pnThongBao.Visible = false;
            pn_Huy.Visible = false;
            btn_HoanTat.Enabled = false;
            btn_Cancel.Enabled = false;
            ViHistory();
        }

        private void btn_Loc_Click(object sender, EventArgs e)
        {
            int Count = 0, Tien = 0, Count_Nhan = 0, Tien_Nhan = 0, Count_Huy = 0, Tien_Huy = 0, Count_Giao = 0, Tien_Giao = 0;
            DateTime date1 = d1.Value;
            DateTime date2 = d2.Value;
            View_History.Items.Clear();
            string MaDH = "";
            foreach (DataRow row in Cart.DT_History.Rows)
            {
                DateTime date = Convert.ToDateTime(row["Ngay Dat Hang"].ToString());
                int result1 = DateTime.Compare(date, date1);
                int result2 = DateTime.Compare(date, date2);

                View_History.LargeImageList = img_List_History;
                View_History.SmallImageList = img_List_History;
                string TrangThai = row["Trang Thai"].ToString();
                string Ma = row["MaDH"].ToString();
                string ThoiGian = row["Ngay Dat Hang"].ToString();
                int money = Int32.Parse(row["Thanh Toan"].ToString().Replace(".", ""));
                if (result1 >= 0 && result2 <=0)
                {
                    if (Ma != MaDH)
                    {
                        Count += 1;
                        MaDH = Ma;
                        Tien += money;
                        ListViewItem item = new ListViewItem();
                        item.Text = "Đơn hàng : " + Ma.Replace("DH", "");
                        item.SubItems.Add(TrangThai);
                        item.SubItems.Add(ThoiGian);
                        if (TrangThai == "Đã Hủy") { Count_Huy += 1; Tien_Huy += money; item.ForeColor = Color.Red; }
                        else if (TrangThai == "Đã Giao") { Count_Nhan += 1; Tien_Nhan += money; item.ForeColor = Color.Green; }
                        else if (TrangThai == "Đang Giao Hàng") { Count_Giao += 1; Tien_Giao += money; }
                        if (TrangThai == "Đã Hủy" || TrangThai == "Đã Giao") { item.ImageIndex = 0; }
                        else { item.ImageIndex = 1; }
                        View_History.Items.Add(item);
                    }
                }
            }
            lb_SoDonHang.Text = "Có tổng cộng " + Count.ToString() + " đơn hàng";
            lb_Giao.Text = "Đang giao hàng : " + Count_Giao.ToString();
            lb_Nhan.Text = "Đã nhận :" + Count_Nhan.ToString();
            lb_Huy.Text = "Đã hủy :" + Count_Huy.ToString();
            lbTien.Text = String.Format("{0:0,0}", Tien);
            lbTienGiao.Text = String.Format("{0:0,0}", Tien_Giao);
            lbTienNhan.Text = String.Format("{0:0,0}", Tien_Nhan);
            lbTienHuy.Text = String.Format("{0:0,0}", Tien_Huy);
        }

        private void btn_Back_LichSu_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
        }
    }
}
