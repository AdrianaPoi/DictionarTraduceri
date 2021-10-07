using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionarTraduceiRE
{
    public partial class AdaugaInBD : Form
    {
        public AdaugaInBD()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0; Data Source=bdCuvinte.accdb");
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;

                comanda.CommandText = "SELECT MAX(ID) FROM bdCuvinte";
                int id = Convert.ToInt32(comanda.ExecuteScalar());

                comanda.CommandText = "INSERT INTO bdCuvinte VALUES(?,?,?,?)";
                comanda.Parameters.Add("ID", OleDbType.Integer).Value = id + 1;
                comanda.Parameters.Add("cuvantR", OleDbType.Char,50).Value = textBoxCR.Text;
                comanda.Parameters.Add("cuvantE", OleDbType.Char,50).Value = textBoxCE.Text;
                comanda.Parameters.Add("explicatii", OleDbType.Char,100).Value = textBoxE.Text;
                comanda.ExecuteNonQuery();
                MessageBox.Show("S-a adaugat!");
                this.Close();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
                textBoxCR.Clear();
                textBoxCE.Clear();
                textBoxE.Clear();
            }
        }

        private void buttonRenunta_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
