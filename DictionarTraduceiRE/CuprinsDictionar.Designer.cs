namespace DictionarTraduceiRE
{
    partial class CuprinsDictionar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuprinsDictionar));
            this.button1 = new System.Windows.Forms.Button();
            this.lvCuvinte = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCuvantRomana = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCuvantEngleza = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnExplicatie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.labelCuvantRomana = new System.Windows.Forms.Label();
            this.labelCuvantEngleza = new System.Windows.Forms.Label();
            this.labelExplicatie = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxCR = new System.Windows.Forms.TextBox();
            this.textBoxCE = new System.Windows.Forms.TextBox();
            this.textBoxE = new System.Windows.Forms.TextBox();
            this.buttonAdauga = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.meniu1 = new DictionarTraduceiRE.Meniu();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(27, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cuvinte existente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvCuvinte
            // 
            this.lvCuvinte.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lvCuvinte.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnCuvantRomana,
            this.columnCuvantEngleza,
            this.columnExplicatie});
            this.lvCuvinte.ContextMenuStrip = this.contextMenuStrip1;
            this.lvCuvinte.GridLines = true;
            this.lvCuvinte.HideSelection = false;
            this.lvCuvinte.Location = new System.Drawing.Point(27, 403);
            this.lvCuvinte.Name = "lvCuvinte";
            this.lvCuvinte.Size = new System.Drawing.Size(783, 216);
            this.lvCuvinte.TabIndex = 5;
            this.lvCuvinte.UseCompatibleStateImageBehavior = false;
            this.lvCuvinte.View = System.Windows.Forms.View.Details;
            this.lvCuvinte.SelectedIndexChanged += new System.EventHandler(this.lvCuvinte_SelectedIndexChanged);
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(217, 34);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Enabled = false;
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.stergeToolStripMenuItem.Text = "Sterge un cuvant";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(922, 465);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(229, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "Salveaza cuvintele in fisier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(922, 536);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(229, 36);
            this.button3.TabIndex = 7;
            this.button3.Text = "Curata lista de cuvinte";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(79, 36);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(76, 20);
            this.labelID.TabIndex = 8;
            this.labelID.Text = "IDCuvant";
            // 
            // labelCuvantRomana
            // 
            this.labelCuvantRomana.AutoSize = true;
            this.labelCuvantRomana.Location = new System.Drawing.Point(79, 77);
            this.labelCuvantRomana.Name = "labelCuvantRomana";
            this.labelCuvantRomana.Size = new System.Drawing.Size(120, 20);
            this.labelCuvantRomana.TabIndex = 9;
            this.labelCuvantRomana.Text = "CuvantRomana";
            // 
            // labelCuvantEngleza
            // 
            this.labelCuvantEngleza.AutoSize = true;
            this.labelCuvantEngleza.Location = new System.Drawing.Point(79, 122);
            this.labelCuvantEngleza.Name = "labelCuvantEngleza";
            this.labelCuvantEngleza.Size = new System.Drawing.Size(117, 20);
            this.labelCuvantEngleza.TabIndex = 10;
            this.labelCuvantEngleza.Text = "CuvantEngleza";
            // 
            // labelExplicatie
            // 
            this.labelExplicatie.AutoSize = true;
            this.labelExplicatie.Location = new System.Drawing.Point(79, 169);
            this.labelExplicatie.Name = "labelExplicatie";
            this.labelExplicatie.Size = new System.Drawing.Size(76, 20);
            this.labelExplicatie.TabIndex = 11;
            this.labelExplicatie.Text = "Explicatie";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(286, 36);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(72, 26);
            this.textBoxID.TabIndex = 12;
            this.textBoxID.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxID_Validating);
            // 
            // textBoxCR
            // 
            this.textBoxCR.Location = new System.Drawing.Point(286, 77);
            this.textBoxCR.Name = "textBoxCR";
            this.textBoxCR.Size = new System.Drawing.Size(154, 26);
            this.textBoxCR.TabIndex = 14;
            this.textBoxCR.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCR_Validating);
            // 
            // textBoxCE
            // 
            this.textBoxCE.Location = new System.Drawing.Point(286, 122);
            this.textBoxCE.Name = "textBoxCE";
            this.textBoxCE.Size = new System.Drawing.Size(154, 26);
            this.textBoxCE.TabIndex = 15;
            this.textBoxCE.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCE_Validating);
            // 
            // textBoxE
            // 
            this.textBoxE.Location = new System.Drawing.Point(286, 169);
            this.textBoxE.Name = "textBoxE";
            this.textBoxE.Size = new System.Drawing.Size(154, 26);
            this.textBoxE.TabIndex = 16;
            this.textBoxE.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxE_Validating);
            // 
            // buttonAdauga
            // 
            this.buttonAdauga.Location = new System.Drawing.Point(150, 217);
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.Size = new System.Drawing.Size(183, 34);
            this.buttonAdauga.TabIndex = 17;
            this.buttonAdauga.Text = "Adauga cuvant nou";
            this.buttonAdauga.UseVisualStyleBackColor = true;
            this.buttonAdauga.Click += new System.EventHandler(this.buttonAdauga_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(650, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(441, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(140, 277);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(202, 34);
            this.button4.TabIndex = 19;
            this.button4.Text = "Adauga prin alt formular";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(220, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "sau";
            // 
            // meniu1
            // 
            this.meniu1.Location = new System.Drawing.Point(973, 603);
            this.meniu1.Name = "meniu1";
            this.meniu1.Size = new System.Drawing.Size(131, 34);
            this.meniu1.TabIndex = 21;
            // 
            // CuprinsDictionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1212, 658);
            this.Controls.Add(this.meniu1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonAdauga);
            this.Controls.Add(this.textBoxE);
            this.Controls.Add(this.textBoxCE);
            this.Controls.Add(this.textBoxCR);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelExplicatie);
            this.Controls.Add(this.labelCuvantEngleza);
            this.Controls.Add(this.labelCuvantRomana);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lvCuvinte);
            this.Controls.Add(this.button1);
            this.Name = "CuprinsDictionar";
            this.Text = "CuprinsDictionar";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lvCuvinte;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnCuvantRomana;
        private System.Windows.Forms.ColumnHeader columnCuvantEngleza;
        private System.Windows.Forms.ColumnHeader columnExplicatie;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelCuvantRomana;
        private System.Windows.Forms.Label labelCuvantEngleza;
        private System.Windows.Forms.Label labelExplicatie;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxCR;
        private System.Windows.Forms.TextBox textBoxCE;
        private System.Windows.Forms.TextBox textBoxE;
        private System.Windows.Forms.Button buttonAdauga;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private Meniu meniu1;
    }
}