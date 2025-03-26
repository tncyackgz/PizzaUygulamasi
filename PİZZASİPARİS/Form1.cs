using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PİZZASİPARİS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtToplam.Enabled = false;
            double toplamfiyat = 0;
            int adet = 0;

            if (int.TryParse(txtadet.Text, out adet) && adet > 0)
            {
                string secilenboyut = ebat.SelectedItem.ToString();
                if (secilenboyut == "Küçük")
                {
                    toplamfiyat += 120 * adet;
                }
                else if (secilenboyut == "Orta")
                {
                    toplamfiyat += 150 * adet;
                }
                else if (secilenboyut == "Büyük")
                {
                    toplamfiyat += 210 * adet;

                }

                if (jambon.Checked)
                {

                    toplamfiyat += 12 * adet;

                }
                if (sosis.Checked)
                {

                    toplamfiyat += 10 * adet;

                }
                if (mısır.Checked)
                {

                    toplamfiyat += 5 * adet;

                }
                if (anquez.Checked)
                {

                    toplamfiyat += 8 * adet;

                }
                if (zeytin.Checked)
                {

                    toplamfiyat += 4 * adet;

                }
                if (salam.Checked)
                {

                    toplamfiyat += 10 * adet;

                }
                if (sucuk.Checked)
                {

                    toplamfiyat += 15 * adet;

                }
                if (mantar.Checked)
                {

                    toplamfiyat += 5 * adet;

                }
                if (tonbaligi.Checked)
                {

                    toplamfiyat += 20 * adet;

                }
                if (peynir.Checked)
                {

                    toplamfiyat += 0 * adet;

                }

                if (radio1.Checked)
                {
                    toplamfiyat += 15 * adet;
                }
            }


            txtToplam.Text = toplamfiyat.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtToplam.Text = "0";
            txtadet.Text = "0";
            ebat.Text = "";
            listBox1.ClearSelected();
            jambon.Checked = false;
            sosis.Checked = false;
            mısır.Checked = false;
            anquez.Checked = false;
            zeytin.Checked = false;
            salam.Checked = false;
            sucuk.Checked = false;
            mantar.Checked = false;
            tonbaligi.Checked = false;
            peynir.Checked = false;
            radio1.Checked = false;
        }
    }
}
