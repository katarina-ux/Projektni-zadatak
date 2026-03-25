using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projektni_zadatak
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Admin.Vrste().Distinct().ToList();
		}

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<string> lista = Admin.Ucitaj();
            foreach (string zapis in lista)
            {
                listBox1.Items.Add(zapis.Replace("|", " "));
			}
		}

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            string kriterij = comboBox1.SelectedItem.ToString();
            List<string> pronadjene = Admin.PronadiPoVrsti(kriterij);
            foreach (string vrsta in pronadjene)
            { 
              listBox1.Items.Add(vrsta.Replace("|", " "));
			}
		}
    }
}
