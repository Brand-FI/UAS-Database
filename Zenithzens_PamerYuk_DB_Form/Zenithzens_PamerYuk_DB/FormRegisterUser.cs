using Class_PamerYuk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zenithzens_PamerYuk_DB_Form
{
    public partial class FormRegisterUser : Form
    {
        public FormRegisterUser()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                User u = new User();
                u.Username = textBoxUsername.Text;
                u.Password = textBoxPassword.Text;
                u.TglLahir = dateTimeTglLahir.Value;
                u.NoKTP = textBoxNoKtp.Text;
                u.Kota = (Kota)comboBoxKota.SelectedItem;

                foreach (DataGridViewRow row in dataGridViewKisah.Rows)
                {
                    if (row.Cells["Organisasi_id"].Value != null)
                    {
                        Organisasi org = new Organisasi();
                        org.Id = int.Parse(row.Cells["Organisasi_id"].Value.ToString());
                        string thnAwal = row.Cells["thawal"].Value.ToString();
                        string thnAkhir = row.Cells["thakhir"].Value.ToString();
                        string deskripsi = row.Cells["deskripsi"].Value.ToString();
                        u.TambahKisah(org, thnAwal, thnAkhir, deskripsi);
                    }
                }
                User.TambahData(u, pictureBox1.Image);

                User.EkripsiPassword();
                MessageBox.Show("Berhasil Mendaftarkan Akun");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormRegisterUser_Load(object sender, EventArgs e)
        {
            List<Kota> listKota = Kota.BacaData();
            comboBoxKota.DataSource = listKota;

            if (dataGridViewKisah.ColumnCount == 0)
            {
                dataGridViewKisah.Columns.Add("Organisasi_id", "Id");
                dataGridViewKisah.Columns.Add("Nama", "Nama");
                dataGridViewKisah.Columns.Add("thawal", "Tahun Awal");
                dataGridViewKisah.Columns.Add("thakhir", "Tahun Akhir");
                dataGridViewKisah.Columns.Add("deskripsi", "Deskripsi");
                dataGridViewKisah.AllowUserToAddRows = false;
            }
            if (dataGridViewKisah.ColumnCount == 5)
            {
                DataGridViewButtonColumn btnHapus = new DataGridViewButtonColumn();
                btnHapus.Text = "Hapus";
                btnHapus.HeaderText = "Hapus";
                btnHapus.UseColumnTextForButtonValue = true;
                btnHapus.Name = "buttonHapusGrid";
                dataGridViewKisah.Columns.Add(btnHapus);
            }
        }
        public void AddDataToGrid(int id, string nama, string thAwal, string thAkhir, string deskripsi)//Method Menambahkan Data ke Grid
        {
            dataGridViewKisah.Rows.Add(id, nama, thAwal, thAkhir, deskripsi);
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelRegisterUser_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialogProfile.ShowDialog(this);
        }

        private void openFileDialogProfile_FileOk(object sender, CancelEventArgs e)
        {
            pictureBox1.ImageLocation = openFileDialogProfile.FileName;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahKisahHidup frm = new FormTambahKisahHidup();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void dataGridViewKisah_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = dataGridViewKisah.CurrentRow.Index;
            if (e.ColumnIndex == dataGridViewKisah.Columns["buttonHapusGrid"].Index)
            {
                DialogResult dialogResult = MessageBox.Show("Apakah Anda yakin " +
                "ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    dataGridViewKisah.Rows.RemoveAt(idx);
                    MessageBox.Show("Data berhasil dihapus");
                }
                else
                {
                    MessageBox.Show("Data gagal dihapus");
                }
            }
        }
    }
}
