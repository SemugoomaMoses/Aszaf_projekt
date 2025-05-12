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
            // PictureBox beállítás
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            // Esemény hozzárendelés
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            


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
                        writer.WriteLine("Ellátás: Igen");
                    }
                    else
                    {
                        writer.WriteLine("Ellátás: Nem");
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
                // Itt írhatsz hibaüzenetet, vagy logolhatod a hibát
                MessageBox.Show("Hiba történt a mentés során.");
            }


        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Regisztracio RegisztracioForm = new Regisztracio();
            //RegisztracioForm.Show();
            Regisztracio RegisztracioForm = new Regisztracio();

            // Csak a TabControl legyen látható, a form többi része ne jelenjen meg
            RegisztracioForm.FormBorderStyle = FormBorderStyle.None;  // Nincs ablakkeret
            RegisztracioForm.StartPosition = FormStartPosition.CenterScreen;  // A form középre kerül
            RegisztracioForm.Size = RegisztracioForm.GetTabControl().Size;  // Beállítjuk a Form méretét a TabControl méretéhez
            RegisztracioForm.Location = this.Location;  // A Form helyzetét a jelenlegi form pozíciójára állítjuk



            // Megjelenítjük a Regisztracio formot
            RegisztracioForm.Show();

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.FromArgb(100, Color.Gray); // 100 = transparency level
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
           

            // Program leállítása
            Application.Exit();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Idő és dátum kiírása label12-re
            label12.Text = DateTime.Now.ToString("yyyy.MM.dd. HH:mm:ss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000; // 1 másodperc
            timer1.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
