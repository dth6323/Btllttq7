using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Btllttq7
{
    public partial class KhachHang : Form
    {
        ProcessDb db = new ProcessDb();
        public KhachHang()
        {
            InitializeComponent();
        }
        public void reload()
        {
            dtgv.DataSource = db.DocBangsql("Select * from KhachHang");
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (ktra() == true)
            {
                string ma = txtmakh.Text;
                string ten = txtten.Text;
                string dc = txtdc.Text;
                string mst = txtmst.Text;
                string dt = txtdt.Text;
                string sql = $"Insert into KhachHang values('{ma}',N'{ten}',N'{dc}','{dt}','{mst}')";
                db.CapNhat(sql);
                reload();
            }
        }
        bool ktra()
        {
            bool k = true;
            if (txtmakh.Text.Trim().Equals("") || txtdc.Text.Trim().Equals("") 
                || txtdt.Text.Trim().Equals("") || txtten.Text.Trim().Equals("") || txtmst.Text.Trim().Equals(""))
            {
                MessageBox.Show("Dien day du thong tin");
                k = false;
            }
            else
            {
                string sql = "Select * from KhachHang where MaKhachHang = '" + txtmakh.Text + "'";
                DataTable tb = db.DocBangsql(sql);
                if (tb.Rows.Count > 0)
                {
                    MessageBox.Show("Mon nay da ton tai");
                    k = false;
                }
            }
            return k;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (ktrasua() == true)
            {
                string ma = txtmakh.Text;
                string ten = txtten.Text;
                string dc = txtdc.Text;
                string mst = txtmst.Text;
                string dt = txtdt.Text;
                string sql = $"Update KhachHang set TenKhachHang=N'{ten}', DiaChi=N'{dc}',DienThoai='{dt}',MaSoTHue='{mst}' where MaKhachHang = '{ma}'";
                db.CapNhat(sql);
                reload();
            }
        }
        bool ktrasua()
        {
            bool k = true;
            if (txtmakh.Text.Trim().Equals("") || txtdc.Text.Trim().Equals("")
                || txtdt.Text.Trim().Equals("") || txtten.Text.Trim().Equals("") || txtmst.Text.Trim().Equals(""))
            {
                MessageBox.Show("Dien day du thong tin");
                k = false;
            }

            return k;
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ban co muon xoa", "thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = $"Delete KhachHang where MaKhachHang='{txtmakh.Text}'";
                db.CapNhat(sql);
                reload();
            }
        }

        private void btntk_Click(object sender, EventArgs e)
        {
            string find = txttk.Text;
            string sql = $"Select * from KhachHang where TenKhachHang like '%{find}%'";
            dtgv.DataSource = db.DocBangsql(sql);

        }

        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmakh.Text = dtgv.CurrentRow.Cells[0].Value.ToString();
            txtten.Text = dtgv.CurrentRow.Cells[1].Value.ToString();
            txtdc.Text = dtgv.CurrentRow.Cells[2].Value.ToString();
            txtdt.Text = dtgv.CurrentRow.Cells[3].Value.ToString();
            txtmst.Text = dtgv.CurrentRow.Cells[4].Value.ToString();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {

            dtgv.DataSource = db.DocBangsql("Select * from KhachHang");
        }
    }
}
