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

namespace QRcode
{
    public partial class QuanLySanPham : Form
    {
        public QuanLySanPham()
        {
            InitializeComponent();
        }

        public void LoadDb()
        {

            SqlDataAdapter da;
            DataSet ds;
            string SqlConnectionString = @"Data Source=DESKTOP-NMATOM3\SQLEXPRESS;Initial Catalog=CameraManager;Integrated Security=True";
            SqlConnection conn = new SqlConnection(SqlConnectionString);
            conn.Open();
            string query = $"select * from Camera_Info";
            SqlCommand cmd = new SqlCommand(query, conn);
            da = new SqlDataAdapter(query, conn);
            ds = new DataSet();
            da.Fill(ds, "Camera_Info");
            dgSanPham.DataSource = ds.Tables["Camera_Info"];
            dgSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void QuanLySanPham_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da;
            DataSet ds;
            string SqlConnectionString = @"Data Source=DESKTOP-NMATOM3\SQLEXPRESS;Initial Catalog=CameraManager;Integrated Security=True";
            SqlConnection conn = new SqlConnection(SqlConnectionString);
            conn.Open();
            string query = $"select * from Camera_Info";
            SqlCommand cmd = new SqlCommand(query, conn);
            da = new SqlDataAdapter(query, conn);
            ds = new DataSet();
            da.Fill(ds, "Camera_Info");
            dgSanPham.DataSource = ds.Tables["Camera_Info"];
            dgSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string SqlConnectionString = @"Data Source=DESKTOP-NMATOM3\SQLEXPRESS;Initial Catalog=CameraManager;Integrated Security=True";
            SqlConnection conn = new SqlConnection(SqlConnectionString);
            conn.Open();
            string Update_Query = $"update Camera_Info set Name=N'{txtProductName.Text}',Production=N'{txtProduction.Text}',Price=N'{txtPrice.Text}',Status=N'{txtStatus.Text}',IntactRatio=N'{txtIntactRatio.Text}',Distributor=N'{txtDistributor.Text}' where ID=N'{txtId.Text}'";
            SqlCommand cmd = new SqlCommand(Update_Query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Sửa thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDb();
            conn.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rindex = e.RowIndex;
            if (rindex >= 0)
            {
                txtId.Text = dgSanPham.Rows[rindex].Cells[0].Value.ToString();
                txtProductName.Text = dgSanPham.Rows[rindex].Cells[1].Value.ToString();
                txtProduction.Text = dgSanPham.Rows[rindex].Cells[2].Value.ToString();
                txtPrice.Text = dgSanPham.Rows[rindex].Cells[3].Value.ToString();
                txtStatus.Text = dgSanPham.Rows[rindex].Cells[4].Value.ToString();
                txtIntactRatio.Text = dgSanPham.Rows[rindex].Cells[5].Value.ToString();
                txtDistributor.Text = dgSanPham.Rows[rindex].Cells[6].Value.ToString();


               
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string SqlConnectionString = @"Data Source=DESKTOP-NMATOM3\SQLEXPRESS;Initial Catalog=CameraManager;Integrated Security=True";
                SqlConnection conn = new SqlConnection(SqlConnectionString);
                conn.Open();
                string Del_Query = $"Delete from Camera_Info  where Id =N'{txtId.Text}'";
                SqlCommand cmd = new SqlCommand(Del_Query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDb();
                conn.Close();

            }
            catch
            {
                MessageBox.Show("Hãy kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnfrmProductManager_Click(object sender, EventArgs e)
        {

        }

        private void btnfrmCreate_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnfrmCreate_Click_1(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void btnViewQRcode_Click(object sender, EventArgs e)
        {
            KiemTraSanPham ktsp = new KiemTraSanPham();
            ktsp.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                string key = "%"+txtSearch.Text+"%";
                string SqlConnectionString = @"Data Source=DESKTOP-NMATOM3\SQLEXPRESS;Initial Catalog=CameraManager;Integrated Security=True";
                SqlConnection conn = new SqlConnection(SqlConnectionString);
                conn.Open();
                string Search_Query = $"select * from Camera_Info where ID like N'{key}' or Name like N'{key}' or Production like N'{key}' or Status like N'{key}' or IntactRatio like N'{key}' or Distributor like N'{key}' ";
                SqlDataAdapter adt = new SqlDataAdapter(Search_Query, conn);
                DataSet ds = new DataSet();
                adt.Fill(ds, "Search");
                dgSanPham.DataSource = ds.Tables["Search"];
                conn.Close();

            }
            catch
            {
                MessageBox.Show("Hãy kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (sub_panel.Visible == true)
            {
                sub_panel.Visible = false;
            }
            else
            {
                sub_panel.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TrangChu ct = new TrangChu();
            ct.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LoadDb();
        }
    }
}
