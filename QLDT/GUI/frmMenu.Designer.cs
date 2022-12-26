namespace QLDT
{
    partial class frmMenu
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
            this.btnquanlydiem = new System.Windows.Forms.Button();
            this.btnloai = new System.Windows.Forms.Button();
            this.sidebar = new System.Windows.Forms.Panel();
            this.btnthoat = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnqlsinhvien = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.sidebar.SuspendLayout();
            this.logo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnquanlydiem
            // 
            this.btnquanlydiem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnquanlydiem.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnquanlydiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquanlydiem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquanlydiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnquanlydiem.Location = new System.Drawing.Point(3, 187);
            this.btnquanlydiem.Name = "btnquanlydiem";
            this.btnquanlydiem.Size = new System.Drawing.Size(179, 47);
            this.btnquanlydiem.TabIndex = 0;
            this.btnquanlydiem.Text = "QUẢN LÝ ĐIỂM";
            this.btnquanlydiem.UseVisualStyleBackColor = false;
            this.btnquanlydiem.Click += new System.EventHandler(this.btnquanlydiem_Click);
            // 
            // btnloai
            // 
            this.btnloai.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnloai.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnloai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnloai.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloai.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnloai.Location = new System.Drawing.Point(3, 240);
            this.btnloai.Name = "btnloai";
            this.btnloai.Size = new System.Drawing.Size(179, 58);
            this.btnloai.TabIndex = 0;
            this.btnloai.Text = "QUẢN LÝ XÉT TỐT NGHIỆP";
            this.btnloai.UseVisualStyleBackColor = false;
            this.btnloai.Click += new System.EventHandler(this.btnloai_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sidebar.Controls.Add(this.btnthoat);
            this.sidebar.Controls.Add(this.logo);
            this.sidebar.Controls.Add(this.btnloai);
            this.sidebar.Controls.Add(this.btnquanlydiem);
            this.sidebar.Controls.Add(this.btnqlsinhvien);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(182, 665);
            this.sidebar.TabIndex = 1;
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnthoat.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthoat.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthoat.Location = new System.Drawing.Point(0, 304);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(179, 51);
            this.btnthoat.TabIndex = 1;
            this.btnthoat.Text = "THOÁT";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // logo
            // 
            this.logo.Controls.Add(this.label1);
            this.logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(182, 62);
            this.logo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ SINH VIÊN TGU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnqlsinhvien
            // 
            this.btnqlsinhvien.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnqlsinhvien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnqlsinhvien.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnqlsinhvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnqlsinhvien.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnqlsinhvien.ForeColor = System.Drawing.Color.Transparent;
            this.btnqlsinhvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnqlsinhvien.Location = new System.Drawing.Point(0, 134);
            this.btnqlsinhvien.Name = "btnqlsinhvien";
            this.btnqlsinhvien.Size = new System.Drawing.Size(179, 47);
            this.btnqlsinhvien.TabIndex = 0;
            this.btnqlsinhvien.Text = "QUẢN LÝ SINH VIÊN";
            this.btnqlsinhvien.UseVisualStyleBackColor = false;
            this.btnqlsinhvien.Click += new System.EventHandler(this.btnqlsinhvien_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1130, 665);
            this.Controls.Add(this.sidebar);
            this.IsMdiContainer = true;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU";
            this.TransparencyKey = System.Drawing.Color.White;
            this.sidebar.ResumeLayout(false);
            this.logo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnqlsinhvien;
        private System.Windows.Forms.Button btnquanlydiem;
        private System.Windows.Forms.Button btnloai;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
    }
}

