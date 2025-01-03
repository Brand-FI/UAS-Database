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
        FormRegisterUser frmRegist;
        public User userLogin;
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
            frmRegist = (FormRegisterUser)this.Owner;
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
        Organisasi orgPilihan = new Organisasi();
        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Form form = Application.OpenForms["FormRegisterUser"];  
                if (form != null)
                {
                    frmRegist.AddDataToGrid(orgPilihan.Id, orgPilihan.Nama, dateTimeThnAwal.Value.Year.ToString(),
                        dateTimeThnAkhir.Value.Year.ToString(), richTextBoxDeskripsi.Text);
                }
                else
                {

                    KisahHidup kh = new KisahHidup();
                    kh.Organisasi = orgPilihan;
                    kh.ThAwal = dateTimeThnAwal.Value.Year.ToString();
                    kh.ThAkhir = dateTimeThnAkhir.Value.Year.ToString();
                    kh.Deskripsi = richTextBoxDeskripsi.Text;

                    User.TambahKisahHidup(userLogin, kh);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxOrganisasi_SelectedIndexChanged(object sender, EventArgs e)
        {
            orgPilihan = (Organisasi)comboBoxOrganisasi.SelectedItem;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTambahKisahHidup_Activated(object sender, EventArgs e)
        {
            List<Organisasi> listOrganisasi = Organisasi.BacaData();
            comboBoxOrganisasi.DataSource = listOrganisasi;
            comboBoxOrganisasi.SelectedIndex = -1;
        }
    }
}
