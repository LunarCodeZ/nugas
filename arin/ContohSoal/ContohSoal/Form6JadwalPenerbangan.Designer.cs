namespace ContohSoal
{
    partial class Form6JadwalPenerbangan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6JadwalPenerbangan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.teksDashboard = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.teksLogout = new System.Windows.Forms.Label();
            this.teksUbahStatusPenerbangan = new System.Windows.Forms.Label();
            this.teksMasterKodePromo = new System.Windows.Forms.Label();
            this.teksMasterJadwalPenerbangan = new System.Windows.Forms.Label();
            this.teksMasterMaskapai = new System.Windows.Forms.Label();
            this.teksMasterBandara = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.teksDashboard0 = new System.Windows.Forms.Label();
            this.teksDashboard1 = new System.Windows.Forms.Label();
            this.teksDashboard2 = new System.Windows.Forms.Label();
            this.teksDashboard5 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.teksDashboard4 = new System.Windows.Forms.Label();
            this.maskapaiBox = new System.Windows.Forms.ComboBox();
            this.teksDashboard3 = new System.Windows.Forms.Label();
            this.teksDashboard6 = new System.Windows.Forms.Label();
            this.teksDashboard7 = new System.Windows.Forms.Label();
            this.teksDashboard8 = new System.Windows.Forms.Label();
            this.teksDashboard9 = new System.Windows.Forms.Label();
            this.codeText = new System.Windows.Forms.TextBox();
            this.departureBox = new System.Windows.Forms.ComboBox();
            this.destinationBox = new System.Windows.Forms.ComboBox();
            this.departureDate = new System.Windows.Forms.DateTimePicker();
            this.ikonLogout = new System.Windows.Forms.PictureBox();
            this.ikonUbahStatusPenerbangan = new System.Windows.Forms.PictureBox();
            this.ikonMasterKodePromo = new System.Windows.Forms.PictureBox();
            this.ikonMasterJadwalPenerbangan = new System.Windows.Forms.PictureBox();
            this.ikonMasterMaskapai = new System.Windows.Forms.PictureBox();
            this.ikonMasterBandara = new System.Windows.Forms.PictureBox();
            this.ikonDashboard = new System.Windows.Forms.PictureBox();
            this.dataGridJadwal = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KodePenerbangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BandaraKeberangkatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BandaraTujuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maskapai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HargaPerTiket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaktuKeberangkatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.hapus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.departureTime = new System.Windows.Forms.DateTimePicker();
            this.priceCount = new System.Windows.Forms.NumericUpDown();
            this.durationText = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ikonLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ikonUbahStatusPenerbangan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ikonMasterKodePromo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ikonMasterJadwalPenerbangan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ikonMasterMaskapai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ikonMasterBandara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ikonDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridJadwal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceCount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.ikonDashboard);
            this.panel1.Controls.Add(this.teksDashboard);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1287, 87);
            this.panel1.TabIndex = 0;
            // 
            // teksDashboard
            // 
            this.teksDashboard.AutoSize = true;
            this.teksDashboard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksDashboard.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.teksDashboard.Location = new System.Drawing.Point(78, 27);
            this.teksDashboard.Name = "teksDashboard";
            this.teksDashboard.Size = new System.Drawing.Size(108, 28);
            this.teksDashboard.TabIndex = 2;
            this.teksDashboard.Text = "Dashboard";
            this.teksDashboard.Click += new System.EventHandler(this.teksDashboard_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ikonLogout);
            this.panel2.Controls.Add(this.ikonUbahStatusPenerbangan);
            this.panel2.Controls.Add(this.ikonMasterKodePromo);
            this.panel2.Controls.Add(this.ikonMasterJadwalPenerbangan);
            this.panel2.Controls.Add(this.ikonMasterMaskapai);
            this.panel2.Controls.Add(this.ikonMasterBandara);
            this.panel2.Controls.Add(this.teksLogout);
            this.panel2.Controls.Add(this.teksUbahStatusPenerbangan);
            this.panel2.Controls.Add(this.teksMasterKodePromo);
            this.panel2.Controls.Add(this.teksMasterJadwalPenerbangan);
            this.panel2.Controls.Add(this.teksMasterMaskapai);
            this.panel2.Controls.Add(this.teksMasterBandara);
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel2.Location = new System.Drawing.Point(-1, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 597);
            this.panel2.TabIndex = 1;
            // 
            // teksLogout
            // 
            this.teksLogout.AutoSize = true;
            this.teksLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksLogout.ForeColor = System.Drawing.Color.Red;
            this.teksLogout.Location = new System.Drawing.Point(77, 547);
            this.teksLogout.Name = "teksLogout";
            this.teksLogout.Size = new System.Drawing.Size(75, 28);
            this.teksLogout.TabIndex = 2;
            this.teksLogout.Text = "Logout";
            this.teksLogout.Click += new System.EventHandler(this.teksLogout_Click);
            // 
            // teksUbahStatusPenerbangan
            // 
            this.teksUbahStatusPenerbangan.AutoSize = true;
            this.teksUbahStatusPenerbangan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksUbahStatusPenerbangan.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.teksUbahStatusPenerbangan.Location = new System.Drawing.Point(77, 254);
            this.teksUbahStatusPenerbangan.Name = "teksUbahStatusPenerbangan";
            this.teksUbahStatusPenerbangan.Size = new System.Drawing.Size(236, 28);
            this.teksUbahStatusPenerbangan.TabIndex = 2;
            this.teksUbahStatusPenerbangan.Text = "Ubah Status Penerbangan";
            this.teksUbahStatusPenerbangan.Click += new System.EventHandler(this.teksUbahStatusPenerbangan_Click);
            // 
            // teksMasterKodePromo
            // 
            this.teksMasterKodePromo.AutoSize = true;
            this.teksMasterKodePromo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksMasterKodePromo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.teksMasterKodePromo.Location = new System.Drawing.Point(77, 195);
            this.teksMasterKodePromo.Name = "teksMasterKodePromo";
            this.teksMasterKodePromo.Size = new System.Drawing.Size(187, 28);
            this.teksMasterKodePromo.TabIndex = 2;
            this.teksMasterKodePromo.Text = "Master Kode Promo";
            this.teksMasterKodePromo.Click += new System.EventHandler(this.teksMasterKodePromo_Click);
            // 
            // teksMasterJadwalPenerbangan
            // 
            this.teksMasterJadwalPenerbangan.AutoSize = true;
            this.teksMasterJadwalPenerbangan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksMasterJadwalPenerbangan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.teksMasterJadwalPenerbangan.Location = new System.Drawing.Point(77, 138);
            this.teksMasterJadwalPenerbangan.Name = "teksMasterJadwalPenerbangan";
            this.teksMasterJadwalPenerbangan.Size = new System.Drawing.Size(254, 28);
            this.teksMasterJadwalPenerbangan.TabIndex = 2;
            this.teksMasterJadwalPenerbangan.Text = "Master Jadwal Penerbangan";
            // 
            // teksMasterMaskapai
            // 
            this.teksMasterMaskapai.AutoSize = true;
            this.teksMasterMaskapai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksMasterMaskapai.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.teksMasterMaskapai.Location = new System.Drawing.Point(77, 76);
            this.teksMasterMaskapai.Name = "teksMasterMaskapai";
            this.teksMasterMaskapai.Size = new System.Drawing.Size(160, 28);
            this.teksMasterMaskapai.TabIndex = 2;
            this.teksMasterMaskapai.Text = "Master Maskapai";
            this.teksMasterMaskapai.Click += new System.EventHandler(this.teksMasterMaskapai_Click);
            // 
            // teksMasterBandara
            // 
            this.teksMasterBandara.AutoSize = true;
            this.teksMasterBandara.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksMasterBandara.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.teksMasterBandara.Location = new System.Drawing.Point(77, 19);
            this.teksMasterBandara.Name = "teksMasterBandara";
            this.teksMasterBandara.Size = new System.Drawing.Size(148, 28);
            this.teksMasterBandara.TabIndex = 2;
            this.teksMasterBandara.Text = "Master Bandara";
            this.teksMasterBandara.Click += new System.EventHandler(this.teksMasterBandara_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(368, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(336, 32);
            this.label8.TabIndex = 2;
            this.label8.Text = "Master Jadwal Penerbangan";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(369, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(387, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Semua jadwal penerbangan akan muncul di sini";
            // 
            // teksDashboard0
            // 
            this.teksDashboard0.AutoSize = true;
            this.teksDashboard0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksDashboard0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.teksDashboard0.Location = new System.Drawing.Point(576, 466);
            this.teksDashboard0.Name = "teksDashboard0";
            this.teksDashboard0.Size = new System.Drawing.Size(0, 25);
            this.teksDashboard0.TabIndex = 2;
            // 
            // teksDashboard1
            // 
            this.teksDashboard1.AutoSize = true;
            this.teksDashboard1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksDashboard1.Location = new System.Drawing.Point(369, 442);
            this.teksDashboard1.Name = "teksDashboard1";
            this.teksDashboard1.Size = new System.Drawing.Size(161, 25);
            this.teksDashboard1.TabIndex = 2;
            this.teksDashboard1.Text = "Kode Penerbangan";
            // 
            // teksDashboard2
            // 
            this.teksDashboard2.AutoSize = true;
            this.teksDashboard2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksDashboard2.Location = new System.Drawing.Point(369, 482);
            this.teksDashboard2.Name = "teksDashboard2";
            this.teksDashboard2.Size = new System.Drawing.Size(44, 25);
            this.teksDashboard2.TabIndex = 2;
            this.teksDashboard2.Text = "Dari";
            // 
            // teksDashboard5
            // 
            this.teksDashboard5.AutoSize = true;
            this.teksDashboard5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksDashboard5.Location = new System.Drawing.Point(369, 524);
            this.teksDashboard5.Name = "teksDashboard5";
            this.teksDashboard5.Size = new System.Drawing.Size(31, 25);
            this.teksDashboard5.TabIndex = 2;
            this.teksDashboard5.Text = "Ke";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(996, 619);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(123, 42);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Batal";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(1138, 619);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(123, 42);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "Simpan";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // teksDashboard4
            // 
            this.teksDashboard4.AutoSize = true;
            this.teksDashboard4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksDashboard4.Location = new System.Drawing.Point(369, 563);
            this.teksDashboard4.Name = "teksDashboard4";
            this.teksDashboard4.Size = new System.Drawing.Size(87, 25);
            this.teksDashboard4.TabIndex = 2;
            this.teksDashboard4.Text = "Maskapai";
            // 
            // maskapaiBox
            // 
            this.maskapaiBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskapaiBox.FormattingEnabled = true;
            this.maskapaiBox.Location = new System.Drawing.Point(536, 558);
            this.maskapaiBox.Name = "maskapaiBox";
            this.maskapaiBox.Size = new System.Drawing.Size(222, 33);
            this.maskapaiBox.TabIndex = 9;
            // 
            // teksDashboard3
            // 
            this.teksDashboard3.AutoSize = true;
            this.teksDashboard3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksDashboard3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.teksDashboard3.Location = new System.Drawing.Point(1025, 466);
            this.teksDashboard3.Name = "teksDashboard3";
            this.teksDashboard3.Size = new System.Drawing.Size(0, 25);
            this.teksDashboard3.TabIndex = 10;
            // 
            // teksDashboard6
            // 
            this.teksDashboard6.AutoSize = true;
            this.teksDashboard6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksDashboard6.Location = new System.Drawing.Point(787, 482);
            this.teksDashboard6.Name = "teksDashboard6";
            this.teksDashboard6.Size = new System.Drawing.Size(185, 25);
            this.teksDashboard6.TabIndex = 11;
            this.teksDashboard6.Text = "Waktu Keberangkatan";
            // 
            // teksDashboard7
            // 
            this.teksDashboard7.AutoSize = true;
            this.teksDashboard7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksDashboard7.Location = new System.Drawing.Point(787, 518);
            this.teksDashboard7.Name = "teksDashboard7";
            this.teksDashboard7.Size = new System.Drawing.Size(170, 25);
            this.teksDashboard7.TabIndex = 12;
            this.teksDashboard7.Text = "Durasi Penerbangan";
            // 
            // teksDashboard8
            // 
            this.teksDashboard8.AutoSize = true;
            this.teksDashboard8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksDashboard8.Location = new System.Drawing.Point(787, 558);
            this.teksDashboard8.Name = "teksDashboard8";
            this.teksDashboard8.Size = new System.Drawing.Size(133, 25);
            this.teksDashboard8.TabIndex = 13;
            this.teksDashboard8.Text = "Harga per Tiket";
            // 
            // teksDashboard9
            // 
            this.teksDashboard9.AutoSize = true;
            this.teksDashboard9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksDashboard9.Location = new System.Drawing.Point(787, 442);
            this.teksDashboard9.Name = "teksDashboard9";
            this.teksDashboard9.Size = new System.Drawing.Size(73, 25);
            this.teksDashboard9.TabIndex = 14;
            this.teksDashboard9.Text = "Tanggal";
            // 
            // codeText
            // 
            this.codeText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeText.Location = new System.Drawing.Point(536, 440);
            this.codeText.Name = "codeText";
            this.codeText.Size = new System.Drawing.Size(222, 31);
            this.codeText.TabIndex = 4;
            // 
            // departureBox
            // 
            this.departureBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departureBox.FormattingEnabled = true;
            this.departureBox.Location = new System.Drawing.Point(536, 479);
            this.departureBox.Name = "departureBox";
            this.departureBox.Size = new System.Drawing.Size(222, 33);
            this.departureBox.TabIndex = 20;
            // 
            // destinationBox
            // 
            this.destinationBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationBox.FormattingEnabled = true;
            this.destinationBox.Location = new System.Drawing.Point(536, 518);
            this.destinationBox.Name = "destinationBox";
            this.destinationBox.Size = new System.Drawing.Size(222, 33);
            this.destinationBox.TabIndex = 9;
            // 
            // departureDate
            // 
            this.departureDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departureDate.Location = new System.Drawing.Point(978, 442);
            this.departureDate.Name = "departureDate";
            this.departureDate.Size = new System.Drawing.Size(283, 31);
            this.departureDate.TabIndex = 22;
            // 
            // ikonLogout
            // 
            this.ikonLogout.Image = global::ContohSoal.Properties.Resources.red_left_arrow;
            this.ikonLogout.Location = new System.Drawing.Point(21, 541);
            this.ikonLogout.Name = "ikonLogout";
            this.ikonLogout.Size = new System.Drawing.Size(46, 43);
            this.ikonLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ikonLogout.TabIndex = 2;
            this.ikonLogout.TabStop = false;
            this.ikonLogout.Click += new System.EventHandler(this.ikonLogout_Click);
            // 
            // ikonUbahStatusPenerbangan
            // 
            this.ikonUbahStatusPenerbangan.Image = global::ContohSoal.Properties.Resources.calendar_edit;
            this.ikonUbahStatusPenerbangan.Location = new System.Drawing.Point(21, 249);
            this.ikonUbahStatusPenerbangan.Name = "ikonUbahStatusPenerbangan";
            this.ikonUbahStatusPenerbangan.Size = new System.Drawing.Size(46, 43);
            this.ikonUbahStatusPenerbangan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ikonUbahStatusPenerbangan.TabIndex = 2;
            this.ikonUbahStatusPenerbangan.TabStop = false;
            this.ikonUbahStatusPenerbangan.Click += new System.EventHandler(this.ikonUbahStatusPenerbangan_Click);
            // 
            // ikonMasterKodePromo
            // 
            this.ikonMasterKodePromo.Image = global::ContohSoal.Properties.Resources.tag;
            this.ikonMasterKodePromo.Location = new System.Drawing.Point(21, 190);
            this.ikonMasterKodePromo.Name = "ikonMasterKodePromo";
            this.ikonMasterKodePromo.Size = new System.Drawing.Size(46, 43);
            this.ikonMasterKodePromo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ikonMasterKodePromo.TabIndex = 2;
            this.ikonMasterKodePromo.TabStop = false;
            this.ikonMasterKodePromo.Click += new System.EventHandler(this.ikonMasterKodePromo_Click);
            // 
            // ikonMasterJadwalPenerbangan
            // 
            this.ikonMasterJadwalPenerbangan.Image = global::ContohSoal.Properties.Resources.calendar_plane1;
            this.ikonMasterJadwalPenerbangan.Location = new System.Drawing.Point(21, 132);
            this.ikonMasterJadwalPenerbangan.Name = "ikonMasterJadwalPenerbangan";
            this.ikonMasterJadwalPenerbangan.Size = new System.Drawing.Size(46, 43);
            this.ikonMasterJadwalPenerbangan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ikonMasterJadwalPenerbangan.TabIndex = 2;
            this.ikonMasterJadwalPenerbangan.TabStop = false;
            // 
            // ikonMasterMaskapai
            // 
            this.ikonMasterMaskapai.Image = global::ContohSoal.Properties.Resources.plane_take_off;
            this.ikonMasterMaskapai.Location = new System.Drawing.Point(21, 70);
            this.ikonMasterMaskapai.Name = "ikonMasterMaskapai";
            this.ikonMasterMaskapai.Size = new System.Drawing.Size(46, 43);
            this.ikonMasterMaskapai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ikonMasterMaskapai.TabIndex = 2;
            this.ikonMasterMaskapai.TabStop = false;
            this.ikonMasterMaskapai.Click += new System.EventHandler(this.ikonMasterMaskapai_Click);
            // 
            // ikonMasterBandara
            // 
            this.ikonMasterBandara.Image = global::ContohSoal.Properties.Resources.map_marks;
            this.ikonMasterBandara.Location = new System.Drawing.Point(21, 12);
            this.ikonMasterBandara.Name = "ikonMasterBandara";
            this.ikonMasterBandara.Size = new System.Drawing.Size(46, 43);
            this.ikonMasterBandara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ikonMasterBandara.TabIndex = 2;
            this.ikonMasterBandara.TabStop = false;
            this.ikonMasterBandara.Click += new System.EventHandler(this.ikonMasterBandara_Click);
            // 
            // ikonDashboard
            // 
            this.ikonDashboard.Image = global::ContohSoal.Properties.Resources.menu2;
            this.ikonDashboard.Location = new System.Drawing.Point(22, 22);
            this.ikonDashboard.Name = "ikonDashboard";
            this.ikonDashboard.Size = new System.Drawing.Size(46, 41);
            this.ikonDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ikonDashboard.TabIndex = 2;
            this.ikonDashboard.TabStop = false;
            this.ikonDashboard.Click += new System.EventHandler(this.ikonDashboard_Click);
            // 
            // dataGridJadwal
            // 
            this.dataGridJadwal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridJadwal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.KodePenerbangan,
            this.BandaraKeberangkatan,
            this.BandaraTujuan,
            this.Maskapai,
            this.Tanggal,
            this.Durasi,
            this.HargaPerTiket,
            this.WaktuKeberangkatan,
            this.edit,
            this.hapus});
            this.dataGridJadwal.Location = new System.Drawing.Point(374, 178);
            this.dataGridJadwal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridJadwal.Name = "dataGridJadwal";
            this.dataGridJadwal.RowHeadersWidth = 62;
            this.dataGridJadwal.Size = new System.Drawing.Size(887, 242);
            this.dataGridJadwal.TabIndex = 23;
            this.dataGridJadwal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridJadwal_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Width = 150;
            // 
            // KodePenerbangan
            // 
            this.KodePenerbangan.DataPropertyName = "KodePenerbangan";
            this.KodePenerbangan.HeaderText = "Kode Penerbangan";
            this.KodePenerbangan.MinimumWidth = 8;
            this.KodePenerbangan.Name = "KodePenerbangan";
            this.KodePenerbangan.Width = 150;
            // 
            // BandaraKeberangkatan
            // 
            this.BandaraKeberangkatan.DataPropertyName = "BandaraAsal";
            this.BandaraKeberangkatan.HeaderText = "Keberangkatan";
            this.BandaraKeberangkatan.MinimumWidth = 8;
            this.BandaraKeberangkatan.Name = "BandaraKeberangkatan";
            this.BandaraKeberangkatan.Width = 150;
            // 
            // BandaraTujuan
            // 
            this.BandaraTujuan.DataPropertyName = "BandaraTujuan";
            this.BandaraTujuan.HeaderText = "Tujuan";
            this.BandaraTujuan.MinimumWidth = 8;
            this.BandaraTujuan.Name = "BandaraTujuan";
            this.BandaraTujuan.Width = 150;
            // 
            // Maskapai
            // 
            this.Maskapai.DataPropertyName = "Maskapai";
            this.Maskapai.HeaderText = "Maskapai";
            this.Maskapai.MinimumWidth = 8;
            this.Maskapai.Name = "Maskapai";
            this.Maskapai.Width = 150;
            // 
            // Tanggal
            // 
            this.Tanggal.DataPropertyName = "TanggalKeberangkatan";
            this.Tanggal.HeaderText = "Tanggal Keberangkatan";
            this.Tanggal.MinimumWidth = 8;
            this.Tanggal.Name = "Tanggal";
            this.Tanggal.Width = 150;
            // 
            // Durasi
            // 
            this.Durasi.DataPropertyName = "DurasiPenerbangan";
            this.Durasi.HeaderText = "Durasi Penerbangan";
            this.Durasi.MinimumWidth = 8;
            this.Durasi.Name = "Durasi";
            this.Durasi.Width = 150;
            // 
            // HargaPerTiket
            // 
            this.HargaPerTiket.DataPropertyName = "HargaPerTiket";
            this.HargaPerTiket.HeaderText = "HargaPerTiket";
            this.HargaPerTiket.MinimumWidth = 8;
            this.HargaPerTiket.Name = "HargaPerTiket";
            this.HargaPerTiket.Width = 150;
            // 
            // WaktuKeberangkatan
            // 
            this.WaktuKeberangkatan.DataPropertyName = "WaktuKeberangkatan";
            this.WaktuKeberangkatan.HeaderText = "Waktu Keberangkatan";
            this.WaktuKeberangkatan.MinimumWidth = 8;
            this.WaktuKeberangkatan.Name = "WaktuKeberangkatan";
            this.WaktuKeberangkatan.Width = 150;
            // 
            // edit
            // 
            this.edit.HeaderText = "";
            this.edit.MinimumWidth = 8;
            this.edit.Name = "edit";
            this.edit.Text = "Edit";
            this.edit.UseColumnTextForButtonValue = true;
            this.edit.Width = 150;
            // 
            // hapus
            // 
            this.hapus.HeaderText = "";
            this.hapus.MinimumWidth = 8;
            this.hapus.Name = "hapus";
            this.hapus.Text = "Hapus";
            this.hapus.UseColumnTextForButtonValue = true;
            this.hapus.Width = 150;
            // 
            // departureTime
            // 
            this.departureTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departureTime.Location = new System.Drawing.Point(978, 479);
            this.departureTime.Name = "departureTime";
            this.departureTime.Size = new System.Drawing.Size(283, 31);
            this.departureTime.TabIndex = 22;
            // 
            // priceCount
            // 
            this.priceCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceCount.Location = new System.Drawing.Point(978, 556);
            this.priceCount.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.priceCount.Name = "priceCount";
            this.priceCount.Size = new System.Drawing.Size(283, 31);
            this.priceCount.TabIndex = 17;
            // 
            // durationText
            // 
            this.durationText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationText.Location = new System.Drawing.Point(978, 517);
            this.durationText.Name = "durationText";
            this.durationText.Size = new System.Drawing.Size(283, 31);
            this.durationText.TabIndex = 4;
            this.durationText.Text = "__ Jam __ Menit";
            // 
            // Form6JadwalPenerbangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1285, 681);
            this.Controls.Add(this.dataGridJadwal);
            this.Controls.Add(this.departureTime);
            this.Controls.Add(this.departureDate);
            this.Controls.Add(this.departureBox);
            this.Controls.Add(this.priceCount);
            this.Controls.Add(this.teksDashboard3);
            this.Controls.Add(this.teksDashboard6);
            this.Controls.Add(this.teksDashboard7);
            this.Controls.Add(this.teksDashboard8);
            this.Controls.Add(this.teksDashboard9);
            this.Controls.Add(this.destinationBox);
            this.Controls.Add(this.maskapaiBox);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.durationText);
            this.Controls.Add(this.codeText);
            this.Controls.Add(this.teksDashboard0);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.teksDashboard2);
            this.Controls.Add(this.teksDashboard5);
            this.Controls.Add(this.teksDashboard4);
            this.Controls.Add(this.teksDashboard1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6JadwalPenerbangan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bromo Airlines - Admin";
            this.Load += new System.EventHandler(this.Form6JadwalPenerbangan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ikonLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ikonUbahStatusPenerbangan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ikonMasterKodePromo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ikonMasterJadwalPenerbangan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ikonMasterMaskapai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ikonMasterBandara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ikonDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridJadwal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label teksDashboard;
        private System.Windows.Forms.Label teksUbahStatusPenerbangan;
        private System.Windows.Forms.Label teksMasterKodePromo;
        private System.Windows.Forms.Label teksMasterJadwalPenerbangan;
        private System.Windows.Forms.Label teksMasterMaskapai;
        private System.Windows.Forms.Label teksMasterBandara;
        private System.Windows.Forms.Label teksLogout;
        private System.Windows.Forms.PictureBox ikonDashboard;
        private System.Windows.Forms.PictureBox ikonMasterBandara;
        private System.Windows.Forms.PictureBox ikonMasterMaskapai;
        private System.Windows.Forms.PictureBox ikonUbahStatusPenerbangan;
        private System.Windows.Forms.PictureBox ikonMasterKodePromo;
        private System.Windows.Forms.PictureBox ikonMasterJadwalPenerbangan;
        private System.Windows.Forms.PictureBox ikonLogout;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label teksDashboard0;
        private System.Windows.Forms.Label teksDashboard1;
        private System.Windows.Forms.Label teksDashboard2;
        private System.Windows.Forms.Label teksDashboard5;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label teksDashboard4;
        private System.Windows.Forms.ComboBox maskapaiBox;
        private System.Windows.Forms.Label teksDashboard3;
        private System.Windows.Forms.Label teksDashboard6;
        private System.Windows.Forms.Label teksDashboard7;
        private System.Windows.Forms.Label teksDashboard8;
        private System.Windows.Forms.Label teksDashboard9;
        private System.Windows.Forms.TextBox codeText;
        private System.Windows.Forms.ComboBox departureBox;
        private System.Windows.Forms.ComboBox destinationBox;
        private System.Windows.Forms.DateTimePicker departureDate;
        private System.Windows.Forms.DataGridView dataGridJadwal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KodePenerbangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn BandaraKeberangkatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn BandaraTujuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maskapai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Durasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn HargaPerTiket;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaktuKeberangkatan;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn hapus;
        private System.Windows.Forms.DateTimePicker departureTime;
        private System.Windows.Forms.NumericUpDown priceCount;
        private System.Windows.Forms.TextBox durationText;
    }
}