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
    public partial class FormTambahKisahHidup : Form
    {
        public FormTambahKisahHidup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTambahOrganisasi frm = new FormTambahOrganisasi();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void FormTambahKisahHidup_Load(object sender, EventArgs e)
        {
            List<Organisasi> listOrganisasi = Organisasi.BacaData();
            comboBoxOrganisasi.DataSource = listOrganisasi;
            comboBoxOrganisasi.SelectedIndex = -1;

            dateTimeThnAwal.Format = DateTimePickerFormat.Custom;
            dateTimeThnAwal.CustomFormat = "yyyy";
            dateTimeThnAkhir.Format = DateTimePickerFormat.Custom;
            dateTimeThnAkhir.CustomFormat = "yyyy";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string nilai = textBox1.Text;
            string filter = "Nama";
            List<Organisasi> ListOrganisasi = Organisasi.BacaData(filter, nilai);
            comboBoxOrganisasi.DataSource = ListOrganisasi;
        }
    }
}
