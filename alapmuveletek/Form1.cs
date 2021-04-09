using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alapmuveletek
{
    public partial class Form1 : Form
    {
        private int megoldas;
        private int probalkozasokSzama;
        private int kerdesekSzama;
        public Form1()
        {
            InitializeComponent();
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

     

        private void TxtValasz_TextChanged(object sender, EventArgs e)
        {
                probalkozasokSzama++;
           

            if (txtValasz.Text.Equals(megoldas.ToString()))
            {
                lbHelyesHelytelen.Text= "Az eredmény: helyes";
            }
            else {
                lbHelyesHelytelen.Text = "Az eredmény: helytelen";
            }
            lbProbalkozas.Text = "Próbálkozások száma: " + probalkozasokSzama;

        }

        private void BtnMegoldas_Click(object sender, EventArgs e)
        {
            lbMegoldas.Text = "Megoldás: " + megoldas;
        }

        private void CmsSzorzas_Click(object sender, EventArgs e)
        {
            kerdesekSzama++;
            lbFeladat.Text += "\n 32*4=";
            megoldas = 32 * 4;
            
            lbHanyKerdes.Text = "Kerdések száma: " + kerdesekSzama;
        }

        private void CmsOsztas_Click(object sender, EventArgs e)
        {
            kerdesekSzama++;
            lbFeladat.Text += "\n 32/4=";
            megoldas = 32 / 4;

            lbHanyKerdes.Text = "Kerdések száma: " + kerdesekSzama;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
