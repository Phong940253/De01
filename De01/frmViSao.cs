using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace De01
{
    public partial class frmViSao : Form
    {
        private SqlConnection sqlConnection;
        private SqlDataAdapter adapter;
        private SqlCommandBuilder sqlCommandBuilder;
        private DataTable dataTable = new DataTable();
        public frmViSao()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn sửa", "Sửa Vì Sao", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int rowSelected = dgvViSao.CurrentRow.Index;
                DataRow dataRow = dataTable.Rows[rowSelected];
                dataRow["MaViSao"] = txtMaVS.Text;
                dataRow["TenViSao"] = txtTenVS.Text;
                dataRow["NgayNhap"] = dtNgayNhap.Value;
                dataRow["MaHe"] = cboHe.Text;
                adapter.Update(dataTable);
            } 
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn xóa", "Xóa Vì Sao", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int rowSelected = dgvViSao.CurrentRow.Index;
                dgvViSao.Rows.Remove(dgvViSao.Rows[rowSelected]);
                adapter.Update(dataTable);
                btXoa.Enabled = false;
                btSua.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmViSao_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder sqlString = new SqlConnectionStringBuilder();
            sqlString["server"] = "DESKTOP-T3GOB10\\SQLEXPRESS";
            sqlString["database"] = "QLViSao";
            sqlString["trusted_connection"] = "true";
            sqlConnection = new SqlConnection(sqlString.ToString());
            adapter = new SqlDataAdapter("SELECT * FROM ViSao", sqlConnection);
            sqlCommandBuilder = new SqlCommandBuilder(adapter);
            adapter.Fill(dataTable);
            dgvViSao.DataSource = dataTable;
            SqlDataAdapter adapterHe = new SqlDataAdapter("SELECT TenHe FROM he", sqlConnection);
            DataTable he = new DataTable();
            adapterHe.Fill(he);
            cboHe.DataSource = he;
            cboHe.DisplayMember = "TenHe";
            btSua.Enabled = false;
            btXoa.Enabled = false;
            btThem.Enabled = false;
        }

        private void dgvViSao_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < dgvViSao.Rows.Count - 1 && e.RowIndex >= 0)
            {
                btSua.Enabled = true;
                btXoa.Enabled = true;
                DataRow dataRow = dataTable.Rows[e.RowIndex];
                txtMaVS.Text = dataRow["MaViSao"].ToString();
                txtTenVS.Text = dataRow["TenViSao"].ToString();
                dtNgayNhap.Text = dataRow["NgayNhap"].ToString();
                cboHe.Text = dataRow["MaHe"].ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn thêm", "Thêm Vì Sao", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow["MaViSao"] = txtMaVS.Text;
                dataRow["TenViSao"] = txtTenVS.Text;
                dataRow["NgayNhap"] = dtNgayNhap.Value;
                dataRow["MaHe"] = cboHe.Text;
                dataTable.Rows.Add(dataRow);
                try
                {
                    adapter.Update(dataTable);

                }
                catch (Exception ex)
                {

                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void btNhapMoi_Click(object sender, EventArgs e)
        {
            txtMaVS.Text = "";
            txtTenVS.Text = "";
            dtNgayNhap.Value = System.DateTime.Today;
            cboHe.Text = "";
            btXoa.Enabled = false;
            btSua.Enabled = false;
            btThem.Enabled = false;
        }
        private void cellDataGridViewClick(object sender, DataGridViewCellEventArgs e)
        {
            btSua.Enabled = false;
            btXoa.Enabled = false;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn thoát", "Thoát chương trình", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtMaVS_TextChanged(object sender, EventArgs e)
        {
            btThem.Enabled = txtMaVS.Text == "" ? false : true;
        }

        private void btReport_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
