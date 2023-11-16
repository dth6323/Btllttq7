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
    public partial class LoaiMon : Form
    {
        ProcessDb db = new ProcessDb(); 
        public LoaiMon()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtgv.DataSource = db.DocBangsql("Select * from LoaiMon");
        }
        public void reload()
        {
            dtgv.DataSource = db.DocBangsql("Select * from LoaiMon");
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (ktra() == true)
            {
                string ma = txtmaloai.Text;
                string ten = txttenloai.Text;
                string sql = $"Insert into LoaiMon(TenLoai,MaLoai) values('{ten}','{ma}')";
                db.CapNhat(sql);
                reload();
            }
        }
        bool ktra()
        {
            bool k = true;
            if (txtmaloai.Text.Trim().Equals("") || txttenloai.Text.Trim().Equals(""))
            {
                k = false;
            }
            else
            {
                string sql = "Select * from LoaiMon where MaLoai = '" + txtmaloai.Text + "'";
                DataTable tb = db.DocBangsql(sql);
                if (tb.Rows.Count > 0)
                {
                    MessageBox.Show("Mon nay da ton tai");
                    k = false;
                }
            }
            return k;
        }
        bool ktrasua()
        {
            bool k = true;
            if (txtmaloai.Text.Trim().Equals("") || txttenloai.Text.Trim().Equals(""))
            {
                k = false;
            }
            
            return k;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (ktrasua() == true)
            {
                string ma = txtmaloai.Text;
                string ten = txttenloai.Text;
                string sql = $"Update LoaiMon set TenLoai='{ten}'where MaLoai ='{ma}'";
                db.CapNhat(sql);
                reload();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ban co muon xoa", "thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = $"Delete LoaiMon where MaLoai='{txtmaloai.Text}'";
                db.CapNhat(sql);
                reload();
            }
        }

        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmaloai.Text = dtgv.CurrentRow.Cells[1].Value.ToString();
            txttenloai.Text = dtgv.CurrentRow.Cells[0].Value.ToString();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string find = txttimkiem.Text;
            string sql = $"Select * from LoaiMon where TenLoai like '%{find}%'";
            dtgv.DataSource = db.DocBangsql(sql);
        }
    }
}
