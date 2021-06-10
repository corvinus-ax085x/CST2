using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST2
{
    public partial class ReceptUC : UserControl

        

    {
        EtkeztetesEntities context = new EtkeztetesEntities();
        public ReceptUC()
        {
            InitializeComponent();
            button1.Text = "\uE76B";
            button2.Text = "\uE76C";

        }

        void FogásLista() 
        {
            var fogások = from x in context.Fogasok
                          where x.FogasNev.Contains(textBoxReceptKeresés.Text)
                          select x;
            fogasokBindingSource.DataSource = fogások.ToList();
        }

        void Nyersanyaglista() 
        {
            var nyersanyag = from x in context.Nyersanyagok
                             where x.NyersanyagNev.Contains(textBoxNyersanyagKeresés.Text)
                             select x;
            nyersanyagokBindingSource.DataSource = nyersanyag.ToList();
        }

        private void ReceptUC_Load(object sender, EventArgs e)
        {
            FogásLista();
            Nyersanyaglista();
        }

        private void textBoxReceptKeresés_TextChanged(object sender, EventArgs e)
        {
            FogásLista();
        }

        private void textBoxNyersanyagKeresés_TextChanged(object sender, EventArgs e)
        {
            Nyersanyaglista();
        }

        private void listBoxRecept_SelectedIndexChanged(object sender, EventArgs e)
        {
            HozzávalóLista();

        }

        private void HozzávalóLista()
        {

            if (listBoxRecept.SelectedItem == null) return;

            var kiválasztottfogás = (Fogasok)fogasokBindingSource.Current;

            var hozzávaló = from x in context.Receptek
                            where x.FogasID == kiválasztottfogás.FogasID
                            select new Hozzávaló
                            {
                                
                                ReceptID = x.ReceptID,
                                FogasID = x.FogasID,
                                NyersanyagNev = x.Nyersanyagok.NyersanyagNev,
                                Mennyiseg_4fo = x.Mennyiseg_4fo,
                                EgysegNev = x.Nyersanyagok.MennyisegiEgysegek.EgysegNev,
                                Ár = (double)x.Mennyiseg_4fo * (double)x.Nyersanyagok.Egysegar
                            };


            hozzávalóBindingSource.DataSource = hozzávaló.ToList();
        }

        private void listBoxNyersanyag_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxNyersanyag.SelectedItem == null) return;
            label1.Text = ((Nyersanyagok)listBoxNyersanyag.SelectedItem).MennyisegiEgysegek.EgysegNev;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Receptek r = new Receptek();
            r.NyersanyagID = ((Nyersanyagok)listBoxNyersanyag.SelectedItem).NyersanyagID;
            r.FogasID = ((Fogasok)listBoxRecept.SelectedItem).FogasID;


            double m;
            if (!double.TryParse(textBox1.Text, out m)) return;

            r.Mennyiseg_4fo = m;

            context.Receptek.Add(r);
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            HozzávalóLista();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var receptid = ((Hozzávaló)hozzávalóBindingSource.Current).ReceptID;

            var törlendő = (from x in context.Receptek
                           where x.ReceptID == receptid
                           select x).FirstOrDefault();

            context.Receptek.Remove(törlendő);
            context.SaveChanges();
            HozzávalóLista();



            Console.WriteLine(receptid);
        }
    }
}
