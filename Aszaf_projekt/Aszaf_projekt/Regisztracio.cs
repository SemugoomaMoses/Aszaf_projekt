using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aszaf_projekt
{
    public partial class Regisztracio: Form
    {
        public Regisztracio()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string beirtFelhasznalo = textBox1.Text.Trim();
            string beirtJelszo = textBox2.Text.Trim();

            string[] sorok = File.ReadAllLines("felhasznalok.txt");

            string fileFelhasznalo = "";
            string fileJelszo = "";

            foreach (string sor in sorok)
            {
                if (sor.StartsWith("Felhasználónév:"))
                {
                    fileFelhasznalo = sor.Replace("Felhasználónév:", "").Trim();
                }
                else if (sor.StartsWith("Jelszó:"))
                {
                    fileJelszo = sor.Replace("Jelszó:", "").Trim();
                }
            }

            if (beirtFelhasznalo == fileFelhasznalo && beirtJelszo == fileJelszo)
            {
                MessageBox.Show("Sikeres bejelentkezés!", "Belépés");
                this.Close();
                // Ide jöhet más form megnyitása, ha kell
            }
            else
            {
                MessageBox.Show("Hibás felhasználónév vagy jelszó!", "Hiba");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nev1 = textBox3.Text.Trim();
            string nev2 = textBox4.Text.Trim();
            string felnev = textBox5.Text.Trim();
            string jelszo = textBox6.Text.Trim();
            string jelszoujra = textBox7.Text.Trim();
            string filePath = Path.Combine(Application.StartupPath, "felhasznalok.txt");
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Felhasználónév: " + felnev);
                    writer.WriteLine("Jelszó:" + jelszo);
                    
                    if (string.IsNullOrWhiteSpace(textBox3.Text))
                    {
                        MessageBox.Show("Add meg a Vezetéknevet!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(textBox4.Text))
                    {
                        MessageBox.Show("Add meg a Keresztnevet!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(textBox5.Text))
                    {
                        MessageBox.Show("Add meg a Felhasználónevet!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(textBox6.Text))
                    {
                        MessageBox.Show("Add meg a Jelszót!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(textBox7.Text))
                    {
                        MessageBox.Show("Add meg a jelszót újra!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (textBox6.Text != textBox7.Text)
                    {
                        MessageBox.Show("A jelszavak nem egyeznek!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Ha minden ki van töltve:
                    MessageBox.Show("Sikeres regisztráció!", "Kész", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }








            
            }
            catch (Exception)
            {

                throw;
            }

        }

        public TabControl GetTabControl()
        {
            return reg;  // Visszaadja a reg TabControl-t
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Regisztracio_Load(object sender, EventArgs e)
        {

        }
    }
}
