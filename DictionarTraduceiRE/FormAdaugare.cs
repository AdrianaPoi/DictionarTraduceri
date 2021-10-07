using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionarTraduceiRE
{
    public partial class FormAdaugare : Form
    {
        DictionarRomEng dForm;
        public FormAdaugare(DictionarRomEng dParametru)
        {
            dForm = dParametru;
            InitializeComponent();
            if(dForm.cuvantR.Length>0)
            {
                textBoxID.Text = dForm.idC.ToString();
                textBoxCR.Text = dForm.cuvantR;
                textBoxCE.Text = dForm.cuvantE;
                textBoxE.Text = dForm.explicatie;

                buttonOk.Text = "Modifica";
            }
        }

        

        private void buttonOk_Click(object sender, EventArgs e)
        {
            dForm.cuvantR = textBoxCR.Text;
            dForm.cuvantE = textBoxCE.Text;
            dForm.explicatie = textBoxE.Text;
            bool adaugaok = true;
            try
            {
                dForm.idC = Convert.ToInt32(textBoxID.Text);
            }
            catch
            {
                adaugaok = false;
                MessageBox.Show("Conversia nu a reusit", "Mesaj", MessageBoxButtons.OK);
            }
            if (adaugaok)
            {
               
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }

        }

        
    }
}
