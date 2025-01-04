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
    public partial class FormTeman : Form
    {
        public User userLogin;
        public FormTeman()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormTeman_Load(object sender, EventArgs e)
        {
            List<User> ListUser = User.BacaUserLain(userLogin);
            dataGridViewUser.DataSource = ListUser;
            comboBoxCariTeman.SelectedIndex = 0;
            //Untuk Melebarkan Kolom
            dataGridViewUser.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewUser.Columns[0].Width = dataGridViewUser.Width / 2;
            for (int i = 1; i < dataGridViewUser.Columns.Count; i++)
            {
                dataGridViewUser.Columns[i].Visible = false;
            }
            if (dataGridViewUser.ColumnCount >= 1)
            {
                DataGridViewButtonColumn btnAdd = new DataGridViewButtonColumn();
                btnAdd.Text = "Add Friend";
                btnAdd.HeaderText = "Add as a Friend";
                btnAdd.UseColumnTextForButtonValue = true;
                btnAdd.Name = "buttonAdd";
                dataGridViewUser.Columns.Add(btnAdd);
            }
        }

        private void dataGridViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string nama = dataGridViewUser.CurrentRow.Cells["Username"].Value.ToString();

            if (e.ColumnIndex == dataGridViewUser.Columns["buttonAdd"].Index)
            {
                Teman friend = new Teman();
                friend.Username1 = userLogin.Username;
                friend.Username2 = nama;
                Teman.TambahData(friend);
            }
            List<User> ListUser = User.BacaUserLain(userLogin);
            dataGridViewUser.DataSource = ListUser;
        }

        private void textBoxCariTeman_TextChanged(object sender, EventArgs e)
        {
            string filter;
            if (comboBoxCariTeman.SelectedIndex == 0)
            {
                filter = "Organisasi";
            }
            else
            {
                filter = "";
            }
            string nilai = textBoxCariTeman.Text;
            List<User> ListUser = User.BacaUserLain(userLogin, filter, nilai);
            dataGridViewUser.DataSource = ListUser;
        }

        private void comboBoxCariTeman_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filter;
            if (comboBoxCariTeman.SelectedIndex == 0)
            {
                filter = "Organisasi";
            }
            else
            {
                filter = "";
            }
            string nilai = textBoxCariTeman.Text;
            List<User> ListUser = User.BacaUserLain(userLogin, filter, nilai);
            dataGridViewUser.DataSource = ListUser;
        }
    }
}
