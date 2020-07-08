using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace QRcode
{
    public partial class KiemTraSanPham : Form
    {
        private readonly IBarcodeReader barcodeReader;

   
        public KiemTraSanPham()
        {
            InitializeComponent();
            barcodeReader = new BarcodeReader();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

            using (var openDlg = new OpenFileDialog())
            {
                //openDlg.Multiselect = false;
                if (openDlg.ShowDialog(this) == DialogResult.OK)
                {
                    string fileName = openDlg.FileName;
                    if (!File.Exists(fileName))
                    {
                        return;
                    }

                    var image = (Bitmap)Bitmap.FromFile(fileName);
                    pictureBox.Image = image;

                    var result = barcodeReader.Decode(image);
                    if (result == null)
                    {
                        result = barcodeReader.Decode(image);
                    }

                    if (result == null)
                    {
                        MessageBox.Show("Không nhận diện được mã QR Code",
                        "QR Code Generator");
                    }
                    else
                    {
                        txtThongTinSanPham.Text = result.Text;
                    }
                }
            }

        }

        public void button2_Click(object sender, EventArgs e)
        {
            using (var openDlg = new OpenFileDialog())
            {
                openDlg.Multiselect = false;
                if (openDlg.ShowDialog(this) == DialogResult.OK)
                {
                    string fileName = openDlg.FileName;
                    if (!File.Exists(fileName))
                    {
                        return;
                    }

                    var image = (Bitmap)Bitmap.FromFile(fileName);
                    pictureBox.Image = image;

                    var result = barcodeReader.Decode(image);
                    if (result == null)
                    {
                        result = barcodeReader.Decode(image);
                    }

                    if (result == null)
                    {
                        MessageBox.Show("Không nhận diện được mã QR Code",
                        "QR Code Generator");
                    }
                    else
                    {
                        txtThongTinSanPham.Text = result.Text;
                        lblresult.Visible = true;
                        lblresult2.Visible = true;
                    }
                }
            }
        }

        private void btnfrmCreate_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QuanLySanPham qlsp = new QuanLySanPham();
            qlsp.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtThongTinSanPham.Text = "";
            pictureBox.Image = null;
            lblresult.Visible = false;
            lblresult2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Rectangle bounds = this.Bounds;
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
                }
                //bitmap.Save("C://test.jpg", ImageFormat.Png);
                SaveFileDialog f = new SaveFileDialog();
                f.Filter = "PNG(*.PNG)|*.PNG";
                if (f.ShowDialog() == DialogResult.OK)
                {
                    bitmap.Save(f.FileName);
                }
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (txtThongTinSanPham.Text != "")
            {
                Clipboard.SetText(txtThongTinSanPham.Text);
                 MessageBox.Show("Đã copy vào bộ nhớ tạm!","System");
            }
            else
            {
                MessageBox.Show("Không có gì để coppy", "System");
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

        private void btnViewQRcode_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TrangChu ct = new TrangChu();
            ct.Show();
            this.Hide();
        }
    }
}
