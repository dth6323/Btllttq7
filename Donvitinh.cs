using Btllttq7;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btllttq
{
	public partial class Donvitinh : Form
	{
		ProcessDb db = new ProcessDb();
		public Donvitinh()
		{
			InitializeComponent();
		}

		private void btntkm_Click(object sender, EventArgs e)
		{
			string searchValue = txttk.Text;
			if (!string.IsNullOrEmpty(searchValue))
			{
				string sql = "SELECT * FROM DonViTinh WHERE MaDonViTinh = '" + searchValue + "' OR TenDonViTinh LIKE N'%" + searchValue + "%'";
				dgvdonvitinh.DataSource = db.DocBangsql(sql);
			}
			else
			{
				MessageBox.Show("Vui lòng nhập giá trị cần tìm kiếm.");
			}
		}

		private void btnthem_Click(object sender, EventArgs e)
		{
			if (kiemtradl())
			{
				string sql = "INSERT INTO DonViTinh(MaDonViTinh, TenDonViTinh) VALUES('" + txtmadvt.Text + "', N'" + txttendvt.Text + "')";
				db.CapNhat(sql);
				dgvdonvitinh.DataSource = db.DocBangsql("SELECT * FROM DonViTinh");
			}
		}
		bool kiemtradl()
		{
			bool k = true;
			if (txtmadvt.Text.Trim().Equals("") || txttendvt.Text.Trim() == "")

			{ MessageBox.Show("hay nhap du dl"); k = false; }
			else
			{
				DataTable tb = db.DocBangsql("select * from DonViTinh where MaDonViTinh='" + txtmadvt.Text + "'");
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
			if (txtmadvt.Text.Trim().Equals("") || txttendvt.Text.Trim() == "")

			{
				MessageBox.Show("hay nhap du dl");
			}
			else {
				string sql = "UPDATE DonViTinh SET TenDonViTinh = N'" + txttendvt.Text + "' WHERE MaDonViTinh = '" + txtmadvt.Text + "'";
				db.CapNhat(sql);
				dgvdonvitinh.DataSource = db.DocBangsql("SELECT * FROM DonViTinh");
			}
			
		}

		private void btnxoa_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtmadvt.Text))
			{
				string sql = "DELETE FROM DonViTinh WHERE MaDonViTinh = '" + txtmadvt.Text + "'";
				db.CapNhat(sql);
				dgvdonvitinh.DataSource = db.DocBangsql("SELECT * FROM DonViTinh");
			}
			else
			{
				MessageBox.Show("Vui lòng nhập Mã Đơn Vị Tính để xóa.");
			}
		}

		private void btnthoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Donvitinh_Load(object sender, EventArgs e)
		{
			string sql = "SELECT * FROM DonViTinh";
			dgvdonvitinh.DataSource = db.DocBangsql(sql);
		}
	}
}
