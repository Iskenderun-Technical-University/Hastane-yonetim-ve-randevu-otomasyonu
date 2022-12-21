using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HASTANEPROJESİ
{
    public partial class frmbilgilerinidüzenle : Form
    {
        public frmbilgilerinidüzenle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmhastadetay frmhastadetay = new frmhastadetay();
            frmhastadetay.Show();

        }
    }
}
