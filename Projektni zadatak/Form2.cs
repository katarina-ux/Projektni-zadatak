using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projektni_zadatak
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string slika = openFileDialog1.FileName;
            string zapis = textBox1.Text + "|" + textBox2.Text + "|" + radioButton1.Checked + "|" + radioButton2.Checked + "|" + slika + "|" + textBox3.Text + "|" + checkBox1.Checked + "|" + checkBox2.Checked + "|" + numericUpDown1.Text + "|" + dateTimePicker1.Text + "|" + textBox4.Text;
            Admin.UnosZivotinja(zapis);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string slika = openFileDialog1.FileName;    
            pictureBox1.Load(slika);
        }
    }
}
