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
    public partial class frmilkgiris : Form
    {
        public frmilkgiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmhastagiris frmhastagiris = new frmhastagiris();
            frmhastagiris.Show();
            this.Hide();
        }

        private void btnsekreter_Click(object sender, EventArgs e)
        {
            frmsekreterdetay frmsekreterdetay = new frmsekreterdetay();
            frmsekreterdetay.Show();
            this.Hide();
        }

        private void btndoktor_Click(object sender, EventArgs e)
        {
            frmdoktorrandevu frmdoktorrandevu = new frmdoktorrandevu();
            frmdoktorrandevu.Show();
            this.Hide();
        }
    }
}
