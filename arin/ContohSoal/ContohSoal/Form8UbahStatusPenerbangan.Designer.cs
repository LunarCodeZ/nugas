namespace ContohSoal
{
    partial class Form8UbahStatusPenerbangan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8UbahStatusPenerbangan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ikonDashboard = new System.Windows.Forms.PictureBox();
            this.teksDashboard = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ikonLogout = new System.Windows.Forms.PictureBox();
            this.ikonUbahStatusPenerbangan = new System.Windows.Forms.PictureBox();
            this.ikonMasterKodePromo = new System.Windows.Forms.PictureBox();
            this.ikonMasterJadwalPenerbangan = new System.Windows.Forms.PictureBox();
            this.ikonMasterMaskapai = new System.Windows.Forms.PictureBox();
            this.ikonMasterBandara = new System.Windows.Forms.PictureBox();
            this.teksLogout = new System.Windows.Forms.Label();
            this.teksUbahStatusPenerbangan = new System.Windows.Forms.Label();
            this.teksMasterKodePromo = new System.Windows.Forms.Label();
            this.teksMasterJadwalPenerbangan = new System.Windows.Forms.Label();
            this.teksMasterMaskapai = new System.Windows.Forms.Label();
            this.teksMasterBandara = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridStatus = new System.Windows.Forms.DataGridView();
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.teksDashboard1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ikonDashboard)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ikonLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ikonUbahStatusPenerbangan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ikonMasterKodePromo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ikonMasterJadwalPenerbangan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ikonMasterMaskapai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ikonMasterBandara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStatus)).BeginInit();
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
            // ikonLogout
            // 
            this.ikonLogout.Image = global::ContohSoal.Properties.Resources.red_left_arrow;
            this.ikonLogout.Location = new System.Drawing.Point(21, 541);
            this.ikonLogout.Name = "ikonLogout";
            this.ikonLogout.Size = new System.Drawing.Size(46, 43);
            this.ikonLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ikonLogout.TabIndex = 2;
            this.ikonLogout.TabStop = false;
            // 
            // ikonUbahStatusPenerbangan
            // 
            this.ikonUbahStatusPenerbangan.Image = global::ContohSoal.Properties.Resources.calendar_edit1;
            this.ikonUbahStatusPenerbangan.Location = new System.Drawing.Point(21, 249);
            this.ikonUbahStatusPenerbangan.Name = "ikonUbahStatusPenerbangan";
            this.ikonUbahStatusPenerbangan.Size = new System.Drawing.Size(46, 43);
            this.ikonUbahStatusPenerbangan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ikonUbahStatusPenerbangan.TabIndex = 2;
            this.ikonUbahStatusPenerbangan.TabStop = false;
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
            this.ikonMasterJadwalPenerbangan.Image = global::ContohSoal.Properties.Resources.calendar_plane;
            this.ikonMasterJadwalPenerbangan.Location = new System.Drawing.Point(21, 132);
            this.ikonMasterJadwalPenerbangan.Name = "ikonMasterJadwalPenerbangan";
            this.ikonMasterJadwalPenerbangan.Size = new System.Drawing.Size(46, 43);
            this.ikonMasterJadwalPenerbangan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ikonMasterJadwalPenerbangan.TabIndex = 2;
            this.ikonMasterJadwalPenerbangan.TabStop = false;
            this.ikonMasterJadwalPenerbangan.Click += new System.EventHandler(this.ikonMasterJadwalPenerbangan_Click);
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
            // 
            // teksUbahStatusPenerbangan
            // 
            this.teksUbahStatusPenerbangan.AutoSize = true;
            this.teksUbahStatusPenerbangan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksUbahStatusPenerbangan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.teksUbahStatusPenerbangan.Location = new System.Drawing.Point(77, 254);
            this.teksUbahStatusPenerbangan.Name = "teksUbahStatusPenerbangan";
            this.teksUbahStatusPenerbangan.Size = new System.Drawing.Size(236, 28);
            this.teksUbahStatusPenerbangan.TabIndex = 2;
            this.teksUbahStatusPenerbangan.Text = "Ubah Status Penerbangan";
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
            this.teksMasterJadwalPenerbangan.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.teksMasterJadwalPenerbangan.Location = new System.Drawing.Point(77, 138);
            this.teksMasterJadwalPenerbangan.Name = "teksMasterJadwalPenerbangan";
            this.teksMasterJadwalPenerbangan.Size = new System.Drawing.Size(254, 28);
            this.teksMasterJadwalPenerbangan.TabIndex = 2;
            this.teksMasterJadwalPenerbangan.Text = "Master Jadwal Penerbangan";
            this.teksMasterJadwalPenerbangan.Click += new System.EventHandler(this.teksMasterJadwalPenerbangan_Click);
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
            this.label8.Size = new System.Drawing.Size(307, 32);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ubah Status Penerbangan";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(369, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(450, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Anda bisa mengubah status jadwal penerbangan di sini";
            // 
            // dataGridStatus
            // 
            this.dataGridStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridStatus.Location = new System.Drawing.Point(374, 178);
            this.dataGridStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridStatus.Name = "dataGridStatus";
            this.dataGridStatus.RowHeadersWidth = 62;
            this.dataGridStatus.Size = new System.Drawing.Size(887, 370);
            this.dataGridStatus.TabIndex = 14;
            this.dataGridStatus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridStatus_CellClick);
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
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(1138, 627);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(123, 42);
            this.saveBtn.TabIndex = 17;
            this.saveBtn.Text = "Simpan";
            this.saveBtn.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1009, 628);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 42);
            this.button2.TabIndex = 18;
            this.button2.Text = "Batal";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // teksDashboard1
            // 
            this.teksDashboard1.AutoSize = true;
            this.teksDashboard1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksDashboard1.Location = new System.Drawing.Point(369, 568);
            this.teksDashboard1.Name = "teksDashboard1";
            this.teksDashboard1.Size = new System.Drawing.Size(60, 25);
            this.teksDashboard1.TabIndex = 15;
            this.teksDashboard1.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(844, 571);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Perkiraan Delay";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(982, 567);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 31);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "__ Jam __ Menit";
            // 
            // statusBox
            // 
            this.statusBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Location = new System.Drawing.Point(435, 566);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(314, 33);
            this.statusBox.TabIndex = 21;
            // 
            // Form8UbahStatusPenerbangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1285, 681);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teksDashboard1);
            this.Controls.Add(this.dataGridStatus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form8UbahStatusPenerbangan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bromo Airlines - Admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ikonDashboard)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ikonLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ikonUbahStatusPenerbangan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ikonMasterKodePromo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ikonMasterJadwalPenerbangan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ikonMasterMaskapai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ikonMasterBandara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStatus)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridStatus;
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
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label teksDashboard1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox statusBox;
    }
}