using System;
using System.Drawing;
using System.Windows.Forms;

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

            if (textBox_ProduktName != null && numericUpDown_ProduktAnzahl.Value > 0 &&
                numericUpDown_ProduktKosten.Value > 0 && comboBox_ProduktKategorien != null)
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
                    ClearInput();
                    isUsed = false;
                }


            }
        }

        private void button_ProduktDel_Click(object sender, EventArgs e)
        {

            String selectedProductName = listBox_Produkt.GetItemText(listBox_Produkt.SelectedItem);

            for (var i = 0; i < Program.ProduktListe.Count; i++)
            {
                Produkt produkt = (Produkt) Program.ProduktListe[i];


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
                }

                listBox_Produkt.Refresh();
            }
        }

        private void ClearInput()
        {
            textBox_ProduktName.Text = null;
            numericUpDown_ProduktKosten.Value = 0;
            textBox_ProduktDetails.Text = null;
            comboBox_ProduktKategorien.Text = null;
            numericUpDown_ProduktAnzahl.Value = 0;
            label11.Text = null;
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
            ClearInput();
            textBox_ProduktName.BackColor = Color.White;
        }
    }
}
