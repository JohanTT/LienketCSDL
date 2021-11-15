
using System.Data.SqlClient;

namespace TEST
{
    partial class Form1
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.KetNoi = new System.Windows.Forms.Button();
            this.DongKN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MaKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Seach = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.HoTentxt = new System.Windows.Forms.TextBox();
            this.SDTtxt = new System.Windows.Forms.TextBox();
            this.DiaChitxt = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.MaKhachHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenKhachHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoDienThoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tim2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // KetNoi
            // 
            this.KetNoi.Location = new System.Drawing.Point(-2, 415);
            this.KetNoi.Name = "KetNoi";
            this.KetNoi.Size = new System.Drawing.Size(98, 23);
            this.KetNoi.TabIndex = 0;
            this.KetNoi.Text = "Mở Kết Nối";
            this.KetNoi.UseVisualStyleBackColor = true;
            this.KetNoi.Click += new System.EventHandler(this.KetNoi_Click);
            // 
            // DongKN
            // 
            this.DongKN.Location = new System.Drawing.Point(184, 415);
            this.DongKN.Name = "DongKN";
            this.DongKN.Size = new System.Drawing.Size(105, 23);
            this.DongKN.TabIndex = 1;
            this.DongKN.Text = "Đóng Kết Nối";
            this.DongKN.UseVisualStyleBackColor = true;
            this.DongKN.Click += new System.EventHandler(this.DongKN_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 78);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(262, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Helo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MaKH
            // 
            this.MaKH.Location = new System.Drawing.Point(99, 90);
            this.MaKH.Name = "MaKH";
            this.MaKH.Size = new System.Drawing.Size(100, 20);
            this.MaKH.TabIndex = 4;
            this.MaKH.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã khách hàng:";
            // 
            // Seach
            // 
            this.Seach.Location = new System.Drawing.Point(213, 90);
            this.Seach.Name = "Seach";
            this.Seach.Size = new System.Drawing.Size(59, 27);
            this.Seach.TabIndex = 6;
            this.Seach.Text = "Tìm";
            this.Seach.UseVisualStyleBackColor = true;
            this.Seach.Click += new System.EventHandler(this.Seach_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Họ và Tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số Điện Thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Địa chỉ:";
            // 
            // HoTentxt
            // 
            this.HoTentxt.Location = new System.Drawing.Point(99, 139);
            this.HoTentxt.Name = "HoTentxt";
            this.HoTentxt.Size = new System.Drawing.Size(135, 20);
            this.HoTentxt.TabIndex = 7;
            // 
            // SDTtxt
            // 
            this.SDTtxt.Location = new System.Drawing.Point(99, 171);
            this.SDTtxt.Name = "SDTtxt";
            this.SDTtxt.Size = new System.Drawing.Size(135, 20);
            this.SDTtxt.TabIndex = 7;
            // 
            // DiaChitxt
            // 
            this.DiaChitxt.Location = new System.Drawing.Point(99, 201);
            this.DiaChitxt.Name = "DiaChitxt";
            this.DiaChitxt.Size = new System.Drawing.Size(135, 20);
            this.DiaChitxt.TabIndex = 7;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaKhachHang,
            this.TenKhachHang,
            this.SoDienThoai,
            this.DiaChi});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(351, 93);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(515, 322);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.Text = "MaKhachHang";
            this.MaKhachHang.Width = 96;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.Text = "TenKhachHang";
            this.TenKhachHang.Width = 103;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.Text = "SoDienThoai";
            this.SoDienThoai.Width = 85;
            // 
            // DiaChi
            // 
            this.DiaChi.Text = "DiaChi";
            this.DiaChi.Width = 61;
            // 
            // Tim2
            // 
            this.Tim2.Location = new System.Drawing.Point(603, 421);
            this.Tim2.Name = "Tim2";
            this.Tim2.Size = new System.Drawing.Size(117, 23);
            this.Tim2.TabIndex = 9;
            this.Tim2.Text = "Tìm";
            this.Tim2.UseVisualStyleBackColor = true;
            this.Tim2.Click += new System.EventHandler(this.Tim2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 450);
            this.Controls.Add(this.Tim2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.DiaChitxt);
            this.Controls.Add(this.SDTtxt);
            this.Controls.Add(this.HoTentxt);
            this.Controls.Add(this.Seach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaKH);
            this.Controls.Add(this.DongKN);
            this.Controls.Add(this.KetNoi);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KetNoi;
        private System.Windows.Forms.Button DongKN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MaKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Seach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox HoTentxt;
        private System.Windows.Forms.TextBox SDTtxt;
        private System.Windows.Forms.TextBox DiaChitxt;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader MaKhachHang;
        private System.Windows.Forms.ColumnHeader TenKhachHang;
        private System.Windows.Forms.ColumnHeader SoDienThoai;
        private System.Windows.Forms.ColumnHeader DiaChi;
        private System.Windows.Forms.Button Tim2;
    }
}

