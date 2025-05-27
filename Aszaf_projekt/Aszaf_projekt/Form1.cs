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
            
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            


        }
        public string Form1TextBoxValue
        {
            get { return textBox1.Text; }
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
                    // nev
                    
                    if (string.IsNullOrWhiteSpace(textBox1.Text))
                    {
                        MessageBox.Show("Kérlek, adj meg egy nevet a foglaláshoz!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        
                        writer.WriteLine("Név: " + nev);
                    }

                    if (string.IsNullOrWhiteSpace(comboBox1.Text))
                    {
                        MessageBox.Show("Add meg a Suitet!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (felnottSzam < 1)
                    {
                        MessageBox.Show("Legalább egy felnőttnek lennie kell a foglaláshoz!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        writer.WriteLine("Felnőttek száma: " + felnottSzam);
                    }

                    // gyerekek szama
                    if (gyerekekSzam == 0)
                    {
                        writer.WriteLine("Nincs gyermek");
                    }
                    else
                    {
                        writer.WriteLine("Gyerekek száma: " + gyerekekSzam);
                    }

                    // suite 
                    if (comboBox1.SelectedItem != null)
                    {
                        string kivalasztott = comboBox1.SelectedItem.ToString();
                        writer.WriteLine("Suite: " + kivalasztott);
                    }
                    else
                    {
                        MessageBox.Show("Kérlek, válassz ki egy suite típust a foglaláshoz!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // szobák száma
                    if (numericUpDown3.Value > 0)
                    {
                        string szoba = numericUpDown3.Value.ToString();
                        writer.WriteLine("Szobák száma: " + szoba);
                    }
                    else
                    {
                        MessageBox.Show("Válassz legalább egy szobát!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // érkezés
                    if (dateTimePicker1.Value.Date < DateTime.Today)
                    {
                        mindenRendben = false;
                        uzenet += "A bejelentkezés dátuma nem lehet múltbeli dátum.\n";
                    }
                    if (dateTimePicker2.Value.Date < DateTime.Today)
                    {
                        mindenRendben = false;
                        uzenet2 += "A kijelentkezés dátuma nem lehet múltbeli dátum.\n";
                    }

                    if (mindenRendben)
                    {
                        DateTime erkezes = dateTimePicker1.Value;
                        writer.WriteLine($"Érkezés: {erkezes:yyyy.MM.dd}");
                    }
                    else
                    {
                        MessageBox.Show(uzenet + uzenet2, "Dátum hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // távozás
                    if (dateTimePicker2.Value.Date <= DateTime.Today)
                    {
                        mindenRendben = false;
                        uzenet2 += "A távozás dátuma nem lehet a mai nap vagy korábbi.\n";
                    }

                    if (mindenRendben)
                    {
                        DateTime tavozas = dateTimePicker2.Value;
                        writer.WriteLine($"Távozás: {tavozas:yyyy.MM.dd}");
                    }
                    else
                    {
                        MessageBox.Show(uzenet2, "Add meg a távozás dátumát!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    //reggeli
                    if (!checkBox1.Checked && !checkBox2.Checked)
                    {
                        MessageBox.Show("Kérlek, válaszd ki, hogy kérsz-e ellátást!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (checkBox1.Checked)
                    {
                        writer.WriteLine("Ellátás: Igen");
                    }
                    else if (checkBox2.Checked)
                    {
                        writer.WriteLine("Ellátás: Nem");
                    }
                    //fizetesi mod
                    if (radioButton1.Checked)
                    {
                        writer.WriteLine($"Fizetési mód: Készpénz");
                    }
                    if (radioButton2.Checked)
                    {
                        writer.WriteLine($"Fizetési mód: Bankkártya");
                    }
                    if (radioButton3.Checked)
                    {
                        writer.WriteLine($"Fizetési mód: SZÉP kártya");
                    }
                    if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
                    {
                        MessageBox.Show("Kérlek, válassz ki fizetési módot!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                MessageBox.Show("A foglalás elkészült!");
            }
            catch (Exception)
            {
                
                MessageBox.Show("Hiba történt a mentés során.");
            }

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            Regisztracio RegisztracioForm = new Regisztracio();

            
            RegisztracioForm.FormBorderStyle = FormBorderStyle.None;  
            RegisztracioForm.StartPosition = FormStartPosition.CenterScreen;  
            RegisztracioForm.Size = RegisztracioForm.GetTabControl().Size;  
            RegisztracioForm.Location = this.Location;  


           
            RegisztracioForm.Show();

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.FromArgb(100, Color.Gray); 
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void aktuálisFoglalásokToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Foglalasok foglalasokForm = new Foglalasok();
            foglalasokForm.Show();
            this.Hide();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selected = comboBox1.SelectedItem.ToString();

                switch (selected)
                {
                    case "Panoráma Suite":
                        pictureBox1.Image = Image.FromFile("kep1.jpg");
                        break;
                    case "Luxus Tengerparti Suite":
                        pictureBox1.Image = Image.FromFile("kep2.jpg");
                        break;
                    case "Romantikus Kert Suite":
                        pictureBox1.Image = Image.FromFile("kep3.jpeg");
                        break;
                    case "Tóparti Nyugalom Suite":
                        pictureBox1.Image = Image.FromFile("kep4.jfif");
                        break;

                    default:
                        pictureBox1.Image = null;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nem sikerült betölteni a képet: " + ex.Message);
            }
        }

        private void bezárásToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            
            Application.Exit();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Idő és dátum kiírása label12-re
            label12.Text = DateTime.Now.ToString("yyyy.MM.dd. HH:mm:ss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label12.Text = DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss");
            timer1.Interval = 1000; 
            timer1.Start();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Color selectedColor = colorDialog.Color;
                    SetForeColorRecursive(this, selectedColor);
                }
            }
        }
        private void SetForeColorRecursive(Control parent, Color color)
        {
            foreach (Control control in parent.Controls)
            {
                control.ForeColor = color;

                
                if (control.HasChildren)
                {
                    SetForeColorRecursive(control, color);
                }
            }

            
            parent.ForeColor = color;
        }
    }
}
