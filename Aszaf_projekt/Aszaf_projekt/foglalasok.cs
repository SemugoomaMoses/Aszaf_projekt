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
        private string felhasznaloNev; 
      
        public Foglalasok(string nev)
        {
            InitializeComponent();
            string filePath = Path.Combine(Application.StartupPath, "foglalas.txt");
            felhasznaloNev = nev;


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
            this.BackColor = Color.FromArgb(100, Color.Gray); 
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Foglalasok_Load(object sender, EventArgs e)
        {
            try
            {
                string filePath = "foglalas.txt";

                
                string[] sorok = File.ReadAllLines(filePath);

                
                listBox1.Items.Clear();

                
                foreach (string sor in sorok)
                {
                    listBox1.Items.Add(sor);
                }
            }
            catch (Exception ex)
            {
                
                listBox1.Items.Clear();
                listBox1.Items.Add("Hiba történt: " + ex.Message);
            }
            try
            {
                string[] sorok = File.ReadAllLines("foglalas.txt");
                bool talalat = false;
                string egyFoglalas = "";

                foreach (string sor in sorok)
                {
                    if (sor.StartsWith("Név:"))
                    {
                        if (sor.Contains(felhasznaloNev))
                        {
                            talalat = true;
                            egyFoglalas = sor + "\n";
                        }
                        else
                        {
                            talalat = false;
                        }
                    }
                    else if (talalat)
                    {
                        if (sor.StartsWith("---"))
                        {
                            listBox1.Items.Add(egyFoglalas.Trim());
                            egyFoglalas = "";
                        }
                        else
                        {
                            egyFoglalas += sor + "\n";
                        }
                    }
                }

                if (listBox1.Items.Count == 0)
                {
                    listBox1.Items.Add("Nincs foglalás ehhez a névhez.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt a fájl olvasásakor: " + ex.Message);
            }
        
        }


        private void foglalásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show(); 
            this.Hide();
        }

        private void foglalásokToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Regisztracio RegisztracioForm = new Regisztracio();

            
            RegisztracioForm.FormBorderStyle = FormBorderStyle.None;  
            RegisztracioForm.StartPosition = FormStartPosition.CenterScreen;  
            RegisztracioForm.Size = RegisztracioForm.GetTabControl().Size;  
            RegisztracioForm.Location = this.Location;

            RegisztracioForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                File.WriteAllText("foglalas.txt", string.Empty);

                
                listBox1.Items.Clear();

                
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

        private void betűszínToolStripMenuItem_Click(object sender, EventArgs e)
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

