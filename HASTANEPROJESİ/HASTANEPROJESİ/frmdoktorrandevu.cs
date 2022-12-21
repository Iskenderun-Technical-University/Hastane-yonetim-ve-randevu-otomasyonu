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
    public partial class frmdoktorrandevu : Form
    {
        public frmdoktorrandevu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmrandevugörntle frmrandevugörntle = new frmrandevugörntle();
            frmrandevugörntle.Show();
        }
    }
}
