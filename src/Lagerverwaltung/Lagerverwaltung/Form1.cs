using System;
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
            Produkt produkt = new Produkt(textBox_ProduktName.Text, Convert.ToInt32(numericUpDown_ProduktAnzahl.Text), Convert.ToInt32(numericUpDown_ProduktKosten.Text), comboBox_ProduktKategorien.SelectedText, textBox_ProduktDetails.Text);

            Program.ProduktListe.Add(produkt);
            listBox_Produkt.DataSource = Program.ProduktListe;


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
                Produkt produkt = (Produkt)Program.ProduktListe[i];

                String proName = listBox_Produkt.SelectedItem.ToString();

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
    }
}
