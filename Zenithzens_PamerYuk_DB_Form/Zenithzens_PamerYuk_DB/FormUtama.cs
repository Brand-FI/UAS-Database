using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Class_PamerYuk;

namespace Zenithzens_PamerYuk_DB
{
    public partial class FormUtama : Form
    {
        public User userLogin;
        public FormUtama()
        {
            InitializeComponent();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.Owner = this;
            this.Visible = false;
            frm.ShowDialog();
            if (userLogin is null)
            {
                Application.Exit();
            }
            else
            {
                pictureBoxProfile.Image = User.BacaGambar(userLogin.Foto);
                label1.Text = userLogin.Username;
            }
        }

        private void pictureBoxProfile_Click(object sender, EventArgs e)
        {

        }
    }
}
