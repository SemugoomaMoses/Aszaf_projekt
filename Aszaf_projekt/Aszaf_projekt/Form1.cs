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

                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine("Név: " + nev);
                        if (felnottSzam == 0)
                    {
                        writer.WriteLine("Nincs felnőtt");
                    }
                    else
                    {
                        writer.WriteLine("Felnőttek száma: " + felnottSzam);
                    }
                    
                    if (gyerekekSzam == 0)
                    {
                        writer.WriteLine("Nincs gyermek");
                    }
                    else
                    {
                        writer.WriteLine("Gyerekek száma: " + gyerekekSzam);
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
    }
}
