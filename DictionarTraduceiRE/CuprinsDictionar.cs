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

namespace DictionarTraduceiRE
{
    public partial class CuprinsDictionar : Form
    {
        List<DictionarRomEng> dre = new List<DictionarRomEng>();
        public CuprinsDictionar()
        {
            InitializeComponent();
        }
        private void InitializareDate(string numeFisier)
        {
            try
            {
                StreamReader sr = new StreamReader(numeFisier);
                string linie;
                while ((linie = sr.ReadLine()) != null)
                {
                    int Id= Convert.ToInt32(linie.Split(',')[0]);
                    string CuvantR = linie.Split(',')[1];
                    string CuvantE = linie.Split(',')[2];
                    string Explicatie = linie.Split(',')[3];
                    dre.Add(new DictionarRomEng(Id, CuvantR, CuvantE, Explicatie));
                }
                sr.Close();
            }
   
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InitializareLista()
        {
            foreach(DictionarRomEng d in dre)
            {
                ListViewItem itm = new ListViewItem(d.idC.ToString());
                itm.SubItems.Add(d.cuvantR);
                itm.SubItems.Add(d.cuvantE);
                itm.SubItems.Add(d.explicatie);
                lvCuvinte.Items.Add(itm);
                itm.Tag = dre;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();

            string fisier = op.FileName;
            InitializareDate(fisier);
            InitializareLista();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dre.Clear();
            lvCuvinte.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.ShowDialog();
                string fisier = save.FileName;
                StreamWriter sw = new StreamWriter(fisier);
                foreach(ListViewItem itm in lvCuvinte.Items)
                {
                    for(int i=0;i<itm.SubItems.Count;i++)
                    {
                        sw.Write(itm.SubItems[i].Text);
                            if(i!=itm.SubItems.Count-1)
                        {
                            sw.Write(',');
                        }
                    }
                    sw.WriteLine();

                }
                sw.Close();
                MessageBox.Show("File saved to: " + fisier);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            DictionarRomEng d = new DictionarRomEng(0, "", "", "");
            d.cuvantR = textBoxCR.Text;
            d.cuvantE = textBoxCE.Text;
            d.explicatie = textBoxE.Text;
            bool adaugaok = true;
            try
            {
                d.idC = Convert.ToInt32(textBoxID.Text);
            }
            catch
            {
                adaugaok = false;
               MessageBox.Show ("Conversia nu a reusit", "Mesaj", MessageBoxButtons.OK);
            }
            if(adaugaok)
            {
                AdaugainControale(d);
            }
         
        }

        private void AdaugainControale(DictionarRomEng d)
        {
            ListViewItem lvi= new ListViewItem(d.idC.ToString());
            lvi.SubItems.Add(d.cuvantR);
            lvi.SubItems.Add(d.cuvantE);
            lvi.SubItems.Add(d.explicatie);
            lvi.Tag = d;
            lvCuvinte.Items.Add(lvi);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DictionarRomEng dForm = new DictionarRomEng(0, "", "", "");
            FormAdaugare fa = new FormAdaugare(dForm);
            fa.ShowDialog();
            if (fa.DialogResult == DialogResult.OK)
            {
                AdaugainControale(dForm);
            }


        }

        private void textBoxID_Validating(object sender, CancelEventArgs e)
        {
            TextBox tblocal = (TextBox)sender;
            bool ok = true;
            try
            {
                int id = Convert.ToInt32(tblocal.Text);

            }
            catch
            {
                errorProvider1.SetError(tblocal, "Introduceti ID!");
                ok = false;
            }
            if (ok) errorProvider1.SetError(tblocal, "");
        }

        private void textBoxCR_Validating(object sender, CancelEventArgs e)
        {
            TextBox tblocal = (TextBox)sender;
          
                errorProvider1.SetError(tblocal, "Introduceti Cuvantul!");
               
            
            
        }

        private void textBoxCE_Validating(object sender, CancelEventArgs e)
        {
            TextBox tblocal = (TextBox)sender;

            errorProvider1.SetError(tblocal, "Introduceti Cuvantul!");
        }

        private void textBoxE_Validating(object sender, CancelEventArgs e)
        {
            TextBox tblocal = (TextBox)sender;

            errorProvider1.SetError(tblocal, "Introduceti Explicatia!");
        }


        private void lvCuvinte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvCuvinte.SelectedItems.Count>0)
            {
                contextMenuStrip1.Items[0].Enabled = true;
              
            }
            else
            {
                contextMenuStrip1.Items[0].Enabled = false;
             
            }
        

        }

       
        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvCuvinte.SelectedItems[0].Remove();
        }
    }
}
