namespace btllttq
{
	partial class Donvitinh
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
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txttendvt = new System.Windows.Forms.TextBox();
			this.txtmadvt = new System.Windows.Forms.TextBox();
			this.txttk = new System.Windows.Forms.TextBox();
			this.dgvdonvitinh = new System.Windows.Forms.DataGridView();
			this.btnthoat = new System.Windows.Forms.Button();
			this.btntk = new System.Windows.Forms.Button();
			this.btnxoa = new System.Windows.Forms.Button();
			this.btnsua = new System.Windows.Forms.Button();
			this.btnthem = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvdonvitinh)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(29, 35);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(91, 16);
			this.label4.TabIndex = 17;
			this.label4.Text = "Mã đơn vị tính:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(26, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 16);
			this.label3.TabIndex = 18;
			this.label3.Text = "Tên đơn vị tính: ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(5, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 16);
			this.label1.TabIndex = 19;
			this.label1.Text = "Tìm kiếm:";
			// 
			// txttendvt
			// 
			this.txttendvt.Location = new System.Drawing.Point(145, 75);
			this.txttendvt.Name = "txttendvt";
			this.txttendvt.Size = new System.Drawing.Size(160, 22);
			this.txttendvt.TabIndex = 13;
			// 
			// txtmadvt
			// 
			this.txtmadvt.Location = new System.Drawing.Point(145, 32);
			this.txtmadvt.Name = "txtmadvt";
			this.txtmadvt.Size = new System.Drawing.Size(160, 22);
			this.txtmadvt.TabIndex = 14;
			// 
			// txttk
			// 
			this.txttk.Location = new System.Drawing.Point(80, 46);
			this.txttk.Name = "txttk";
			this.txttk.Size = new System.Drawing.Size(160, 22);
			this.txttk.TabIndex = 15;
			// 
			// dgvdonvitinh
			// 
			this.dgvdonvitinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvdonvitinh.Location = new System.Drawing.Point(388, 12);
			this.dgvdonvitinh.Name = "dgvdonvitinh";
			this.dgvdonvitinh.RowHeadersWidth = 51;
			this.dgvdonvitinh.RowTemplate.Height = 24;
			this.dgvdonvitinh.Size = new System.Drawing.Size(396, 375);
			this.dgvdonvitinh.TabIndex = 11;
			// 
			// btnthoat
			// 
			this.btnthoat.Location = new System.Drawing.Point(680, 393);
			this.btnthoat.Name = "btnthoat";
			this.btnthoat.Size = new System.Drawing.Size(104, 23);
			this.btnthoat.TabIndex = 6;
			this.btnthoat.Text = "Thoát";
			this.btnthoat.UseVisualStyleBackColor = true;
			this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
			// 
			// btntk
			// 
			this.btntk.Location = new System.Drawing.Point(246, 45);
			this.btntk.Name = "btntk";
			this.btntk.Size = new System.Drawing.Size(75, 23);
			this.btntk.TabIndex = 8;
			this.btntk.Text = "Tìm Kiếm";
			this.btntk.UseVisualStyleBackColor = true;
			this.btntk.Click += new System.EventHandler(this.btntkm_Click);
			// 
			// btnxoa
			// 
			this.btnxoa.Location = new System.Drawing.Point(388, 393);
			this.btnxoa.Name = "btnxoa";
			this.btnxoa.Size = new System.Drawing.Size(110, 23);
			this.btnxoa.TabIndex = 9;
			this.btnxoa.Text = "Xoá";
			this.btnxoa.UseVisualStyleBackColor = true;
			this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
			// 
			// btnsua
			// 
			this.btnsua.Location = new System.Drawing.Point(131, 119);
			this.btnsua.Name = "btnsua";
			this.btnsua.Size = new System.Drawing.Size(75, 23);
			this.btnsua.TabIndex = 10;
			this.btnsua.Text = "Sửa";
			this.btnsua.UseVisualStyleBackColor = true;
			this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
			// 
			// btnthem
			// 
			this.btnthem.Location = new System.Drawing.Point(32, 119);
			this.btnthem.Name = "btnthem";
			this.btnthem.Size = new System.Drawing.Size(75, 23);
			this.btnthem.TabIndex = 5;
			this.btnthem.Text = "Thêm";
			this.btnthem.UseVisualStyleBackColor = true;
			this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.btnthem);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.btnsua);
			this.groupBox1.Controls.Add(this.txtmadvt);
			this.groupBox1.Controls.Add(this.txttendvt);
			this.groupBox1.Location = new System.Drawing.Point(24, 56);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(329, 180);
			this.groupBox1.TabIndex = 20;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Đơn Vị Tính";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txttk);
			this.groupBox2.Controls.Add(this.btntk);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(24, 264);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(329, 123);
			this.groupBox2.TabIndex = 21;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Tìm kiếm";
			// 
			// Donvitinh
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dgvdonvitinh);
			this.Controls.Add(this.btnthoat);
			this.Controls.Add(this.btnxoa);
			this.Name = "Donvitinh";
			this.Text = "Donvitinh";
			this.Load += new System.EventHandler(this.Donvitinh_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvdonvitinh)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txttendvt;
		private System.Windows.Forms.TextBox txtmadvt;
		private System.Windows.Forms.TextBox txttk;
		private System.Windows.Forms.DataGridView dgvdonvitinh;
		private System.Windows.Forms.Button btnthoat;
		private System.Windows.Forms.Button btntk;
		private System.Windows.Forms.Button btnxoa;
		private System.Windows.Forms.Button btnsua;
		private System.Windows.Forms.Button btnthem;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
	}
}