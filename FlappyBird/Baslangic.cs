using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Baslangic : Form
    {
        public Baslangic()
        {
            InitializeComponent();
            cmbZorlukSeviyesi.SelectedIndex = 0;
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            int secim = cmbZorlukSeviyesi.SelectedIndex;
            Form1 form1 = new Form1(secim);
            this.Hide();
            form1.ShowDialog();
            this.Show();
        }
    }
}
