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
    public partial class MeniuForm : Form
    {
        public MeniuForm()
        {
            InitializeComponent();
        }

        private void cuvinteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CuprinsDictionar().ShowDialog();
            this.Close();
        }

      

        private void despreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Show();
        }

      

        private void statisticiPrivindAccesareDictionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistici s = new Statistici();
            s.ShowDialog(); 
        }

      

        private void provocareaZileiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Provocare p = new Provocare();
            p.ShowDialog();
            this.Close();

        }

        private void cuvinteStocateIntroBazaDeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BazaDeDateCuvinte bd = new BazaDeDateCuvinte();
            bd.ShowDialog();
            this.Hide();

        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
