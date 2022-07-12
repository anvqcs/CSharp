
namespace FinalCSharp
{
    partial class Pikachu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pikachu));
            this.lbPercent = new System.Windows.Forms.Label();
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.pic_GoiY = new System.Windows.Forms.PictureBox();
            this.pic_Home = new System.Windows.Forms.PictureBox();
            this.pic_TamDung = new System.Windows.Forms.PictureBox();
            this.pic_AmThanh = new System.Windows.Forms.PictureBox();
            this.ptb_progressBar = new System.Windows.Forms.PictureBox();
            this.ProgressBar = new System.Windows.Forms.PictureBox();
            this.lb_Level = new System.Windows.Forms.Label();
            this.lb_Score = new System.Windows.Forms.Label();
            this.lb_Hint = new System.Windows.Forms.Label();
            this.pnl_ChuDe = new System.Windows.Forms.Panel();
            this.Pic_Food = new System.Windows.Forms.PictureBox();
            this.pic_TraiCay = new System.Windows.Forms.PictureBox();
            this.pic_Pokemon = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pic_ChuDe = new System.Windows.Forms.PictureBox();
            this.pnlThanhTich = new System.Windows.Forms.Panel();
            this.pic_Accept = new System.Windows.Forms.PictureBox();
            this.btn_Out = new System.Windows.Forms.Label();
            this.tb_User = new System.Windows.Forms.TextBox();
            this.lb_Score_TT = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pnlOption = new System.Windows.Forms.Panel();
            this.pic_BackColor = new System.Windows.Forms.PictureBox();
            this.pic_Share = new System.Windows.Forms.PictureBox();
            this.pic_SaveBanCo = new System.Windows.Forms.PictureBox();
            this.pic_LoadBanCo = new System.Windows.Forms.PictureBox();
            this.pic_Win = new System.Windows.Forms.PictureBox();
            this.BGMusic = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pic_GoiY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TamDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AmThanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_progressBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBar)).BeginInit();
            this.pnl_ChuDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Food)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TraiCay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Pokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ChuDe)).BeginInit();
            this.pnlThanhTich.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Accept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnlOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_BackColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Share)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SaveBanCo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LoadBanCo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Win)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPercent
            // 
            this.lbPercent.AutoSize = true;
            this.lbPercent.BackColor = System.Drawing.Color.Transparent;
            this.lbPercent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPercent.Location = new System.Drawing.Point(519, 28);
            this.lbPercent.Name = "lbPercent";
            this.lbPercent.Size = new System.Drawing.Size(28, 23);
            this.lbPercent.TabIndex = 19;
            this.lbPercent.Text = "%";
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.AutoSize = true;
            this.pnlChessBoard.BackColor = System.Drawing.Color.Transparent;
            this.pnlChessBoard.Location = new System.Drawing.Point(142, 73);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(193, 173);
            this.pnlChessBoard.TabIndex = 17;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // pic_GoiY
            // 
            this.pic_GoiY.BackColor = System.Drawing.Color.Transparent;
            this.pic_GoiY.BackgroundImage = global::FinalCSharp.Properties.Resources.hint_final;
            this.pic_GoiY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_GoiY.Location = new System.Drawing.Point(1144, 14);
            this.pic_GoiY.Name = "pic_GoiY";
            this.pic_GoiY.Size = new System.Drawing.Size(50, 50);
            this.pic_GoiY.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_GoiY.TabIndex = 24;
            this.pic_GoiY.TabStop = false;
            this.pic_GoiY.Click += new System.EventHandler(this.pic_GoiY_Click);
            // 
            // pic_Home
            // 
            this.pic_Home.BackColor = System.Drawing.Color.Transparent;
            this.pic_Home.BackgroundImage = global::FinalCSharp.Properties.Resources.home_new;
            this.pic_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Home.Location = new System.Drawing.Point(1075, 14);
            this.pic_Home.Name = "pic_Home";
            this.pic_Home.Size = new System.Drawing.Size(50, 50);
            this.pic_Home.TabIndex = 23;
            this.pic_Home.TabStop = false;
            this.pic_Home.Click += new System.EventHandler(this.pic_Home_Click);
            // 
            // pic_TamDung
            // 
            this.pic_TamDung.BackColor = System.Drawing.Color.Transparent;
            this.pic_TamDung.BackgroundImage = global::FinalCSharp.Properties.Resources.pause_new;
            this.pic_TamDung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_TamDung.Location = new System.Drawing.Point(1019, 14);
            this.pic_TamDung.Name = "pic_TamDung";
            this.pic_TamDung.Size = new System.Drawing.Size(50, 50);
            this.pic_TamDung.TabIndex = 22;
            this.pic_TamDung.TabStop = false;
            this.pic_TamDung.Click += new System.EventHandler(this.pic_TamDung_Click);
            // 
            // pic_AmThanh
            // 
            this.pic_AmThanh.BackColor = System.Drawing.Color.Transparent;
            this.pic_AmThanh.BackgroundImage = global::FinalCSharp.Properties.Resources.sound;
            this.pic_AmThanh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_AmThanh.Location = new System.Drawing.Point(963, 14);
            this.pic_AmThanh.Name = "pic_AmThanh";
            this.pic_AmThanh.Size = new System.Drawing.Size(50, 50);
            this.pic_AmThanh.TabIndex = 21;
            this.pic_AmThanh.TabStop = false;
            this.pic_AmThanh.Click += new System.EventHandler(this.pic_AmThanh_Click);
            // 
            // ptb_progressBar
            // 
            this.ptb_progressBar.Location = new System.Drawing.Point(198, 21);
            this.ptb_progressBar.Name = "ptb_progressBar";
            this.ptb_progressBar.Size = new System.Drawing.Size(661, 36);
            this.ptb_progressBar.TabIndex = 18;
            this.ptb_progressBar.TabStop = false;
            // 
            // ProgressBar
            // 
            this.ProgressBar.BackgroundImage = global::FinalCSharp.Properties.Resources.bbbbbbb;
            this.ProgressBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProgressBar.Location = new System.Drawing.Point(122, 14);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(820, 50);
            this.ProgressBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProgressBar.TabIndex = 20;
            this.ProgressBar.TabStop = false;
            // 
            // lb_Level
            // 
            this.lb_Level.AutoSize = true;
            this.lb_Level.BackColor = System.Drawing.Color.Orange;
            this.lb_Level.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Level.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_Level.Location = new System.Drawing.Point(61, 291);
            this.lb_Level.Name = "lb_Level";
            this.lb_Level.Size = new System.Drawing.Size(78, 26);
            this.lb_Level.TabIndex = 27;
            this.lb_Level.Text = "Màn 1";
            // 
            // lb_Score
            // 
            this.lb_Score.AutoSize = true;
            this.lb_Score.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Score.ForeColor = System.Drawing.Color.Orange;
            this.lb_Score.Location = new System.Drawing.Point(23, 376);
            this.lb_Score.Name = "lb_Score";
            this.lb_Score.Size = new System.Drawing.Size(138, 26);
            this.lb_Score.TabIndex = 28;
            this.lb_Score.Text = "Score : 0000";
            // 
            // lb_Hint
            // 
            this.lb_Hint.AutoSize = true;
            this.lb_Hint.BackColor = System.Drawing.Color.SaddleBrown;
            this.lb_Hint.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Hint.Location = new System.Drawing.Point(1179, 14);
            this.lb_Hint.Name = "lb_Hint";
            this.lb_Hint.Size = new System.Drawing.Size(24, 26);
            this.lb_Hint.TabIndex = 29;
            this.lb_Hint.Text = "2";
            // 
            // pnl_ChuDe
            // 
            this.pnl_ChuDe.BackColor = System.Drawing.Color.Transparent;
            this.pnl_ChuDe.BackgroundImage = global::FinalCSharp.Properties.Resources.back_chude;
            this.pnl_ChuDe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_ChuDe.Controls.Add(this.Pic_Food);
            this.pnl_ChuDe.Controls.Add(this.pic_TraiCay);
            this.pnl_ChuDe.Controls.Add(this.pic_Pokemon);
            this.pnl_ChuDe.Controls.Add(this.pictureBox3);
            this.pnl_ChuDe.Controls.Add(this.pictureBox2);
            this.pnl_ChuDe.Controls.Add(this.pictureBox1);
            this.pnl_ChuDe.Location = new System.Drawing.Point(40, 757);
            this.pnl_ChuDe.Name = "pnl_ChuDe";
            this.pnl_ChuDe.Size = new System.Drawing.Size(1225, 654);
            this.pnl_ChuDe.TabIndex = 31;
            this.pnl_ChuDe.Visible = false;
            // 
            // Pic_Food
            // 
            this.Pic_Food.BackgroundImage = global::FinalCSharp.Properties.Resources.Group_48;
            this.Pic_Food.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pic_Food.Location = new System.Drawing.Point(933, 529);
            this.Pic_Food.Name = "Pic_Food";
            this.Pic_Food.Size = new System.Drawing.Size(162, 60);
            this.Pic_Food.TabIndex = 5;
            this.Pic_Food.TabStop = false;
            this.Pic_Food.Click += new System.EventHandler(this.Pic_Food_Click);
            // 
            // pic_TraiCay
            // 
            this.pic_TraiCay.BackgroundImage = global::FinalCSharp.Properties.Resources.Group_50;
            this.pic_TraiCay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_TraiCay.Location = new System.Drawing.Point(539, 529);
            this.pic_TraiCay.Name = "pic_TraiCay";
            this.pic_TraiCay.Size = new System.Drawing.Size(162, 60);
            this.pic_TraiCay.TabIndex = 4;
            this.pic_TraiCay.TabStop = false;
            this.pic_TraiCay.Click += new System.EventHandler(this.pic_TraiCay_Click);
            // 
            // pic_Pokemon
            // 
            this.pic_Pokemon.BackgroundImage = global::FinalCSharp.Properties.Resources.Group_49;
            this.pic_Pokemon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Pokemon.Location = new System.Drawing.Point(143, 529);
            this.pic_Pokemon.Name = "pic_Pokemon";
            this.pic_Pokemon.Size = new System.Drawing.Size(162, 60);
            this.pic_Pokemon.TabIndex = 3;
            this.pic_Pokemon.TabStop = false;
            this.pic_Pokemon.Click += new System.EventHandler(this.pic_Pokemon_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::FinalCSharp.Properties.Resources.food;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(843, 206);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(300, 300);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::FinalCSharp.Properties.Resources.traicay;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(463, 206);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 300);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::FinalCSharp.Properties.Resources.pokemon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(83, 206);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pic_ChuDe
            // 
            this.pic_ChuDe.BackColor = System.Drawing.Color.Transparent;
            this.pic_ChuDe.BackgroundImage = global::FinalCSharp.Properties.Resources.Man;
            this.pic_ChuDe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_ChuDe.Location = new System.Drawing.Point(28, 18);
            this.pic_ChuDe.Name = "pic_ChuDe";
            this.pic_ChuDe.Size = new System.Drawing.Size(150, 95);
            this.pic_ChuDe.TabIndex = 32;
            this.pic_ChuDe.TabStop = false;
            this.pic_ChuDe.Click += new System.EventHandler(this.pic_ChuDe_Click);
            // 
            // pnlThanhTich
            // 
            this.pnlThanhTich.BackgroundImage = global::FinalCSharp.Properties.Resources.thanhtich;
            this.pnlThanhTich.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlThanhTich.Controls.Add(this.pic_Accept);
            this.pnlThanhTich.Controls.Add(this.btn_Out);
            this.pnlThanhTich.Controls.Add(this.tb_User);
            this.pnlThanhTich.Controls.Add(this.lb_Score_TT);
            this.pnlThanhTich.Location = new System.Drawing.Point(410, 309);
            this.pnlThanhTich.Name = "pnlThanhTich";
            this.pnlThanhTich.Size = new System.Drawing.Size(440, 325);
            this.pnlThanhTich.TabIndex = 33;
            this.pnlThanhTich.Visible = false;
            // 
            // pic_Accept
            // 
            this.pic_Accept.BackColor = System.Drawing.Color.Transparent;
            this.pic_Accept.BackgroundImage = global::FinalCSharp.Properties.Resources.xacnhan;
            this.pic_Accept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Accept.Location = new System.Drawing.Point(148, 253);
            this.pic_Accept.Name = "pic_Accept";
            this.pic_Accept.Size = new System.Drawing.Size(140, 50);
            this.pic_Accept.TabIndex = 42;
            this.pic_Accept.TabStop = false;
            this.pic_Accept.Click += new System.EventHandler(this.pic_Accept_Click);
            // 
            // btn_Out
            // 
            this.btn_Out.AutoSize = true;
            this.btn_Out.BackColor = System.Drawing.Color.Transparent;
            this.btn_Out.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Out.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Out.Location = new System.Drawing.Point(381, 296);
            this.btn_Out.Name = "btn_Out";
            this.btn_Out.Size = new System.Drawing.Size(47, 19);
            this.btn_Out.TabIndex = 41;
            this.btn_Out.Text = "Thoát";
            this.btn_Out.Click += new System.EventHandler(this.btn_Out_Click);
            // 
            // tb_User
            // 
            this.tb_User.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_User.ForeColor = System.Drawing.Color.DarkRed;
            this.tb_User.Location = new System.Drawing.Point(204, 129);
            this.tb_User.Name = "tb_User";
            this.tb_User.Size = new System.Drawing.Size(178, 30);
            this.tb_User.TabIndex = 38;
            // 
            // lb_Score_TT
            // 
            this.lb_Score_TT.AutoSize = true;
            this.lb_Score_TT.BackColor = System.Drawing.Color.Transparent;
            this.lb_Score_TT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Score_TT.ForeColor = System.Drawing.Color.Crimson;
            this.lb_Score_TT.Location = new System.Drawing.Point(262, 201);
            this.lb_Score_TT.Name = "lb_Score_TT";
            this.lb_Score_TT.Size = new System.Drawing.Size(60, 23);
            this.lb_Score_TT.TabIndex = 29;
            this.lb_Score_TT.Text = "00000";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::FinalCSharp.Properties.Resources.Back3;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(28, 255);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(150, 95);
            this.pictureBox4.TabIndex = 34;
            this.pictureBox4.TabStop = false;
            // 
            // pnlOption
            // 
            this.pnlOption.BackColor = System.Drawing.Color.Transparent;
            this.pnlOption.Controls.Add(this.pic_BackColor);
            this.pnlOption.Controls.Add(this.pic_Share);
            this.pnlOption.Controls.Add(this.pic_SaveBanCo);
            this.pnlOption.Controls.Add(this.pic_LoadBanCo);
            this.pnlOption.Controls.Add(this.pic_ChuDe);
            this.pnlOption.Controls.Add(this.lb_Level);
            this.pnlOption.Controls.Add(this.lb_Score);
            this.pnlOption.Controls.Add(this.pictureBox4);
            this.pnlOption.Location = new System.Drawing.Point(1133, 95);
            this.pnlOption.Name = "pnlOption";
            this.pnlOption.Size = new System.Drawing.Size(197, 668);
            this.pnlOption.TabIndex = 35;
            // 
            // pic_BackColor
            // 
            this.pic_BackColor.BackColor = System.Drawing.Color.Transparent;
            this.pic_BackColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_BackColor.Image = global::FinalCSharp.Properties.Resources.doimau2;
            this.pic_BackColor.Location = new System.Drawing.Point(28, 134);
            this.pic_BackColor.Name = "pic_BackColor";
            this.pic_BackColor.Size = new System.Drawing.Size(150, 95);
            this.pic_BackColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_BackColor.TabIndex = 43;
            this.pic_BackColor.TabStop = false;
            this.pic_BackColor.Click += new System.EventHandler(this.pic_BackColor_Click);
            // 
            // pic_Share
            // 
            this.pic_Share.BackColor = System.Drawing.Color.Transparent;
            this.pic_Share.BackgroundImage = global::FinalCSharp.Properties.Resources.share;
            this.pic_Share.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Share.Location = new System.Drawing.Point(35, 572);
            this.pic_Share.Name = "pic_Share";
            this.pic_Share.Size = new System.Drawing.Size(140, 50);
            this.pic_Share.TabIndex = 42;
            this.pic_Share.TabStop = false;
            this.pic_Share.Click += new System.EventHandler(this.pic_Share_Click);
            // 
            // pic_SaveBanCo
            // 
            this.pic_SaveBanCo.BackColor = System.Drawing.Color.Transparent;
            this.pic_SaveBanCo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_SaveBanCo.BackgroundImage")));
            this.pic_SaveBanCo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_SaveBanCo.Location = new System.Drawing.Point(35, 420);
            this.pic_SaveBanCo.Name = "pic_SaveBanCo";
            this.pic_SaveBanCo.Size = new System.Drawing.Size(140, 50);
            this.pic_SaveBanCo.TabIndex = 41;
            this.pic_SaveBanCo.TabStop = false;
            this.pic_SaveBanCo.Click += new System.EventHandler(this.pic_SaveBanCo_Click);
            // 
            // pic_LoadBanCo
            // 
            this.pic_LoadBanCo.BackColor = System.Drawing.Color.Transparent;
            this.pic_LoadBanCo.BackgroundImage = global::FinalCSharp.Properties.Resources.open_final;
            this.pic_LoadBanCo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_LoadBanCo.Location = new System.Drawing.Point(35, 498);
            this.pic_LoadBanCo.Name = "pic_LoadBanCo";
            this.pic_LoadBanCo.Size = new System.Drawing.Size(140, 50);
            this.pic_LoadBanCo.TabIndex = 40;
            this.pic_LoadBanCo.TabStop = false;
            this.pic_LoadBanCo.Click += new System.EventHandler(this.pic_LoadBanCo_Click);
            // 
            // pic_Win
            // 
            this.pic_Win.BackColor = System.Drawing.Color.Transparent;
            this.pic_Win.BackgroundImage = global::FinalCSharp.Properties.Resources.temp4;
            this.pic_Win.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Win.Location = new System.Drawing.Point(507, 95);
            this.pic_Win.Name = "pic_Win";
            this.pic_Win.Size = new System.Drawing.Size(353, 179);
            this.pic_Win.TabIndex = 36;
            this.pic_Win.TabStop = false;
            this.pic_Win.Visible = false;
            // 
            // BGMusic
            // 
            this.BGMusic.Enabled = true;
            this.BGMusic.Location = new System.Drawing.Point(904, 504);
            this.BGMusic.Name = "BGMusic";
            this.BGMusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("BGMusic.OcxState")));
            this.BGMusic.Size = new System.Drawing.Size(204, 61);
            this.BGMusic.TabIndex = 38;
            this.BGMusic.Visible = false;
            // 
            // Pikachu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalCSharp.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1342, 803);
            this.Controls.Add(this.BGMusic);
            this.Controls.Add(this.pic_Win);
            this.Controls.Add(this.pnl_ChuDe);
            this.Controls.Add(this.pnlOption);
            this.Controls.Add(this.pnlThanhTich);
            this.Controls.Add(this.lb_Hint);
            this.Controls.Add(this.pic_GoiY);
            this.Controls.Add(this.pic_Home);
            this.Controls.Add(this.pic_TamDung);
            this.Controls.Add(this.pic_AmThanh);
            this.Controls.Add(this.lbPercent);
            this.Controls.Add(this.ptb_progressBar);
            this.Controls.Add(this.pnlChessBoard);
            this.Controls.Add(this.ProgressBar);
            this.DoubleBuffered = true;
            this.Name = "Pikachu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pikachu";
            ((System.ComponentModel.ISupportInitialize)(this.pic_GoiY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TamDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AmThanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_progressBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBar)).EndInit();
            this.pnl_ChuDe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Food)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TraiCay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Pokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ChuDe)).EndInit();
            this.pnlThanhTich.ResumeLayout(false);
            this.pnlThanhTich.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Accept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnlOption.ResumeLayout(false);
            this.pnlOption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_BackColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Share)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SaveBanCo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LoadBanCo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Win)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGMusic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pic_GoiY;
        private System.Windows.Forms.PictureBox pic_Home;
        private System.Windows.Forms.PictureBox pic_TamDung;
        private System.Windows.Forms.PictureBox pic_AmThanh;
        private System.Windows.Forms.Label lbPercent;
        private System.Windows.Forms.PictureBox ptb_progressBar;
        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.PictureBox ProgressBar;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label lb_Level;
        private System.Windows.Forms.Label lb_Score;
        private System.Windows.Forms.Label lb_Hint;
        private System.Windows.Forms.Panel pnl_ChuDe;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pic_ChuDe;
        private System.Windows.Forms.Panel pnlThanhTich;
        private System.Windows.Forms.TextBox tb_User;
        private System.Windows.Forms.Label lb_Score_TT;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel pnlOption;
        private System.Windows.Forms.Label btn_Out;
        private System.Windows.Forms.PictureBox Pic_Food;
        private System.Windows.Forms.PictureBox pic_TraiCay;
        private System.Windows.Forms.PictureBox pic_Pokemon;
        private System.Windows.Forms.PictureBox pic_LoadBanCo;
        private System.Windows.Forms.PictureBox pic_SaveBanCo;
        private System.Windows.Forms.PictureBox pic_Share;
        private System.Windows.Forms.PictureBox pic_BackColor;
        private System.Windows.Forms.PictureBox pic_Accept;
        private System.Windows.Forms.PictureBox pic_Win;
        private AxWMPLib.AxWindowsMediaPlayer BGMusic;
    }
}