namespace QLBMP
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
            this.frmNhanVien = new System.Windows.Forms.Button();
            this.frmKhachHang = new System.Windows.Forms.Button();
            this.frmHangHoa = new System.Windows.Forms.Button();
            this.frmHoaDon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // frmNhanVien
            // 
            this.frmNhanVien.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmNhanVien.Location = new System.Drawing.Point(57, 66);
            this.frmNhanVien.Name = "frmNhanVien";
            this.frmNhanVien.Size = new System.Drawing.Size(75, 67);
            this.frmNhanVien.TabIndex = 0;
            this.frmNhanVien.Text = "Nhân viên";
            this.frmNhanVien.UseVisualStyleBackColor = true;
            this.frmNhanVien.Click += new System.EventHandler(this.frmNhanVien_Click);
            // 
            // frmKhachHang
            // 
            this.frmKhachHang.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmKhachHang.Location = new System.Drawing.Point(211, 66);
            this.frmKhachHang.Name = "frmKhachHang";
            this.frmKhachHang.Size = new System.Drawing.Size(76, 67);
            this.frmKhachHang.TabIndex = 1;
            this.frmKhachHang.Text = "Khách Hàng";
            this.frmKhachHang.UseVisualStyleBackColor = true;
            this.frmKhachHang.Click += new System.EventHandler(this.frmKhachHang_Click);
            // 
            // frmHangHoa
            // 
            this.frmHangHoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmHangHoa.Location = new System.Drawing.Point(372, 66);
            this.frmHangHoa.Name = "frmHangHoa";
            this.frmHangHoa.Size = new System.Drawing.Size(75, 68);
            this.frmHangHoa.TabIndex = 2;
            this.frmHangHoa.Text = "Hàng Hóa";
            this.frmHangHoa.UseVisualStyleBackColor = true;
            this.frmHangHoa.Click += new System.EventHandler(this.frmHangHoa_Click);
            // 
            // frmHoaDon
            // 
            this.frmHoaDon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmHoaDon.Location = new System.Drawing.Point(540, 65);
            this.frmHoaDon.Name = "frmHoaDon";
            this.frmHoaDon.Size = new System.Drawing.Size(75, 68);
            this.frmHoaDon.TabIndex = 3;
            this.frmHoaDon.Text = "Hóa Đơn";
            this.frmHoaDon.UseVisualStyleBackColor = true;
            this.frmHoaDon.Click += new System.EventHandler(this.frmHoaDon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(257, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "QUẢN LÝ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 145);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.frmHoaDon);
            this.Controls.Add(this.frmHangHoa);
            this.Controls.Add(this.frmKhachHang);
            this.Controls.Add(this.frmNhanVien);
            this.Name = "Form1";
            this.Text = "Phần mền bán mỹ phẩm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button frmNhanVien;
        private System.Windows.Forms.Button frmKhachHang;
        private System.Windows.Forms.Button frmHangHoa;
        private System.Windows.Forms.Button frmHoaDon;
        private System.Windows.Forms.Label label1;
    }
}

