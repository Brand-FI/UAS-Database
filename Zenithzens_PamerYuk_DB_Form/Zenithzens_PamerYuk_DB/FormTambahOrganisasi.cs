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
    public partial class FormTambahOrganisasi : Form
    {
        public FormTambahOrganisasi()
        {
            InitializeComponent();
        }

        private void FormTambahOrganisasi_Load(object sender, EventArgs e)
        {
            List<Kota> listKota = Kota.BacaData();
            comboBoxKota.DataSource = listKota;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Organisasi or = new Organisasi();
                or.Nama = textBoxNama.Text;
                or.Kota = (Kota)comboBoxKota.SelectedItem;
                bool hasil = Organisasi.TambahData(or);
                if (hasil == true)
                {
                    MessageBox.Show("Berhasil tambah data");
                }
                else
                {
                    MessageBox.Show("Gagal tambah data");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
