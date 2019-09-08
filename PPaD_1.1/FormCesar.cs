using CesarChiperLibrary;
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
    public partial class FormCesar : Form
    {
        public FormCesar()
        {
            InitializeComponent();
        }
        CesarChiper chiper = new CesarChiper();
        private void ButtonEncrypt_Click(object sender, EventArgs e)
        {
            if (textBoxEncryptOriginal.TextLength == 0)
                return;
            chiper.Key = (int)numericUpDownShift.Value;
            var encrypt = chiper.Encrypt(textBoxEncryptOriginal.Text);

            textBoxEncrypt.Text = encrypt;
        }

        private void ButtonDecrypt_Click(object sender, EventArgs e)
        {
            if (textBoxDecryptOriginal.TextLength == 0)
                return;
            chiper.Key = (int)numericUpDownShift.Value;
            var decrypt = chiper.Decrypt(textBoxDecryptOriginal.Text);

            textBoxDecrypt.Text = decrypt;
        }
    }
}
