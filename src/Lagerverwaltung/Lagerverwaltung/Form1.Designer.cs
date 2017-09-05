namespace Lagerverwaltung
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Produkte = new System.Windows.Forms.TabPage();
            this.button_reinigen = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown_ProduktKosten = new System.Windows.Forms.NumericUpDown();
            this.textBox_ProduktDetails = new System.Windows.Forms.TextBox();
            this.button_ProduktEdit = new System.Windows.Forms.Button();
            this.button_ProduktDel = new System.Windows.Forms.Button();
            this.listBox_Produkt = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_ProduktSave = new System.Windows.Forms.Button();
            this.comboBox_ProduktKategorien = new System.Windows.Forms.ComboBox();
            this.numericUpDown_ProduktAnzahl = new System.Windows.Forms.NumericUpDown();
            this.textBox_ProduktName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Kategorie = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_KategorieName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button_ColorPicker = new System.Windows.Forms.Button();
            this.button_KategorEdit = new System.Windows.Forms.Button();
            this.button_KategorDel = new System.Windows.Forms.Button();
            this.listBox_Kategorien = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_KategorSave = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tabControl1.SuspendLayout();
            this.Produkte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ProduktKosten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ProduktAnzahl)).BeginInit();
            this.textBox_Kategorie.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Produkte);
            this.tabControl1.Controls.Add(this.textBox_Kategorie);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(762, 421);
            this.tabControl1.TabIndex = 8;
            this.tabControl1.TabStop = false;
            // 
            // Produkte
            // 
            this.Produkte.BackColor = System.Drawing.Color.Khaki;
            this.Produkte.Controls.Add(this.button_reinigen);
            this.Produkte.Controls.Add(this.label11);
            this.Produkte.Controls.Add(this.numericUpDown_ProduktKosten);
            this.Produkte.Controls.Add(this.textBox_ProduktDetails);
            this.Produkte.Controls.Add(this.button_ProduktEdit);
            this.Produkte.Controls.Add(this.button_ProduktDel);
            this.Produkte.Controls.Add(this.listBox_Produkt);
            this.Produkte.Controls.Add(this.label2);
            this.Produkte.Controls.Add(this.button_ProduktSave);
            this.Produkte.Controls.Add(this.comboBox_ProduktKategorien);
            this.Produkte.Controls.Add(this.numericUpDown_ProduktAnzahl);
            this.Produkte.Controls.Add(this.textBox_ProduktName);
            this.Produkte.Controls.Add(this.label8);
            this.Produkte.Controls.Add(this.label7);
            this.Produkte.Controls.Add(this.label6);
            this.Produkte.Controls.Add(this.label5);
            this.Produkte.Controls.Add(this.label1);
            this.Produkte.Location = new System.Drawing.Point(4, 22);
            this.Produkte.Name = "Produkte";
            this.Produkte.Padding = new System.Windows.Forms.Padding(3);
            this.Produkte.Size = new System.Drawing.Size(754, 395);
            this.Produkte.TabIndex = 0;
            this.Produkte.Text = "Produkte";
            // 
            // button_reinigen
            // 
            this.button_reinigen.Location = new System.Drawing.Point(128, 324);
            this.button_reinigen.Name = "button_reinigen";
            this.button_reinigen.Size = new System.Drawing.Size(75, 23);
            this.button_reinigen.TabIndex = 32;
            this.button_reinigen.Text = "Reinigen";
            this.button_reinigen.UseVisualStyleBackColor = true;
            this.button_reinigen.Click += new System.EventHandler(this.button_reinigen_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 288);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 31;
            // 
            // numericUpDown_ProduktKosten
            // 
            this.numericUpDown_ProduktKosten.BackColor = System.Drawing.Color.White;
            this.numericUpDown_ProduktKosten.ForeColor = System.Drawing.Color.Black;
            this.numericUpDown_ProduktKosten.Location = new System.Drawing.Point(209, 109);
            this.numericUpDown_ProduktKosten.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_ProduktKosten.Name = "numericUpDown_ProduktKosten";
            this.numericUpDown_ProduktKosten.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown_ProduktKosten.TabIndex = 30;
            // 
            // textBox_ProduktDetails
            // 
            this.textBox_ProduktDetails.Location = new System.Drawing.Point(209, 158);
            this.textBox_ProduktDetails.Name = "textBox_ProduktDetails";
            this.textBox_ProduktDetails.Size = new System.Drawing.Size(100, 20);
            this.textBox_ProduktDetails.TabIndex = 29;
            // 
            // button_ProduktEdit
            // 
            this.button_ProduktEdit.BackColor = System.Drawing.Color.Transparent;
            this.button_ProduktEdit.Location = new System.Drawing.Point(617, 250);
            this.button_ProduktEdit.Name = "button_ProduktEdit";
            this.button_ProduktEdit.Size = new System.Drawing.Size(75, 23);
            this.button_ProduktEdit.TabIndex = 28;
            this.button_ProduktEdit.Text = "Bearbeiten";
            this.button_ProduktEdit.UseVisualStyleBackColor = false;
            this.button_ProduktEdit.Click += new System.EventHandler(this.button_ProduktEdit_Click);
            // 
            // button_ProduktDel
            // 
            this.button_ProduktDel.BackColor = System.Drawing.Color.Transparent;
            this.button_ProduktDel.Location = new System.Drawing.Point(617, 279);
            this.button_ProduktDel.Name = "button_ProduktDel";
            this.button_ProduktDel.Size = new System.Drawing.Size(75, 23);
            this.button_ProduktDel.TabIndex = 27;
            this.button_ProduktDel.Text = "Entfernen";
            this.button_ProduktDel.UseVisualStyleBackColor = false;
            this.button_ProduktDel.Click += new System.EventHandler(this.button_ProduktDel_Click);
            // 
            // listBox_Produkt
            // 
            this.listBox_Produkt.FormattingEnabled = true;
            this.listBox_Produkt.Location = new System.Drawing.Point(397, 129);
            this.listBox_Produkt.Name = "listBox_Produkt";
            this.listBox_Produkt.ScrollAlwaysVisible = true;
            this.listBox_Produkt.Size = new System.Drawing.Size(178, 212);
            this.listBox_Produkt.Sorted = true;
            this.listBox_Produkt.TabIndex = 26;
            this.listBox_Produkt.SelectedIndexChanged += new System.EventHandler(this.listBox_Produkt_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Produktliste";
            // 
            // button_ProduktSave
            // 
            this.button_ProduktSave.BackColor = System.Drawing.Color.Transparent;
            this.button_ProduktSave.Location = new System.Drawing.Point(209, 325);
            this.button_ProduktSave.Name = "button_ProduktSave";
            this.button_ProduktSave.Size = new System.Drawing.Size(75, 23);
            this.button_ProduktSave.TabIndex = 24;
            this.button_ProduktSave.Text = "Speichern";
            this.button_ProduktSave.UseVisualStyleBackColor = false;
            this.button_ProduktSave.Click += new System.EventHandler(this.button_ProduktSave_Click);
            // 
            // comboBox_ProduktKategorien
            // 
            this.comboBox_ProduktKategorien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ProduktKategorien.Location = new System.Drawing.Point(209, 204);
            this.comboBox_ProduktKategorien.Name = "comboBox_ProduktKategorien";
            this.comboBox_ProduktKategorien.Size = new System.Drawing.Size(100, 21);
            this.comboBox_ProduktKategorien.TabIndex = 33;
            // 
            // numericUpDown_ProduktAnzahl
            // 
            this.numericUpDown_ProduktAnzahl.BackColor = System.Drawing.Color.White;
            this.numericUpDown_ProduktAnzahl.ForeColor = System.Drawing.Color.Black;
            this.numericUpDown_ProduktAnzahl.Location = new System.Drawing.Point(209, 243);
            this.numericUpDown_ProduktAnzahl.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_ProduktAnzahl.Name = "numericUpDown_ProduktAnzahl";
            this.numericUpDown_ProduktAnzahl.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown_ProduktAnzahl.TabIndex = 22;
            // 
            // textBox_ProduktName
            // 
            this.textBox_ProduktName.Location = new System.Drawing.Point(209, 73);
            this.textBox_ProduktName.Name = "textBox_ProduktName";
            this.textBox_ProduktName.Size = new System.Drawing.Size(100, 20);
            this.textBox_ProduktName.TabIndex = 17;
            this.textBox_ProduktName.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Kosten des Produktes *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Details zum Produkt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Kategorie des Produktes *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Anzahl der Produkte *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name des Produktes *";
            // 
            // textBox_Kategorie
            // 
            this.textBox_Kategorie.BackColor = System.Drawing.Color.Khaki;
            this.textBox_Kategorie.Controls.Add(this.label12);
            this.textBox_Kategorie.Controls.Add(this.button1);
            this.textBox_Kategorie.Controls.Add(this.textBox_KategorieName);
            this.textBox_Kategorie.Controls.Add(this.label10);
            this.textBox_Kategorie.Controls.Add(this.button_ColorPicker);
            this.textBox_Kategorie.Controls.Add(this.button_KategorEdit);
            this.textBox_Kategorie.Controls.Add(this.button_KategorDel);
            this.textBox_Kategorie.Controls.Add(this.listBox_Kategorien);
            this.textBox_Kategorie.Controls.Add(this.label3);
            this.textBox_Kategorie.Controls.Add(this.textBox4);
            this.textBox_Kategorie.Controls.Add(this.label9);
            this.textBox_Kategorie.Controls.Add(this.label4);
            this.textBox_Kategorie.Controls.Add(this.button_KategorSave);
            this.textBox_Kategorie.Location = new System.Drawing.Point(4, 22);
            this.textBox_Kategorie.Name = "textBox_Kategorie";
            this.textBox_Kategorie.Padding = new System.Windows.Forms.Padding(3);
            this.textBox_Kategorie.Size = new System.Drawing.Size(754, 395);
            this.textBox_Kategorie.TabIndex = 1;
            this.textBox_Kategorie.Text = "Kategorien";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 338);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "Reinigen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_KategorieName
            // 
            this.textBox_KategorieName.Location = new System.Drawing.Point(179, 103);
            this.textBox_KategorieName.Name = "textBox_KategorieName";
            this.textBox_KategorieName.Size = new System.Drawing.Size(111, 20);
            this.textBox_KategorieName.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(487, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Kategorieliste";
            // 
            // button_ColorPicker
            // 
            this.button_ColorPicker.Location = new System.Drawing.Point(179, 153);
            this.button_ColorPicker.Name = "button_ColorPicker";
            this.button_ColorPicker.Size = new System.Drawing.Size(75, 23);
            this.button_ColorPicker.TabIndex = 33;
            this.button_ColorPicker.UseVisualStyleBackColor = true;
            this.button_ColorPicker.Click += new System.EventHandler(this.button_ColorPicker_Click);
            // 
            // button_KategorEdit
            // 
            this.button_KategorEdit.BackColor = System.Drawing.Color.Transparent;
            this.button_KategorEdit.Location = new System.Drawing.Point(626, 241);
            this.button_KategorEdit.Name = "button_KategorEdit";
            this.button_KategorEdit.Size = new System.Drawing.Size(75, 23);
            this.button_KategorEdit.TabIndex = 32;
            this.button_KategorEdit.Text = "Bearbeiten";
            this.button_KategorEdit.UseVisualStyleBackColor = false;
            this.button_KategorEdit.Click += new System.EventHandler(this.button_KategorEdit_Click);
            // 
            // button_KategorDel
            // 
            this.button_KategorDel.BackColor = System.Drawing.Color.Transparent;
            this.button_KategorDel.Location = new System.Drawing.Point(626, 270);
            this.button_KategorDel.Name = "button_KategorDel";
            this.button_KategorDel.Size = new System.Drawing.Size(75, 23);
            this.button_KategorDel.TabIndex = 31;
            this.button_KategorDel.Text = "Entfernen";
            this.button_KategorDel.UseVisualStyleBackColor = false;
            this.button_KategorDel.Click += new System.EventHandler(this.button_KategorDel_Click);
            // 
            // listBox_Kategorien
            // 
            this.listBox_Kategorien.FormattingEnabled = true;
            this.listBox_Kategorien.Location = new System.Drawing.Point(464, 120);
            this.listBox_Kategorien.Name = "listBox_Kategorien";
            this.listBox_Kategorien.ScrollAlwaysVisible = true;
            this.listBox_Kategorien.Size = new System.Drawing.Size(120, 173);
            this.listBox_Kategorien.Sorted = true;
            this.listBox_Kategorien.TabIndex = 30;
            this.listBox_Kategorien.SelectedIndexChanged += new System.EventHandler(this.listBox_Kategorien_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 34;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(0, 0);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Name der Kategorie *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Farbe";
            // 
            // button_KategorSave
            // 
            this.button_KategorSave.Location = new System.Drawing.Point(31, 213);
            this.button_KategorSave.Name = "button_KategorSave";
            this.button_KategorSave.Size = new System.Drawing.Size(98, 23);
            this.button_KategorSave.TabIndex = 8;
            this.button_KategorSave.Text = "Speichern";
            this.button_KategorSave.UseVisualStyleBackColor = true;
            this.button_KategorSave.Click += new System.EventHandler(this.button_KategorSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 421);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Lagerverwaltung";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Produkte.ResumeLayout(false);
            this.Produkte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ProduktKosten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ProduktAnzahl)).EndInit();
            this.textBox_Kategorie.ResumeLayout(false);
            this.textBox_Kategorie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Produkte;
        private System.Windows.Forms.TabPage textBox_Kategorie;
        private System.Windows.Forms.TextBox textBox_ProduktName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_ProduktKategorien;
        private System.Windows.Forms.NumericUpDown numericUpDown_ProduktAnzahl;
        private System.Windows.Forms.Button button_ProduktEdit;
        private System.Windows.Forms.Button button_ProduktDel;
        private System.Windows.Forms.ListBox listBox_Produkt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_ProduktSave;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_KategorSave;
        private System.Windows.Forms.Button button_KategorEdit;
        private System.Windows.Forms.Button button_KategorDel;
        private System.Windows.Forms.ListBox listBox_Kategorien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_ColorPicker;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox textBox_ProduktDetails;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown_ProduktKosten;
        private System.Windows.Forms.Button button_reinigen;
        private System.Windows.Forms.TextBox textBox_KategorieName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
    }
}

