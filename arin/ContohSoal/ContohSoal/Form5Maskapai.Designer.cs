namespace ContohSoal
{
    partial class Form5Maskapai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5Maskapai));
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
            this.teksDashboard0 = new System.Windows.Forms.Label();
            this.teksDashboard1 = new System.Windows.Forms.Label();
            this.teksDashboard2 = new System.Windows.Forms.Label();
            this.teksDashboard5 = new System.Windows.Forms.Label();
            this.companyTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.crewCount = new System.Windows.Forms.NumericUpDown();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.teksDashboard3 = new System.Windows.Forms.Label();
            this.dataGridMaskapai = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Perusahaan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JumlahKru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deskripsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hapus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ikonDashboard)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ikonLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ikonUbahStatusPenerbangan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ikonMasterKodePromo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ikonMasterJadwalPenerbangan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ikonMasterMaskapai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ikonMasterBandara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMaskapai)).BeginInit();
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
            this.ikonMasterMaskapai.Image = global::ContohSoal.Properties.Resources.plane_take_off1;
            this.ikonMasterMaskapai.Location = new System.Drawing.Point(21, 70);
            this.ikonMasterMaskapai.Name = "ikonMasterMaskapai";
            this.ikonMasterMaskapai.Size = new System.Drawing.Size(46, 43);
            this.ikonMasterMaskapai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ikonMasterMaskapai.TabIndex = 2;
            this.ikonMasterMaskapai.TabStop = false;
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
            this.teksMasterMaskapai.ForeColor = System.Drawing.SystemColors.ControlText;
            this.teksMasterMaskapai.Location = new System.Drawing.Point(77, 76);
            this.teksMasterMaskapai.Name = "teksMasterMaskapai";
            this.teksMasterMaskapai.Size = new System.Drawing.Size(160, 28);
            this.teksMasterMaskapai.TabIndex = 2;
            this.teksMasterMaskapai.Text = "Master Maskapai";
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
            this.label8.Size = new System.Drawing.Size(208, 32);
            this.label8.TabIndex = 2;
            this.label8.Text = "Master Maskapai";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(369, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(419, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Semua maskapai yang terdaftar akan muncul di sini";
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
            this.teksDashboard1.Size = new System.Drawing.Size(59, 25);
            this.teksDashboard1.TabIndex = 2;
            this.teksDashboard1.Text = "Nama";
            // 
            // teksDashboard2
            // 
            this.teksDashboard2.AutoSize = true;
            this.teksDashboard2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksDashboard2.Location = new System.Drawing.Point(369, 478);
            this.teksDashboard2.Name = "teksDashboard2";
            this.teksDashboard2.Size = new System.Drawing.Size(101, 25);
            this.teksDashboard2.TabIndex = 2;
            this.teksDashboard2.Text = "Perusahaan";
            // 
            // teksDashboard5
            // 
            this.teksDashboard5.AutoSize = true;
            this.teksDashboard5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksDashboard5.Location = new System.Drawing.Point(369, 518);
            this.teksDashboard5.Name = "teksDashboard5";
            this.teksDashboard5.Size = new System.Drawing.Size(98, 25);
            this.teksDashboard5.TabIndex = 2;
            this.teksDashboard5.Text = "Jumlah Kru";
            // 
            // companyTxt
            // 
            this.companyTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyTxt.Location = new System.Drawing.Point(494, 477);
            this.companyTxt.Name = "companyTxt";
            this.companyTxt.Size = new System.Drawing.Size(264, 31);
            this.companyTxt.TabIndex = 4;
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(494, 440);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(264, 31);
            this.nameTxt.TabIndex = 4;
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTxt.Location = new System.Drawing.Point(876, 443);
            this.descriptionTxt.Multiline = true;
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(385, 141);
            this.descriptionTxt.TabIndex = 4;
            // 
            // crewCount
            // 
            this.crewCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crewCount.Location = new System.Drawing.Point(494, 518);
            this.crewCount.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.crewCount.Name = "crewCount";
            this.crewCount.Size = new System.Drawing.Size(264, 31);
            this.crewCount.TabIndex = 7;
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
            // teksDashboard3
            // 
            this.teksDashboard3.AutoSize = true;
            this.teksDashboard3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksDashboard3.Location = new System.Drawing.Point(787, 442);
            this.teksDashboard3.Name = "teksDashboard3";
            this.teksDashboard3.Size = new System.Drawing.Size(84, 25);
            this.teksDashboard3.TabIndex = 14;
            this.teksDashboard3.Text = "Deskripsi";
            // 
            // dataGridMaskapai
            // 
            this.dataGridMaskapai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMaskapai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nama,
            this.Perusahaan,
            this.JumlahKru,
            this.Deskripsi,
            this.hapus,
            this.edit});
            this.dataGridMaskapai.Location = new System.Drawing.Point(374, 178);
            this.dataGridMaskapai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridMaskapai.Name = "dataGridMaskapai";
            this.dataGridMaskapai.RowHeadersWidth = 62;
            this.dataGridMaskapai.Size = new System.Drawing.Size(887, 242);
            this.dataGridMaskapai.TabIndex = 15;
            this.dataGridMaskapai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMaskapai_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Width = 150;
            // 
            // Nama
            // 
            this.Nama.DataPropertyName = "Nama";
            this.Nama.HeaderText = "Nama";
            this.Nama.MinimumWidth = 8;
            this.Nama.Name = "Nama";
            this.Nama.Width = 150;
            // 
            // Perusahaan
            // 
            this.Perusahaan.DataPropertyName = "Perusahaan";
            this.Perusahaan.HeaderText = "Perusahaan";
            this.Perusahaan.MinimumWidth = 8;
            this.Perusahaan.Name = "Perusahaan";
            this.Perusahaan.Width = 150;
            // 
            // JumlahKru
            // 
            this.JumlahKru.DataPropertyName = "JumlahKru";
            this.JumlahKru.HeaderText = "JumlahKru";
            this.JumlahKru.MinimumWidth = 8;
            this.JumlahKru.Name = "JumlahKru";
            this.JumlahKru.Width = 150;
            // 
            // Deskripsi
            // 
            this.Deskripsi.DataPropertyName = "Deskripsi";
            this.Deskripsi.HeaderText = "Deskripsi";
            this.Deskripsi.MinimumWidth = 8;
            this.Deskripsi.Name = "Deskripsi";
            this.Deskripsi.Width = 150;
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
            // edit
            // 
            this.edit.HeaderText = "";
            this.edit.MinimumWidth = 8;
            this.edit.Name = "edit";
            this.edit.Text = "Edit";
            this.edit.UseColumnTextForButtonValue = true;
            this.edit.Width = 150;
            // 
            // Form5Maskapai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1285, 681);
            this.Controls.Add(this.dataGridMaskapai);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.crewCount);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.companyTxt);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.teksDashboard0);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.teksDashboard2);
            this.Controls.Add(this.teksDashboard3);
            this.Controls.Add(this.teksDashboard5);
            this.Controls.Add(this.teksDashboard1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5Maskapai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bromo Airlines - Admin";
            this.Load += new System.EventHandler(this.Form5Maskapai_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.crewCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMaskapai)).EndInit();
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
        private System.Windows.Forms.TextBox companyTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox descriptionTxt;
        private System.Windows.Forms.NumericUpDown crewCount;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label teksDashboard3;
        private System.Windows.Forms.DataGridView dataGridMaskapai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Perusahaan;
        private System.Windows.Forms.DataGridViewTextBoxColumn JumlahKru;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deskripsi;
        private System.Windows.Forms.DataGridViewButtonColumn hapus;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
    }
}