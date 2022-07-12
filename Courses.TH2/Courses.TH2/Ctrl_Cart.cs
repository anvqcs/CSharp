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
    public partial class Ctrl_Cart : UserControl
    {
        public Ctrl_Cart()
        {
            InitializeComponent();
        }
        private string _name;
        private string _gia;
        private string _soluong;
        private Image _image;

        [Category("Customs Props")]
        public string TenSP
        {
            get { return _name; }
            set { _name = value; lb_Name.Text = value; }
        }


        [Category("Customs Props")]
        public string GiaSP
        {
            get { return _gia; }
            set { _gia = value; lb_Gia.Text = value; }
        }


        [Category("Customs Props")]
        public string SoLuong
        {
            get { return _soluong; }
            set { _soluong = value; lb_Soluong.Text = value; }
        }


        [Category("Customs Props")]
        public Image IconSP
        {
            get { return _image; }
            set { _image = value; pic_Image.Image = value; }
        }
    }
}
