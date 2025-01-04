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
using Zenithzens_PamerYuk_DB_Form;

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

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void kisahHidupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormKisahHidup"];

            if (form == null)
            {
                FormKisahHidup frmKisahHidup = new FormKisahHidup();
                frmKisahHidup.Owner = this;
                frmKisahHidup.userLogin = userLogin;
                frmKisahHidup.ShowDialog();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void cariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormTeman"];

            if (form == null)
            {
                FormTeman frmTeman = new FormTeman();
                frmTeman.Owner = this;
                frmTeman.userLogin = userLogin;
                frmTeman.ShowDialog();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void permintaanPertemananToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormPermintaanPertemanan"];

            if (form == null)
            {
                FormPermintaanPertemanan frmPermintaanTeman = new FormPermintaanPertemanan();
                frmPermintaanTeman.Owner = this;
                frmPermintaanTeman.userLogin = userLogin;
                frmPermintaanTeman.ShowDialog();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userLogin = null;

            FormLogin frm = new FormLogin();
            frm.Owner = this;
            this.Visible = false;
            frm.ShowDialog();

            if (userLogin == null)
            {
                Application.Exit(); 
            }
            else
            {
                pictureBoxProfile.Image = User.BacaGambar(userLogin.Foto);
                label1.Text = userLogin.Username;
            }
        }

        private void daftarTemanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarTeman"];

            if (form == null)
            {
                FormDaftarTeman frmDaftarTeman = new FormDaftarTeman();
                frmDaftarTeman.Owner = this;
                frmDaftarTeman.userLogin = userLogin;
                frmDaftarTeman.ShowDialog();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }
    }
}
