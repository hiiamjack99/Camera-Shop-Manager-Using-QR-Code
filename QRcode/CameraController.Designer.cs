namespace QRcode
{
    partial class CameraController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CameraController));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.sub_panel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.btn_btn_Compose = new System.Windows.Forms.Button();
            this.btn_Disconnect = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.applyButton = new System.Windows.Forms.Button();
            this.widthText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.heightText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CameraBox = new System.Windows.Forms.GroupBox();
            this.videoViewerWF1 = new Ozeki.Media.VideoViewerWF();
            this.save_Butt = new System.Windows.Forms.Button();
            this.lab_zoomfactor = new System.Windows.Forms.Label();
            this.textBox_factor = new System.Windows.Forms.TextBox();
            this.btn_zoommin = new System.Windows.Forms.Button();
            this.btn_zoomplus = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnfrmCreate = new System.Windows.Forms.Button();
            this.btnViewQRcode = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.sub_panel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.CameraBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 550);
            this.panel1.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(8)))), ((int)(((byte)(37)))));
            this.panel4.Controls.Add(this.sub_panel);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.btnfrmCreate);
            this.panel4.Controls.Add(this.btnViewQRcode);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Location = new System.Drawing.Point(0, 106);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(187, 384);
            this.panel4.TabIndex = 2;
            // 
            // sub_panel
            // 
            this.sub_panel.BackColor = System.Drawing.Color.Black;
            this.sub_panel.Controls.Add(this.button7);
            this.sub_panel.Controls.Add(this.button6);
            this.sub_panel.Controls.Add(this.button5);
            this.sub_panel.Location = new System.Drawing.Point(3, 190);
            this.sub_panel.Name = "sub_panel";
            this.sub_panel.Size = new System.Drawing.Size(187, 191);
            this.sub_panel.TabIndex = 1;
            this.sub_panel.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.txtSearch);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(190, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(818, 55);
            this.panel5.TabIndex = 13;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(463, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(224, 24);
            this.txtSearch.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(391, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Tìm kiếm:";
            // 
            // btn_Connect
            // 
            this.btn_Connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Connect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.btn_Connect.Location = new System.Drawing.Point(725, 178);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(120, 29);
            this.btn_Connect.TabIndex = 16;
            this.btn_Connect.Text = "Conect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click_Click);
            // 
            // btn_btn_Compose
            // 
            this.btn_btn_Compose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_btn_Compose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_btn_Compose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.btn_btn_Compose.Location = new System.Drawing.Point(787, 115);
            this.btn_btn_Compose.Name = "btn_btn_Compose";
            this.btn_btn_Compose.Size = new System.Drawing.Size(117, 31);
            this.btn_btn_Compose.TabIndex = 16;
            this.btn_btn_Compose.Text = "Chọn thiết bị";
            this.btn_btn_Compose.UseVisualStyleBackColor = true;
            this.btn_btn_Compose.Click += new System.EventHandler(this.btn_btn_Compose_Click);
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Disconnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.btn_Disconnect.Location = new System.Drawing.Point(851, 178);
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.Size = new System.Drawing.Size(119, 29);
            this.btn_Disconnect.TabIndex = 16;
            this.btn_Disconnect.Text = "Disconect";
            this.btn_Disconnect.UseVisualStyleBackColor = true;
            this.btn_Disconnect.Click += new System.EventHandler(this.btn_Disconnect_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(725, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 22);
            this.textBox1.TabIndex = 17;
            // 
            // applyButton
            // 
            this.applyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.applyButton.Location = new System.Drawing.Point(937, 260);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(59, 23);
            this.applyButton.TabIndex = 23;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // widthText
            // 
            this.widthText.Location = new System.Drawing.Point(842, 263);
            this.widthText.Name = "widthText";
            this.widthText.Size = new System.Drawing.Size(79, 20);
            this.widthText.TabIndex = 22;
            this.widthText.Text = "420";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.label10.Location = new System.Drawing.Point(670, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Width:";
            // 
            // heightText
            // 
            this.heightText.Location = new System.Drawing.Point(714, 263);
            this.heightText.Name = "heightText";
            this.heightText.Size = new System.Drawing.Size(67, 20);
            this.heightText.TabIndex = 20;
            this.heightText.Text = "320";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.label1.Location = new System.Drawing.Point(787, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Height:";
            // 
            // CameraBox
            // 
            this.CameraBox.BackColor = System.Drawing.Color.Black;
            this.CameraBox.Controls.Add(this.videoViewerWF1);
            this.CameraBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.CameraBox.Location = new System.Drawing.Point(214, 71);
            this.CameraBox.Name = "CameraBox";
            this.CameraBox.Size = new System.Drawing.Size(450, 360);
            this.CameraBox.TabIndex = 24;
            this.CameraBox.TabStop = false;
            this.CameraBox.Text = "Live camera ";
            // 
            // videoViewerWF1
            // 
            this.videoViewerWF1.BackColor = System.Drawing.Color.Black;
            this.videoViewerWF1.ContextMenuEnabled = true;
            this.videoViewerWF1.FlipMode = Ozeki.Media.FlipMode.None;
            this.videoViewerWF1.FrameStretch = Ozeki.Media.FrameStretch.Uniform;
            this.videoViewerWF1.FullScreenEnabled = true;
            this.videoViewerWF1.Location = new System.Drawing.Point(6, 19);
            this.videoViewerWF1.Name = "videoViewerWF1";
            this.videoViewerWF1.RotateAngle = 0;
            this.videoViewerWF1.Size = new System.Drawing.Size(438, 335);
            this.videoViewerWF1.TabIndex = 0;
            this.videoViewerWF1.Text = "videoViewerWF1";
            // 
            // save_Butt
            // 
            this.save_Butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_Butt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.save_Butt.Location = new System.Drawing.Point(698, 400);
            this.save_Butt.Name = "save_Butt";
            this.save_Butt.Size = new System.Drawing.Size(120, 29);
            this.save_Butt.TabIndex = 16;
            this.save_Butt.Text = "Capture";
            this.save_Butt.UseVisualStyleBackColor = true;
            this.save_Butt.Click += new System.EventHandler(this.save_Butt_Click);
            // 
            // lab_zoomfactor
            // 
            this.lab_zoomfactor.AutoSize = true;
            this.lab_zoomfactor.Location = new System.Drawing.Point(810, 323);
            this.lab_zoomfactor.Name = "lab_zoomfactor";
            this.lab_zoomfactor.Size = new System.Drawing.Size(70, 13);
            this.lab_zoomfactor.TabIndex = 28;
            this.lab_zoomfactor.Text = " Zoom factor:";
            // 
            // textBox_factor
            // 
            this.textBox_factor.Location = new System.Drawing.Point(811, 347);
            this.textBox_factor.Name = "textBox_factor";
            this.textBox_factor.Size = new System.Drawing.Size(75, 20);
            this.textBox_factor.TabIndex = 27;
            this.textBox_factor.Text = "1";
            // 
            // btn_zoommin
            // 
            this.btn_zoommin.Location = new System.Drawing.Point(910, 323);
            this.btn_zoommin.Name = "btn_zoommin";
            this.btn_zoommin.Size = new System.Drawing.Size(75, 44);
            this.btn_zoommin.TabIndex = 26;
            this.btn_zoommin.Text = "Zoom -";
            this.btn_zoommin.UseVisualStyleBackColor = true;
            this.btn_zoommin.Click += new System.EventHandler(this.btn_zoommin_Click);
            // 
            // btn_zoomplus
            // 
            this.btn_zoomplus.Location = new System.Drawing.Point(714, 323);
            this.btn_zoomplus.Name = "btn_zoomplus";
            this.btn_zoomplus.Size = new System.Drawing.Size(73, 44);
            this.btn_zoomplus.TabIndex = 25;
            this.btn_zoomplus.Text = "Zoom +";
            this.btn_zoomplus.UseVisualStyleBackColor = true;
            this.btn_zoomplus.Click += new System.EventHandler(this.btn_zoomplus_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::QRcode.Properties.Resources._211885_24;
            this.button2.Location = new System.Drawing.Point(693, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 24);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.button1.Image = global::QRcode.Properties.Resources._171495_24__1_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thoát chương trình";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(95)))));
            this.button7.Image = global::QRcode.Properties.Resources._352158_24;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(19, 104);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(149, 41);
            this.button7.TabIndex = 0;
            this.button7.Text = "Updating...";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(95)))));
            this.button6.Image = global::QRcode.Properties.Resources._2559804_24;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(19, 57);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(186, 41);
            this.button6.TabIndex = 0;
            this.button6.Text = "Checking Shutter";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(95)))));
            this.button5.Image = global::QRcode.Properties.Resources._383091_24;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(19, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(179, 41);
            this.button5.TabIndex = 0;
            this.button5.Text = "Camera control";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.button4.Image = global::QRcode.Properties.Resources._186400_24;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(3, 154);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(184, 41);
            this.button4.TabIndex = 0;
            this.button4.Text = "Chức năng khác";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnfrmCreate
            // 
            this.btnfrmCreate.FlatAppearance.BorderSize = 0;
            this.btnfrmCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btnfrmCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfrmCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfrmCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.btnfrmCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnfrmCreate.Image")));
            this.btnfrmCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfrmCreate.Location = new System.Drawing.Point(0, 13);
            this.btnfrmCreate.Name = "btnfrmCreate";
            this.btnfrmCreate.Size = new System.Drawing.Size(223, 41);
            this.btnfrmCreate.TabIndex = 0;
            this.btnfrmCreate.Text = "Thêm mới sản phẩm";
            this.btnfrmCreate.UseVisualStyleBackColor = true;
            this.btnfrmCreate.Click += new System.EventHandler(this.btnfrmCreate_Click);
            // 
            // btnViewQRcode
            // 
            this.btnViewQRcode.FlatAppearance.BorderSize = 0;
            this.btnViewQRcode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btnViewQRcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewQRcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewQRcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.btnViewQRcode.Image = global::QRcode.Properties.Resources._126581_24;
            this.btnViewQRcode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewQRcode.Location = new System.Drawing.Point(3, 60);
            this.btnViewQRcode.Name = "btnViewQRcode";
            this.btnViewQRcode.Size = new System.Drawing.Size(198, 41);
            this.btnViewQRcode.TabIndex = 0;
            this.btnViewQRcode.Text = "Kiểm tra sản phẩm";
            this.btnViewQRcode.UseVisualStyleBackColor = true;
            this.btnViewQRcode.Click += new System.EventHandler(this.btnViewQRcode_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.button3.Image = global::QRcode.Properties.Resources._115746_24;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 41);
            this.button3.TabIndex = 0;
            this.button3.Text = "Quản lý sản phẩm";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CameraController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1008, 550);
            this.Controls.Add(this.lab_zoomfactor);
            this.Controls.Add(this.textBox_factor);
            this.Controls.Add(this.btn_zoommin);
            this.Controls.Add(this.btn_zoomplus);
            this.Controls.Add(this.CameraBox);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.widthText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.heightText);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Disconnect);
            this.Controls.Add(this.btn_btn_Compose);
            this.Controls.Add(this.save_Butt);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Name = "CameraController";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CameraController";
            this.Load += new System.EventHandler(this.CameraController_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.sub_panel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.CameraBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel sub_panel;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnfrmCreate;
        private System.Windows.Forms.Button btnViewQRcode;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Button btn_btn_Compose;
        private System.Windows.Forms.Button btn_Disconnect;
        private System.Windows.Forms.TextBox textBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.TextBox widthText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox heightText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox CameraBox;
        private Ozeki.Media.VideoViewerWF videoViewerWF1;
        private System.Windows.Forms.Button save_Butt;
        private System.Windows.Forms.Label lab_zoomfactor;
        private System.Windows.Forms.TextBox textBox_factor;
        private System.Windows.Forms.Button btn_zoommin;
        private System.Windows.Forms.Button btn_zoomplus;
    }
}