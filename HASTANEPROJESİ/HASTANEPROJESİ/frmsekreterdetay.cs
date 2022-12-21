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
    public partial class frmsekreterdetay : Form
    {
        public frmsekreterdetay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*frmrandevutalebi frmrandevutalebi = new frmrandevutalebi();
            frmrandevutalebi.Show();*/
            MessageBox.Show("Randevu Talebi Alındı.");
        }

        private void frmsekreterdetay_Load(object sender, EventArgs e)
        {

        }
    }
}
