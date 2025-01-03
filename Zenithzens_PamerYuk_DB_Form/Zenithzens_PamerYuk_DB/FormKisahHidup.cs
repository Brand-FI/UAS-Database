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
    public partial class FormKisahHidup : Form
    {
        public User userLogin;
        public FormKisahHidup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTambahKisahHidup frm = new FormTambahKisahHidup();
            frm.userLogin = userLogin;
            frm.ShowDialog();
        }

        private void FormKisahHidup_Load(object sender, EventArgs e)
        {
            dataGridViewKisah.Columns.Add("Organisasi_id", "Id");
            dataGridViewKisah.Columns.Add("Nama", "Nama");
            dataGridViewKisah.Columns.Add("thawal", "Tahun Awal");
            dataGridViewKisah.Columns.Add("thakhir", "Tahun Akhir");
            dataGridViewKisah.Columns.Add("deskripsi", "Deskripsi");
            dataGridViewKisah.AllowUserToAddRows = false;

            User.BacaKisahHidup(userLogin);

            for (int i = 0; i < userLogin.ListKisahHidup.Count; i++)
            {
                int orgId = userLogin.ListKisahHidup[i].Organisasi.Id;
                string nama = userLogin.ListKisahHidup[i].Organisasi.Nama;
                string thawal = userLogin.ListKisahHidup[i].ThAwal;
                string thakhir = userLogin.ListKisahHidup[i].ThAkhir;
                string deskripsi = userLogin.ListKisahHidup[i].Deskripsi;
                dataGridViewKisah.Rows.Add(orgId, nama, thawal, thakhir, deskripsi);
            }
        }

        private void dataGridViewKisah_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FormKisahHidup_Activated(object sender, EventArgs e)
        {

        }
    }
}
