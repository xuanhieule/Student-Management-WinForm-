namespace XUAN_HIEU_4665
{
    partial class Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMasv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtTensv = new System.Windows.Forms.TextBox();
            this.txtDiemtb = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtGt = new System.Windows.Forms.TextBox();
            this.lblTB = new System.Windows.Forms.Label();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(191, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 39);
            this.label1.TabIndex = 44;
            this.label1.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // txtMasv
            // 
            this.txtMasv.Location = new System.Drawing.Point(85, 128);
            this.txtMasv.Name = "txtMasv";
            this.txtMasv.Size = new System.Drawing.Size(173, 20);
            this.txtMasv.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-3, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Tên sinh viên :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(315, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Giới tính:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(499, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Điểm trung bình :";
            // 
            // TxtTensv
            // 
            this.TxtTensv.Location = new System.Drawing.Point(85, 191);
            this.TxtTensv.Name = "TxtTensv";
            this.TxtTensv.Size = new System.Drawing.Size(178, 20);
            this.TxtTensv.TabIndex = 54;
            // 
            // txtDiemtb
            // 
            this.txtDiemtb.Location = new System.Drawing.Point(584, 128);
            this.txtDiemtb.Name = "txtDiemtb";
            this.txtDiemtb.Size = new System.Drawing.Size(100, 20);
            this.txtDiemtb.TabIndex = 55;
            
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(469, 187);
            this.txtDiachi.Multiline = true;
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(215, 20);
            this.txtDiachi.TabIndex = 56;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column7,
            this.Column4,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(40, 389);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(660, 203);
            this.dataGridView1.TabIndex = 60;
            
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(14, 255);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(116, 51);
            this.btnThem.TabIndex = 62;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(198, 255);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(116, 51);
            this.btnSua.TabIndex = 64;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(395, 255);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(116, 51);
            this.btnXoa.TabIndex = 66;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 69;
            this.label8.Text = "Mã sinh viên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "Địa chỉ :";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(584, 255);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(116, 51);
            this.btnThoat.TabIndex = 72;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtGt
            // 
            this.txtGt.Location = new System.Drawing.Point(371, 128);
            this.txtGt.Name = "txtGt";
            this.txtGt.Size = new System.Drawing.Size(92, 20);
            this.txtGt.TabIndex = 78;
            // 
            // lblTB
            // 
            this.lblTB.AutoSize = true;
            this.lblTB.Location = new System.Drawing.Point(869, 130);
            this.lblTB.Name = "lblTB";
            this.lblTB.Size = new System.Drawing.Size(0, 13);
            this.lblTB.TabIndex = 79;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "masv";
            this.Column2.HeaderText = "Mã sinh viên";
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "tensv";
            this.Column3.HeaderText = "Tên sinh viên";
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "gioitinh";
            this.Column7.HeaderText = "Giới tính";
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "diachi";
            this.Column4.HeaderText = "Địa chỉ";
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "diemtb";
            this.Column8.HeaderText = "Điểm trung bình";
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 604);
            this.Controls.Add(this.lblTB);
            this.Controls.Add(this.txtGt);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.txtDiemtb);
            this.Controls.Add(this.TxtTensv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMasv);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Text = "Home";
            
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMasv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtTensv;
        private System.Windows.Forms.TextBox txtDiemtb;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtGt;
        private System.Windows.Forms.Label lblTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}