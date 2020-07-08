using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ozeki.Camera;
using Ozeki.Media;
using System.Drawing.Imaging;
using System.Globalization;

namespace QRcode
{
    public partial class CameraController : Form
    {
        private OzekiCamera _webCamera;
        private DrawingImageProvider _Provider;
        private DrawingImageProvider _imageProvider;
        private MediaConnector _mediaConnector;
        private CameraURLBuilderWF _myCameraUrlBuilder;
        private Zoom zoom;
        private MediaConnector _connector;
        public CameraController()
        {
            InitializeComponent();
            _imageProvider = new DrawingImageProvider();
            _mediaConnector = new MediaConnector();
            _connector = new MediaConnector();
            _Provider = new DrawingImageProvider();

            videoViewerWF1.SetImageProvider(_Provider);
            _myCameraUrlBuilder = new CameraURLBuilderWF();

            zoom = new Zoom();

            videoViewerWF1.SetImageProvider(_imageProvider);
        }

        private void CameraController_Load(object sender, EventArgs e)
        {

        }

        private void btn_Connect_Click_Click(object sender, EventArgs e)
        {
            if (_webCamera != null)
            {
                videoViewerWF1.Stop();
                _webCamera.Stop();
                _mediaConnector.Disconnect(_webCamera.VideoChannel, _imageProvider);
            }
            btn_Connect.Enabled = false;

            _webCamera = new OzekiCamera(_myCameraUrlBuilder.CameraURL);

            _webCamera.CameraStateChanged += _webCamera_CameraStateChanged;

            //_mediaConnector.Connect(_webCamera.VideoChannel, _imageProvider);

            // _connector.Connect(_webCamera.VideoChannel, zoom);
           // _connector.Connect(zoom, _imageProvider);
           _mediaConnector.Connect(_webCamera.VideoChannel, zoom);
            _mediaConnector.Connect(zoom, _imageProvider);

            _webCamera.Start();

            videoViewerWF1.Start();
            zoom.Start();
        }
        void _webCamera_CameraStateChanged(object sender, CameraStateEventArgs e)
        {
            InvokeGuiThread(() =>
            {
                switch (e.State)
                {
                    case CameraState.Streaming:
                        btn_Disconnect.Enabled = true;
                        break;
                    case CameraState.Disconnected:
                        btn_Disconnect.Enabled = false;
                        btn_Connect.Enabled = true;
                        break;
                }
            });
        }
        private void InvokeGuiThread(Action action)
        {
            BeginInvoke(action);
        }

        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
            videoViewerWF1.Stop();
            _webCamera.Stop();
            _mediaConnector.Disconnect(_webCamera.VideoChannel, _imageProvider);
            _webCamera = null;
        }

        private void btn_btn_Compose_Click(object sender, EventArgs e)
        {
            var data = new CameraURLBuilderData { DeviceTypeFilter = DiscoverDeviceType.USB };
            _myCameraUrlBuilder = new CameraURLBuilderWF(data);
            var result = _myCameraUrlBuilder.ShowDialog();

            if (result != DialogResult.OK)
                return;

            textBox1.Text = _myCameraUrlBuilder.CameraURL;

            btn_Connect.Enabled = true;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            try
            {
                var height = int.Parse(heightText.Text);
                var width = int.Parse(widthText.Text);
                if (!(height < 40 || height > 320)) // 40 - 320
                    videoViewerWF1.Height = height;
                else
                {
                    if (!(height >= 40))
                    {
                        videoViewerWF1.Height = 40;
                        heightText.Text = videoViewerWF1.Height.ToString();
                    }

                    if (!(height <= 320))
                    {
                        videoViewerWF1.Height = 320;
                        heightText.Text = videoViewerWF1.Height.ToString();
                    }
                }
                if (!(width < 50 || width > 400)) // 50 - 400
                    videoViewerWF1.Width = width;
                else
                {
                    if (!(width >= 50))
                    {
                        videoViewerWF1.Width = 50;
                        widthText.Text = videoViewerWF1.Width.ToString();
                    }
                    videoViewerWF1.Width = 50;
                    if (!(width <= 400))
                    {
                        videoViewerWF1.Width = 400;
                        widthText.Text = videoViewerWF1.Width.ToString();
                    }
                }
                ControlToCenter();
            }

            catch (Exception exception)
            {
                MessageBox.Show("Lỗi");
            }

        }
        private void ControlToCenter()
        {
            videoViewerWF1.Anchor = AnchorStyles.None;
            videoViewerWF1.Dock = DockStyle.None;
            var pt = CameraBox.DisplayRectangle.Location;
            pt.X += (CameraBox.DisplayRectangle.Width - videoViewerWF1.Width) / 2;

            pt.Y += (CameraBox.DisplayRectangle.Height - videoViewerWF1.Height) / 2;

            videoViewerWF1.Location = pt;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TrangChu tt = new TrangChu();
            tt.Show();
            this.Hide();
        }

        private void save_Butt_Click(object sender, EventArgs e)
        {
            /*try
            {
                var bmp = ScreenCapture.SaveAllScreens();
                var path = "c:\\myBitmap.jpg";
                //bmp.Save(path);
                //MessageBox.Show("Screen saved to: " + path);
                SaveFileDialog f = new SaveFileDialog();
                f.Filter = "PNG(*.PNG)|*.PNG";
                if (f.ShowDialog() == DialogResult.OK)
                {
                    bmp.Save(f.FileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem saving the file." +
                    "Check the file permissions.");
            }*/
            System.Drawing.Rectangle bounds = this.Bounds;
           
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
                    
                }
  
                SaveFileDialog f = new SaveFileDialog();
                f.Filter = "PNG(*.PNG)|*.PNG";
                if (f.ShowDialog() == DialogResult.OK)
                {
                    bitmap.Save(f.FileName);
                }
            }
        }

        private void btn_zoomplus_Click(object sender, EventArgs e)
        {
            zoom.In();
            textBox_factor.Text = zoom.Factor.ToString(CultureInfo.InvariantCulture);
        }

        private void btn_zoommin_Click(object sender, EventArgs e)
        {
            zoom.Out();
            textBox_factor.Text = zoom.Factor.ToString(CultureInfo.InvariantCulture);
        }

        private void btnfrmCreate_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
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

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
