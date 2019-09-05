using CesarChiperLibrary;
using SloganChiperLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPaD_1._1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            SloganCipher chiper = new SloganCipher("ДЯДИНА");
            MessageBox.Show(chiper.Encrypt("Абрамов"));
            MessageBox.Show(chiper.Decrypt("Япыч ЭложчЁ"));
        }
    }
}
