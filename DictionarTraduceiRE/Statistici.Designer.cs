namespace DictionarTraduceiRE
{
    partial class Statistici
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.incarcaDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printeazaStatistciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.schimbaCuloareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaGraficulStatisticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incarcaDateToolStripMenuItem,
            this.printeazaStatistciToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // incarcaDateToolStripMenuItem
            // 
            this.incarcaDateToolStripMenuItem.Name = "incarcaDateToolStripMenuItem";
            this.incarcaDateToolStripMenuItem.Size = new System.Drawing.Size(119, 29);
            this.incarcaDateToolStripMenuItem.Text = "Incarca date";
            this.incarcaDateToolStripMenuItem.Click += new System.EventHandler(this.incarcaDateToolStripMenuItem_Click);
            // 
            // printeazaStatistciToolStripMenuItem
            // 
            this.printeazaStatistciToolStripMenuItem.Name = "printeazaStatistciToolStripMenuItem";
            this.printeazaStatistciToolStripMenuItem.Size = new System.Drawing.Size(159, 29);
            this.printeazaStatistciToolStripMenuItem.Text = "Printeaza statistci";
            this.printeazaStatistciToolStripMenuItem.Click += new System.EventHandler(this.printeazaStatistciToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schimbaCuloareToolStripMenuItem,
            this.salveazaGraficulStatisticToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(279, 64);
            // 
            // schimbaCuloareToolStripMenuItem
            // 
            this.schimbaCuloareToolStripMenuItem.Name = "schimbaCuloareToolStripMenuItem";
            this.schimbaCuloareToolStripMenuItem.Size = new System.Drawing.Size(278, 30);
            this.schimbaCuloareToolStripMenuItem.Text = "Schimba culoare";
            this.schimbaCuloareToolStripMenuItem.Click += new System.EventHandler(this.schimbaCuloareToolStripMenuItem_Click);
            // 
            // salveazaGraficulStatisticToolStripMenuItem
            // 
            this.salveazaGraficulStatisticToolStripMenuItem.Name = "salveazaGraficulStatisticToolStripMenuItem";
            this.salveazaGraficulStatisticToolStripMenuItem.Size = new System.Drawing.Size(278, 30);
            this.salveazaGraficulStatisticToolStripMenuItem.Text = "Salveaza graficul statistic";
            this.salveazaGraficulStatisticToolStripMenuItem.Click += new System.EventHandler(this.salveazaGraficulStatisticToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.ContextMenuStrip = this.contextMenuStrip1;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 417);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // Statistici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Statistici";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem incarcaDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printeazaStatistciToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem schimbaCuloareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaGraficulStatisticToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
    }
}