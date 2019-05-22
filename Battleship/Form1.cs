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
using System.Text.RegularExpressions;

namespace Battleship
{
    
    
  
    public partial class frmMain : Form
    {
        // Globale Startparameter
        public int fieldtop = 50;
        public int fieldleft = 50;
        public int fieldsize = 25;
        public int enemyfield = 500;
        public int currentShipLength = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void NeuesSpielToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
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

                    pb1[x,y] = new PictureBox();                                        
                    pb1[x,y].Name = "picbox_" + x.ToString() + y.ToString();
                    pb1[x, y].Location = new Point(x, y); 
                    pb1[x, y].Size = new Size(fieldsize, fieldsize);
                    pb1[x, y].BackColor = Color.DodgerBlue;
                    pb1[x, y].BorderStyle = BorderStyle.FixedSingle;
                    pb1[x, y].Visible = true;
                    pb1[x, y].Click += new System.EventHandler(setShip_Click);
                    this.Controls.Add(pb1[x, y]);

                    pb1[x, y] = new PictureBox();
                    pb1[x, y].Name = "picbox_" + x.ToString() + y.ToString() + "e";
                    pb1[x, y].Location = new Point(x+enemyfield, y);
                    pb1[x, y].Size = new Size(fieldsize, fieldsize);
                    pb1[x, y].BackColor = Color.DodgerBlue;
                    pb1[x, y].BorderStyle = BorderStyle.FixedSingle;
                    pb1[x, y].Visible = true;
                    pb1[x, y].Click += new System.EventHandler(setShip_Click);
                    this.Controls.Add(pb1[x, y]);
                }
            }
        }

        private void setShip_Click(object sender, EventArgs e)
        {
            PictureBox picbox = sender as PictureBox;

            //Check ob das gegnerische Feld angeklickt wurde
            string name = picbox.Name;
            var regexItem = new Regex("e");
            if (regexItem.IsMatch(name))
            {
                MessageBox.Show("Stop");
            }
            else if (currentShipLength == 0)
            {
                lb_status.Text = "Wähle Schiff";
                lb_status.ForeColor = Color.Red;
            }
            else if (currentShipLength == 2)
            {
                picbox.BackColor = Color.Red;
                lb_status.Text = picbox.Name;
            }
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

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void Btn_ship2_Click(object sender, EventArgs e)
        {
            // Message Bitte erstes Feld für dein Schiff auswählen
            lb_status.Text = "Bitte Schiff wählen!";
            // currentshiplength setzen
            currentShipLength = 2;
        }
    }
}
