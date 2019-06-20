using System;
using System.Windows.Forms;
using CAM.RSAL;

namespace CAM
{   
    public partial class RSA : Form
    {
         RSAClass _rsa = null;
        
        public RSA()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_rsa == null)
            {
                MessageBox.Show("Создай пару ключей");
                return;
            }
            if (string.IsNullOrEmpty(txtContent.Text))
            {
                MessageBox.Show("Заполни данные");
                return;
            }
            try
            {
                txtResult.Text = _rsa.DecryptString(txtContent.Text, txtPrivateKay.Text);
            }
            catch (Exception ex)
            {
                txtResult.Text = "";
                MessageBox.Show("Проверь ключи!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int keySize = 0;
            try { keySize= int.Parse(comboBox1.SelectedItem.ToString()); }
            catch(Exception ee)
            {
                MessageBox.Show("Ключ!");
               

            }
            if (keySize == 0)
            {
                MessageBox.Show("Кликни на ключ");
                return;
            }
            //lblKeySizeValue.Text = keySize.ToString();
            _rsa = new RSAClass(keySize);
            txtPublicKey.Text = _rsa.PublicKey();
            txtPrivateKay.Text = _rsa.PrivateKey();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_rsa == null)
            {
                MessageBox.Show("Создай пару ключей!");
                return;
            }
            if (string.IsNullOrEmpty(txtContent.Text))
            {
                MessageBox.Show("Заполни данные");
                return;
            }
            try
            {
                txtResult.Text = _rsa.EncryptString(txtContent.Text, txtPublicKey.Text);
            }
            catch (Exception ex)
            {
                txtResult.Text = "";
                MessageBox.Show("Проверь ключи");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainMenu f = new MainMenu();
            this.Hide();
            f.ShowDialog();
            
        }
    }
}
