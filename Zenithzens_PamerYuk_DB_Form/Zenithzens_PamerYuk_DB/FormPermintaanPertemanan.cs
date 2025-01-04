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
    public partial class FormPermintaanPertemanan : Form
    {
        public User userLogin;
        public FormPermintaanPertemanan()
        {
            InitializeComponent();
        }

        private void dataGridViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string username1 = dataGridViewRequest.CurrentRow.Cells["username1"].Value.ToString();
            if (e.ColumnIndex == dataGridViewRequest.Columns["buttonAcc"].Index)
            {
                Teman tmn = new Teman();
                tmn.Username1 = username1;
                Teman.TerimaTeman(tmn);
                //Refresh Page
                Teman teman = new Teman();
                teman.Username2 = userLogin.Username;
                List<Teman> ListPermintaan = Teman.BacaRequest(teman);
                dataGridViewRequest.DataSource = ListPermintaan;
            }
            else
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Apakah Anda yakin " +
                        "ingin menghapus Permintaan pertemanan ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Teman.HapusTeman(username1);
                        //Refresh Page
                        Teman teman = new Teman();
                        teman.Username2 = userLogin.Username;
                        List<Teman> ListPermintaan = Teman.BacaRequest(teman);
                        dataGridViewRequest.DataSource = ListPermintaan;

                        MessageBox.Show("Data berhasil dihapus");
                    }
                    else
                    {
                        MessageBox.Show("Data gagal dihapus");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FormPermintaanPertemanan_Load(object sender, EventArgs e)
        {
            Teman teman = new Teman();
            teman.Username2 = userLogin.Username;

            List<Teman> ListPermintaan = Teman.BacaRequest(teman);
            dataGridViewRequest.DataSource = ListPermintaan;
            dataGridViewRequest.Columns[0].HeaderText = "Username";
            dataGridViewRequest.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewRequest.Columns[0].Width = dataGridViewRequest.Width / 2;

            for (int i = 1; i < dataGridViewRequest.Columns.Count; i++)
            {
                dataGridViewRequest.Columns[i].Visible = false;
            }
            if (dataGridViewRequest.ColumnCount >= 1)
            {
                DataGridViewButtonColumn btnAcc= new DataGridViewButtonColumn();
                btnAcc.Text = "Terima";
                btnAcc.UseColumnTextForButtonValue = true;
                btnAcc.HeaderText = "";
                btnAcc.Name = "buttonAcc";
                dataGridViewRequest.Columns.Add(btnAcc);
            }
            if (dataGridViewRequest.ColumnCount >= 1)
            {
                DataGridViewButtonColumn btnDec = new DataGridViewButtonColumn();
                btnDec.Text = "Tolak";
                btnDec.UseColumnTextForButtonValue = true;
                btnDec.HeaderText = "";
                btnDec.Name = "buttonDec";
                dataGridViewRequest.Columns.Add(btnDec);
            }
        }
    }
}
