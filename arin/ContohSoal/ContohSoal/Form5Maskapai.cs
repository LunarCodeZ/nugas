using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContohSoal
{
    public partial class Form5Maskapai : Form
    {
        BandaraEntities db = new BandaraEntities();
        private int idMaskapai = -1;

        public Form5Maskapai()
        {
            // Inisialisasi komponen-komponen yang digunakan pada halaman ini (Form5Maskapai) agar bisa dirender saat dimulai
            InitializeComponent();
        }

        // Saat teks "dashboard" diklik:
        private void teksDashboard_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman dashboard (Form3Dashboard)
            Form3Dashboard dashboard = new Form3Dashboard();

            // Tutup halaman saat ini
            this.Close();

            // Tampilkan halaman dashboard (Form3Dashboard)
            dashboard.Show();
        }

        // Saat ikon "dashboard" diklik:
        private void ikonDashboard_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman dashboard (Form3Dashboard)
            Form3Dashboard dashboard = new Form3Dashboard();

            // Tutup halaman saat ini
            this.Close();

            // Tampilkan halaman dashboard (Form3Dashboard)
            dashboard.Show();
        }

        // Saat teks "Master Bandara" diklik:
        private void teksMasterBandara_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman bandara (Form4Bandara)
            Form4Bandara bandara = new Form4Bandara();

            // Sembunyikan halaman saat ini (Form3Dashboard)
            this.Hide();

            // Tampilkan halaman bandara (Form4Bandara)
            bandara.Show();
        }

        // Saat ikon "Master Bandara" diklik:
        private void ikonMasterBandara_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman bandara (Form4Bandara)
            Form4Bandara bandara = new Form4Bandara();

            // Tutup halaman saat ini
            this.Close();

            // Tampilkan halaman bandara (Form4Bandara)
            bandara.Show();
        }

        // Saat ikon "Master Jadwal Penerbangan" diklik:
        private void ikonMasterJadwalPenerbangan_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman jadwal (Form6JadwalPenerbangan)
            Form6JadwalPenerbangan jadwal = new Form6JadwalPenerbangan();

            // Tutup halaman saat ini
            this.Close();

            // Tampilkan halaman jadwal (Form6JadwalPenerbangan)
            jadwal.Show();
        }

        // Saat teks "Master Jadwal Penerbangan" diklik:
        private void teksMasterJadwalPenerbangan_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman jadwal (Form6JadwalPenerbangan)
            Form6JadwalPenerbangan jadwal = new Form6JadwalPenerbangan();

            // Tutup halaman saat ini
            this.Close();

            // Tampilkan halaman jadwal (Form6JadwalPenerbangan)
            jadwal.Show();
        }

        // Saat teks "Master Kode Promo" diklik:
        private void teksMasterKodePromo_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman promo (Form7KodePromo)
            Form7KodePromo promo = new Form7KodePromo();

            // Tutup halaman saat ini
            this.Close();

            // Tampilkan halaman promo (Form7KodePromo)
            promo.Show();
        }

        // Saat ikon "Master Kode Promo" diklik:
        private void ikonMasterKodePromo_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman promo (Form7KodePromo)
            Form7KodePromo promo = new Form7KodePromo();

            // Tutup halaman saat ini
            this.Close();

            // Tampilkan halaman promo (Form7KodePromo)
            promo.Show();
        }

        // Saat ikon "Ubah Status Penerbangan" diklik:
        private void ikonUbahStatusPenerbangan_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman status (Form8UbahStatusPenerbangan)
            Form8UbahStatusPenerbangan status = new Form8UbahStatusPenerbangan();

            // Sembunyikan halaman saat ini (Form3Dashboard)
            this.Hide();

            // Tampilkan halaman status (Form8UbahStatusPenerbangan)
            status.Show();
        }

        // Saat teks "Ubah Status Penerbangan" diklik:
        private void teksUbahStatusPenerbangan_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman status penerbangan (Form8UbahStatusPenerbangan)
            Form8UbahStatusPenerbangan status = new Form8UbahStatusPenerbangan();

            // Tutup halaman saat ini
            this.Close();

            // Tampilkan halaman status penerbangan (Form8UbahStatusPenerbangan)
            status.Show();
        }

        // Saat teks "logout" diklik:
        private void teksLogout_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman login (Form1Login)
            Form1Login login = new Form1Login();

            // Tutup halaman saat ini
            this.Close();

            // Tampilkan halaman login (Form1Login)
            login.Show();
        }

        // Saat ikon "logout" diklik:
        private void ikonLogout_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman login (Form1Login)
            Form1Login login = new Form1Login();

            // Tutup halaman saat ini
            this.Close();

            // Tampilkan halaman login (Form1Login)
            login.Show();
        }

        private void Form5Maskapai_Load(object sender, EventArgs e)
        {
            dataGridMaskapai.AutoGenerateColumns = false;
            dataGridMaskapai.AllowUserToAddRows = false;
            dataGridMaskapai.ReadOnly = true;
            LoadMaskapai();
        }

        private void LoadMaskapai()
        {
            dataGridMaskapai.DataSource = db.Maskapais.OrderBy(m => m.Nama).ToList(); // bisa langsung ToList jika ingin ditampilkan sesuai dengan kolom yang ada di dalam database
        }

        private void ClearForm()
        {
            nameTxt.Clear();
            companyTxt.Clear();
            descriptionTxt.Clear();

            crewCount.Value = 0;
            idMaskapai = -1;
            saveBtn.Text = "Simpan";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // validasi isi textbox
            if (nameTxt.Text == "" || companyTxt.Text == "" || descriptionTxt.Text == "")
            {
                MessageBox.Show("Semua data wajib diisi!");
                return;
            }

            // validasi jumlah kru
            if (crewCount.Value < 1)
            {
                MessageBox.Show("Jumlah kru minimal 1!");
                return;
            }

            // percabangan add / update
            if (idMaskapai == -1) // add
            {
                Maskapai maskapaiBaru = new Maskapai();
                maskapaiBaru.Nama = nameTxt.Text;
                maskapaiBaru.Perusahaan = companyTxt.Text;
                maskapaiBaru.JumlahKru = Convert.ToInt32(crewCount.Value);
                maskapaiBaru.Deskripsi = descriptionTxt.Text;

                db.Maskapais.Add(maskapaiBaru);
                MessageBox.Show("Data berhasil ditambahkan");

            }
            else // update
            {
                Maskapai editMaskapai = db.Maskapais.Find(idMaskapai);

                editMaskapai.Nama = nameTxt.Text;
                editMaskapai.Perusahaan = companyTxt.Text;
                editMaskapai.JumlahKru = Convert.ToInt32(crewCount.Value);
                editMaskapai.Deskripsi = descriptionTxt.Text;

                MessageBox.Show("Berhasil mengubah data maskapai");
            }

            db.SaveChanges();
            LoadMaskapai();
            ClearForm();
        }

        private void dataGridMaskapai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (dataGridMaskapai.Columns[e.ColumnIndex].Name == "edit")
            {
                idMaskapai = Convert.ToInt32(dataGridMaskapai.Rows[e.RowIndex].Cells["ID"].Value);

                Maskapai editMaskapai = db.Maskapais.Find(idMaskapai);
                nameTxt.Text = editMaskapai.Nama;
                companyTxt.Text = editMaskapai.Perusahaan;
                crewCount.Value = editMaskapai.JumlahKru;
                descriptionTxt.Text = editMaskapai.Deskripsi;

                saveBtn.Text = "Update";
            }
            else if (dataGridMaskapai.Columns[e.ColumnIndex].Name == "hapus")
            {
                int id = Convert.ToInt32(dataGridMaskapai.Rows[e.RowIndex].Cells["ID"].Value);

                var hasil = MessageBox.Show("Apakah anda yakin ingin menghapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (hasil == DialogResult.Yes)
                {
                    Maskapai hapusMaskapai = db.Maskapais.Find(id);
                    db.Maskapais.Remove(hapusMaskapai);
                    db.SaveChanges();

                    MessageBox.Show("Maskapai berhasil dihapus");
                    LoadMaskapai();
                    ClearForm();
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
