namespace QLDT.GUI
{
    partial class frmDiem
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
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpngaysinh = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbogioitinh = new System.Windows.Forms.ComboBox();
            this.txtnganh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gvdanhsach = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdiemquatrinh = new System.Windows.Forms.TextBox();
            this.txtdiemgiuahp = new System.Windows.Forms.TextBox();
            this.labelxx = new System.Windows.Forms.Label();
            this.txtdiemketthuc = new System.Windows.Forms.TextBox();
            this.label11111 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvdanhsach)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(506, 338);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(113, 41);
            this.btnthoat.TabIndex = 6;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(387, 338);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(113, 41);
            this.btnxoa.TabIndex = 7;
            this.btnxoa.Text = "Xoá";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(149, 338);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(113, 41);
            this.btnluu.TabIndex = 8;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(268, 338);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(113, 41);
            this.btnsua.TabIndex = 9;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpngaysinh);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbogioitinh);
            this.groupBox1.Controls.Add(this.txtnganh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtten);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtma);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(46, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 259);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // dtpngaysinh
            // 
            this.dtpngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpngaysinh.Location = new System.Drawing.Point(93, 171);
            this.dtpngaysinh.Name = "dtpngaysinh";
            this.dtpngaysinh.Size = new System.Drawing.Size(216, 20);
            this.dtpngaysinh.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ngày sinh";
            // 
            // cbogioitinh
            // 
            this.cbogioitinh.FormattingEnabled = true;
            this.cbogioitinh.Location = new System.Drawing.Point(93, 125);
            this.cbogioitinh.Name = "cbogioitinh";
            this.cbogioitinh.Size = new System.Drawing.Size(216, 21);
            this.cbogioitinh.TabIndex = 2;
            // 
            // txtnganh
            // 
            this.txtnganh.Location = new System.Drawing.Point(93, 212);
            this.txtnganh.Name = "txtnganh";
            this.txtnganh.Size = new System.Drawing.Size(216, 20);
            this.txtnganh.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngành";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giới tính";
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(93, 76);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(216, 20);
            this.txtten.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên sinh viên";
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(93, 28);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(216, 20);
            this.txtma.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sinh viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "QUẢN LÝ ĐIỂM";
            // 
            // gvdanhsach
            // 
            this.gvdanhsach.AllowUserToOrderColumns = true;
            this.gvdanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvdanhsach.Location = new System.Drawing.Point(46, 395);
            this.gvdanhsach.Name = "gvdanhsach";
            this.gvdanhsach.Size = new System.Drawing.Size(674, 189);
            this.gvdanhsach.TabIndex = 11;
            this.gvdanhsach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvdanhsach_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtdiemketthuc);
            this.groupBox2.Controls.Add(this.label11111);
            this.groupBox2.Controls.Add(this.txtdiemgiuahp);
            this.groupBox2.Controls.Add(this.labelxx);
            this.groupBox2.Controls.Add(this.txtdiemquatrinh);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(421, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 259);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Điểm sinh viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Điểm quá trình";
            // 
            // txtdiemquatrinh
            // 
            this.txtdiemquatrinh.Location = new System.Drawing.Point(114, 37);
            this.txtdiemquatrinh.Name = "txtdiemquatrinh";
            this.txtdiemquatrinh.Size = new System.Drawing.Size(171, 20);
            this.txtdiemquatrinh.TabIndex = 1;
            // 
            // txtdiemgiuahp
            // 
            this.txtdiemgiuahp.Location = new System.Drawing.Point(114, 76);
            this.txtdiemgiuahp.Name = "txtdiemgiuahp";
            this.txtdiemgiuahp.Size = new System.Drawing.Size(171, 20);
            this.txtdiemgiuahp.TabIndex = 3;
            // 
            // labelxx
            // 
            this.labelxx.AutoSize = true;
            this.labelxx.Location = new System.Drawing.Point(6, 79);
            this.labelxx.Name = "labelxx";
            this.labelxx.Size = new System.Drawing.Size(102, 13);
            this.labelxx.TabIndex = 2;
            this.labelxx.Text = "Điểm giữa học phần";
            // 
            // txtdiemketthuc
            // 
            this.txtdiemketthuc.Location = new System.Drawing.Point(114, 121);
            this.txtdiemketthuc.Name = "txtdiemketthuc";
            this.txtdiemketthuc.Size = new System.Drawing.Size(171, 20);
            this.txtdiemketthuc.TabIndex = 5;
            // 
            // label11111
            // 
            this.label11111.AutoSize = true;
            this.label11111.Location = new System.Drawing.Point(6, 124);
            this.label11111.Name = "label11111";
            this.label11111.Size = new System.Drawing.Size(73, 13);
            this.label11111.TabIndex = 4;
            this.label11111.Text = "Điểm kết thúc";
            // 
            // frmDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 611);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gvdanhsach);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDiem";
            this.Load += new System.EventHandler(this.frmDiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvdanhsach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtnganh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvdanhsach;
        private System.Windows.Forms.ComboBox cbogioitinh;
        private System.Windows.Forms.DateTimePicker dtpngaysinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtdiemketthuc;
        private System.Windows.Forms.Label label11111;
        private System.Windows.Forms.TextBox txtdiemgiuahp;
        private System.Windows.Forms.Label labelxx;
        private System.Windows.Forms.TextBox txtdiemquatrinh;
        private System.Windows.Forms.Label label7;
    }
}