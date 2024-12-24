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
                bool hasil = User.TambahData(u, pictureBox1.Image);
                if (hasil == true)
                {
                    User.EkripsiPassword();
                    MessageBox.Show("Berhasil Mendaftarkan Akun");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Gagal Mendaftarkan Akun");
                }
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
    }
}
