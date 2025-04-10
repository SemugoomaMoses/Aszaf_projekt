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

namespace Aszaf_projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Panoráma Suite");
            comboBox1.Items.Add("Luxus Tengerparti Suite");
            comboBox1.Items.Add("Romantikus Kert Suite");
            comboBox1.Items.Add("Tóparti Nyugalom Suite");



        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                string nev = textBox1.Text.Trim();
                int felnottSzam = (int)numericUpDown1.Value;
                int gyerekekSzam = (int)numericUpDown2.Value;
            string filePath = Path.Combine(Application.StartupPath, "foglalas.txt");
            bool mindenRendben = true;
            string uzenet = "";
            string uzenet2 = "";

            try
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                    //nev
                        writer.WriteLine("Név: " + nev);
                    //felnottek szama
                        if (felnottSzam == 0)
                    {
                        writer.WriteLine("Nincs felnőtt");
                    }
                    else
                    {
                        writer.WriteLine("Felnőttek száma: " + felnottSzam);
                    }
                    
                     //gyerekek szama
                    if (gyerekekSzam == 0)
                    {
                        writer.WriteLine("Nincs gyermek");
                    }
                    else
                    {
                        writer.WriteLine("Gyerekek száma: " + gyerekekSzam);
                    }
                    //suite 
                    if (comboBox1.SelectedItem != null)
                    {
                        string kivalasztott = comboBox1.SelectedItem.ToString();
                        
                        writer.WriteLine("Suite: " + kivalasztott);
                        
                    }
                    else
                    {
                        MessageBox.Show("Kérlek válassz ki egy elemet a listából!");
                    }
                    //szobák száma
                    if (numericUpDown3.Value != null)
                    {
                        string szoba = numericUpDown3.Value.ToString();
                        writer.WriteLine("Szobák száma:" + szoba);
                    }
                    //érkezés
                    if (dateTimePicker1.Value.Date == DateTime.Today)
                    {
                        mindenRendben = false;
                        uzenet += "A bejelentkezés dátuma nem lehet múltbeli dátum.\n";
                    }
                    if (dateTimePicker2.Value.Date == DateTime.Today)
                    {
                        mindenRendben = false;
                        uzenet2 += "A bejelentkezés dátuma nem lehet múltbeli dátum.\n";
                    }
                    if (mindenRendben)
                    {
                        DateTime erkezes = dateTimePicker1.Value;
                        erkezes.ToString("yyyy.MM.dd");
                        writer.WriteLine($"Érkezés:{erkezes.ToString("yyyy.MM.dd")}");
                    }
                    else
                    {
                        MessageBox.Show(uzenet, "Hiányzó vagy hibás adatok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    //távozás
                    if (mindenRendben)
                    {
                        DateTime tavozas = dateTimePicker2.Value;
                        tavozas.ToString("yyyy.MM.dd");
                        writer.WriteLine($"Távozás:{tavozas.ToString("yyyy.MM.dd")}");
                    }
                    else
                    {
                        MessageBox.Show(uzenet2, "Hiányzó vagy hibás adatok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    //Reggli
                    if (checkBox1.Checked)
                    {
                        writer.WriteLine("Étkezés: Igen");
                    }
                    else
                    {
                        writer.WriteLine("Étkezés: Nem");
                    }

                }
                MessageBox.Show("A foglalás elkészült!");
                }
                catch (Exception)
                {
                    // Itt írhatsz hibaüzenetet, vagy logolhatod a hibát
                    MessageBox.Show("Hiba történt a mentés során.");
                }
            

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Regisztracio RegisztracioForm = new Regisztracio();
            RegisztracioForm.Show();
            
        }
    }
}
