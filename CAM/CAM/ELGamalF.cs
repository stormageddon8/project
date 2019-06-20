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
    public partial class ELGamalF : Form
    {
        public ELGamalF()
        {
            InitializeComponent();
        }

        private int Rand()
        {
            Random random = new Random();
            return random.Next();
        }
        int power(int a, int b, int n)
        {
            int tmp = a;
            int sum = tmp;
            for (int i = 1; i < b; i++)
            {
                for (int j = 1; j < a; j++)
                {
                    sum += tmp;
                    if (sum >= n)
                    {
                        sum -= n;
                    }
                }
                tmp = sum;
            }
            return tmp;
        }
        int mul(int a, int b, int n) 
        {
            int sum = 0;
            for (int i = 0; i < b; i++)
            {
                sum += a;
                if (sum >= n)
                {
                    sum -= n;
                }
            }
            return sum;
        }
        void crypt(int p, int g, int x, string strIn)
        {
            
            int y = power(g, x, p);
            textBox5.Text = y.ToString();
            textBox4.Text = g.ToString();
            textBox6.Text =x.ToString();
            if (strIn.Length > 0)
            {
                char[] temp = new char[strIn.Length - 1];
                temp = strIn.ToCharArray();
                for (int i = 0; i <= strIn.Length - 1; i++)
                {
                    int m = (int)temp[i];
                    if (m > 0)
                    {
                        int k = Rand() % (p - 2) + 1; 
                        int a = power(g, k, p);
                        int b = mul(power(y, k, p), m, p);
                        textBox2.Text = textBox2.Text + a + " " + b + " ";
                    }
                }
            }
        }

        void decrypt(int p, int x, string strIn)
        {
            textBox7.Text = "";
            byte[] f;
            string n = "";
            if (strIn.Length > 0)
            {
                
                string[] strA = strIn.Split(' ');
                if (strA.Length > 0)
                {
                    for (int i = 0; i < strA.Length - 1; i += 2)
                    {
                        char[] a = new char[strA[i].Length];
                        char[] b = new char[strA[i + 1].Length];
                        int ai = 0;
                        int bi = 0;
                        a = strA[i].ToCharArray();
                        b = strA[i + 1].ToCharArray();
                        for (int j = 0; (j < a.Length); j++)
                        {
                            ai = ai * 10 + (int)(a[j] - 48);
                        }
                        for (int j = 0; (j < b.Length); j++)
                        {
                            bi = bi * 10 + (int)(b[j] - 48);
                        }
                        if ((ai != 0) && (bi != 0))
                        {
                            int deM = mul(bi, power(ai, p - 1 - x, p), p);
                            char m = (char)deM;
                            textBox7.Text=textBox7.Text+m;
                        }
                    }
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            int p = Convert.ToInt32(textBox3.Text);
            int g = Convert.ToInt32(textBox4.Text);
            int x = Convert.ToInt32(8);
            
            MessageBox.Show(p.ToString());
            crypt(p, g, x, textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
            textBox2.Text = "";

            int p = Convert.ToInt32(textBox3.Text);
            int x = new Random().Next(p);
            int g = Convert.ToInt32(textBox4.Text);
            crypt(p, g, x, textBox1.Text);
            decrypt(p, x, textBox2.Text);

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MainMenu fo = new MainMenu();
            this.Hide();
            fo.ShowDialog();
            
        }
    }
}
