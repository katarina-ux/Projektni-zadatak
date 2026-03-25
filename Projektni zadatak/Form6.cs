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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            List<string> lista = Admin.Ucitaj();
            int brojac = 0;
            foreach (string s in lista)
            { 
              brojac++;
			}
            Statistika.Items.Add("Ukupan broj životinja: " + brojac);
            List<string> udomitelj = Admin.UcitajUdomitelje();
            int udomljenih = 0;
            foreach (string s in udomitelj)
            {
                udomljenih++;
			}
            Statistika.Items.Add("Ukupan broj udomljenih životinja: " + udomljenih);
            Statistika.Items.Add("Ukupan broj neudomljenih životinja: " + (brojac - udomljenih));
            Statistika.Items.Add("Prosječna dob životinja: " + Admin.ProsjecnaDob() + "godina");


		}
    }
}
