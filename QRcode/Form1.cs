using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;

namespace QRcode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtProductName.Text) || string.IsNullOrEmpty(txtProduction.Text) || string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(txtStatus.Text) || string.IsNullOrEmpty(txtIntactRatio.Text) || string.IsNullOrEmpty(txtDistributor.Text))
            {
                MessageBox.Show("Vui lòng không để trống nội dung",
                    "System");
                return;
            }
            try
            {

                string SqlConnectionString = @"Data Source=DESKTOP-NMATOM3\SQLEXPRESS;Initial Catalog=CameraManager;Integrated Security=True";
                SqlConnection conn = new SqlConnection(SqlConnectionString);
                conn.Open();
                string Insert_Query = $"insert into Camera_Info (ID,Name,Production,Price,Status,IntactRatio,Distributor) values (N'{txtId.Text}',N'{txtProductName.Text}',N'{txtProduction.Text}',N'{txtPrice.Text}',N'{txtStatus.Text}',N'{txtIntactRatio.Text}',N'{txtDistributor.Text}')";
                SqlCommand cmd = new SqlCommand(Insert_Query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                //tao QR code

                var barcodeWriter = new BarcodeWriter
                {
                    Format = BarcodeFormat.QR_CODE,
                    Options = new EncodingOptions
                    {
                        Height = 150,
                        Width = 150,
                        Margin = 0
                    }
                };

                string content = "ID:" + txtId.Text + "\n" + "Name:" + txtProductName.Text + "\n" + "Production:" + txtProduction.Text + "\n" + "Price:" + txtPrice.Text + " VND" + "\n" + "Status:" + txtStatus.Text + "\n" + "Intact ratio:" + txtIntactRatio.Text + "%" + "\n" + "Distributor:" + txtDistributor.Text;

                using (var bitmap = barcodeWriter.Write(content))
                {
                    using (var stream = new MemoryStream())
                    {
                        bitmap.Save(stream, ImageFormat.Png);
                        var image = Image.FromStream(stream);
                        pictureBox.Image = image;
                        //pictureBox.Image.Save("D:\\temp.png", ImageFormat.Png);

                    }
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null)
            {
                MessageBox.Show("Đã xảy ra lỗi vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveFileDialog f = new SaveFileDialog();
            f.Filter = "PNG(*.PNG)|*.PNG";
            if (f.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image.Save(f.FileName);
            }
            
}

        private void button3_Click(object sender, EventArgs e)
        {
            QuanLySanPham frmQLSP = new QuanLySanPham();
            frmQLSP.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnViewQRcode_Click(object sender, EventArgs e)
        {
            KiemTraSanPham ktsp = new KiemTraSanPham();
            ktsp.Show();
            this.Hide();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                MessageBox.Show("Bạn vừa nhấn phím Enter");
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://google.com/"+ "search?query=" + txtSeach.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TrangChu tt = new TrangChu();
            tt.Show();
            this.Hide();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
