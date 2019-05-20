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
using System.Dynamic;

namespace Battleship
{
    
    
  
    public partial class frmMain : Form
    {
        // Globale Startparameter
        public int fieldtop = 50;
        public int fieldleft = 50;
        public int fieldsize = 25;

        public frmMain()
        {
            InitializeComponent();
        }

        private void NeuesSpielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* int x = 0; // X Koordinate
             int y = 0; // Y Koordinate
             int t = 50; //länge | Top ausrichtung
             int l = 50; //Left Ausrichtung
             int n = 1; //reihe
             int i = 0;
             int z = 1; //zähler
             using (var form = new frmSetting())
             {
                 var result = form.ShowDialog();
                 if (result == DialogResult.OK)
                 {
                     string val = form.breite;

                     Int32.TryParse(val, out i);
                 }
             }

             PictureBox[] pb1 = new PictureBox[i];
            for(y = 0; y <= i - 1; y++) {
                 l = 50;
              for (x = 0; x <= i-1; x++) {

                  pb1[x,y] = new PictureBox();
                  pb1[x,y].Name = "picbox_" + x.ToString();
                 if (x == 0) { pb1[x,y].Location = new Point(l, t); }
                 else if (i != 0) { pb1[x].Location = new Point(pb1[x-1,y].Left + l, pb1[x-1,y].Top+t); }

                  pb1[x,y].Size = new Size(25, 25);
                  pb1[x,y].BackColor = Color.DodgerBlue;
                  pb1[x,y].BorderStyle = BorderStyle.FixedSingle;
                  pb1[x,y].Visible = true;
                  this.Controls.Add(pb1[x,y]);
                  l = l + 25;
                     x++;
                 }
                 t = t + 25;
                 n = n + 1;
             }*/
            setField();
            gb_infop.Enabled = true;
            gb_infog.Enabled = true;
            gb_setzen.Enabled = true;
            btn_start.Enabled = true;

        }

        private void setField()
        {
            // Lokale Variablen
            int i = 0;

            // Form für Feldgröße abrufen
            using (var form = new frmSetting())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string val = form.breite;

                    Int32.TryParse(val, out i);
                }
            }

            // Anzahl Felder mit Feldgröße multiplizieren
            i = i * fieldsize + fieldtop;

            // Spielfeld mit Picturebox erstellen
            PictureBox[,] pb1 = new PictureBox[i,i];
            
            for (int y = fieldtop; y <= i - fieldsize; y += fieldsize)                  //y = 50
            {
                for (int x = fieldleft; x <= i - fieldsize; x += fieldsize)             //x = 50 | y = 50 
                {

                    pb1[x,y] = new PictureBox();                                        //x = 50 | y = 50
                    pb1[x,y].Name = "picbox_" + x.ToString() + y.ToString();            //x = 50 | y = 50
                    if (x == x) { pb1[x, y].Location = new Point(x, y); }       //x = 50 | y = 50
                    //else if (x != fieldleft) { pb1[x,y].Location = new Point(pb1[x - fieldsize, y].Left + x, pb1[x - fieldsize, y].Top + y); }

                    pb1[x, y].Size = new Size(fieldsize, fieldsize);
                    pb1[x, y].BackColor = Color.DodgerBlue;
                    pb1[x, y].BorderStyle = BorderStyle.FixedSingle;
                    pb1[x, y].Visible = true;
                    pb1[x, y].Click += new System.EventHandler(picbox_Click);
                    this.Controls.Add(pb1[x, y]);
                    textBox1.Text = textBox1.Text + " x=" + x + " y=" + y + "\r";

                }
            }
        }

        private void picbox_Click(object sender, EventArgs e)
        {
            string name = (sender as PictureBox).Name;
            MessageBox.Show(name);
            PictureBox wdfsdf = sender as PictureBox;
            wdfsdf.BackColor = Color.Red;
        }


        private void BeendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BeendenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Rb_horizontal_CheckedChanged(object sender, EventArgs e)
        {
            rb_vertical.Checked = false;
            rb_horizontal.Checked = true;
        }
    }
}
