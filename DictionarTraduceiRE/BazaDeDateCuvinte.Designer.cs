namespace DictionarTraduceiRE
{
    partial class BazaDeDateCuvinte
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
            this.lvCuvinte = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCuvantRomana = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCuvantEngleza = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnExplicatie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.meniu2 = new DictionarTraduceiRE.Meniu();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvCuvinte
            // 
            this.lvCuvinte.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lvCuvinte.CheckBoxes = true;
            this.lvCuvinte.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnCuvantRomana,
            this.columnCuvantEngleza,
            this.columnExplicatie});
            this.lvCuvinte.ContextMenuStrip = this.contextMenuStrip1;
            this.lvCuvinte.FullRowSelect = true;
            this.lvCuvinte.GridLines = true;
            this.lvCuvinte.HideSelection = false;
            this.lvCuvinte.Location = new System.Drawing.Point(190, 86);
            this.lvCuvinte.Name = "lvCuvinte";
            this.lvCuvinte.Size = new System.Drawing.Size(780, 253);
            this.lvCuvinte.TabIndex = 6;
            this.lvCuvinte.UseCompatibleStateImageBehavior = false;
            this.lvCuvinte.View = System.Windows.Forms.View.Details;
            // 
            // columnID
            // 
            this.columnID.Text = "IDCuvant";
            this.columnID.Width = 48;
            // 
            // columnCuvantRomana
            // 
            this.columnCuvantRomana.Text = "CuvantRomana";
            this.columnCuvantRomana.Width = 123;
            // 
            // columnCuvantEngleza
            // 
            this.columnCuvantEngleza.Text = "CuvantEngleza";
            this.columnCuvantEngleza.Width = 125;
            // 
            // columnExplicatie
            // 
            this.columnExplicatie.Text = "Explicatie";
            this.columnExplicatie.Width = 479;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 34);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(134, 30);
            this.stergeToolStripMenuItem.Text = "Sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Vizualizare date din bd";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(438, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "Adauga un cuvant nou";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // meniu2
            // 
            this.meniu2.Location = new System.Drawing.Point(774, 425);
            this.meniu2.Name = "meniu2";
            this.meniu2.Size = new System.Drawing.Size(131, 34);
            this.meniu2.TabIndex = 9;
            // 
            // BazaDeDateCuvinte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1161, 613);
            this.Controls.Add(this.meniu2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvCuvinte);
            this.Name = "BazaDeDateCuvinte";
            this.Text = "BazaDeDateCuvinte";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvCuvinte;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnCuvantRomana;
        private System.Windows.Forms.ColumnHeader columnCuvantEngleza;
        private System.Windows.Forms.ColumnHeader columnExplicatie;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Meniu meniu1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private Meniu meniu2;
    }
}