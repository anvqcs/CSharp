
namespace FinalCSharp
{
    partial class Menu
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlDiemCao = new System.Windows.Forms.Panel();
            this.listHighScore = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_HuongDan = new System.Windows.Forms.Button();
            this.btn_DiemCao = new System.Windows.Forms.Button();
            this.btn_TiepTuc = new System.Windows.Forms.Button();
            this.btn_ChoiMoi = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.pnlDiemCao.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenu.Controls.Add(this.pnlDiemCao);
            this.pnlMenu.Location = new System.Drawing.Point(475, 125);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(634, 470);
            this.pnlMenu.TabIndex = 17;
            this.pnlMenu.Visible = false;
            // 
            // pnlDiemCao
            // 
            this.pnlDiemCao.BackgroundImage = global::FinalCSharp.Properties.Resources.diemcao_final;
            this.pnlDiemCao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDiemCao.Controls.Add(this.listHighScore);
            this.pnlDiemCao.Location = new System.Drawing.Point(3, 3);
            this.pnlDiemCao.Name = "pnlDiemCao";
            this.pnlDiemCao.Size = new System.Drawing.Size(628, 464);
            this.pnlDiemCao.TabIndex = 1;
            this.pnlDiemCao.Visible = false;
            // 
            // listHighScore
            // 
            this.listHighScore.BackgroundImage = global::FinalCSharp.Properties.Resources.back1;
            this.listHighScore.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listHighScore.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listHighScore.ForeColor = System.Drawing.Color.Black;
            this.listHighScore.HideSelection = false;
            this.listHighScore.Location = new System.Drawing.Point(107, 82);
            this.listHighScore.Name = "listHighScore";
            this.listHighScore.Size = new System.Drawing.Size(413, 319);
            this.listHighScore.TabIndex = 0;
            this.listHighScore.UseCompatibleStateImageBehavior = false;
            this.listHighScore.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Xếp Hạng";
            this.columnHeader1.Width = 99;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Người Chơi";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Level";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Điểm";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackgroundImage = global::FinalCSharp.Properties.Resources.exit;
            this.btn_Thoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Thoat.Location = new System.Drawing.Point(100, 540);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(214, 75);
            this.btn_Thoat.TabIndex = 22;
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_HuongDan
            // 
            this.btn_HuongDan.BackgroundImage = global::FinalCSharp.Properties.Resources.guide;
            this.btn_HuongDan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_HuongDan.Location = new System.Drawing.Point(100, 430);
            this.btn_HuongDan.Name = "btn_HuongDan";
            this.btn_HuongDan.Size = new System.Drawing.Size(214, 75);
            this.btn_HuongDan.TabIndex = 21;
            this.btn_HuongDan.UseVisualStyleBackColor = true;
            this.btn_HuongDan.Click += new System.EventHandler(this.btn_HuongDan_Click);
            // 
            // btn_DiemCao
            // 
            this.btn_DiemCao.BackgroundImage = global::FinalCSharp.Properties.Resources.DCao;
            this.btn_DiemCao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DiemCao.Location = new System.Drawing.Point(100, 320);
            this.btn_DiemCao.Name = "btn_DiemCao";
            this.btn_DiemCao.Size = new System.Drawing.Size(214, 75);
            this.btn_DiemCao.TabIndex = 20;
            this.btn_DiemCao.UseVisualStyleBackColor = true;
            this.btn_DiemCao.Click += new System.EventHandler(this.btn_DiemCao_Click);
            // 
            // btn_TiepTuc
            // 
            this.btn_TiepTuc.BackgroundImage = global::FinalCSharp.Properties.Resources.resume;
            this.btn_TiepTuc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_TiepTuc.Location = new System.Drawing.Point(100, 210);
            this.btn_TiepTuc.Name = "btn_TiepTuc";
            this.btn_TiepTuc.Size = new System.Drawing.Size(214, 75);
            this.btn_TiepTuc.TabIndex = 19;
            this.btn_TiepTuc.UseVisualStyleBackColor = true;
            this.btn_TiepTuc.Click += new System.EventHandler(this.btn_TiepTuc_Click);
            // 
            // btn_ChoiMoi
            // 
            this.btn_ChoiMoi.BackgroundImage = global::FinalCSharp.Properties.Resources.choimoi;
            this.btn_ChoiMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ChoiMoi.Location = new System.Drawing.Point(100, 100);
            this.btn_ChoiMoi.Name = "btn_ChoiMoi";
            this.btn_ChoiMoi.Size = new System.Drawing.Size(214, 75);
            this.btn_ChoiMoi.TabIndex = 18;
            this.btn_ChoiMoi.UseVisualStyleBackColor = true;
            this.btn_ChoiMoi.Click += new System.EventHandler(this.btn_ChoiMoi_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalCSharp.Properties.Resources.back_v1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1342, 803);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_HuongDan);
            this.Controls.Add(this.btn_DiemCao);
            this.Controls.Add(this.btn_TiepTuc);
            this.Controls.Add(this.btn_ChoiMoi);
            this.DoubleBuffered = true;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.pnlMenu.ResumeLayout(false);
            this.pnlDiemCao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_HuongDan;
        private System.Windows.Forms.Button btn_DiemCao;
        private System.Windows.Forms.Button btn_TiepTuc;
        private System.Windows.Forms.Button btn_ChoiMoi;
        private System.Windows.Forms.ListView listHighScore;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel pnlDiemCao;
    }
}