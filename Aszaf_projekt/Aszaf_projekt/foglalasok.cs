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
    public partial class Foglalasok : Form
    {
        public Foglalasok()
        {
            InitializeComponent();
            string filePath = Path.Combine(Application.StartupPath, "foglalas.txt");
         
        }

    
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void aktuálisFoglalásokToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.FromArgb(100, Color.Gray); // 100 = transparency level
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Foglalasok_Load(object sender, EventArgs e)
        {
            try
            {
                // Fájl elérési útja (ha a program mappájában van)
                string filePath = "foglalas.txt";

                // Fájl beolvasása
                string tartalom = File.ReadAllText(filePath);

                // Labelre kiírás
                label2.Text = tartalom;
            }
            catch (Exception ex)
            {
                label2.Text = "Hiba történt: " + ex.Message;
            }
        }

        private void foglalásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show(); // ha nem modálisan akarod megnyitni
            this.Hide();
        }

        private void foglalásokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Regisztracio RegisztracioForm = new Regisztracio();
            //RegisztracioForm.Show();
            Regisztracio RegisztracioForm = new Regisztracio();

            // Csak a TabControl legyen látható, a form többi része ne jelenjen meg
            RegisztracioForm.FormBorderStyle = FormBorderStyle.None;  // Nincs ablakkeret
            RegisztracioForm.StartPosition = FormStartPosition.CenterScreen;  // A form középre kerül
            RegisztracioForm.Size = RegisztracioForm.GetTabControl().Size;  // Beállítjuk a Form méretét a TabControl méretéhez
            RegisztracioForm.Location = this.Location;  // A Form helyzetét a jelenlegi form pozíciójára állítjuk

        }

        private void button1_Click(object sender, EventArgs e)
        {
     
            try
            {
                // A foglalas.txt fájl törlése (üresítése)
                File.WriteAllText("foglalas.txt", string.Empty);
                label2.Text = string.Empty;


                // Üzenet a felhasználónak
                MessageBox.Show("A foglalásokat sikeresen töröltük.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt a fájl törlésekor: " + ex.Message);
            }
        }

        private void bezárásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

