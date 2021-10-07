using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace DictionarTraduceiRE
{
    public partial class Statistici : Form
    {
        double[] vect = new double[20];
        int nrE = 0;
        bool vb = false;
        const int margine = 10;
        Color culoare = Color.RoyalBlue;
      
        public Statistici()
        {
            InitializeComponent();
        }

        private void incarcaDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("date.txt");
            string linie = null;
            while((linie=sr.ReadLine())!=null)
            {
                try
                {
                    vect[nrE] = Convert.ToDouble(linie);
                    nrE++;
                    vb = true; //ins ca am cel putin un elem in vector

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Invalidate();
                }
            }
            sr.Close();
            MessageBox.Show("Datele au fost incarcate!");
            panel1.Invalidate();
        }

       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (vb == true)
            {
                Graphics g = e.Graphics;
                Rectangle rec = new Rectangle(panel1.ClientRectangle.X + margine, panel1.ClientRectangle.Y + 2 * margine, panel1.ClientRectangle.Width - 2 * margine, panel1.ClientRectangle.Height - 3 * margine);
                Pen pen = new Pen(Color.White, 3);
                g.DrawRectangle(pen, rec);

                double latime = rec.Width / nrE / 3;
                double distanta = (rec.Width - nrE * latime) / (nrE + 1); //distanta drept; 3 drept=>4 distante
                double vMax = vect.Max();

                Brush br = new SolidBrush(culoare);

                Rectangle[] rect = new Rectangle[nrE];
                for (int i = 0; i < nrE; i++)
                {
                    rect[i] = new Rectangle((int)(rec.Location.X + (i + 1) * distanta + i * latime),
                      (int)(rec.Location.Y + rec.Height - vect[i] / vMax * rec.Height),
                      (int)latime,
                      (int)(vect[i] / vMax * rec.Height));
                    g.DrawString(vect[i].ToString(), this.Font, br, new Point((int)(rect[i].Location.X + latime / 2),
                        (int)(rect[i].Location.Y - this.Font.Height)));

                }
                g.FillRectangles(br, rect);

            }
        }
        private void schimbaCuloareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                culoare = dlg.Color;
            panel1.Invalidate();
        }

        private void Save(Control c, string denumire)
        {
            Bitmap img = new Bitmap(c.Width, c.Height);
            c.DrawToBitmap(img, new Rectangle(c.ClientRectangle.X, c.ClientRectangle.Y,
                c.ClientRectangle.Width, c.ClientRectangle.Height));
            img.Save(denumire);
            img.Dispose(); //sterge memorie dupa ce am salvat pe disc
        }

        private void salveazaGraficulStatisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save(panel1, "poza.bmp");
            MessageBox.Show("Imaginea a fost salvata!");
        }
        private void print(object sender, PrintPageEventArgs e)
        {
            if (vb == true)
            {
                Graphics g = e.Graphics;
                Rectangle rec = new Rectangle(e.PageBounds.X + margine, e.PageBounds.Y + 2 * margine, e.PageBounds.Width - 2 * margine, e.PageBounds.Height - 3 * margine);
                Pen pen = new Pen(Color.White, 3);
                g.DrawRectangle(pen, rec);

                double latime = rec.Width / nrE / 3;
                double distanta = (rec.Width - nrE * latime) / (nrE + 1); //distanta drept; 3 drept=>4 distante
                double vMax = vect.Max();

                Brush br = new SolidBrush(culoare);

                Rectangle[] rect = new Rectangle[nrE];
                for (int i = 0; i < nrE; i++)
                {
                    rect[i] = new Rectangle((int)(rec.Location.X + (i + 1) * distanta + i * latime),
                      (int)(rec.Location.Y + rec.Height - vect[i] / vMax * rec.Height),
                      (int)latime,
                      (int)(vect[i] / vMax * rec.Height));
                    g.DrawString(vect[i].ToString(), this.Font, br, new Point((int)(rect[i].Location.X + latime / 2),
                        (int)(rect[i].Location.Y - this.Font.Height)));

                }
                g.FillRectangles(br, rect);
            }
        }

        private void printeazaStatistciToolStripMenuItem_Click(object sender, EventArgs e)
        {
           PrintDocument pd= new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(print);
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = pd;
            dlg.ShowDialog();
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
