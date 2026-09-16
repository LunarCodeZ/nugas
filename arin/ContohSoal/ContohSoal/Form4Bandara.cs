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
    public partial class Form4Bandara : Form
    {
        BandaraEntities db = new BandaraEntities(); // membuat koneksi ke database
        private int idBandara = -1; // menyimpan id bandara yang sedang diedit (-1 mode tambah, jika > 0 mode update)

        public Form4Bandara()
        {
            // Inisialisasi komponen-komponen yang digunakan pada halaman ini (Form4Bandara) agar bisa dirender saat dimulai
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

        // Saat ikon "Master Maskapai" diklik:
        private void ikonMasterMaskapai_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman maskapai (Form5Maskapai)
            Form5Maskapai maskapai = new Form5Maskapai();

            // Tutup halaman saat ini
            this.Close();

            // Tampilkan halaman maskapai (Form5Maskapai)
            maskapai.Show();
        }

        // Saat teks "Master Maskapai" diklik:
        private void teksMasterMaskapai_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman maskapai (Form5Maskapai)
            Form5Maskapai maskapai = new Form5Maskapai();

            // Tutup halaman saat ini
            this.Close();

            // Tampilkan halaman maskapai (Form5Maskapai)
            maskapai.Show();
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

        private void Form4Bandara_Load(object sender, EventArgs e)
        {
            LoadNegara(); // menampilkan daftar negara ke combobox
            LoadBandara(); // menampilkan semua data bandara ke dalam dataGridView

            dataGridBandara.AutoGenerateColumns = false;
            dataGridBandara.AllowUserToAddRows = false;
            dataGridBandara.ReadOnly = true;
        }

        private void LoadNegara()
        {
            countryBox.DataSource = db.Negaras.OrderBy(n => n.Nama).ToList();
            countryBox.DisplayMember = "Nama";
            countryBox.ValueMember = "ID";
            countryBox.SelectedIndex = -1;
        }

        private void LoadBandara()
        {
            dataGridBandara.DataSource = db.Bandaras.Include("Negara") // Include() mengambil data dari
            .OrderBy(b => b.Nama) // urutkan berdasarkan nama, dari
            .Select(b => new // select() memilih kolom yang akan
            {
                b.ID,
                b.Nama,
                b.KodeIATA,
                b.Kota,
                Negara = b.Negara.Nama,
                b.JumlahTerminal,
                b.Alamat,
            }).ToList();
        }

        private void ResetForm()
        {
            nameTxt.Clear();
            iataTxt.Clear();
            cityTxt.Clear();
            addressTxt.Clear();
            countryBox.SelectedIndex = -1;
            terminalCount.Value = 1;
            idBandara = -1; // kembali ke mode tambah data
            saveBtn.Text = "Simpan";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (nameTxt.Text == "" || iataTxt.Text == "" || cityTxt.Text == "" || addressTxt.Text == "" || countryBox.SelectedIndex == -1)
            {
                MessageBox.Show("Semua data harus diisi!");
                return;
            }

            // validasi panjang kode IATA
            if (iataTxt.Text.Length != 3)
            {
                MessageBox.Show("Kode IATA wajib memiliki 3 huruf!");
                return;
            }

            // semua karakter IATA harus berupa huruf
            if (!iataTxt.Text.All(char.IsLetter)) // All() mengecek semua karakter
            {
                MessageBox.Show("Kode IATA hanya boleh huruf!");
                return;
            }

            // validasi IATA tidak boleh sama
            bool adaIATA = db.Bandaras.Any(b => b.KodeIATA == iataTxt.Text && b.ID != idBandara);

            if (adaIATA)
            {
                MessageBox.Show("Kode IATA sudah digunakan!");
                return;
            }

            // validasi jumlah terminal (minimal 1 terminal)
            if (terminalCount.Value < 1)
            {
                MessageBox.Show("Jumlah terminal minimal 1");
                return;
            }

            // validasi nama bandara harus unik
            bool adaBandara = db.Bandaras.Any(b => b.Nama.ToLower() == nameTxt.Text.ToLower() && b.ID != idBandara);

            if (adaBandara)
            {
                MessageBox.Show("Nama bandara sudah dipakai!");
                return;
            }

            // percabangan edit atau add data
            if (idBandara == -1) // add data
            {
                // membuat object bandara baru
                Bandara bandaraBaru = new Bandara();
                bandaraBaru.Nama = nameTxt.Text;
                bandaraBaru.KodeIATA = iataTxt.Text;
                bandaraBaru.Kota = cityTxt.Text;
                bandaraBaru.NegaraID = Convert.ToInt32(countryBox.SelectedValue);
                bandaraBaru.JumlahTerminal = Convert.ToInt32(terminalCount.Value);
                bandaraBaru.Alamat = addressTxt.Text;

                MessageBox.Show("Data berhasil ditambahkan!");
            }
            else // edit
            {
                Bandara editBandara = new Bandara();
                editBandara.Nama = nameTxt.Text;
                editBandara.KodeIATA = iataTxt.Text;
                editBandara.Kota = cityTxt.Text;
                editBandara.NegaraID = Convert.ToInt32(countryBox.SelectedValue);
                editBandara.JumlahTerminal = Convert.ToInt32(terminalCount.Value);
                editBandara.Alamat = addressTxt.Text;

                MessageBox.Show("Data berhasil diedit!");
            }

            // membuat object bandara baru
            Bandara bandara = new Bandara();

            bandara.Nama = nameTxt.Text;
            bandara.KodeIATA = iataTxt.Text;
            bandara.Kota = nameTxt.Text;
            bandara.NegaraID = Convert.ToInt32(countryBox.SelectedValue);
            bandara.JumlahTerminal = Convert.ToInt32(terminalCount.Value);
            bandara.Alamat = addressTxt.Text;

            db.Bandaras.Add(bandara);
            db.SaveChanges();

            LoadBandara();
            ResetForm();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) // error handling agar bukan header yang diklik
            {
                return;
            }

            // edit and delete
            if (dataGridBandara.Columns[e.ColumnIndex].Name == "edit")
            {
                idBandara = Convert.ToInt32(dataGridBandara.Rows[e.RowIndex].Cells["ID"].Value); // mengambil ID pada data
                Bandara bandaraEdit = db.Bandaras.Find(idBandara); // ambil object bandara sesuai dengan ID yang dipilih
                // menampilkan data ke dalam textbox dan combobox
                nameTxt.Text = bandaraEdit.Nama;
                iataTxt.Text = bandaraEdit.KodeIATA;
                cityTxt.Text = bandaraEdit.Kota;
                addressTxt.Text = bandaraEdit.Alamat;

                countryBox.SelectedValue = bandaraEdit.NegaraID;

                terminalCount.Value = bandaraEdit.JumlahTerminal;

                saveBtn.Text = "Update";
            }
            else if (dataGridBandara.Columns[e.ColumnIndex].Name == "hapus")
            {
                int id = Convert.ToInt32(dataGridBandara.Rows[e.RowIndex].Cells["ID"].Value);
                var hasil = MessageBox.Show("Yakin ingin menghapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (hasil == DialogResult.Yes)
                {
                    Bandara bandaraHapus = db.Bandaras.Find(id);
                    db.Bandaras.Remove(bandaraHapus);
                    db.Bandaras.Remove(bandaraHapus);
                    db.SaveChanges();

                    LoadBandara();
                    ResetForm();
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
