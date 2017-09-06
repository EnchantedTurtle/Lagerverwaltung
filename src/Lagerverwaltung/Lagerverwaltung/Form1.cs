using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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
        }

        /*
         * 
          TODO Produkte bearbeitbar machen
          (TODO Kategorien sortieren)
        */
        private void button_ProduktSave_Click(object sender, EventArgs e)
        {
            if (ValidateProduct(textBox_ProduktName.Text))
            {
                    Produkt produkt = new Produkt(textBox_ProduktName.Text,
                    Convert.ToInt32(numericUpDown_ProduktAnzahl.Value),
                    Convert.ToInt32(numericUpDown_ProduktKosten.Value), comboBox_ProduktKategorien.GetItemText(comboBox_ProduktKategorien.SelectedItem),
                    textBox_ProduktDetails.Text);

                    Program.Daten.CreateProdukt(produkt, comboBox_ProduktKategorien.SelectedValue.ToString());
                    RefreshView();
                    ClearInputProd();
            }
        }

        private void button_ProduktDel_Click(object sender, EventArgs e) 
        {
            Program.Daten.DeleteProdukt(listBox_Produkt.SelectedValue.ToString());
            RefreshView();
        }

        private void button_ProduktEdit_Click(object sender, EventArgs e)
        {

                Produkt produkt = (Produkt) listBox_Produkt.SelectedItem;

                Program.Daten.UpdateProdukt(produkt,textBox_ProduktName.Text, textBox_ProduktDetails.Text, numericUpDown_ProduktKosten.Value.ToString(), numericUpDown_ProduktAnzahl.Value.ToString());
                RefreshView();
            
        }

        private void listBox_Produkt_SelectedIndexChanged(object sender, EventArgs e) 
        {
            List<Produkt> products = Program.Daten.ReadProdukt();
            List<Category> categories = Program.Daten.ReadCategory();

            for (var i = 0; i < products.Count; i++)
            {
                Produkt produkt = products[i];

                if (listBox_Produkt.SelectedValue != null)
                {
                    String proId = listBox_Produkt.SelectedValue.ToString();

                    if (proId.Equals(produkt.Id))
                    {      
                        textBox_ProduktName.Text = produkt.Name;
                        numericUpDown_ProduktKosten.Text = produkt.Kosten.ToString();
                        textBox_ProduktDetails.Text = produkt.Details;
                        numericUpDown_ProduktAnzahl.Text = produkt.Anzahl.ToString();

                        for (var j = 0; j < categories.Count; j++)
                        {

                            if (categories[j].Products.Contains(produkt))
                            {
                                comboBox_ProduktKategorien.Text = categories[j].Name;
                            }   
                        }
                    }
                }
            }
        }

        private void button_KategorSave_Click(object sender, EventArgs e)
        {
            if (ValidateCategory(textBox_KategorieName.Text))
            {
                Category category = new Category(textBox_KategorieName.Text);
                Program.Daten.CreateCategory(category);
                RefreshView();
                ClearInputKat();
            }
        }

        private void button_KategorDel_Click(object sender, EventArgs e)
        {
            string selectedCategoryName = listBox_Kategorien.GetItemText(listBox_Kategorien.SelectedItem);

            if (listBox_Kategorien.SelectedValue != null)
            {
                string selectedCategoryId = listBox_Kategorien.SelectedValue.ToString();

                Program.Daten.DeleteCategory(selectedCategoryName, selectedCategoryId);
                RefreshView();
            }    
        }

        private void button_KategorEdit_Click(object sender, EventArgs e)
        {
                Category category = (Category) listBox_Kategorien.SelectedItem;
                
                Program.Daten.UpdateCategory(category, textBox_KategorieName.Text);
                RefreshView();
            
        }

        private void listBox_Kategorien_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Category> categories = Program.Daten.ReadCategory();

            for (var i = 0; i < categories.Count; i++)
            {
                Category category = categories[i];

                if (listBox_Kategorien.SelectedValue != null)
                {
                    String katId = listBox_Kategorien.SelectedValue.ToString();

                    if (katId.Equals(category.Id))
                    {
                        textBox_KategorieName.Text = category.Name;
                    }
                }
            }
        }

        public bool ValidateProduct(string productName)
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

            // Validieren ob Produktname bereits verewendet wird
            foreach (Produkt prod in Program.Daten.ReadProdukt())
            {
                if (prod.Name.Equals(productName))
                {
                    MessageBox.Show("Dieser Name wird bereits benutzt");
                    return false;
                }
            }

            return true;
        }

        public bool ValidateCategory(string categoryName)
        {
            if (String.IsNullOrWhiteSpace(textBox_KategorieName.Text))
            {
                MessageBox.Show("Der Kategoriename darf nicht leer sein");
                return false;
            }

            foreach (Category kat in Program.Daten.ReadCategory())
            {
                if (kat.Name.Equals(textBox_KategorieName.Text))
                {
                    MessageBox.Show("Dieser Name wird bereits genutzt");
                    return false;
                }
            }
            return true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox_KategorieName.Text = "";
            listBox_Kategorien.ClearSelected();
        }


        public void ClearInputProd()
        {
            textBox_ProduktName.Text = "";
            numericUpDown_ProduktKosten.Value = 0;
            textBox_ProduktDetails.Text = "";
            comboBox_ProduktKategorien.SelectedText = "";
            numericUpDown_ProduktAnzahl.Value = 0;
            listBox_Produkt.ClearSelected();
            comboBox_ProduktKategorien.SelectedIndex = 0;
        }

        public void ClearInputKat()
        {
            textBox_KategorieName.Text = "";
            listBox_Kategorien.ClearSelected();
        }

        private void button_reinigen_Click(object sender, EventArgs e)
        {
            textBox_ProduktName.Text = "";
            numericUpDown_ProduktKosten.Value = 0;
            textBox_ProduktDetails.Text = "";
            comboBox_ProduktKategorien.SelectedText = "";
            numericUpDown_ProduktAnzahl.Value = 0;
            listBox_Produkt.ClearSelected();
            comboBox_ProduktKategorien.SelectedIndex = -1;
        }

        private void RefreshView()
        {
            List<Produkt> products = Program.Daten.ReadProdukt();
            List<Category> categories = Program.Daten.ReadCategory();

            listBox_Produkt.DataSource = null;
            listBox_Kategorien.DataSource = null;
            comboBox_ProduktKategorien.DataSource = null;

            listBox_Produkt.DisplayMember = "Name";
            listBox_Kategorien.DisplayMember = "Name";
            comboBox_ProduktKategorien.DisplayMember = "Name";

            listBox_Produkt.ValueMember = "Id";
            listBox_Kategorien.ValueMember = "Id";
            comboBox_ProduktKategorien.ValueMember = "Id";

            listBox_Produkt.DataSource = products;
            listBox_Kategorien.DataSource = categories;
            comboBox_ProduktKategorien.DataSource = categories;
        }
    }
}

