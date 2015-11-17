using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Zadatak3_Cas.Enum_classes;
using Zadatak3_Cas.Domain__classes;

namespace Zadatak3_Cas
{
    
    public partial class Form1 : Form
    {

        public Komitent vlasnik;
        public PartijaBase partija;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_UnesiPartiju_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBrojPartije.Text))
            {
                vlasnik = new Komitent()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    JMBG = txtJMBG.Text,
                    Telefon = txtTelefon.Text
                };

                switch ((TTipPartije)cbTipPartije.SelectedIndex)
                { 
                    case TTipPartije.DeviznaStednja:
                        partija = new DeviznaStednja() { BrojPartije = txtBrojPartije.Text, Vlasnik = vlasnik};
                        break;
                    case TTipPartije.DinarskaStednja:
                        partija = new DinarskaStednja() { BrojPartije = txtBrojPartije.Text, Vlasnik = vlasnik };
                        break;
                    case TTipPartije.TekuciRacun:
                        partija = new TekuciRacun() { BrojPartije = txtBrojPartije.Text, Vlasnik = vlasnik };
                        break;

                }

                gbPrikaz.Enabled = true;
                gbPromene.Enabled = true;

                if (partija is TekuciRacun)
                {
                    cbValute.SelectedIndex = 0;
                    cbValute.Enabled = false;
                }
                else
                {
                    cbValute.Enabled = true;
                }

            }
        }

        private void btnUplata_Click(object sender, EventArgs e)
        {
            partija.Uplata(float.Parse(txtIznos.Text), DateTime.Now, DateTime.Now, (TValuta)cbValute.SelectedIndex);
        }

        private void btnIsplata_Click(object sender, EventArgs e)
        {
            partija.Isplata(float.Parse(txtIznos.Text), DateTime.Now, DateTime.Now, (TValuta)cbValute.SelectedIndex);

        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            this.Width = 735;
            float tempStanje = 0;
            int i = 0;

            foreach (Promena prom in partija.GetPromenePoDatumuKnjizenja(dtpOd.Value, dtpDo.Value))
            {
                tempStanje += (float)prom.GetDuguje();
                tempStanje -= (float)prom.GetPotrazuje();
                i++;
                txtPromene.Text += i.ToString() + "---Duguje: " + prom.GetDuguje().ToString() + "---" + 
                    "Potrazuje: " + prom.GetPotrazuje().ToString() + "---" + tempStanje.ToString() + "\r\n";

            }

        }


    

        




    }
}
