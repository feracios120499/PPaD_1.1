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
