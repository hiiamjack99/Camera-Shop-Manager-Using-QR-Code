using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRcode
{
    public partial class TrangChu : Form
    {
        public static string dirParameter = AppDomain.CurrentDomain.BaseDirectory + @"file.txt";
        public TrangChu()
        {
            InitializeComponent();

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {        }

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

        private void button5_Click(object sender, EventArgs e)
        {
            CameraController control = new CameraController();
            control.Show();
            this.Hide();
        }

        private void btnfrmCreate_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void btnViewQRcode_Click(object sender, EventArgs e)
        {
            KiemTraSanPham kt = new KiemTraSanPham();
            kt.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QuanLySanPham ql = new QuanLySanPham();
            ql.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var p = new Process();
            p.StartInfo.FileName = @"D:\Photoshop\Photoshop.exe";  // just for example, you can use yours.
            p.Start();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.Width += 10;
            pictureBox5.Height += 10;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Width -= 10;
            pictureBox5.Height -= 10;
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.Width += 10;
            pictureBox6.Height += 10;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Width -= 10;
            pictureBox6.Height -= 10;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Width += 10;
            pictureBox4.Height += 10;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Width -= 10;
            pictureBox4.Height -= 10;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            var p = new Process();
            p.StartInfo.FileName = @"notepad.exe";  // just for example, you can use yours.
            p.Start();
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://websosanh.vn/tin-tuc/bang-gia-may-anh-canon-cap-nhat-moi-nhat-c24-20190413112448375.htm");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtghichu.Text == "")
            {
                MessageBox.Show("Vui lòng không để trống nội dung", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                saveFile(txtghichu.Text);
                MessageBox.Show(@"Đã lưu vào C:\User\Documents", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void saveFile(string name)
        {
            string Msg = txtghichu.Text;

            // Save File to .txt
            FileStream fParameter = new FileStream(dirParameter, FileMode.Create, FileAccess.Write);
            StreamWriter m_WriterParameter = new StreamWriter(fParameter);
            m_WriterParameter.BaseStream.Seek(0, SeekOrigin.End);
            m_WriterParameter.Write(Msg);
            m_WriterParameter.Flush();
            m_WriterParameter.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtghichu.Text = "";
        }
    }
}
