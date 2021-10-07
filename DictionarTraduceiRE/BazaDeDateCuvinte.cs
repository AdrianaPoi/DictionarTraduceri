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
    public partial class BazaDeDateCuvinte : Form
    {
        string connString;

        OleDbConnection connection = new OleDbConnection(@"");
        public BazaDeDateCuvinte()
        {
            InitializeComponent();
            connString = "Provider= Microsoft.ACE.OLEDB.12.0; Data Source=bdCuvinte.accdb";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lvCuvinte.Items.Clear();
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                //OleDbCommand comanda = new OleDbCommand("SELECT *FROM bdCuvinte", conexiune);
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT * FROM bdCuvinte";

                OleDbDataReader reader = comanda.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["ID"].ToString());
                    itm.SubItems.Add(reader["cuvantR"].ToString());
                    itm.SubItems.Add(reader["cuvantE"].ToString());
                    itm.SubItems.Add(reader["explicatii"].ToString());
                    lvCuvinte.Items.Add(itm);
                }

                MessageBox.Show("Conexiunea a functionat!");
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
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdaugaInBD a = new AdaugaInBD();
            a.Show();
            
        }

      

        private void stergeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;

                int id = Convert.ToInt32(lvCuvinte.SelectedItems[0].Text);
                comanda.CommandText = "DELETE FROM bdCuvinte WHERE ID="+ id ;
                comanda.ExecuteNonQuery(); //apelam comanda

            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message);
            }
            finally
            {
                conexiune.Close();

            }
            lvCuvinte.SelectedItems[0].Remove();
        }
    }
}

  