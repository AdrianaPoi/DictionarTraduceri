namespace DictionarTraduceiRE
{
    partial class FormAdaugare
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
            this.textBoxE = new System.Windows.Forms.TextBox();
            this.textBoxCE = new System.Windows.Forms.TextBox();
            this.textBoxCR = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelExplicatie = new System.Windows.Forms.Label();
            this.labelCuvantEngleza = new System.Windows.Forms.Label();
            this.labelCuvantRomana = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.buttonRenunta = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxE
            // 
            this.textBoxE.Location = new System.Drawing.Point(410, 221);
            this.textBoxE.Name = "textBoxE";
            this.textBoxE.Size = new System.Drawing.Size(154, 26);
            this.textBoxE.TabIndex = 24;
            // 
            // textBoxCE
            // 
            this.textBoxCE.Location = new System.Drawing.Point(410, 174);
            this.textBoxCE.Name = "textBoxCE";
            this.textBoxCE.Size = new System.Drawing.Size(154, 26);
            this.textBoxCE.TabIndex = 23;
            // 
            // textBoxCR
            // 
            this.textBoxCR.Location = new System.Drawing.Point(410, 129);
            this.textBoxCR.Name = "textBoxCR";
            this.textBoxCR.Size = new System.Drawing.Size(154, 26);
            this.textBoxCR.TabIndex = 22;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(410, 88);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(72, 26);
            this.textBoxID.TabIndex = 21;
            // 
            // labelExplicatie
            // 
            this.labelExplicatie.AutoSize = true;
            this.labelExplicatie.Location = new System.Drawing.Point(203, 221);
            this.labelExplicatie.Name = "labelExplicatie";
            this.labelExplicatie.Size = new System.Drawing.Size(76, 20);
            this.labelExplicatie.TabIndex = 20;
            this.labelExplicatie.Text = "Explicatie";
            // 
            // labelCuvantEngleza
            // 
            this.labelCuvantEngleza.AutoSize = true;
            this.labelCuvantEngleza.Location = new System.Drawing.Point(203, 174);
            this.labelCuvantEngleza.Name = "labelCuvantEngleza";
            this.labelCuvantEngleza.Size = new System.Drawing.Size(117, 20);
            this.labelCuvantEngleza.TabIndex = 19;
            this.labelCuvantEngleza.Text = "CuvantEngleza";
            // 
            // labelCuvantRomana
            // 
            this.labelCuvantRomana.AutoSize = true;
            this.labelCuvantRomana.Location = new System.Drawing.Point(203, 129);
            this.labelCuvantRomana.Name = "labelCuvantRomana";
            this.labelCuvantRomana.Size = new System.Drawing.Size(120, 20);
            this.labelCuvantRomana.TabIndex = 18;
            this.labelCuvantRomana.Text = "CuvantRomana";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(203, 88);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(76, 20);
            this.labelID.TabIndex = 17;
            this.labelID.Text = "IDCuvant";
            // 
            // buttonRenunta
            // 
            this.buttonRenunta.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonRenunta.Location = new System.Drawing.Point(406, 318);
            this.buttonRenunta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRenunta.Name = "buttonRenunta";
            this.buttonRenunta.Size = new System.Drawing.Size(112, 35);
            this.buttonRenunta.TabIndex = 26;
            this.buttonRenunta.Text = "Renunta";
            this.buttonRenunta.UseVisualStyleBackColor = true;
          
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(243, 318);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(112, 35);
            this.buttonOk.TabIndex = 25;
            this.buttonOk.Text = "Adauga";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormAdaugare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRenunta);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxE);
            this.Controls.Add(this.textBoxCE);
            this.Controls.Add(this.textBoxCR);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelExplicatie);
            this.Controls.Add(this.labelCuvantEngleza);
            this.Controls.Add(this.labelCuvantRomana);
            this.Controls.Add(this.labelID);
            this.Name = "FormAdaugare";
            this.Text = "FormAdaugare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxE;
        private System.Windows.Forms.TextBox textBoxCE;
        private System.Windows.Forms.TextBox textBoxCR;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelExplicatie;
        private System.Windows.Forms.Label labelCuvantEngleza;
        private System.Windows.Forms.Label labelCuvantRomana;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button buttonRenunta;
        private System.Windows.Forms.Button buttonOk;
    }
}