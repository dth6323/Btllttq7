using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Btllttq7;

namespace btllttq
{
	public partial class Xeploai : Form
	{
		ProcessDb db = new ProcessDb();
		public Xeploai()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			string sql = "SELECT * FROM XepLoai";
			dgvxeploai.DataSource = db.DocBangsql(sql);
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnthem_Click(object sender, EventArgs e)
		{
			if (kiemtradl())
			{
				string sql = "INSERT INTO XepLoai(MaXepLoai, TenXepLoai) VALUES('" + txtmaxl.Text + "', N'" + txttenxl.Text + "')";
				db.CapNhat(sql);
				dgvxeploai.DataSource = db.DocBangsql("SELECT * FROM XepLoai");
			}
		}
		bool kiemtradl()
		{
			bool k = true;
			if (txtmaxl.Text.Trim().Equals("") || txttenxl.Text.Trim() == "")

			{ MessageBox.Show("hay nhap du dl"); k = false; }
			else
			{
				DataTable tb = db.DocBangsql("select * from XepLoai where MaXepLoai='" + txtmaxl.Text + "'");
				if (tb.Rows.Count > 0)
				{
					MessageBox.Show("ma nay da ton tai");
					k = false;
				}

			}
			return k;
		}

		private void btnsua_Click(object sender, EventArgs e)
		{
			if (txtmaxl.Text.Trim().Equals("") || txttenxl.Text.Trim() == "")

			{ MessageBox.Show("hay nhap du dl"); }
			else
			{
				string sql = "UPDATE XepLoai SET TenXepLoai = N'" + txttenxl.Text + "' WHERE MaXepLoai = '" + txtmaxl.Text + "'";
				db.CapNhat(sql);
				dgvxeploai.DataSource = db.DocBangsql("SELECT * FROM XepLoai");
			}
		}

		private void btnxoa_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtmaxl.Text))
			{
				string sql = "DELETE FROM XepLoai WHERE MaXepLoai = '" + txtmaxl.Text + "'";
				db.CapNhat(sql);
				dgvxeploai.DataSource = db.DocBangsql("SELECT * FROM XepLoai");
			}
			else
			{
				MessageBox.Show("Vui lòng nhập Mã Xếp Loại để xóa.");
			}
		}

		private void btnthoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btntkm_Click(object sender, EventArgs e)
		{
			string searchValue = txttk.Text;
			if (!string.IsNullOrEmpty(searchValue))
			{
				string sql = "SELECT * FROM XepLoai WHERE MaXepLoai = '" + searchValue + "' OR TenXepLoai LIKE N'%" + searchValue + "%'";
				dgvxeploai.DataSource = db.DocBangsql(sql);
			}
			else
			{
				MessageBox.Show("Vui lòng nhập giá trị cần tìm kiếm.");
			}
		}
	}
}
