using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAM
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RSA form = new RSA();
            this.Hide();
            form.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ELGamalF f = new ELGamalF();
            this.Hide();
            f.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RC4F f = new RC4F();
            this.Hide();
            f.ShowDialog();
            
        }
    }
}
