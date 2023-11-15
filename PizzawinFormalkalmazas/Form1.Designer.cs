namespace PizzawinFormalkalmazas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_Pizza_nevek = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_Fajl_valasztas = new System.Windows.Forms.Button();
            this.button_atlag = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Megszamolas = new System.Windows.Forms.Button();
            this.radioButton_LegfeljebbSzazEzer = new System.Windows.Forms.RadioButton();
            this.radioButton_szazezerFelett = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_SzamlaigenylesNeve = new System.Windows.Forms.TextBox();
            this.button_Szamlaigenyles = new System.Windows.Forms.Button();
            this.label_Pizza_Nev = new System.Windows.Forms.Label();
            this.textBox_Pizza_Nev = new System.Windows.Forms.TextBox();
            this.numericUpDown_db_szam = new System.Windows.Forms.NumericUpDown();
            this.button_ujrendeles = new System.Windows.Forms.Button();
            this.button_Megvasarlas = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_db_szam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fájlbeolvasás pizzákról";
            // 
            // listBox_Pizza_nevek
            // 
            this.listBox_Pizza_nevek.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.listBox_Pizza_nevek.FormattingEnabled = true;
            this.listBox_Pizza_nevek.Location = new System.Drawing.Point(62, 113);
            this.listBox_Pizza_nevek.Name = "listBox_Pizza_nevek";
            this.listBox_Pizza_nevek.Size = new System.Drawing.Size(298, 329);
            this.listBox_Pizza_nevek.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Location = new System.Drawing.Point(62, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button_Fajl_valasztas
            // 
            this.button_Fajl_valasztas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Fajl_valasztas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Fajl_valasztas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Fajl_valasztas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Fajl_valasztas.Location = new System.Drawing.Point(62, 61);
            this.button_Fajl_valasztas.Margin = new System.Windows.Forms.Padding(6);
            this.button_Fajl_valasztas.Name = "button_Fajl_valasztas";
            this.button_Fajl_valasztas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_Fajl_valasztas.Size = new System.Drawing.Size(298, 43);
            this.button_Fajl_valasztas.TabIndex = 3;
            this.button_Fajl_valasztas.Text = "Fájl kiválasztás";
            this.button_Fajl_valasztas.UseVisualStyleBackColor = false;
            // 
            // button_atlag
            // 
            this.button_atlag.BackColor = System.Drawing.Color.IndianRed;
            this.button_atlag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_atlag.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_atlag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_atlag.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button_atlag.Location = new System.Drawing.Point(62, 448);
            this.button_atlag.Name = "button_atlag";
            this.button_atlag.Size = new System.Drawing.Size(298, 43);
            this.button_atlag.TabIndex = 4;
            this.button_atlag.Text = "Átlag számítás a pizzákra";
            this.button_atlag.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Controls.Add(this.button_Megszamolas);
            this.groupBox1.Controls.Add(this.radioButton_LegfeljebbSzazEzer);
            this.groupBox1.Controls.Add(this.radioButton_szazezerFelett);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(62, 497);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 140);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mivel szeretne fizetni?";
            // 
            // button_Megszamolas
            // 
            this.button_Megszamolas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_Megszamolas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Megszamolas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Megszamolas.Location = new System.Drawing.Point(6, 93);
            this.button_Megszamolas.Name = "button_Megszamolas";
            this.button_Megszamolas.Size = new System.Drawing.Size(286, 42);
            this.button_Megszamolas.TabIndex = 6;
            this.button_Megszamolas.Text = "Választás";
            this.button_Megszamolas.UseVisualStyleBackColor = false;
            // 
            // radioButton_LegfeljebbSzazEzer
            // 
            this.radioButton_LegfeljebbSzazEzer.AutoSize = true;
            this.radioButton_LegfeljebbSzazEzer.Checked = true;
            this.radioButton_LegfeljebbSzazEzer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_LegfeljebbSzazEzer.Location = new System.Drawing.Point(29, 70);
            this.radioButton_LegfeljebbSzazEzer.Name = "radioButton_LegfeljebbSzazEzer";
            this.radioButton_LegfeljebbSzazEzer.Size = new System.Drawing.Size(69, 17);
            this.radioButton_LegfeljebbSzazEzer.TabIndex = 1;
            this.radioButton_LegfeljebbSzazEzer.TabStop = true;
            this.radioButton_LegfeljebbSzazEzer.Text = "Kártyával";
            this.radioButton_LegfeljebbSzazEzer.UseVisualStyleBackColor = true;
            // 
            // radioButton_szazezerFelett
            // 
            this.radioButton_szazezerFelett.AutoSize = true;
            this.radioButton_szazezerFelett.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_szazezerFelett.Location = new System.Drawing.Point(29, 29);
            this.radioButton_szazezerFelett.Name = "radioButton_szazezerFelett";
            this.radioButton_szazezerFelett.Size = new System.Drawing.Size(79, 17);
            this.radioButton_szazezerFelett.TabIndex = 0;
            this.radioButton_szazezerFelett.Text = "Kézpénzzel";
            this.radioButton_szazezerFelett.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Green;
            this.groupBox2.Controls.Add(this.button_Megvasarlas);
            this.groupBox2.Controls.Add(this.button_ujrendeles);
            this.groupBox2.Controls.Add(this.numericUpDown_db_szam);
            this.groupBox2.Controls.Add(this.textBox_Pizza_Nev);
            this.groupBox2.Controls.Add(this.label_Pizza_Nev);
            this.groupBox2.Controls.Add(this.textBox_SzamlaigenylesNeve);
            this.groupBox2.Controls.Add(this.button_Szamlaigenyles);
            this.groupBox2.Location = new System.Drawing.Point(388, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 274);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pizza igénylés és mennyisége választás";
            // 
            // textBox_SzamlaigenylesNeve
            // 
            this.textBox_SzamlaigenylesNeve.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_SzamlaigenylesNeve.Location = new System.Drawing.Point(20, 27);
            this.textBox_SzamlaigenylesNeve.Name = "textBox_SzamlaigenylesNeve";
            this.textBox_SzamlaigenylesNeve.Size = new System.Drawing.Size(335, 20);
            this.textBox_SzamlaigenylesNeve.TabIndex = 12;
            // 
            // button_Szamlaigenyles
            // 
            this.button_Szamlaigenyles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_Szamlaigenyles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Szamlaigenyles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Szamlaigenyles.Location = new System.Drawing.Point(20, 53);
            this.button_Szamlaigenyles.Name = "button_Szamlaigenyles";
            this.button_Szamlaigenyles.Size = new System.Drawing.Size(335, 42);
            this.button_Szamlaigenyles.TabIndex = 11;
            this.button_Szamlaigenyles.Text = "Számlaigénylés";
            this.button_Szamlaigenyles.UseVisualStyleBackColor = false;
            // 
            // label_Pizza_Nev
            // 
            this.label_Pizza_Nev.AutoSize = true;
            this.label_Pizza_Nev.Location = new System.Drawing.Point(17, 98);
            this.label_Pizza_Nev.Name = "label_Pizza_Nev";
            this.label_Pizza_Nev.Size = new System.Drawing.Size(133, 13);
            this.label_Pizza_Nev.TabIndex = 13;
            this.label_Pizza_Nev.Text = "Pizza neve kiválaztás után";
            // 
            // textBox_Pizza_Nev
            // 
            this.textBox_Pizza_Nev.Location = new System.Drawing.Point(20, 114);
            this.textBox_Pizza_Nev.Name = "textBox_Pizza_Nev";
            this.textBox_Pizza_Nev.Size = new System.Drawing.Size(335, 20);
            this.textBox_Pizza_Nev.TabIndex = 14;
            this.textBox_Pizza_Nev.Text = "Pizza_név";
            // 
            // numericUpDown_db_szam
            // 
            this.numericUpDown_db_szam.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.numericUpDown_db_szam.Location = new System.Drawing.Point(20, 140);
            this.numericUpDown_db_szam.Name = "numericUpDown_db_szam";
            this.numericUpDown_db_szam.Size = new System.Drawing.Size(335, 20);
            this.numericUpDown_db_szam.TabIndex = 15;
            // 
            // button_ujrendeles
            // 
            this.button_ujrendeles.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button_ujrendeles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ujrendeles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ujrendeles.Location = new System.Drawing.Point(20, 215);
            this.button_ujrendeles.Name = "button_ujrendeles";
            this.button_ujrendeles.Size = new System.Drawing.Size(335, 42);
            this.button_ujrendeles.TabIndex = 16;
            this.button_ujrendeles.Text = "Új rendelés";
            this.button_ujrendeles.UseVisualStyleBackColor = false;
            // 
            // button_Megvasarlas
            // 
            this.button_Megvasarlas.BackColor = System.Drawing.Color.Orange;
            this.button_Megvasarlas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Megvasarlas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Megvasarlas.Location = new System.Drawing.Point(20, 166);
            this.button_Megvasarlas.Name = "button_Megvasarlas";
            this.button_Megvasarlas.Size = new System.Drawing.Size(335, 43);
            this.button_Megvasarlas.TabIndex = 17;
            this.button_Megvasarlas.Text = "Megvásárlás";
            this.button_Megvasarlas.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 683);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_atlag);
            this.Controls.Add(this.button_Fajl_valasztas);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox_Pizza_nevek);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pizza_winForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_db_szam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_Pizza_nevek;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_Fajl_valasztas;
        private System.Windows.Forms.Button button_atlag;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Megszamolas;
        private System.Windows.Forms.RadioButton radioButton_LegfeljebbSzazEzer;
        private System.Windows.Forms.RadioButton radioButton_szazezerFelett;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_SzamlaigenylesNeve;
        private System.Windows.Forms.Button button_Szamlaigenyles;
        private System.Windows.Forms.Label label_Pizza_Nev;
        private System.Windows.Forms.TextBox textBox_Pizza_Nev;
        private System.Windows.Forms.Button button_ujrendeles;
        private System.Windows.Forms.NumericUpDown numericUpDown_db_szam;
        private System.Windows.Forms.Button button_Megvasarlas;
    }
}

