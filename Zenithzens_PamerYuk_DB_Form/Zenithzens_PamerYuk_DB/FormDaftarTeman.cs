using System;
using Class_PamerYuk;
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
    public partial class FormDaftarTeman : Form
    {
        public User userLogin;
        public FormDaftarTeman()
        {
            InitializeComponent();
        }

        private void FormDaftarTeman_Load(object sender, EventArgs e)
        {
            List<Teman> ListTeman = Teman.BacaTeman(userLogin);
            dataGridViewTeman.DataSource = ListTeman;

            dataGridViewTeman.Columns[0].HeaderText = "Username";
            dataGridViewTeman.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTeman.Columns[0].Width = dataGridViewTeman.Width / 2;

            for (int i = 1; i < dataGridViewTeman.Columns.Count; i++)
            {
                dataGridViewTeman.Columns[i].Visible = false;
            }
            if (dataGridViewTeman.ColumnCount >= 1)
            {
                DataGridViewButtonColumn btnMessage = new DataGridViewButtonColumn();
                btnMessage.Text = "Message";
                btnMessage.UseColumnTextForButtonValue = true;
                btnMessage.HeaderText = "";
                btnMessage.Name = "buttonMessage";
                dataGridViewTeman.Columns.Add(btnMessage);
            }
            if (dataGridViewTeman.ColumnCount >= 1)
            {
                DataGridViewButtonColumn btnRemoveFriend= new DataGridViewButtonColumn();
                btnRemoveFriend.Text = "Hapus Teman";
                btnRemoveFriend.UseColumnTextForButtonValue = true;
                btnRemoveFriend.HeaderText = "";
                btnRemoveFriend.Name = "buttonRemoveFriend";
                dataGridViewTeman.Columns.Add(btnRemoveFriend);
            }

        }

        private void dataGridViewTeman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string username1 = dataGridViewTeman.CurrentRow.Cells["username1"].Value.ToString();
            if (e.ColumnIndex == dataGridViewTeman.Columns["buttonMessage"].Index)
            {

            }
            else
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Apakah Anda yakin " +
                        "ingin menghapus " + username1 +" dari teman?", "Konfirmasi Hapus", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Teman.HapusTeman(username1);
                        //Refresh Page
                        List<Teman> ListTeman = Teman.BacaTeman(userLogin);
                        dataGridViewTeman.DataSource = ListTeman;

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
    }
}
