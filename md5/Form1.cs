using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace md5
{
    public partial class frmmd5 : Form
    {
        public frmmd5()
        {
            InitializeComponent();
        }

       
        string hash = "";
        string Encrypt(string text)
        {
            byte[] data=Encoding.Default.GetBytes(text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(Encoding.Default.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripleDes = new TripleDESCryptoServiceProvider()
                { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform=tripleDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data,0,data.Length);
                    return Convert.ToBase64String(results,0,results.Length);
                }
            }
        }
        string Descrypt(string text)
        {
            byte[] data = Convert.FromBase64String(text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(Encoding.Default.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripleDes = new TripleDESCryptoServiceProvider()
                { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripleDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return Encoding.Default.GetString(results);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            txtSifrelenen.Text = Encrypt(txtMetin.Text);
            txtCozulen.Text = Descrypt(txtSifrelenen.Text);
        }
        private void frmmd5_Load(object sender, EventArgs e)
        {

        }

        private void txtMetin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
