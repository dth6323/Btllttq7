using Btllttq7;
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

namespace hangu
{
    
	public partial class NoiHoc : Form
	{
	    ProcessDb db= new ProcessDb();
		public NoiHoc()
		{
			InitializeComponent();
		}

        bool kiemtradl()
        {
            bool k = true;
            if (txtMaNoiHoc.Text.Trim().Equals("") || txtTenNoiHoc.Text.Trim() == "")
               
            { MessageBox.Show("hay nhap du dl"); k = false; }
            else
            {
                DataTable tb = db.DocBangsql("select * from NoiHoc where MaNoiHoc='" + txtMaNoiHoc.Text + "'");
                if (tb.Rows.Count > 0)
                {
                    MessageBox.Show("Ma nay da ton tai");
                    k = false;
                }
                    
            }
            return k;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			string searchValue = txtTimKiem.Text;
			if (!string.IsNullOrEmpty(searchValue))
			{
				string sql = "SELECT * FROM NoiHoc WHERE MaNoiHoc = '" + searchValue + "' OR TenNoiHoc LIKE N'%" + searchValue + "%'";
				dataGridViewNoiHoc.DataSource = db.DocBangsql(sql);
			}
			else
			{
				MessageBox.Show("Vui lòng nhập giá trị cần tìm kiếm.");
			}

		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			
			if (txtMaNoiHoc.Text.Trim().Equals("") || txtTenNoiHoc.Text.Trim() == "")

			{ MessageBox.Show("hay nhap du dl"); 
			 }
			else
			{
				string sql = "UPDATE NoiHoc SET TenNoiHoc = N'" + txtTenNoiHoc.Text + "' WHERE MaNoiHoc = '" + txtMaNoiHoc.Text + "'";
				db.CapNhat(sql);
				dataGridViewNoiHoc.DataSource = db.DocBangsql("SELECT * FROM NoiHoc");
			}
		
			

		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtMaNoiHoc.Text))
			{
				string sql = "DELETE FROM NoiHoc WHERE MaNoiHoc = '" + txtMaNoiHoc.Text + "'";
				db.CapNhat(sql);
				dataGridViewNoiHoc.DataSource = db.DocBangsql("SELECT * FROM NoiHoc");
			}
			else
			{
				MessageBox.Show("Vui lòng nhập Mã Nơi Học để xóa.");
			}

		}

		private void Form1_Load_1(object sender, EventArgs e)
		{
			// Load data from the NoiHoc table when the form loads
			string sql = "SELECT * FROM NoiHoc";
			dataGridViewNoiHoc.DataSource = db.DocBangsql(sql);
		}

		private void btnThem_Click_1(object sender, EventArgs e)
		{
			if (kiemtradl())
			{
				string sql = "INSERT INTO NoiHoc(MaNoiHoc, TenNoiHoc) VALUES('" + txtMaNoiHoc.Text + "', N'" + txtTenNoiHoc.Text + "')";
				db.CapNhat(sql);
				dataGridViewNoiHoc.DataSource = db.DocBangsql("SELECT * FROM NoiHoc");
			}
		}
	}
}
