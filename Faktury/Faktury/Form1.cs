using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faktury
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ListaZamowien listaZamowien = new ListaZamowien();


        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

      

        public void dodajZamowienie()
        {
            //spradzamy czy pole nazwy zamowienia nie jest puste ( bo nie powinno być)
            if (tb_NazwaZamowienia.Text != "")
            {
                if (listaZamowien.FindAll(zam => zam.Nazwa == tb_NazwaZamowienia.Text).Count == 0)
                {
                    listaZamowien.Add(new Zamowienie(tb_NazwaZamowienia.Text));
                    odswiezZamowienia();
                }
                else MessageBox.Show("Istnieje już zamówienie o takiej nazwie.", "Dodawanie zamówienia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else MessageBox.Show("Musisz podać nazwę zamówienia", "Dodawanie zamówienia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void odswiezZamowienia()
        {
            lv_Zamowienia.Items.Clear();
            foreach (Zamowienie zam in listaZamowien)
            {
                lv_Zamowienia.Items.Add(zam.Nazwa);
                lv_Zamowienia.Items[lv_Zamowienia.Items.Count - 1].SubItems.Add(zam.Wartosc.ToString());
                lv_Zamowienia.Items[lv_Zamowienia.Items.Count - 1].SubItems.Add(zam.Rabat.ToString());
                lv_Zamowienia.Items[lv_Zamowienia.Items.Count - 1].SubItems.Add(zam.IloscProduktow.ToString());
            }
        }

        public void dodajProdukt()
        {
            if(tb_cena.Text !="" && tb_ilosc.Text !="" && tb_nazwaProduktu.Text !="" && tb_rabat.Text !="" && tb_vat.Text !="")
            {
                //if (listaZamowien.WybraneZamowienie.Produkty.FindAll(prod => prod.Nazwa == tb_ilosc.Text).Count == 0)
                //{
                    if (listaZamowien.WybraneZamowienie != null)
                    {
                        string nazwa = tb_nazwaProduktu.Text;
                        double cena = Double.Parse(tb_cena.Text);
                        double ilosc = Double.Parse(tb_ilosc.Text);
                        double vat = Double.Parse(tb_vat.Text);
                        double rabat = Double.Parse(tb_rabat.Text);
                        listaZamowien.WybraneZamowienie.Produkty.Add(new Produkt(nazwa, ilosc, cena, vat, rabat));
                        ladujZamowienie(listaZamowien.WybraneZamowienie);
                        odswiezZamowienia();
                    }
                else MessageBox.Show("Wybierz zamówienie do którego chcesz dodać ten produkt", "Dodawanie produktu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else MessageBox.Show("Musisz wypełnić wszystkie pola", "Dodawanie produktu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void bt_dodaj_Click(object sender, EventArgs e)
        {
            dodajZamowienie();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dodajProdukt();
        }

        private void lb_Zamowienia_SelectedIndexChanged(object sender, EventArgs e)
        {
           // if (lb_Zamowienia.SelectedIndex != null)
            {
                listaZamowien.WybraneZamowienie = listaZamowien[lv_Zamowienia.SelectedIndices[0]];
                ladujZamowienie(listaZamowien.WybraneZamowienie);
            }
        }

        private void ladujZamowienie(Zamowienie wybraneZamowienie)
        {
            lv_produkty.Items.Clear();
            foreach (Produkt prod in wybraneZamowienie.Produkty)
            {
                lv_produkty.Items.Add(prod.Nazwa);
                lv_produkty.Items[lv_produkty.Items.Count - 1].SubItems.Add(prod.Ilosc.ToString());
                lv_produkty.Items[lv_produkty.Items.Count - 1].SubItems.Add(prod.Cena.ToString());
                lv_produkty.Items[lv_produkty.Items.Count - 1].SubItems.Add(prod.Vat.ToString());
                lv_produkty.Items[lv_produkty.Items.Count - 1].SubItems.Add(prod.Rabat.ToString());
            }
        }

        public void lv_produkty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_produkty.SelectedIndices.Count > 0)
            {
                listaZamowien.WybraneZamowienie.WybranyProdukt = listaZamowien.WybraneZamowienie.Produkty[lv_produkty.SelectedIndices[0]];
                ladujProdukt(listaZamowien.WybraneZamowienie.WybranyProdukt);   
            }
        }

        private void ladujProdukt(Produkt wybranyProdukt)
        {
            tb_cena.Text = wybranyProdukt.Cena.ToString();
            tb_ilosc.Text = wybranyProdukt.Ilosc.ToString();
            tb_nazwaProduktu.Text = wybranyProdukt.Nazwa.ToString();
            tb_rabat.Text = wybranyProdukt.Rabat.ToString();
            tb_vat.Text = wybranyProdukt.Vat.ToString();
        }

        private void lv_Zamowienia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Zamowienia.SelectedIndices.Count > 0)
            {
                listaZamowien.WybraneZamowienie = listaZamowien[lv_Zamowienia.SelectedIndices[0]];
                ladujZamowienie(listaZamowien.WybraneZamowienie);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            zmienProdukt();
        }

        public void zmienProdukt()
        {
            
            if (listaZamowien.WybraneZamowienie != null && listaZamowien.WybraneZamowienie.WybranyProdukt != null)
            {
                Produkt prod = listaZamowien.WybraneZamowienie.WybranyProdukt;
                string nazwa = tb_nazwaProduktu.Text;
                double cena = Double.Parse(tb_cena.Text);
                double ilosc = Double.Parse(tb_ilosc.Text);
                double vat = Double.Parse(tb_vat.Text);
                double rabat = Double.Parse(tb_rabat.Text);

                prod.Nazwa = nazwa;
                prod.Cena = cena;
                prod.Ilosc = ilosc;
                prod.Vat = vat;
                prod.Rabat = rabat;

                ladujZamowienie(listaZamowien.WybraneZamowienie);
                odswiezZamowienia();
            }
            else MessageBox.Show("Musisz wybrać zamówienie i produkt który chcesz edytować", "Edycja produktu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

       

    }
}
