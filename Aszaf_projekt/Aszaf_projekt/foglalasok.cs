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
            string bejelentkezettNev = Regisztracio.RegisztraltTeljesNev;
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
            this.BackColor = Color.FromArgb(100, Color.Gray); 
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

        private void Foglalasok_Load(object sender, EventArgs e)
        {
            string filePath = "foglalas.txt";

            if (!File.Exists(filePath))
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Nincs elérhető foglalás.");
                return;
            }

            string[] lines = File.ReadAllLines(filePath);
            listBox1.Items.Clear();

            string keresettNev = Regisztracio.RegisztraltTeljesNev;
            if (string.IsNullOrEmpty(keresettNev))
            {
                listBox1.Items.Add("Nem vagy bejelentkezve.");
                return;
            }

            

            List<string> egyFoglalas = new List<string>();
            bool talaltFoglalas = false;

            foreach (string sor in lines)
            {
                if (string.IsNullOrWhiteSpace(sor))
                {
                    
                    if (egyFoglalas.Count > 0)
                    {
                        
                        string nevSor = egyFoglalas.FirstOrDefault(s => s.StartsWith("Név:"));
                        if (nevSor != null)
                        {
                            string nev = nevSor.Substring(4).Trim();
                            if (nev == keresettNev)
                            {
                                talaltFoglalas = true;
                                
                                foreach (var sorAdat in egyFoglalas)
                                {
                                    listBox1.Items.Add(sorAdat);
                                }
                                listBox1.Items.Add("");
                            }
                        }
                    }
                    egyFoglalas.Clear();
                }
                else
                {
                    egyFoglalas.Add(sor);
                }
            }

            
            if (egyFoglalas.Count > 0)
            {
                string nevSor = egyFoglalas.FirstOrDefault(s => s.StartsWith("Név:"));
                if (nevSor != null)
                {
                    string nev = nevSor.Substring(4).Trim();
                    if (nev == keresettNev)
                    {
                        talaltFoglalas = true;
                        foreach (var sorAdat in egyFoglalas)
                        {
                            listBox1.Items.Add(sorAdat);
                        }
                        listBox1.Items.Add("");
                    }
                }
            }

            if (!talaltFoglalas)
            {
                listBox1.Items.Add("Nincsenek foglalások ehhez a felhasználóhoz.");
            }
        }
    }
}

