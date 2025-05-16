namespace Aszaf_projekt
{
    partial class Foglalasok
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Foglalasok));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.foglalásokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foglalásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktuálisFoglalásokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bezárásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(282, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aktuális foglalások";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foglalásokToolStripMenuItem,
            this.foglalásToolStripMenuItem,
            this.aktuálisFoglalásokToolStripMenuItem,
            this.bezárásToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // foglalásokToolStripMenuItem
            // 
            this.foglalásokToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.foglalásokToolStripMenuItem.Name = "foglalásokToolStripMenuItem";
            this.foglalásokToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.foglalásokToolStripMenuItem.Text = "Regisztráció";
            this.foglalásokToolStripMenuItem.Click += new System.EventHandler(this.foglalásokToolStripMenuItem_Click);
            // 
            // foglalásToolStripMenuItem
            // 
            this.foglalásToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.foglalásToolStripMenuItem.Name = "foglalásToolStripMenuItem";
            this.foglalásToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.foglalásToolStripMenuItem.Text = "Foglalás";
            this.foglalásToolStripMenuItem.Click += new System.EventHandler(this.foglalásToolStripMenuItem_Click);
            // 
            // aktuálisFoglalásokToolStripMenuItem
            // 
            this.aktuálisFoglalásokToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.aktuálisFoglalásokToolStripMenuItem.Name = "aktuálisFoglalásokToolStripMenuItem";
            this.aktuálisFoglalásokToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.aktuálisFoglalásokToolStripMenuItem.Text = "Aktuális foglalások";
            this.aktuálisFoglalásokToolStripMenuItem.Click += new System.EventHandler(this.aktuálisFoglalásokToolStripMenuItem_Click);
            // 
            // bezárásToolStripMenuItem
            // 
            this.bezárásToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.bezárásToolStripMenuItem.Name = "bezárásToolStripMenuItem";
            this.bezárásToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.bezárásToolStripMenuItem.Text = "Bezárás";
            this.bezárásToolStripMenuItem.Click += new System.EventHandler(this.bezárásToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(150, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 329);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(176, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Törlés";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(41, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Foglalasok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Foglalasok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "foglalasok";
            this.Load += new System.EventHandler(this.Foglalasok_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem foglalásokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aktuálisFoglalásokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foglalásToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem bezárásToolStripMenuItem;
    }
}