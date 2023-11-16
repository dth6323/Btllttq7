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

namespace hangu
{
	public partial class DauBep : Form
	{
		ProcessDb db = new ProcessDb();
		public DauBep()
		{
			InitializeComponent();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			if (kiemtradlDauBep())
			{
				string sql = "INSERT INTO DauBep(MaDauBep, TenDauBep, DienThoai, GioiTinh, DiaChi, MaNoiHoc, MaTrinhDo) " +
							 "VALUES('" + int.Parse(txtMaDauBep.Text) + "', N'" + txtTenDauBep.Text + "', '" + txtDienThoai.Text + "', " +
							 "N'" + txtGioiTinh.Text + "', N'" + txtDiaChi.Text + "', '" + txtMaNoiHoc.Text + "', '" +
							 txtMaTrinhDo.Text + "')";
				db.CapNhat(sql);
				dataGridViewDauBep.DataSource = db.DocBangsql("SELECT [MaDauBep], [TenDauBep], [DienThoai], [GioiTinh], [DiaChi], [MaNoiHoc], [MaTrinhDo] FROM DauBep ");
			}

		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			//if (kiemtradlDauBep())
			//{
			//	string sql = "Select * From DauBep(MaDauBep, TenDauBep, DienThoai, GioiTinh, DiaChi, MaNoiHoc, MaTrinhDo) " +
			//				 "VALUES('" + txtMaDauBep.Text + "', N'" + txtTenDauBep.Text + "', '" + txtDienThoai.Text + "', " +
			//				 "N'" + txtGioiTinh.Text + "', N'" + txtDiaChi.Text + "', '" + txtMaNoiHoc.Text + "', '" +
			//				 txtMaTrinhDo.Text + "')";
			//	db.CapNhat(sql);
			//	dataGridViewDauBep.DataSource = db.DocBangsql("SELECT [MaDauBep], [TenDauBep], [DienThoai], [GioiTinh], [DiaChi], [MaNoiHoc], [MaTrinhDo] FROM DauBep");
			//}
			string sql = "Select [MaDauBep], [TenDauBep], [DienThoai], [GioiTinh], [DiaChi], [MaNoiHoc], [MaTrinhDo] From DauBep where MaDauBep=N'" + txtTimKiem.Text + "'";
			db.CapNhat(sql);
			dataGridViewDauBep.DataSource = db.DocBangsql(sql);
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (txtMaDauBep.Text.Trim().Equals("") || txtTenDauBep.Text.Trim() == "" ||
				txtDienThoai.Text.Trim() == "" || txtGioiTinh.Text.Trim() == "" || txtDiaChi.Text.Trim() == "" ||
				txtMaNoiHoc.Text.Trim() == "" || txtMaTrinhDo.Text.Trim() == "")
			{
				MessageBox.Show("Hãy nhập đủ dữ liệu.");
			}
			else
			{
				string sql = "UPDATE DauBep SET TenDauBep = N'" + txtTenDauBep.Text + "', DienThoai = '" + txtDienThoai.Text +
							 "', GioiTinh = N'" + txtGioiTinh.Text + "', DiaChi = N'" + txtDiaChi.Text + "', MaNoiHoc = '" +
							 txtMaNoiHoc.Text + "', MaTrinhDo = '" +txtMaTrinhDo.Text + "' " +
							 "WHERE MaDauBep = '" + txtMaDauBep.Text + "'";
				db.CapNhat(sql);
				dataGridViewDauBep.DataSource = db.DocBangsql("SELECT [MaDauBep], [TenDauBep], [DienThoai], [GioiTinh], [DiaChi], [MaNoiHoc], [MaTrinhDo] FROM DauBep");
			}

		}
		bool kiemtradlDauBep()
		{
			bool k = true;
			if (txtMaDauBep.Text.Trim().Equals("") || txtTenDauBep.Text.Trim() == "" ||
				txtDienThoai.Text.Trim() == "" || txtGioiTinh.Text.Trim() == "" || txtDiaChi.Text.Trim() == "" ||
				txtMaNoiHoc.Text.Trim() == "" || txtMaTrinhDo.Text.Trim() == "")
			{
				MessageBox.Show("Hãy nhập đủ dữ liệu.");
				k = false;
			}
			else
			{
				DataTable tb = db.DocBangsql("SELECT * FROM DauBep WHERE MaDauBep = '" + int.Parse(txtMaDauBep.Text) + "'");
				if (tb.Rows.Count > 0)
				{
					MessageBox.Show("Mã Đầu Bếp này đã tồn tại.");
					k = false;
				}
			}
			return k;
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtMaDauBep.Text))
			{
				string sql = "DELETE FROM DauBep WHERE MaDauBep = '" + int.Parse(txtMaDauBep.Text) + "'";
				db.CapNhat(sql);
				dataGridViewDauBep.DataSource = db.DocBangsql("SELECT [MaDauBep], [TenDauBep], [DienThoai], [GioiTinh], [DiaChi], [MaNoiHoc], [MaTrinhDo] FROM DauBep");
			}
			else
			{
				MessageBox.Show("Vui lòng nhập Mã Đầu Bếp để xóa.");
			}
			//string maDauBep = txtMaDauBep.Text;

			//// Tạo câu truy vấn SQL DELETE
			//string sql = $"DELETE FROM DauBep WHERE MaDauBep = '{maDauBep}'";

			//// Thực hiện câu truy vấn DELETE
			//db.CapNhat(sql);

			//// Cập nhật DataGridView sau khi xóa
			//dataGridViewDauBep.DataSource = db.DocBangsql("SELECT * FROM DauBep");
		}

		private void DauBep_Load(object sender, EventArgs e)
		{
			// Load data from the DauBep table when the form loads
			string sql = "SELECT [MaDauBep], [TenDauBep], [DienThoai], [GioiTinh], [DiaChi], [MaNoiHoc], [MaTrinhDo] FROM DauBep";
			dataGridViewDauBep.DataSource = db.DocBangsql(sql);
		}
	}
}
