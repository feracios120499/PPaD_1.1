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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private Dictionary<string, Form> chipers = new Dictionary<string, Form>();

        private void FormMain_Load(object sender, EventArgs e)
        {

            GenerateChiperForm();
            comboBoxChipers.Items.AddRange(chipers.Keys.ToArray());
            comboBoxChipers.SelectedIndex = 0;
        }
        private void GenerateChiperForm()
        {
            chipers.Clear();
            chipers.Add("Шифр цезаря", new FormCesar());
            chipers.Add("Шифр слоганом", new FormSlogan());
            chipers.Add("Шифр полибианского квадрата", new FormPolybius());
            chipers.Add("Шифр системы Трисемуса", new FormTritemius());
            chipers.Add("Шифр Playfair", new FormPlayfair());
            chipers.Add("Шифр системы омофонов", new FormMono());
            chipers.Add("Шифр Виженера", new FormVigenere());
        }
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            var nameChiper=comboBoxChipers.SelectedItem.ToString();
            var form = chipers[nameChiper];
            form.Show();

            GenerateChiperForm();
        }
    }
}
