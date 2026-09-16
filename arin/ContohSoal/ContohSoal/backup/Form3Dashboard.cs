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
    public partial class Form3Dashboard : Form
    {
        public Form3Dashboard()
        {
            // Inisialisasi komponen-komponen yang digunakan pada halaman ini (Form3Dashboard) agar bisa dirender saat dimulai
            InitializeComponent();
        }



        //// Saat ikon "Dashboard" diklik:
        //private void ikonDashboard_Click(object sender, EventArgs e)
        //{
        //    // Buat instansi halaman dashboard (Form3Dashboard)
        //    Form3Dashboard dashboard = new Form3Dashboard();

        //    // Tutup halaman saat ini ()
        //    this.Close();

        //    // Tampilkan halaman dashboard (Form3Dashboard)
        //    dashboard.Show();
        //}

        //// Saat teks "Dashboard" diklik:
        //private void teksDashboard_Click(object sender, EventArgs e)
        //{
        //    // Buat instansi halaman dashboard (Form3Dashboard)
        //    Form3Dashboard dashboard = new Form3Dashboard();

        //    // Tutup halaman saat ini ()
        //    this.Close();

        //    // Tampilkan halaman dashboard (Form3Dashboard)
        //    dashboard.Show();
        //}



        // Saat teks "Master Bandara" pada menu navigasi diklik:
        private void teksMasterBandara_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman status penerbangan (Form8UbahStatusPenerbangan)
            Form8UbahStatusPenerbangan status = new Form8UbahStatusPenerbangan();

            // Tutup halaman saat ini
            this.Close();

            // Tampilkan halaman status penerbangan (Form8UbahStatusPenerbangan)
            status.Show();
        }

        // Saat ikon "Master Bandara" pada menu navigasi diklik:
        private void ikonMasterBandara_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman bandara (Form4Bandara)
            Form4Bandara bandara = new Form4Bandara();

            // Tutup halaman saat ini
            this.Close();

            // Tampilkan halaman bandara (Form4Bandara)
            bandara.Show();
        }



        // Saat ikon "Master Maskapai" pada menu navigasi diklik:
        private void ikonMasterMaskapai_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman maskapai (Form5Maskapai)
            Form5Maskapai maskapai = new Form5Maskapai();

            // Tutup halaman saat ini
            this.Close();

            // Tampilkan halaman maskapai (Form5Maskapai)
            maskapai.Show();
        }

        // Saat teks "Master Maskapai" pada menu navigasi diklik:
        private void teksMasterMaskapai_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman maskapai (Form5Maskapai)
            Form5Maskapai maskapai = new Form5Maskapai();

            // Tutup halaman saat ini
            this.Close();

            // Tampilkan halaman maskapai (Form5Maskapai)
            maskapai.Show();
        }



        // Saat ikon "Master Jadwal Penerbangan" pada menu navigasi diklik:
        private void ikonMasterJadwalPenerbangan_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman jadwal (Form6JadwalPenerbangan)
            Form6JadwalPenerbangan jadwal = new Form6JadwalPenerbangan();

            // Tutup halaman saat ini
            this.Close();

            // Tampilkan halaman jadwal (Form6JadwalPenerbangan)
            jadwal.Show();
        }

        // Saat teks "Master Jadwal Penerbangan" pada menu navigasi diklik:
        private void teksMasterJadwalPenerbangan_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman jadwal (Form6JadwalPenerbangan)
            Form6JadwalPenerbangan jadwal = new Form6JadwalPenerbangan();

            // Tutup halaman saat ini
            this.Close();

            // Tampilkan halaman jadwal (Form6JadwalPenerbangan)
            jadwal.Show();
        }



        // Saat teks "Master Kode Promo" pada menu navigasi diklik:
        private void teksMasterKodePromo_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman promo (Form7KodePromo)
            Form7KodePromo promo = new Form7KodePromo();

            // Tutup halaman saat ini
            this.Close();

            // Tampilkan halaman promo (Form7KodePromo)
            promo.Show();
        }

        // Saat ikon "Master Kode Promo" pada menu navigasi diklik, maka:
        private void ikonMasterKodePromo_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman promo (Form7KodePromo)
            Form7KodePromo promo = new Form7KodePromo();

            // Tutup halaman saat ini
            this.Close();

            // Tampilkan halaman promo (Form7KodePromo)
            promo.Show();
        }



        // Saat teks "Ubah Status Penerbangan" pada menu navigasi diklik:
        private void ikonUbahStatusPenerbangan_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman bandara (Form4Bandara)
            Form4Bandara bandara = new Form4Bandara();

            // Sembunyikan halaman saat ini (Form3Dashboard)
            this.Hide();

            // Tampilkan halaman bandara (Form4Bandara)
            bandara.Show();
        }

        // Saat ikon "Ubah Status Penerbangan" pada menu navigasi diklik:
        private void teksUbahStatusPenerbangan_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman bandara (Form4Bandara)
            Form4Bandara bandara = new Form4Bandara();

            // Sembunyikan halaman saat ini (Form3Dashboard)
            this.Hide();

            // Tampilkan halaman bandara (Form4Bandara)
            bandara.Show();
        }



        // Saat ikon "Logout" diklik:
        private void ikonLogout_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman login (Form1Login)
            Form1Login login = new Form1Login();

            // Tutup halaman saat ini
            this.Close();

            // Tampilkan halaman login (Form1Login)
            login.Show();
        }

        // Saat teks "Logout" diklik:
        private void teksLogout_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman login (Form1Login)
            Form1Login login = new Form1Login();

            // Tutup halaman saat ini
            this.Close();

            // Tampilkan halaman login (Form1Login)
            login.Show();
        }
    }
}
