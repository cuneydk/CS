namespace Yazlabkargo
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbUserName = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbPass = new System.Windows.Forms.Label();
            this.tbPassConfirm = new System.Windows.Forms.TextBox();
            this.lbConfirmPass = new System.Windows.Forms.Label();
            this.tbNewUsrPass = new System.Windows.Forms.TextBox();
            this.lbNewUserPass = new System.Windows.Forms.Label();
            this.tbNewUser = new System.Windows.Forms.TextBox();
            this.lbNewUser = new System.Windows.Forms.Label();
            this.tbNewPass = new System.Windows.Forms.TextBox();
            this.lbNewPass = new System.Windows.Forms.Label();
            this.lbSingInEkrani = new System.Windows.Forms.Label();
            this.lbCreateUserEkrani = new System.Windows.Forms.Label();
            this.lbChangePassEkran = new System.Windows.Forms.Label();
            this.btSignIn = new System.Windows.Forms.Button();
            this.btSingUp = new System.Windows.Forms.Button();
            this.btChangePass = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.btSave = new System.Windows.Forms.Button();
            this.lbMusteriCity = new System.Windows.Forms.Label();
            this.tbMusteriCity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMusteri = new System.Windows.Forms.TextBox();
            this.lbMusteriAd = new System.Windows.Forms.Label();
            this.rtbMusteriAdres = new System.Windows.Forms.RichTextBox();
            this.lbAdres = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbKargoEkrani = new System.Windows.Forms.Label();
            this.lbKullanici = new System.Windows.Forms.Label();
            this.getroute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbUserName
            // 
            this.lbUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbUserName.AutoSize = true;
            this.lbUserName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbUserName.Location = new System.Drawing.Point(2, 42);
            this.lbUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(60, 13);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "User Name";
            // 
            // tbUserName
            // 
            this.tbUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbUserName.Location = new System.Drawing.Point(66, 42);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(2);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(76, 20);
            this.tbUserName.TabIndex = 1;
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbPassword.Location = new System.Drawing.Point(66, 67);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(76, 20);
            this.tbPassword.TabIndex = 3;
            // 
            // lbPass
            // 
            this.lbPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPass.AutoSize = true;
            this.lbPass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbPass.Location = new System.Drawing.Point(2, 67);
            this.lbPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(53, 13);
            this.lbPass.TabIndex = 2;
            this.lbPass.Text = "Password";
            // 
            // tbPassConfirm
            // 
            this.tbPassConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbPassConfirm.Location = new System.Drawing.Point(400, 91);
            this.tbPassConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassConfirm.Name = "tbPassConfirm";
            this.tbPassConfirm.PasswordChar = '*';
            this.tbPassConfirm.Size = new System.Drawing.Size(76, 20);
            this.tbPassConfirm.TabIndex = 11;
            // 
            // lbConfirmPass
            // 
            this.lbConfirmPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbConfirmPass.AutoSize = true;
            this.lbConfirmPass.ForeColor = System.Drawing.SystemColors.Control;
            this.lbConfirmPass.Location = new System.Drawing.Point(337, 94);
            this.lbConfirmPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbConfirmPass.Name = "lbConfirmPass";
            this.lbConfirmPass.Size = new System.Drawing.Size(42, 13);
            this.lbConfirmPass.TabIndex = 10;
            this.lbConfirmPass.Text = "Confirm";
            // 
            // tbNewUsrPass
            // 
            this.tbNewUsrPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbNewUsrPass.Location = new System.Drawing.Point(400, 67);
            this.tbNewUsrPass.Margin = new System.Windows.Forms.Padding(2);
            this.tbNewUsrPass.Name = "tbNewUsrPass";
            this.tbNewUsrPass.PasswordChar = '*';
            this.tbNewUsrPass.Size = new System.Drawing.Size(76, 20);
            this.tbNewUsrPass.TabIndex = 9;
            // 
            // lbNewUserPass
            // 
            this.lbNewUserPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbNewUserPass.AutoSize = true;
            this.lbNewUserPass.ForeColor = System.Drawing.SystemColors.Control;
            this.lbNewUserPass.Location = new System.Drawing.Point(337, 70);
            this.lbNewUserPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNewUserPass.Name = "lbNewUserPass";
            this.lbNewUserPass.Size = new System.Drawing.Size(53, 13);
            this.lbNewUserPass.TabIndex = 8;
            this.lbNewUserPass.Text = "Password";
            // 
            // tbNewUser
            // 
            this.tbNewUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbNewUser.Location = new System.Drawing.Point(400, 42);
            this.tbNewUser.Margin = new System.Windows.Forms.Padding(2);
            this.tbNewUser.Name = "tbNewUser";
            this.tbNewUser.Size = new System.Drawing.Size(76, 20);
            this.tbNewUser.TabIndex = 7;
            // 
            // lbNewUser
            // 
            this.lbNewUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbNewUser.AutoSize = true;
            this.lbNewUser.ForeColor = System.Drawing.SystemColors.Control;
            this.lbNewUser.Location = new System.Drawing.Point(337, 45);
            this.lbNewUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNewUser.Name = "lbNewUser";
            this.lbNewUser.Size = new System.Drawing.Size(60, 13);
            this.lbNewUser.TabIndex = 6;
            this.lbNewUser.Text = "User Name";
            // 
            // tbNewPass
            // 
            this.tbNewPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbNewPass.Location = new System.Drawing.Point(213, 42);
            this.tbNewPass.Margin = new System.Windows.Forms.Padding(2);
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.PasswordChar = '*';
            this.tbNewPass.Size = new System.Drawing.Size(76, 20);
            this.tbNewPass.TabIndex = 13;
            // 
            // lbNewPass
            // 
            this.lbNewPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbNewPass.AutoSize = true;
            this.lbNewPass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbNewPass.Location = new System.Drawing.Point(157, 45);
            this.lbNewPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNewPass.Name = "lbNewPass";
            this.lbNewPass.Size = new System.Drawing.Size(55, 13);
            this.lbNewPass.TabIndex = 12;
            this.lbNewPass.Text = "New Pass";
            // 
            // lbSingInEkrani
            // 
            this.lbSingInEkrani.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbSingInEkrani.AutoSize = true;
            this.lbSingInEkrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSingInEkrani.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSingInEkrani.Location = new System.Drawing.Point(61, 15);
            this.lbSingInEkrani.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSingInEkrani.Name = "lbSingInEkrani";
            this.lbSingInEkrani.Size = new System.Drawing.Size(81, 13);
            this.lbSingInEkrani.TabIndex = 20;
            this.lbSingInEkrani.Text = "OTURUM AÇ";
            // 
            // lbCreateUserEkrani
            // 
            this.lbCreateUserEkrani.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCreateUserEkrani.AutoSize = true;
            this.lbCreateUserEkrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbCreateUserEkrani.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCreateUserEkrani.Location = new System.Drawing.Point(364, 15);
            this.lbCreateUserEkrani.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCreateUserEkrani.Name = "lbCreateUserEkrani";
            this.lbCreateUserEkrani.Size = new System.Drawing.Size(104, 13);
            this.lbCreateUserEkrani.TabIndex = 19;
            this.lbCreateUserEkrani.Text = "YENİ KULLANICI";
            // 
            // lbChangePassEkran
            // 
            this.lbChangePassEkran.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbChangePassEkran.AutoSize = true;
            this.lbChangePassEkran.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbChangePassEkran.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbChangePassEkran.Location = new System.Drawing.Point(197, 15);
            this.lbChangePassEkran.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbChangePassEkran.Name = "lbChangePassEkran";
            this.lbChangePassEkran.Size = new System.Drawing.Size(106, 13);
            this.lbChangePassEkran.TabIndex = 18;
            this.lbChangePassEkran.Text = "ŞİFRE DEĞİŞTİR";
            // 
            // btSignIn
            // 
            this.btSignIn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btSignIn.Location = new System.Drawing.Point(71, 91);
            this.btSignIn.Margin = new System.Windows.Forms.Padding(2);
            this.btSignIn.Name = "btSignIn";
            this.btSignIn.Size = new System.Drawing.Size(64, 26);
            this.btSignIn.TabIndex = 21;
            this.btSignIn.Text = "Giriş";
            this.btSignIn.UseVisualStyleBackColor = false;
            this.btSignIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // btSingUp
            // 
            this.btSingUp.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btSingUp.Location = new System.Drawing.Point(404, 115);
            this.btSingUp.Margin = new System.Windows.Forms.Padding(2);
            this.btSingUp.Name = "btSingUp";
            this.btSingUp.Size = new System.Drawing.Size(64, 26);
            this.btSingUp.TabIndex = 22;
            this.btSingUp.Text = "Kayıt ol";
            this.btSingUp.UseVisualStyleBackColor = false;
            this.btSingUp.Click += new System.EventHandler(this.button2_Click);
            // 
            // btChangePass
            // 
            this.btChangePass.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btChangePass.Location = new System.Drawing.Point(212, 66);
            this.btChangePass.Margin = new System.Windows.Forms.Padding(2);
            this.btChangePass.Name = "btChangePass";
            this.btChangePass.Size = new System.Drawing.Size(77, 28);
            this.btChangePass.TabIndex = 23;
            this.btChangePass.Text = "Şifre değiştir";
            this.btChangePass.UseVisualStyleBackColor = false;
            this.btChangePass.Click += new System.EventHandler(this.button3_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(480, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(488, 411);
            this.splitter1.TabIndex = 24;
            this.splitter1.TabStop = false;
            // 
            // gMapControl1
            // 
            this.gMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(480, 0);
            this.gMapControl1.Margin = new System.Windows.Forms.Padding(2);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(488, 411);
            this.gMapControl1.TabIndex = 25;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseClick);
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btSave.Location = new System.Drawing.Point(187, 265);
            this.btSave.Margin = new System.Windows.Forms.Padding(2);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(102, 28);
            this.btSave.TabIndex = 32;
            this.btSave.Text = "KARGO KAYDET";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.button4_Click);
            // 
            // lbMusteriCity
            // 
            this.lbMusteriCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbMusteriCity.AutoSize = true;
            this.lbMusteriCity.ForeColor = System.Drawing.SystemColors.Control;
            this.lbMusteriCity.Location = new System.Drawing.Point(7, 207);
            this.lbMusteriCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMusteriCity.Name = "lbMusteriCity";
            this.lbMusteriCity.Size = new System.Drawing.Size(44, 13);
            this.lbMusteriCity.TabIndex = 30;
            this.lbMusteriCity.Text = "Adres İli";
            // 
            // tbMusteriCity
            // 
            this.tbMusteriCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbMusteriCity.Location = new System.Drawing.Point(113, 204);
            this.tbMusteriCity.Margin = new System.Windows.Forms.Padding(2);
            this.tbMusteriCity.Name = "tbMusteriCity";
            this.tbMusteriCity.Size = new System.Drawing.Size(156, 20);
            this.tbMusteriCity.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(121, 200);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 28;
            // 
            // tbMusteri
            // 
            this.tbMusteri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbMusteri.Location = new System.Drawing.Point(113, 173);
            this.tbMusteri.Margin = new System.Windows.Forms.Padding(2);
            this.tbMusteri.Name = "tbMusteri";
            this.tbMusteri.Size = new System.Drawing.Size(156, 20);
            this.tbMusteri.TabIndex = 27;
            // 
            // lbMusteriAd
            // 
            this.lbMusteriAd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbMusteriAd.AutoSize = true;
            this.lbMusteriAd.ForeColor = System.Drawing.SystemColors.Control;
            this.lbMusteriAd.Location = new System.Drawing.Point(7, 176);
            this.lbMusteriAd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMusteriAd.Name = "lbMusteriAd";
            this.lbMusteriAd.Size = new System.Drawing.Size(94, 13);
            this.lbMusteriAd.TabIndex = 26;
            this.lbMusteriAd.Text = "Müşteri Adı Soyadı";
            // 
            // rtbMusteriAdres
            // 
            this.rtbMusteriAdres.Location = new System.Drawing.Point(113, 237);
            this.rtbMusteriAdres.Margin = new System.Windows.Forms.Padding(2);
            this.rtbMusteriAdres.Name = "rtbMusteriAdres";
            this.rtbMusteriAdres.Size = new System.Drawing.Size(355, 20);
            this.rtbMusteriAdres.TabIndex = 33;
            this.rtbMusteriAdres.Text = "";
            // 
            // lbAdres
            // 
            this.lbAdres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbAdres.AutoSize = true;
            this.lbAdres.ForeColor = System.Drawing.SystemColors.Control;
            this.lbAdres.Location = new System.Drawing.Point(7, 239);
            this.lbAdres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAdres.Name = "lbAdres";
            this.lbAdres.Size = new System.Drawing.Size(58, 13);
            this.lbAdres.TabIndex = 34;
            this.lbAdres.Text = "Açık Adres";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(5, 297);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(471, 108);
            this.listBox1.TabIndex = 35;
            // 
            // lbKargoEkrani
            // 
            this.lbKargoEkrani.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbKargoEkrani.AutoSize = true;
            this.lbKargoEkrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbKargoEkrani.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbKargoEkrani.Location = new System.Drawing.Point(197, 142);
            this.lbKargoEkrani.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbKargoEkrani.Name = "lbKargoEkrani";
            this.lbKargoEkrani.Size = new System.Drawing.Size(92, 13);
            this.lbKargoEkrani.TabIndex = 36;
            this.lbKargoEkrani.Text = "KARGO GİRİŞİ";
            // 
            // lbKullanici
            // 
            this.lbKullanici.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbKullanici.AutoSize = true;
            this.lbKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbKullanici.ForeColor = System.Drawing.Color.Chocolate;
            this.lbKullanici.Location = new System.Drawing.Point(290, 200);
            this.lbKullanici.Name = "lbKullanici";
            this.lbKullanici.Size = new System.Drawing.Size(27, 13);
            this.lbKullanici.TabIndex = 37;
            this.lbKullanici.Text = ".....";
            // 
            // getroute
            // 
            this.getroute.BackColor = System.Drawing.SystemColors.ControlDark;
            this.getroute.Location = new System.Drawing.Point(315, 267);
            this.getroute.Margin = new System.Windows.Forms.Padding(2);
            this.getroute.Name = "getroute";
            this.getroute.Size = new System.Drawing.Size(64, 26);
            this.getroute.TabIndex = 38;
            this.getroute.Text = "Yolu Çiz";
            this.getroute.UseVisualStyleBackColor = false;
            this.getroute.Click += new System.EventHandler(this.getroute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(968, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getroute);
            this.Controls.Add(this.lbKullanici);
            this.Controls.Add(this.lbKargoEkrani);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbAdres);
            this.Controls.Add(this.rtbMusteriAdres);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.lbMusteriCity);
            this.Controls.Add(this.tbMusteriCity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbMusteri);
            this.Controls.Add(this.lbMusteriAd);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.btChangePass);
            this.Controls.Add(this.btSingUp);
            this.Controls.Add(this.btSignIn);
            this.Controls.Add(this.lbSingInEkrani);
            this.Controls.Add(this.lbCreateUserEkrani);
            this.Controls.Add(this.lbChangePassEkran);
            this.Controls.Add(this.tbNewPass);
            this.Controls.Add(this.lbNewPass);
            this.Controls.Add(this.tbPassConfirm);
            this.Controls.Add(this.lbConfirmPass);
            this.Controls.Add(this.tbNewUsrPass);
            this.Controls.Add(this.lbNewUserPass);
            this.Controls.Add(this.tbNewUser);
            this.Controls.Add(this.lbNewUser);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.lbUserName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "KARGO TAKİP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.TextBox tbPassConfirm;
        private System.Windows.Forms.Label lbConfirmPass;
        private System.Windows.Forms.TextBox tbNewUsrPass;
        private System.Windows.Forms.Label lbNewUserPass;
        private System.Windows.Forms.TextBox tbNewUser;
        private System.Windows.Forms.Label lbNewUser;
        private System.Windows.Forms.TextBox tbNewPass;
        private System.Windows.Forms.Label lbNewPass;
        private System.Windows.Forms.Label lbSingInEkrani;
        private System.Windows.Forms.Label lbCreateUserEkrani;
        private System.Windows.Forms.Label lbChangePassEkran;
        private System.Windows.Forms.Button btSignIn;
        private System.Windows.Forms.Button btSingUp;
        private System.Windows.Forms.Button btChangePass;
        private System.Windows.Forms.Splitter splitter1;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label lbMusteriCity;
        private System.Windows.Forms.TextBox tbMusteriCity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMusteri;
        private System.Windows.Forms.Label lbMusteriAd;
        private System.Windows.Forms.RichTextBox rtbMusteriAdres;
        private System.Windows.Forms.Label lbAdres;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbKargoEkrani;
        private System.Windows.Forms.Label lbKullanici;
        private System.Windows.Forms.Button getroute;
        private System.Windows.Forms.Label label1;
    }
}

