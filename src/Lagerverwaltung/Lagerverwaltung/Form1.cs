using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Lagerverwaltung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            listBox_Produkt.DisplayMember = "Name";
            listBox_Kategorien.DisplayMember = "Name";
            comboBox_ProduktKategorien.DisplayMember = "Name";

        }

        private void button_ColorPicker_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button) sender;

            DialogResult result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                clickedButton.BackColor = colorDialog1.Color;
            }
        }

        private void button_ProduktSave_Click(object sender, EventArgs e)
        {
            bool isUsed = false;

            if (TestForEmptyProd())
            {
                Produkt produkt = new Produkt(textBox_ProduktName.Text,
                    Convert.ToInt32(numericUpDown_ProduktAnzahl.Value),
                    Convert.ToInt32(numericUpDown_ProduktKosten.Value), comboBox_ProduktKategorien.SelectedText,
                    textBox_ProduktDetails.Text, Guid.NewGuid().ToString());

                foreach (Produkt prod in Program.ProduktListe)
                {
                    if (prod.Name.Equals(produkt.Name))
                    {
                        textBox_ProduktName.BackColor = Color.Red;
                        isUsed = true;
                    }
                }
                if (!isUsed)
                {
                    Program.ProduktListe.Add(produkt);
                    listBox_Produkt.DataSource = Program.ProduktListe;
                    textBox_ProduktName.BackColor = Color.White;
                    ClearInputProd();
                }
            }
        }

        private void button_ProduktDel_Click(object sender, EventArgs e)
        {

            String selectedProductName = listBox_Produkt.GetItemText(listBox_Produkt.SelectedItem);

            for (var i = 0; i < Program.ProduktListe.Count; i++)
            {
                Produkt produkt = Program.ProduktListe[i];


                if (selectedProductName.Equals(produkt.Name))
                {
                    Program.ProduktListe.Remove(Program.ProduktListe[i]);
                }
            }
            
        }

        private void button_ProduktEdit_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < Program.ProduktListe.Count; i++)
            {
                Produkt produkt = Program.ProduktListe[i];

                String id = produkt.Id;

                if (label11.Text.Equals(id))
                {
                    produkt.Name = textBox_ProduktName.Text;
                    produkt.Kosten = Convert.ToInt32(numericUpDown_ProduktKosten.Value);
                    produkt.Details = textBox_ProduktDetails.Text;
                    produkt.Kategorie = comboBox_ProduktKategorien.Text;
                    produkt.Anzahl = Convert.ToInt32(numericUpDown_ProduktAnzahl.Value);

                    Program.ProduktListe.Remove(produkt);
                    Program.ProduktListe.Add(produkt);
                }
            }
        }

        private void ClearInputProd()
        {
            textBox_ProduktName.Text = "";
            numericUpDown_ProduktKosten.Value = 0;
            textBox_ProduktDetails.Text = "";
            comboBox_ProduktKategorien.Text = "";
            numericUpDown_ProduktAnzahl.Value = 0;
            label11.Text = "";
        }

        private void ClearInputKat()
        {
            textBox_KategorieName.Text = "";
            button_ColorPicker.BackColor = Color.LightGray;
            textBox_KategorieName.BackColor = Color.White;
            label12.Text = "";
        }

        private void listBox_Produkt_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (var i = 0; i < Program.ProduktListe.Count; i++)
            {
                Produkt produkt = Program.ProduktListe[i];

                String proName = listBox_Produkt.GetItemText(listBox_Produkt.SelectedItem);

                if (proName.Equals(produkt.Name))
                {
                    textBox_ProduktName.Text = produkt.Name;
                    numericUpDown_ProduktKosten.Text = produkt.Kosten.ToString();
                    textBox_ProduktDetails.Text = produkt.Details;
                    comboBox_ProduktKategorien.Text = produkt.Kategorie;
                    numericUpDown_ProduktAnzahl.Text = produkt.Anzahl.ToString();
                    label11.Text = produkt.Id;
                }
            }
        }

        private void button_reinigen_Click(object sender, EventArgs e)
        {
            ClearInputProd();
            textBox_ProduktName.BackColor = Color.White;
        }

        private void button_KategorSave_Click(object sender, EventArgs e)
        {
            bool isUsed = false;

            if (TestForEmptyKat())
            {
                Kategorie kategorie = new Kategorie(textBox_KategorieName.Text,Guid.NewGuid().ToString());

                foreach (Kategorie kat in Program.Kategorieliste)
                {
                    if (kat.Name.Equals(kategorie.Name))
                    {
                        textBox_KategorieName.BackColor = Color.Red;
                        isUsed = true;
                    }
                }
                if (!isUsed)
                {
                    Program.Kategorieliste.Add(kategorie);
                    listBox_Kategorien.DataSource = Program.Kategorieliste;
                    comboBox_ProduktKategorien.DataSource = Program.Kategorieliste;
                    textBox_KategorieName.BackColor = Color.White;
                    ClearInputKat();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearInputKat();
        }

        private void button_KategorDel_Click(object sender, EventArgs e)
        {
            String selectedKategorieName = listBox_Kategorien.GetItemText(listBox_Kategorien.SelectedItem);

            for (var i = 0; i < Program.Kategorieliste.Count; i++)
            {
                Kategorie kategorie = Program.Kategorieliste[i];


                if (selectedKategorieName.Equals(kategorie.Name))
                {
                    Program.Kategorieliste.Remove(Program.Kategorieliste[i]);
                }
            }
        }

        private void button_KategorEdit_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < Program.Kategorieliste.Count; i++)
            {
                Kategorie kategorie = Program.Kategorieliste[i];

                String id = kategorie.Id;

                if (label12.Text.Equals(id))
                {
                    kategorie.Name = textBox_KategorieName.Text;

                    Program.Kategorieliste.Remove(kategorie);
                    Program.Kategorieliste.Add(kategorie);
                }
            }
        }

        private void listBox_Kategorien_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (var i = 0; i < Program.Kategorieliste.Count; i++)
            {
                Kategorie kategorie = Program.Kategorieliste[i];

                String katname = listBox_Kategorien.GetItemText(listBox_Kategorien.SelectedItem);

                if (katname.Equals(kategorie.Name))
                {
                    textBox_KategorieName.Text = kategorie.Name;
                }
            }
        }

        public bool TestForEmptyProd()
        {
            if (String.IsNullOrWhiteSpace(textBox_ProduktName.Text))
            {
                MessageBox.Show("Der Name darf nicht leer sein");
                return false;
            }
            else if (!(numericUpDown_ProduktKosten.Value <= 0))
            {
                MessageBox.Show("Die Anzahl muss größer als 0 sein");
                return false;
            }
            else if (String.IsNullOrWhiteSpace(comboBox_ProduktKategorien.SelectedText))
            {
                MessageBox.Show("Es muss eine Kategorie gewählt werden");
                return false;
            }
            else if (!(numericUpDown_ProduktAnzahl.Value <= 0))
            {
                MessageBox.Show("Das Produkt darf nicht kostenlos sein");
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool TestForEmptyKat()
        {
            if (String.IsNullOrWhiteSpace(textBox_KategorieName.Text))
            {
                MessageBox.Show("Der Kategoriename darf nicht leer sein");
                return false;
            }
                return true;
        }
    }
}
