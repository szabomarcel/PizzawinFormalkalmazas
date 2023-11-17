using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzawinFormalkalmazas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Fajl_valasztas_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "vesszővel tagolt csv|*.csv|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.Title = "Adatfájl neve";
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "pizza.csv";
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        listBox_Pizza_nevek.Items.Add(new Pizza(sr.ReadLine()));
                    }
                }
            }
            else
            {
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_Pizza_Nev = null;
            string kiindulasiFajl = Environment.CurrentDirectory + Path.DirectorySeparatorChar + "pizza.csv";
            if (File.Exists(kiindulasiFajl))
            {
                Adatbetoltes(kiindulasiFajl);
            }
        }
        private void Adatbetoltes(string file)
        {
            listBox_Pizza_nevek.Items.Clear();
            try
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        listBox_Pizza_nevek.Items.Add(new Pizza(sr.ReadLine()));
                    }
                }

            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_atlag_Click(object sender, EventArgs e)
        {
            atlagszamitas();
            atlagszamitas2();
        }
        private void atlagszamitas2()
        {
            double atlag = listBox_Pizza_nevek.Items.Cast<Pizza>().ToList().Average(a => a.PizzaAr);
        }

        private void atlagszamitas()
        {
            int osszesar = 0;
            double atlag = 0;
            foreach (Pizza item in listBox_Pizza_nevek.Items)
            {
                osszesar += item.PizzaAr;
            }
            atlag = osszesar / listBox_Pizza_nevek.Items.Count;
            MessageBox.Show($"A pizzák átlaga: {atlag.ToString("#,##0.00")}", "A pizzák átlaga", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_Szamlaigenyles_Click(object sender, EventArgs e)
        {
            if (listBox_Pizza_nevek.SelectedIndex < 0)
            {
                return;
            }
            if (listBox_Pizza_nevek.SelectedIndex >= 0)
            {
                Pizza kivalasztottPizza = (Pizza)listBox_Pizza_nevek.SelectedItem;
                bool nagyobbTerulet = kivalasztottPizza.PizzaAr > 100000;

                MessageBox.Show($"{kivalasztottPizza.PizzaNev} {(nagyobbTerulet ? "nagyobb" : "legfeljebb")} 100.000 területű.",
                                nagyobbTerulet ? "Nagyobb terület" : "Legfeljebb 100.000 terület",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nincs kijelölt ország.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Megvasarlas_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "valaki valaminek a zövege|*.txt";
            saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog.FileName = "eredmeny.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string eredmenyfajl = saveFileDialog.FileName;
                textBox_SzamlaigenylesNeve.Text = eredmenyfajl;
                //textBox_Pizza_Nev.Text = Path.GetFileName(eredmenyfajl);
                try
                {
                    using (StreamWriter sw = new StreamWriter(eredmenyfajl))
                    {
                        sw.WriteLine("Ez az eredmény!");
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Valami nem oké!" + Environment.NewLine + ex.Message);
                }
            }
        }

        private void button_ujrendeles_Click(object sender, EventArgs e)
        {
            // Az új űrlap létrehozása
            Form1 newForm = new Form1();

            // Az új űrlap megjelenítése
            newForm.Show();
        }
    }
}
