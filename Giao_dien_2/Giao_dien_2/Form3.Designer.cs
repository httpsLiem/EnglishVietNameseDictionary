namespace Giao_dien_2
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCapNhatTu = new System.Windows.Forms.Button();
            this.btnDocFromTxt = new System.Windows.Forms.Button();
            this.btnSaveToTxT = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThemTu = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnTimTu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTu = new System.Windows.Forms.Label();
            this.lblNghia = new System.Windows.Forms.Label();
            this.lblViDu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TuLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nghia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViDu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTu = new System.Windows.Forms.TextBox();
            this.txtNghia = new System.Windows.Forms.TextBox();
            this.txtViDu = new System.Windows.Forms.TextBox();
            this.txtTuLoai = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel2.Controls.Add(this.txtFind);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 664);
            this.panel2.TabIndex = 7;
            // 
            // txtFind
            // 
            this.txtFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtFind.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtFind.Location = new System.Drawing.Point(16, 135);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(150, 34);
            this.txtFind.TabIndex = 2;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(229, 100);
            this.panel5.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(69, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 72);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCapNhatTu);
            this.groupBox1.Controls.Add(this.btnDocFromTxt);
            this.groupBox1.Controls.Add(this.btnSaveToTxT);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThemTu);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 333);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // btnCapNhatTu
            // 
            this.btnCapNhatTu.Location = new System.Drawing.Point(49, 207);
            this.btnCapNhatTu.Name = "btnCapNhatTu";
            this.btnCapNhatTu.Size = new System.Drawing.Size(128, 53);
            this.btnCapNhatTu.TabIndex = 5;
            this.btnCapNhatTu.Text = "Cập Nhật";
            this.btnCapNhatTu.UseVisualStyleBackColor = true;
            this.btnCapNhatTu.Click += new System.EventHandler(this.btnCapNhatTu_Click);
            // 
            // btnDocFromTxt
            // 
            this.btnDocFromTxt.Location = new System.Drawing.Point(119, 129);
            this.btnDocFromTxt.Name = "btnDocFromTxt";
            this.btnDocFromTxt.Size = new System.Drawing.Size(87, 50);
            this.btnDocFromTxt.TabIndex = 3;
            this.btnDocFromTxt.Text = "Đọc";
            this.btnDocFromTxt.UseVisualStyleBackColor = true;
            this.btnDocFromTxt.Click += new System.EventHandler(this.btnDocFromTxt_Click);
            // 
            // btnSaveToTxT
            // 
            this.btnSaveToTxT.Location = new System.Drawing.Point(12, 129);
            this.btnSaveToTxT.Name = "btnSaveToTxT";
            this.btnSaveToTxT.Size = new System.Drawing.Size(86, 50);
            this.btnSaveToTxT.TabIndex = 2;
            this.btnSaveToTxT.Text = "Lưu";
            this.btnSaveToTxT.UseVisualStyleBackColor = true;
            this.btnSaveToTxT.Click += new System.EventHandler(this.btnSaveToTxT_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(119, 33);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 50);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemTu
            // 
            this.btnThemTu.Location = new System.Drawing.Point(12, 33);
            this.btnThemTu.Name = "btnThemTu";
            this.btnThemTu.Size = new System.Drawing.Size(86, 50);
            this.btnThemTu.TabIndex = 0;
            this.btnThemTu.Text = "Thêm";
            this.btnThemTu.UseVisualStyleBackColor = true;
            this.btnThemTu.Click += new System.EventHandler(this.btnThemTu_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnTimTu);
            this.panel4.Location = new System.Drawing.Point(163, 122);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(66, 60);
            this.panel4.TabIndex = 6;
            // 
            // btnTimTu
            // 
            this.btnTimTu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnTimTu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnTimTu.Image = ((System.Drawing.Image)(resources.GetObject("btnTimTu.Image")));
            this.btnTimTu.Location = new System.Drawing.Point(-19, -21);
            this.btnTimTu.Name = "btnTimTu";
            this.btnTimTu.Size = new System.Drawing.Size(95, 98);
            this.btnTimTu.TabIndex = 5;
            this.btnTimTu.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tìm: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Danh sách từ: ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(163)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(227, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(819, 100);
            this.panel3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dictionary";
            // 
            // lblTu
            // 
            this.lblTu.AutoSize = true;
            this.lblTu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTu.ForeColor = System.Drawing.Color.Black;
            this.lblTu.Location = new System.Drawing.Point(271, 143);
            this.lblTu.Name = "lblTu";
            this.lblTu.Size = new System.Drawing.Size(38, 28);
            this.lblTu.TabIndex = 9;
            this.lblTu.Text = "Từ:";
            // 
            // lblNghia
            // 
            this.lblNghia.AutoSize = true;
            this.lblNghia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNghia.ForeColor = System.Drawing.Color.Black;
            this.lblNghia.Location = new System.Drawing.Point(240, 196);
            this.lblNghia.Name = "lblNghia";
            this.lblNghia.Size = new System.Drawing.Size(69, 28);
            this.lblNghia.TabIndex = 10;
            this.lblNghia.Text = "Nghĩa:";
            // 
            // lblViDu
            // 
            this.lblViDu.AutoSize = true;
            this.lblViDu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViDu.ForeColor = System.Drawing.Color.Black;
            this.lblViDu.Location = new System.Drawing.Point(628, 143);
            this.lblViDu.Name = "lblViDu";
            this.lblViDu.Size = new System.Drawing.Size(61, 28);
            this.lblViDu.TabIndex = 11;
            this.lblViDu.Text = "Ví dụ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(614, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "Từ loại:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tu,
            this.TuLoai,
            this.Nghia,
            this.ViDu});
            this.dataGridView1.Location = new System.Drawing.Point(293, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(700, 340);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Tu
            // 
            this.Tu.DataPropertyName = "Tu";
            this.Tu.HeaderText = "Từ";
            this.Tu.MinimumWidth = 6;
            this.Tu.Name = "Tu";
            this.Tu.Width = 125;
            // 
            // TuLoai
            // 
            this.TuLoai.DataPropertyName = "TuLoai";
            this.TuLoai.HeaderText = "Từ Loại";
            this.TuLoai.MinimumWidth = 6;
            this.TuLoai.Name = "TuLoai";
            this.TuLoai.Width = 125;
            // 
            // Nghia
            // 
            this.Nghia.DataPropertyName = "Nghia";
            this.Nghia.HeaderText = "Nghĩa";
            this.Nghia.MinimumWidth = 6;
            this.Nghia.Name = "Nghia";
            this.Nghia.Width = 125;
            // 
            // ViDu
            // 
            this.ViDu.DataPropertyName = "ViDu";
            this.ViDu.HeaderText = "Ví Dụ";
            this.ViDu.MinimumWidth = 6;
            this.ViDu.Name = "ViDu";
            this.ViDu.Width = 300;
            // 
            // txtTu
            // 
            this.txtTu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTu.Location = new System.Drawing.Point(330, 136);
            this.txtTu.Name = "txtTu";
            this.txtTu.Size = new System.Drawing.Size(250, 34);
            this.txtTu.TabIndex = 14;
            // 
            // txtNghia
            // 
            this.txtNghia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNghia.Location = new System.Drawing.Point(330, 190);
            this.txtNghia.Name = "txtNghia";
            this.txtNghia.Size = new System.Drawing.Size(250, 34);
            this.txtNghia.TabIndex = 15;
            // 
            // txtViDu
            // 
            this.txtViDu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViDu.Location = new System.Drawing.Point(695, 136);
            this.txtViDu.Name = "txtViDu";
            this.txtViDu.Size = new System.Drawing.Size(318, 34);
            this.txtViDu.TabIndex = 16;
            // 
            // txtTuLoai
            // 
            this.txtTuLoai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuLoai.Location = new System.Drawing.Point(695, 190);
            this.txtTuLoai.Name = "txtTuLoai";
            this.txtTuLoai.Size = new System.Drawing.Size(318, 34);
            this.txtTuLoai.TabIndex = 17;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1044, 666);
            this.Controls.Add(this.txtTuLoai);
            this.Controls.Add(this.txtViDu);
            this.Controls.Add(this.txtNghia);
            this.Controls.Add(this.txtTu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblViDu);
            this.Controls.Add(this.lblNghia);
            this.Controls.Add(this.lblTu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCapNhatTu;
        private System.Windows.Forms.Button btnDocFromTxt;
        private System.Windows.Forms.Button btnSaveToTxT;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThemTu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnTimTu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTu;
        private System.Windows.Forms.Label lblNghia;
        private System.Windows.Forms.Label lblViDu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nghia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViDu;
        private System.Windows.Forms.TextBox txtTu;
        private System.Windows.Forms.TextBox txtNghia;
        private System.Windows.Forms.TextBox txtViDu;
        private System.Windows.Forms.TextBox txtTuLoai;
        private System.Windows.Forms.TextBox txtFind;
    }
}