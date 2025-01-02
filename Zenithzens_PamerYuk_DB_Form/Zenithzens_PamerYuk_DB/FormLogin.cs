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
using Zenithzens_PamerYuk_DB_Form;

namespace Zenithzens_PamerYuk_DB
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            FormUtama frm = (FormUtama)this.Owner;
            string uid = textBoxUsername.Text;
            string pwd = textBoxPassword.Text;
            frm.userLogin = User.CekLogin(uid, pwd);
            if (frm.userLogin is null)
            {
                MessageBox.Show("Username atau Password yang dimasukkan salah");
                Application.Exit();
            }
            else
            {
                frm.Visible = true;
                this.Close();
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["FormRegisterUser"];
            if (f == null)
            {
                FormRegisterUser frm = new FormRegisterUser();
                frm.Owner = this;
                frm.ShowDialog();
            }
            else
            {
                f.BringToFront();
                f.ShowDialog();
            }
        }
    }
}
