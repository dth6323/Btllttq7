using Btllttq7;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btllttq
{
	public partial class Monan : Form
	{
		ProcessDb db = new ProcessDb();
		public Monan()
		{
			InitializeComponent();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			if (kiemtradl())
			{
				string sql = "INSERT INTO MonAn(MaMonAn, TenMonAn, MaLoai, MaCongDung, DonGia, CachLam, YeuCau) " +
							 "VALUES('" + int.Parse(txtmamonan.Text) + "', N'" + txttenmonan.Text + "', '" + txtmaloai.Text + "', " +
							 "N'" + txtmacongdung.Text + "', N'" + txtdongia.Text + "', '" + int.Parse(txtcachlam.Text) + "', '" +
							 int.Parse(txtyeucau.Text) + "')";
				db.CapNhat(sql);
				dgvmonan.DataSource = db.DocBangsql("SELECT * FROM DauBep");
			}
		}

		private void Monan_Load(object sender, EventArgs e)
		{
			string sql = "SELECT * FROM MonAn";
			dgvmonan.DataSource = db.DocBangsql(sql);
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (kiemtradl())
			{
				string sql = "UPDATE MonAn SET TenMon = N'" + txttenmonan.Text + "' WHERE MaMonAn = '" + int.Parse(txtmamonan.Text) + "'";
				db.CapNhat(sql);
				dgvmonan.DataSource = db.DocBangsql("SELECT * FROM MonAn");
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtmamonan.Text))
			{
				string sql = "DELETE FROM MonAn WHERE MaMonAn = '" + int.Parse(txtmamonan.Text) + "'";
				db.CapNhat(sql);
				dgvmonan.DataSource = db.DocBangsql("SELECT * FROM MonAn");
			}
			else
			{
				MessageBox.Show("Vui lòng nhập Mã món ăn để xóa.");
			}
		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			string searchValue = txtmamonan.Text;
			if (!string.IsNullOrEmpty(searchValue))
			{
				string sql = "SELECT * FROM MonAn WHERE MaMonAn = '" + int.Parse(searchValue) + "' OR TenMonAn LIKE N'%" + searchValue + "%'";
				dgvmonan.DataSource = db.DocBangsql(sql);
			}
			else
			{
				MessageBox.Show("Vui lòng nhập giá trị cần tìm kiếm.");
			}
		}
		bool kiemtradl()
		{
			bool k = true;
			if (txtmamonan.Text.Trim().Equals("") || txttenmonan.Text.Trim() == "" ||
				txtmaloai.Text.Trim() == "" || txtmacongdung.Text.Trim() == "" || txtdongia.Text.Trim() == "" ||
				txtcachlam.Text.Trim() == "" || txtyeucau.Text.Trim() == "")
			{
				MessageBox.Show("Hãy nhập đủ dữ liệu.");
				k = false;
			}
			else
			{
				DataTable tb = db.DocBangsql("SELECT * FROM MonAn WHERE MaMonAn = '" + int.Parse(txtmamonan.Text) + "'");
				if (tb.Rows.Count > 0)
				{
					MessageBox.Show("Mã món ăn này đã tồn tại.");
					k = false;
				}
			}
			return k;
		}
	}
}
