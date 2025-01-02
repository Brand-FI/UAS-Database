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
        public FormKisahHidup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTambahKisahHidup frm = new FormTambahKisahHidup();
            frm.Owner = this;
            frm.ShowDialog();
        }
    }
}
