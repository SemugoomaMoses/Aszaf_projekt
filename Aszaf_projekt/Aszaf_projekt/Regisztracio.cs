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
            string nev = textBox1.Text.Trim();
            string jelszo=textBox2.Text.Trim();
            
            string filePath = Path.Combine(Application.StartupPath, "felhasznalok.txt");
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    //nev
                    writer.WriteLine("Felhasználónév: " + nev);
                    writer.WriteLine("Jelszó:" + jelszo);
                    MessageBox.Show("Sikeres Bejelentkezés!");
                }
            }


            catch (Exception)
            {

                MessageBox.Show("Helytelen Email vagy jelszó!");
            }
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide(); // vagy this.Close(); ha végleg be akarod zárni a Form2-t
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
                    writer.WriteLine("Felhasználónév: " + nev1,nev2);
                    writer.WriteLine("Jelszó:" + jelszo);
                    if (textBox3.Text == null)
                    {
                        MessageBox.Show("Add meg a Vezetéknevet");
                    }
                    if (textBox4.Text == null)
                    {
                        MessageBox.Show("Add meg a személynevet");
                    }
                    if (textBox5.Text == null)
                    {
                        MessageBox.Show("Add meg a Felhasználónevet!");
                    }
                    if (textBox6.Text == null)
                    {
                        MessageBox.Show("Add meg a Jelszót!");
                    }
                    if (textBox7.Text == null)
                    {
                        MessageBox.Show($"Add meg a jelszót újra!{MessageBoxIcon.Error}");

                    }







                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
