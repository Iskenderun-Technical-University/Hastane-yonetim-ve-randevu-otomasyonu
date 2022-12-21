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
    public partial class frmrandevualma : Form
    {
        public frmrandevualma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmbeyinvesinir frmbeyinvesinir = new frmbeyinvesinir();
            frmbeyinvesinir.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmçocukhastalık frmçocukhastalık = new frmçocukhastalık();
            frmçocukhastalık.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmdahiliye frmdahiliye = new frmdahiliye();
            frmdahiliye.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmgözhastalıkları frmgözhastalıkları = new frmgözhastalıkları();
            frmgözhastalıkları.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmkardiyoloji frmkardiyoloji = new frmkardiyoloji();
            frmkardiyoloji.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmnöroloji frmnöroloji = new frmnöroloji();
            frmnöroloji.Show();

        }
    }
}
