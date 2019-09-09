using PolybiusSquareLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TritemiusChiperLibrary;

namespace PPaD_1._1
{
    public partial class FormTritemius : Form
    {
        public FormTritemius()
        {
            InitializeComponent();
        }
        TritemiusChiper chiper = new TritemiusChiper();
        private void ButtonEncrypt_Click(object sender, EventArgs e)
        {
            if (textBoxEncryptOriginal.TextLength == 0)
                return;
            var encrypt = chiper.Encrypt(textBoxEncryptOriginal.Text, textBoxKey.Text);

            textBoxEncrypt.Text = encrypt;
        }

        private void ButtonDecrypt_Click(object sender, EventArgs e)
        {
            if (textBoxDecryptOriginal.TextLength == 0)
                return;
            var decrypt = chiper.Decrypt(textBoxDecryptOriginal.Text, textBoxKey.Text);

            textBoxDecrypt.Text = decrypt;
        }
    }
}
