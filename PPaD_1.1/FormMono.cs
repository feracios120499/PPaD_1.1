using MonoalphabeticLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPaD_1._1
{
    public partial class FormMono : Form
    {
        public FormMono()
        {
            InitializeComponent();
        }
        Monoalphabetic chiper = new Monoalphabetic();
        private void ButtonEncrypt_Click(object sender, EventArgs e)
        {
            if (textBoxEncryptOriginal.TextLength == 0)
                return;
            var encrypt = chiper.Encrypt(textBoxEncryptOriginal.Text);

            textBoxEncrypt.Text = encrypt;
        }

        private void ButtonDecrypt_Click(object sender, EventArgs e)
        {
            if (textBoxDecryptOriginal.TextLength == 0)
                return;
            var decrypt = chiper.Decrypt(textBoxDecryptOriginal.Text);

            textBoxDecrypt.Text = decrypt;
        }
    }
}
