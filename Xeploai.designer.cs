namespace btllttq
{
	partial class Xeploai
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
			this.btnthem = new System.Windows.Forms.Button();
			this.btnsua = new System.Windows.Forms.Button();
			this.btnxoa = new System.Windows.Forms.Button();
			this.btntk = new System.Windows.Forms.Button();
			this.btnthoat = new System.Windows.Forms.Button();
			this.dgvxeploai = new System.Windows.Forms.DataGridView();
			this.txttk = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtmaxl = new System.Windows.Forms.TextBox();
			this.txttenxl = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvxeploai)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnthem
			// 
			this.btnthem.Location = new System.Drawing.Point(29, 168);
			this.btnthem.Name = "btnthem";
			this.btnthem.Size = new System.Drawing.Size(75, 23);
			this.btnthem.TabIndex = 0;
			this.btnthem.Text = "Thêm";
			this.btnthem.UseVisualStyleBackColor = true;
			this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
			// 
			// btnsua
			// 
			this.btnsua.Location = new System.Drawing.Point(213, 168);
			this.btnsua.Name = "btnsua";
			this.btnsua.Size = new System.Drawing.Size(75, 23);
			this.btnsua.TabIndex = 1;
			this.btnsua.Text = "Sửa";
			this.btnsua.UseVisualStyleBackColor = true;
			this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
			// 
			// btnxoa
			// 
			this.btnxoa.Location = new System.Drawing.Point(392, 364);
			this.btnxoa.Name = "btnxoa";
			this.btnxoa.Size = new System.Drawing.Size(110, 23);
			this.btnxoa.TabIndex = 1;
			this.btnxoa.Text = "Xoá";
			this.btnxoa.UseVisualStyleBackColor = true;
			this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
			// 
			// btntk
			// 
			this.btntk.Location = new System.Drawing.Point(128, 90);
			this.btntk.Name = "btntk";
			this.btntk.Size = new System.Drawing.Size(75, 23);
			this.btntk.TabIndex = 1;
			this.btntk.Text = "Tìm Kiếm";
			this.btntk.UseVisualStyleBackColor = true;
			this.btntk.Click += new System.EventHandler(this.btntkm_Click);
			// 
			// btnthoat
			// 
			this.btnthoat.Location = new System.Drawing.Point(684, 364);
			this.btnthoat.Name = "btnthoat";
			this.btnthoat.Size = new System.Drawing.Size(104, 23);
			this.btnthoat.TabIndex = 1;
			this.btnthoat.Text = "Thoát";
			this.btnthoat.UseVisualStyleBackColor = true;
			this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
			// 
			// dgvxeploai
			// 
			this.dgvxeploai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvxeploai.Location = new System.Drawing.Point(392, 43);
			this.dgvxeploai.Name = "dgvxeploai";
			this.dgvxeploai.RowHeadersWidth = 51;
			this.dgvxeploai.RowTemplate.Height = 24;
			this.dgvxeploai.Size = new System.Drawing.Size(396, 274);
			this.dgvxeploai.TabIndex = 2;
			// 
			// txttk
			// 
			this.txttk.Location = new System.Drawing.Point(128, 46);
			this.txttk.Name = "txttk";
			this.txttk.Size = new System.Drawing.Size(160, 22);
			this.txttk.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "Tìm kiếm:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(23, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Tên xếp loại";
			this.label3.Click += new System.EventHandler(this.label1_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(23, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(79, 16);
			this.label4.TabIndex = 4;
			this.label4.Text = "Mã xếp loại:";
			this.label4.Click += new System.EventHandler(this.label1_Click);
			// 
			// txtmaxl
			// 
			this.txtmaxl.Location = new System.Drawing.Point(128, 34);
			this.txtmaxl.Name = "txtmaxl";
			this.txtmaxl.Size = new System.Drawing.Size(160, 22);
			this.txtmaxl.TabIndex = 3;
			// 
			// txttenxl
			// 
			this.txttenxl.Location = new System.Drawing.Point(128, 74);
			this.txttenxl.Name = "txttenxl";
			this.txttenxl.Size = new System.Drawing.Size(160, 22);
			this.txttenxl.TabIndex = 3;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.btnthem);
			this.groupBox1.Controls.Add(this.btnsua);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtmaxl);
			this.groupBox1.Controls.Add(this.txttenxl);
			this.groupBox1.Location = new System.Drawing.Point(12, 43);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(355, 213);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Xếp Loại";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.btntk);
			this.groupBox2.Controls.Add(this.txttk);
			this.groupBox2.Location = new System.Drawing.Point(12, 274);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(355, 152);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Tìm Kiếm";
			// 
			// Xeploai
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dgvxeploai);
			this.Controls.Add(this.btnthoat);
			this.Controls.Add(this.btnxoa);
			this.Name = "Xeploai";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvxeploai)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnthem;
		private System.Windows.Forms.Button btnsua;
		private System.Windows.Forms.Button btnxoa;
		private System.Windows.Forms.Button btntk;
		private System.Windows.Forms.Button btnthoat;
		private System.Windows.Forms.DataGridView dgvxeploai;
		private System.Windows.Forms.TextBox txttk;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtmaxl;
		private System.Windows.Forms.TextBox txttenxl;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
	}
}

