using System;
using System.Security.Cryptography;
using System.Windows.Forms;
using System;
using System.Text;

namespace CAM
{


    public partial class Main : Form
    {

        private static RSAParameters publicKey;
        private static RSAParameters privateKey;
        static string NAME = "Geronimo";
        public enum KeySize
        {
            SIZE_512 = 512,
            SIZE_1024 = 1024,
            SIZE_2048 = 2048,
            SIZE_952 = 952,
            SIZE_1369 = 1369
        };

        public Main()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(UnCryptData.Text))
            {
                string messsage = UnCryptData.Text;
                generateKeys();
                byte[] encrypted = Encrypt(Encoding.UTF8.GetBytes(messsage));
                byte[] decrypted = Decrypt(encrypted);
                CryptData.Text = BitConverter.ToString(encrypted).Replace("-", "");
                textBox1.Text = Encoding.UTF8.GetString(decrypted);
            }
            else
            {
                string messsage = CryptData.Text;
                generateKeys();
                
                byte[] decrypted = Decrypt(Encoding.ASCII.GetBytes(messsage));
                UnCryptData.Text = Encoding.UTF8.GetString(decrypted);
            }
            

        }
        static void generateKeys()
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                publicKey = rsa.ExportParameters(false);
                privateKey = rsa.ExportParameters(true);
            }
        }
        static byte[] Encrypt(byte[] input)
        {
            byte[] encrypted;
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                rsa.ImportParameters(publicKey);
                encrypted = rsa.Encrypt(input, true);
            }
            return encrypted;
        }

        static byte[] Decrypt(byte[] input)
        {
            byte[] decrypted;
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                rsa.ImportParameters(privateKey);
                decrypted = rsa.Decrypt(input, true);
            }
            return decrypted;
        }
    }
}
