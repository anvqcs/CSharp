
namespace Courses.TH2
{
    partial class Ctrl_Cart
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_Gia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.pic_Image = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Soluong = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lb_Soluong);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lb_Gia);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lb_Name);
            this.panel1.Controls.Add(this.pic_Image);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 127);
            this.panel1.TabIndex = 0;
            // 
            // lb_Gia
            // 
            this.lb_Gia.AutoSize = true;
            this.lb_Gia.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Gia.Location = new System.Drawing.Point(199, 97);
            this.lb_Gia.Name = "lb_Gia";
            this.lb_Gia.Size = new System.Drawing.Size(18, 19);
            this.lb_Gia.TabIndex = 6;
            this.lb_Gia.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Giá :";
            // 
            // lb_Name
            // 
            this.lb_Name.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.Location = new System.Drawing.Point(106, 12);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(318, 42);
            this.lb_Name.TabIndex = 1;
            this.lb_Name.Text = "label1";
            // 
            // pic_Image
            // 
            this.pic_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Image.Location = new System.Drawing.Point(12, 12);
            this.pic_Image.Name = "pic_Image";
            this.pic_Image.Size = new System.Drawing.Size(80, 72);
            this.pic_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Image.TabIndex = 0;
            this.pic_Image.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Số lượng :";
            // 
            // lb_Soluong
            // 
            this.lb_Soluong.AutoSize = true;
            this.lb_Soluong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Soluong.Location = new System.Drawing.Point(199, 71);
            this.lb_Soluong.Name = "lb_Soluong";
            this.lb_Soluong.Size = new System.Drawing.Size(18, 19);
            this.lb_Soluong.TabIndex = 8;
            this.lb_Soluong.Text = "0";
            // 
            // Ctrl_Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Name = "Ctrl_Cart";
            this.Size = new System.Drawing.Size(433, 132);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.PictureBox pic_Image;
        private System.Windows.Forms.Label lb_Gia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Soluong;
        private System.Windows.Forms.Label label2;
    }
}
