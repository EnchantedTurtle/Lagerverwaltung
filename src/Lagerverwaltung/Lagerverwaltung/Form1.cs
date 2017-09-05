using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Windows.Forms;

namespace Lagerverwaltung
{
    [SuppressMessage("ReSharper", "LocalizableElement")]
    [SuppressMessage("ReSharper", "ForCanBeConvertedToForeach")]
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

            listBox_Produkt.ValueMember = " Id";
            listBox_Kategorien.ValueMember = "Id";
            comboBox_ProduktKategorien.ValueMember = "Id";

        }
        

        private void button_ProduktSave_Click(object sender, EventArgs e)
        {
            bool isUsed = false;

            if (TestForEmptyProd())
            {
                Produkt produkt = new Produkt(textBox_ProduktName.Text,
                    Convert.ToInt32(numericUpDown_ProduktAnzahl.Value),
                    Convert.ToInt32(numericUpDown_ProduktKosten.Value), comboBox_ProduktKategorien.GetItemText(comboBox_ProduktKategorien.SelectedItem),
                    textBox_ProduktDetails.Text);

                foreach (Produkt prod in Program.Produkte)
                {
                    if (prod.Name.Equals(produkt.Name))
                    {
                        MessageBox.Show("Dieser Name wird bereits benutzt");
                        isUsed = true;
                    }
                }
                if (!isUsed)
                {
                    Program.Produkte.Add(produkt);
                    listBox_Produkt.DataSource = Program.Produkte;
                    ClearInputProd();
                }
            }
        }

        private void button_ProduktDel_Click(object sender, EventArgs e)
        {

            String selectedProductName = listBox_Produkt.GetItemText(listBox_Produkt.SelectedItem);

            for (var i = 0; i < Program.Produkte.Count; i++)
            {
                Produkt produkt = Program.Produkte[i];


                if (selectedProductName.Equals(produkt.Name))
                {
                    Program.Produkte.Remove(Program.Produkte[i]);
                }
            }
            
        }

        private void button_ProduktEdit_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < Program.Produkte.Count; i++)
            {
                Produkt produkt = Program.Produkte[i];

                if(listBox_Produkt.SelectedValue.ToString().Equals(produkt.Id))
                 {
                    produkt.Name = textBox_ProduktName.Text;
                    produkt.Kosten = Convert.ToInt32(numericUpDown_ProduktKosten.Value);
                    produkt.Details = textBox_ProduktDetails.Text;
                    produkt.Kategorie = comboBox_ProduktKategorien.GetItemText(comboBox_ProduktKategorien.SelectedItem);
                    produkt.Anzahl = Convert.ToInt32(numericUpDown_ProduktAnzahl.Value);

                    Program.Produkte.Remove(produkt);
                    Program.Produkte.Add(produkt);
                }
            }
        }

        private void ClearInputProd()
        {
            textBox_ProduktName.Text = "";
            numericUpDown_ProduktKosten.Value = 0;
            textBox_ProduktDetails.Text = "";
            comboBox_ProduktKategorien.SelectedText = "";
            numericUpDown_ProduktAnzahl.Value = 0;
        }

        private void ClearInputKat()
        {
            textBox_KategorieName.Text = "";
        }

        private void listBox_Produkt_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (var i = 0; i < Program.Produkte.Count; i++)
            {
                Produkt produkt = Program.Produkte[i];

                String proName = listBox_Produkt.GetItemText(listBox_Produkt.SelectedItem);

                if (proName.Equals(produkt.Name))
                {
                    textBox_ProduktName.Text = produkt.Name;
                    numericUpDown_ProduktKosten.Text = produkt.Kosten.ToString();
                    textBox_ProduktDetails.Text = produkt.Details;
                    comboBox_ProduktKategorien.Text = produkt.Kategorie;
                    numericUpDown_ProduktAnzahl.Text = produkt.Anzahl.ToString();
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

                foreach (Kategorie kat in Program.Kategorien)
                {
                    if (kat.Name.Equals(textBox_KategorieName.Text))
                    {
                        MessageBox.Show("Dieser Name wird bereits genutzt");
                        isUsed = true;
                    }
                }
                if (!isUsed)
                {

                    Kategorie kategorie = new Kategorie(textBox_KategorieName.Text);
                    Program.Kategorien.Add(kategorie);
                    listBox_Kategorien.DataSource = Program.Kategorien;
                    comboBox_ProduktKategorien.DataSource = Program.Kategorien;
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



            for (var i = 0; i < Program.Produkte.Count; i++)
            {
                var product = Program.Produkte[i];
                if (product.Kategorie.Equals(selectedKategorieName))
                {
                    MessageBox.Show("Es sind Produkte dieser Kategorie zugeordnet");
                    return;
                }
            }


            for (var i = 0; i < Program.Kategorien.Count; i++)
            {
                Kategorie kategorie = Program.Kategorien[i];
               
                    if (selectedKategorieName.Equals(kategorie.Name))
                    {
                        Program.Kategorien.Remove(Program.Kategorien[i]);
                        return;
                    }
                
            }


        }

        private void button_KategorEdit_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < Program.Kategorien.Count; i++)
            {
                Kategorie kategorie = Program.Kategorien[i];

                if (listBox_Kategorien.SelectedValue.ToString().Equals(kategorie.Id))
                {
                    kategorie.Name = textBox_KategorieName.Text;

                    Program.Kategorien.Remove(kategorie);
                    Program.Kategorien.Add(kategorie);
                }
            }
        }

        private void listBox_Kategorien_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (var i = 0; i < Program.Kategorien.Count; i++)
            {
                Kategorie kategorie = Program.Kategorien[i];

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
            if (numericUpDown_ProduktKosten.Value <= 0)
            {
                MessageBox.Show("Die Kosten muss größer als 0 sein");
                return false;
            }
            if (String.IsNullOrWhiteSpace(comboBox_ProduktKategorien.GetItemText(comboBox_ProduktKategorien.SelectedItem)))
            {
                MessageBox.Show("Es muss eine Kategorie gewählt werden");
                return false;
            }
            if (numericUpDown_ProduktAnzahl.Value <= 0)
            {
                MessageBox.Show("Die Anzahl darf nicht kostenlos sein");
                return false;
            }
            return true;
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
