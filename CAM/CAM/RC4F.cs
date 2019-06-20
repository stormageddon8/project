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
    public partial class RC4F : Form
    {
        byte[] s = new byte[256];
        int x = 0, y = 0;
        public RC4F()
        {
            InitializeComponent();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = RC4Alg(textBox1.Text, textBox4.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = RC4Alg(textBox2.Text, textBox4.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainMenu fo = new MainMenu();
            this.Hide();
            fo.ShowDialog();
           
        }

        public string RC4Alg(string input, string key)
        {
            StringBuilder result = new StringBuilder();
            int x, y, j = 0;
            int[] boxkey = new int[256];
            for (int i = 0; i < 256; i++)
                boxkey[i] = i;
            for (int i = 0; i < 256; i++)
            {
                j = (key[i % key.Length] + boxkey[i] + j) % 256;
                x = boxkey[i];
                boxkey[i] = boxkey[j];
                boxkey[j] = x;
            }
            for (int i = 0; i < input.Length; i++)
            {
                y = i % 256;
                j = (boxkey[y] + j) % 256;
                x = boxkey[y];
                boxkey[y] = boxkey[j];
                boxkey[j] = x;
                result.Append((char)(input[i] ^ boxkey[(boxkey[y] + boxkey[j]) % 256]));
            }
            return result.ToString();
        }
    }
}
