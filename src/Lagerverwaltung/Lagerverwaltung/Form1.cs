using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    }
}
