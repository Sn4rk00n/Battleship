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
        public int[] s11;
        public int[] s12;
        public int[] s13;
        public int[] s14;

        public int[] s21;
        public int[] s22;
        public int[] s23;

        public int[] s31;
        public int[] s32;

        public int gameState = 0;   //GameState: 0=Setzen 1=Spiel starten

        //Difinitions Integer für Feld- Position, Größe und Erscheinungsbild
        public int fieldtop = 50;
        public int fieldleft = 50;
        public int fieldsize = 25;
        public int enemyfield = 500;

        //Variable um zu Wissen, welches Schiff beim setzen gewählt wurden ist.
        public int currentShipLength = 0;

        //PictureBoxen für das eigene Feld wie auch für das gegnerische Feld
        public PictureBox[,] pbe;
        public PictureBox[,] pbg;

        //Variablen für max/min X/Y Koordinate
        public int xmin = 50;
        public int xmax;
        public int ymin = 50;
        public int ymax;

        public int lock_field;
        public int fGr;

        //Variable wie viele Schiffe gesetzt werden dürfen
        public int s1Count;
        public int s2Count;
        public int s3Count;

        public frmMain()
        {
            InitializeComponent();
            
        }

        //Erstellen einer neuen Runde
        private void NeuesSpielToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            setField();
            gb_infop.Enabled = true;
            gb_infog.Enabled = true;
            btn_start.Enabled = true;

        }

        //Funktion um 
        private void setField()
        {
            // Lokale Variablen
            int i = 0;
            int l = frmMain.ActiveForm.Width;

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

            //Je nach Feldgröße werden entspreche viele Schiffe zur verfügung gestellt
            fGr = i;
            Shipcount(fGr);

            // Anzahl Felder mit Feldgröße multiplizieren
            i = i * fieldsize + fieldtop;
      
            // Initiallisierung des 2D Arrays für die Felder
            pbe = new PictureBox[i, i];
            pbg = new PictureBox[i, i];
            
            //Zweifach verstrickte FOR-Schleife für die Erstellung der Felder mit ihren jeweiligen Events(Funktionen) und Eigenschaften
            for (int y = fieldtop; y <= i - fieldsize; y += fieldsize)                  
            {
                for (int x = fieldleft; x <= i - fieldsize; x += fieldsize)            
                {
                    pbe[x, y] = new PictureBox();                                        
                    pbe[x, y].Name = "picbox_" + x.ToString() + "-" + y.ToString();
                    pbe[x, y].Location = new Point(x, y); 
                    pbe[x, y].Size = new Size(fieldsize, fieldsize);
                    pbe[x, y].BackColor = Color.DodgerBlue;
                    pbe[x, y].BorderStyle = BorderStyle.FixedSingle;
                    pbe[x, y].Visible = true;
                    pbe[x, y].Click += new System.EventHandler(setShip_Click);
                    pbe[x, y].MouseHover += new System.EventHandler(setShip_MouseHover);
                    pbe[x, y].MouseLeave += new System.EventHandler(setShip_MouseLeave);
                    this.Controls.Add(pbe[x, y]);
                    xmax = x;
                    ymax = y;

                    pbg[x, y] = new PictureBox();
                    pbg[x, y].Name = "picboxg_" + x.ToString() + "-" + y.ToString();
                    pbg[x, y].Location = new Point(l-(x+fieldleft), y);
                    pbg[x, y].Size = new Size(fieldsize, fieldsize);
                    pbg[x, y].BackColor = Color.DodgerBlue;
                    pbg[x, y].BorderStyle = BorderStyle.FixedSingle;
                    pbg[x, y].Visible = true;
                    pbg[x, y].Click += new System.EventHandler(setShip_Click);
                    this.Controls.Add(pbg[x, y]);
                }
            }
        }
        
        //Dynamische Anzahl der Schiffe für die jeweilige Feldgröße
        private void Shipcount (int count)
        {
            switch(count)
            {
                case 5:
                    s1Count = 3;
                    s11 = new int[2];
                    s12 = new int[2];
                    s13 = new int[2];
                    s2Count = 1;
                    s21 = new int[4];
                    s3Count = 0;
                    lb_s1counter.Text = s1Count.ToString();
                    lb_s2counter.Text = s2Count.ToString();
                    lb_s3counter.Text = s3Count.ToString();
                    break;
                case 6:
                    s1Count = 3;
                    s11 = new int[2];
                    s12 = new int[2];
                    s13 = new int[2];
                    s2Count = 2;
                    s21 = new int[4];
                    s22 = new int[4];
                    s3Count = 0;
                    lb_s1counter.Text = s1Count.ToString();
                    lb_s2counter.Text = s2Count.ToString();
                    lb_s3counter.Text = s3Count.ToString();
                    break;
                case 7:
                    s1Count = 4;
                    s11 = new int[2];
                    s12 = new int[2];
                    s13 = new int[2];
                    s14 = new int[2];
                    s2Count = 2;
                    s21 = new int[4];
                    s22 = new int[4];
                    s3Count = 1;
                    s31 = new int[6];
                    lb_s1counter.Text = s1Count.ToString();
                    lb_s2counter.Text = s2Count.ToString();
                    lb_s3counter.Text = s3Count.ToString();
                    break;
                case 8:
                    s1Count = 4;
                    s11 = new int[2];
                    s12 = new int[2];
                    s13 = new int[2];
                    s14 = new int[2];
                    s2Count = 3;
                    s21 = new int[4];
                    s22 = new int[4];
                    s23 = new int[4];
                    s3Count = 1;
                    s31 = new int[6];
                    lb_s1counter.Text = s1Count.ToString();
                    lb_s2counter.Text = s2Count.ToString();
                    lb_s3counter.Text = s3Count.ToString();
                    break;
                case 9:
                    s1Count = 4;
                    s11 = new int[2];
                    s12 = new int[2];
                    s13 = new int[2];
                    s14 = new int[2];
                    s2Count = 3;
                    s21 = new int[4];
                    s22 = new int[4];
                    s23 = new int[4];
                    s3Count = 2;
                    s31 = new int[6];
                    s32 = new int[6];
                    lb_s1counter.Text = s1Count.ToString();
                    lb_s2counter.Text = s2Count.ToString();
                    lb_s3counter.Text = s3Count.ToString();
                    break;
            }
        }

        //Event wenn die Maus beim setzen über ein Feld geht
        private void setShip_MouseHover(object sender, EventArgs e)
        {
            PictureBox picbox = sender as PictureBox;
            string name = picbox.Name;
            string strx;
            string stry;
            int xcoor;
            int ycoor;
            name = picbox.Name;
            var result = name.Substring(name.LastIndexOf('_') + 1);
            strx = result.Substring(0, result.IndexOf('-'));
            stry = result.Substring(result.LastIndexOf('-') + 1);
            //rtb_status.Text = strx + stry;
            Int32.TryParse(strx, out xcoor);
            Int32.TryParse(stry, out ycoor);

            if (shipsGone() == 0) { 
                if (picbox.BackColor != Color.Gray)
                {
                    switch (currentShipLength)
                    {
                        case 0:
                            rtb_status.Text = "Wähle Schiff";
                            break;
                        case 1:
                            if (picbox.BackColor != Color.Gray)
                            {
                                picbox.BackColor = Color.Yellow;
                            }
                            else if (picbox.BackColor == Color.Gray)
                            {
                                rtb_status.Text = "Hier kann kein Schiff gesetzt werden!";
                            }
                            break;
                        case 2:
                            if (picbox.BackColor != Color.Gray) { picbox.BackColor = Color.Yellow; }

                            if (rb_horizontal.Checked == true)
                            {
                                xcoor = xcoor + fieldsize;
                                if (xcoor > xmax || ycoor > ymax)
                                {
                                    rtb_status.Text = "Hier kann kein Schiff gesetzt werden!\nBitte wähle ein anderes Feld!";
                                }
                                else if (pbe[xcoor, ycoor].BackColor == Color.Gray) { rtb_status.Text = "Hier kann kein Schiff platziert werden"; }
                                else { pbe[xcoor, ycoor].BackColor = Color.Yellow; }
                            }
                            else if (rb_vertical.Checked == true)
                            {
                                ycoor = ycoor + fieldsize;
                                if (xcoor > xmax || ycoor > ymax)
                                {
                                    rtb_status.Text = "Hier kann kein Schiff gesetzt werden!\nBitte wähle ein anderes Feld!";
                                }
                                else if (pbe[xcoor, ycoor].BackColor == Color.Gray) { rtb_status.Text = "Hier kann kein Schiff platziert werden"; }
                                else { pbe[xcoor, ycoor].BackColor = Color.Yellow; }
                            }
                            break;
                        case 3:
                            if (picbox.BackColor != Color.Gray) { picbox.BackColor = Color.Yellow; }
                            if (rb_horizontal.Checked == true)
                            {
                                xcoor = xcoor + fieldsize;
                                if (xcoor > xmax)
                                {
                                    rtb_status.Text = "Hier kann kein Schiff gesetzt werden!\nBitte wähle ein anderes Feld!";
                                }
                                else if (pbe[xcoor, ycoor].BackColor == Color.Gray) { rtb_status.Text = "Hier kann kein Schiff platziert werden"; }
                                else { pbe[xcoor, ycoor].BackColor = Color.Yellow; }

                                xcoor = xcoor + fieldsize;
                                if (xcoor > xmax)
                                {
                                    rtb_status.Text = "Hier kann kein Schiff gesetzt werden!\nBitte wähle ein anderes Feld!";
                                }
                                else if (pbe[xcoor, ycoor].BackColor == Color.Gray) { rtb_status.Text = "Hier kann kein Schiff platziert werden"; }
                                else pbe[xcoor, ycoor].BackColor = Color.Yellow;
                            }
                            else if (rb_vertical.Checked == true)
                            {
                                ycoor = ycoor + 25;
                                if (ycoor > ymax)
                                {
                                    rtb_status.Text = "Hier kann kein Schiff gesetzt werden!\nBitte wähle ein anderes Feld!";
                                }
                                else if (pbe[xcoor, ycoor].BackColor == Color.Gray) { rtb_status.Text = "Hier kann kein Schiff platziert werden"; }
                                else { pbe[xcoor, ycoor].BackColor = Color.Yellow; }

                                ycoor = ycoor + 25;
                                if (ycoor > ymax)
                                {
                                    rtb_status.Text = "Hier kann kein Schiff gesetzt werden!\nBitte wähle ein anderes Feld!";
                                }
                                else if (pbe[xcoor, ycoor].BackColor == Color.Gray) { rtb_status.Text = "Hier kann kein Schiff platziert werden"; }
                                else { pbe[xcoor, ycoor].BackColor = Color.Yellow; }
                            }
                            break;
                        default:
                            rtb_status.Text = "Wähle Schiff";
                            rtb_status.ForeColor = Color.Yellow;
                            break;
                    }
                }
            }
        }

        //Event wenn die Maus das Feld verlässt
        private void setShip_MouseLeave(object sender, EventArgs e)
        {
            PictureBox picbox = sender as PictureBox;
            string name = picbox.Name;
            string strx;
            string stry;
            int xcoor;
            int ycoor;
            name = picbox.Name;
            var result = name.Substring(name.LastIndexOf('_') + 1);
            strx = result.Substring(0, result.IndexOf('-'));
            stry = result.Substring(result.LastIndexOf('-') + 1);
            //rtb_status.Text = strx + stry;
            Int32.TryParse(strx, out xcoor);
            Int32.TryParse(stry, out ycoor);
            if (shipsGone() == 0)
            {
                if (picbox.BackColor != Color.Gray)
                {
                    switch (currentShipLength)
                    {
                        case 0:
                            rtb_status.Text = "Wähle Schiff";
                            break;

                        case 1:
                            if (picbox.BackColor != Color.Gray)
                            {
                                picbox.BackColor = Color.DodgerBlue;
                            }
                            else if (picbox.BackColor == Color.Gray)
                            {
                                rtb_status.Text = "Hier kann kein Schiff gesetzt werden!";
                            }
                            break;

                        case 2:
                            if (picbox.BackColor != Color.Gray) { picbox.BackColor = Color.DodgerBlue; }

                            if (rb_horizontal.Checked == true)
                            {
                                xcoor = xcoor + fieldsize;
                                if (xcoor > xmax || ycoor > ymax)
                                {
                                    rtb_status.Text = "Hier kann kein Schiff gesetzt werden!\nBitte wähle ein anderes Feld!";
                                }
                                else if (pbe[xcoor, ycoor].BackColor == Color.Gray) { rtb_status.Text = "Hier kann kein Schiff platziert werden"; }
                                else { pbe[xcoor, ycoor].BackColor = Color.DodgerBlue; }
                            }
                            else if (rb_vertical.Checked == true)
                            {
                                ycoor = ycoor + fieldsize;
                                if (xcoor > xmax || ycoor > ymax)
                                {
                                    rtb_status.Text = "Hier kann kein Schiff gesetzt werden!\nBitte wähle ein anderes Feld!";
                                }
                                else if (pbe[xcoor, ycoor].BackColor == Color.Gray) { rtb_status.Text = "Hier kann kein Schiff platziert werden"; }
                                else { pbe[xcoor, ycoor].BackColor = Color.DodgerBlue; }
                            }
                            break;
                        case 3:
                            if (picbox.BackColor != Color.Gray) { picbox.BackColor = Color.DodgerBlue; }
                            if (rb_horizontal.Checked == true)
                            {
                                xcoor = xcoor + fieldsize;
                                if (xcoor > xmax)
                                {
                                    rtb_status.Text = "Hier kann kein Schiff gesetzt werden!\nBitte wähle ein anderes Feld!";
                                }
                                else if (pbe[xcoor, ycoor].BackColor == Color.Gray) { rtb_status.Text = "Hier kann kein Schiff platziert werden"; }
                                else { pbe[xcoor, ycoor].BackColor = Color.DodgerBlue; }

                                xcoor = xcoor + fieldsize;
                                if (xcoor > xmax)
                                {
                                    rtb_status.Text = "Hier kann kein Schiff gesetzt werden!\nBitte wähle ein anderes Feld!";
                                }
                                else if (pbe[xcoor, ycoor].BackColor == Color.Gray) { rtb_status.Text = "Hier kann kein Schiff platziert werden"; }
                                else pbe[xcoor, ycoor].BackColor = Color.DodgerBlue;
                            }
                            else if (rb_vertical.Checked == true)
                            {
                                ycoor = ycoor + 25;
                                if (ycoor > ymax)
                                {
                                    rtb_status.Text = "Hier kann kein Schiff gesetzt werden!\nBitte wähle ein anderes Feld!";
                                }
                                else if (pbe[xcoor, ycoor].BackColor == Color.Gray) { rtb_status.Text = "Hier kann kein Schiff platziert werden"; }
                                else { pbe[xcoor, ycoor].BackColor = Color.DodgerBlue; }

                                ycoor = ycoor + 25;
                                if (ycoor > ymax)
                                {
                                    rtb_status.Text = "Hier kann kein Schiff gesetzt werden!\nBitte wähle ein anderes Feld!";
                                }
                                else if (pbe[xcoor, ycoor].BackColor == Color.Gray) { rtb_status.Text = "Hier kann kein Schiff platziert werden"; }
                                else { pbe[xcoor, ycoor].BackColor = Color.DodgerBlue; }
                            }
                            break;
                        default:
                            rtb_status.Text = "Wähle Schiff";
                            rtb_status.ForeColor = Color.Yellow;
                            break;
                    }
                }
            }
        }

        //Event um ein Schiff zu setzen
        private void setShip_Click(object sender, EventArgs e)
        {
            //Object sender ist die angeklickte Picture box die als "PictureBox picbox" Variable gleichgesetzt wird, damit picbox alle Eigenschaften hat von dem angeklickten Feld
            PictureBox picbox = sender as PictureBox;
            string name = picbox.Name;
            string strx;
            string stry;
            int xcoor;
            int ycoor;
            int check;

            name = picbox.Name;
            var result = name.Substring(name.LastIndexOf('_') + 1);
            strx = result.Substring(0, result.IndexOf('-'));
            stry = result.Substring(result.LastIndexOf('-') + 1);
            Int32.TryParse(strx, out xcoor);
            Int32.TryParse(stry, out ycoor);

            if (gameState == 0)
            {
                //Abfangen, dass man nicht im gegnerischen Feld Schiffe setzen kann
                var regexItem = new Regex("g");
                if (regexItem.IsMatch(name))
                {
                    MessageBox.Show("Stop");
                    rtb_status.Text = picbox.Name;
                }

                //Das setzen von 1-3er Schiffen
                else
                {
                    switch (currentShipLength)
                    {
                        case 0:
                            rtb_status.Text = "Wähle Schiff";
                            break;
                        case 1:
                            if (picbox.BackColor != Color.Gray && s1Count != 0)
                            {
                                check = checkShip(xcoor, ycoor, currentShipLength); //Funktion um zu überprüfen, dass kein anderes Schiff in der Nähe ist
                                if (check == 1) { rtb_status.Text = "Hier kann kein Schiff gesetzt werden!"; }
                                else
                                {
                                    picbox.BackColor = Color.Gray;
                                    //genStruct(xcoor, ycoor, currentShipLength);
                                    s1Count--;
                                    lb_s1counter.Text = s1Count.ToString();

                                }

                            }
                            else if (picbox.BackColor == Color.Gray)
                            {
                                rtb_status.Text = "Hier kann kein Schiff gesetzt werden!";
                            }
                            else
                            {
                                rtb_status.Text = "Es sind keine Schiffe in der Länge von 1 Feld verfügbar";
                                shipsGone();
                            }
                            break;
                        case 2:

                            if (rb_horizontal.Checked == true && s2Count != 0)
                            {
                                if ((xcoor + fieldsize) <= xmax)
                                {
                                    check = checkShip(xcoor, ycoor, currentShipLength);

                                    if (check == 1)
                                    {
                                        rtb_status.Text = "Hier kann kein Schiff gesetzt werden!\nBitte wähle ein anderes Feld!";
                                    }
                                    else
                                    {
                                        picbox.BackColor = Color.Gray;
                                        pbe[xcoor + fieldsize, ycoor].BackColor = Color.Gray;
                                        s2Count--;
                                        lb_s2counter.Text = s2Count.ToString();
                                    }
                                }
                                else { rtb_status.Text = "Hier kann kein Schiff gesetzt werden!\nBitte wähle ein anderes Feld!"; }

                            }
                            else if (rb_vertical.Checked == true && s2Count != 0)
                            {
                                if ((ycoor + fieldsize) <= ymax)
                                {
                                    check = checkShip(xcoor, ycoor, currentShipLength);

                                    if (check == 1)
                                    {
                                        rtb_status.Text = "Hier kann kein Schiff gesetzt werden!\nBitte wähle ein anderes Feld!";
                                    }
                                    else
                                    {
                                        picbox.BackColor = Color.Gray;
                                        pbe[xcoor, ycoor + fieldsize].BackColor = Color.Gray;
                                        s2Count--;
                                        lb_s2counter.Text = s2Count.ToString();
                                    }
                                }
                                else { rtb_status.Text = "Hier kann kein Schiff gesetzt werden!\nBitte wähle ein anderes Feld!"; }
                            }
                            else
                            {
                                rtb_status.Text = "Es sind keine Schiffe in der Länge von 2 Feldern verfügbar";
                                shipsGone();
                            }
                            break;
                        case 3:
                            if (rb_horizontal.Checked == true && s3Count != 0)
                            {
                                if (xcoor + (fieldsize * 2) <= xmax)
                                {
                                    if ((xcoor + fieldsize) <= xmax)
                                    {
                                        check = checkShip(xcoor, ycoor, currentShipLength);

                                        if (check == 1)
                                        {
                                            rtb_status.Text = "Hier kann kein Schiff gesetzt werden!\nBitte wähle ein anderes Feld!";
                                        }
                                        else
                                        {
                                            picbox.BackColor = Color.Gray;
                                            pbe[xcoor + fieldsize, ycoor].BackColor = Color.Gray;
                                            pbe[xcoor + (2 * fieldsize), ycoor].BackColor = Color.Gray;
                                            s3Count--;
                                            lb_s3counter.Text = s3Count.ToString();
                                        }
                                    }
                                    else { rtb_status.Text = "Hier kann kein Schiff gesetzt werden!\nBitte wähle ein anderes Feld!"; }
                                }
                            }
                            else if (rb_vertical.Checked == true && s3Count != 0)
                            {
                                if (ycoor + (fieldsize * 2) <= ymax)
                                {
                                    if ((ycoor + fieldsize) <= ymax)
                                    {
                                        check = checkShip(xcoor, ycoor, currentShipLength);

                                        if (check == 1)
                                        {
                                            rtb_status.Text = "Hier kann kein Schiff gesetzt werden!\nBitte wähle ein anderes Feld!";
                                        }
                                        else
                                        {
                                            picbox.BackColor = Color.Gray;
                                            pbe[xcoor, ycoor + fieldsize].BackColor = Color.Gray;
                                            pbe[xcoor, ycoor + (2 * fieldsize)].BackColor = Color.Gray;
                                            s3Count--;
                                            lb_s3counter.Text = s3Count.ToString();
                                        }
                                    }
                                    else { rtb_status.Text = "Hier kann kein Schiff gesetzt werden!\nBitte wähle ein anderes Feld!"; }
                                }
                            }
                            else
                            {
                                rtb_status.Text = "Es sind keine Schiffe in der Länge von 3 Feldern verfügbar";
                                shipsGone();
                            }
                            break;
                        default:
                            rtb_status.Text = "Wähle Schiff";
                            rtb_status.ForeColor = Color.Gray;
                            break;
                    }
                }
            }
        }

        private int shipsGone()
        {
            if (s1Count == 0 && s2Count == 0 && s3Count == 0)
            {
                rtb_status.Text = "Alle Schiffe sind gesetzt, bitte starte das Spiel.";
                gameState = 1;
                return 1;
            }
            else { return 0; }
        }

        private int checkShip(int x, int y,int lenght)
        {
            //X/Y = Koordinaten vom angeklickten Objekt
            int check;

            switch (lenght)
            {
                case 1:
                    check = fieldCheck(x, y);
                    if(check == 1)
                    {
                        return 1;
                    }
                    break;
                case 2:
                    check = fieldCheck(x, y);
                    if(check == 1)
                    {
                        return 1;
                    }
                    else if (rb_horizontal.Checked && check == 0)
                    {
                        check = fieldCheck(x + fieldsize, y);
                        if (check == 1) { return 1; }
                        else { return 0; }
                    }

                    else if(rb_vertical.Checked && check == 0)
                    {
                        check = fieldCheck(x, y + fieldsize);
                        if (check == 1) { return 1; }
                        else { return 0; }
                    }
                    break;
                case 3:
                    check = fieldCheck(x, y);
                    if (check == 1)
                    {
                        return 1;
                    }
                    else if (rb_horizontal.Checked && check == 0)
                    {
                        check = fieldCheck(x + fieldsize, y);
                        if (check == 1) { return 1; }
                        else if (check == 0)
                        {
                            check = fieldCheck(x + (2 * fieldsize), y);
                            if (check == 1) { return 1; }
                            else { return 0; }
                        }
                        
                    }
                    else if (rb_vertical.Checked && check == 0)
                    {
                        check = fieldCheck(x, y + fieldsize);
                        if (check == 1) { return 1; }
                        else if (check == 0)
                        {
                            check = fieldCheck(x, y + (2 * fieldsize));
                            if (check == 1) { return 1; }
                            else { return 0; }
                        }
                    }
                    break;
            }
            return 0;
        }

        private int fieldCheck(int x, int y)
        {
            if (x - fieldsize < xmin && y - fieldsize < ymin) //Ecke obenlinks
            {
                if(pbe[x+fieldsize,y].BackColor == Color.Gray || pbe[x,y+fieldsize].BackColor == Color.Gray)
                {
                    return 1;
                }
                else { return 0; }
            }
            else if (x + fieldsize > xmax && y - fieldsize < ymin) //Ecke oben rechts
            {
                if(pbe[x-fieldsize,y].BackColor == Color.Gray || pbe[x,y+fieldsize].BackColor == Color.Gray)
                {
                    return 1;
                }
                else { return 0; }
            }
            else if (x - fieldsize < xmin && y + fieldsize > ymax) //Unterelinke Ecke
            {
                if(pbe[x+fieldsize,y].BackColor == Color.Gray || pbe[x,y-fieldsize].BackColor == Color.Gray)
                {
                    return 1;
                }
                else { return 0; }
            }
            else if(x + fieldsize > xmax && y + fieldsize > ymax) //Untererechte Ecke
            {
                if(pbe[x-fieldsize,y].BackColor == Color.Gray || pbe[x,y-fieldsize].BackColor == Color.Gray)
                {
                    return 1;
                }
                else { return 0; }
            }
            else if (y-fieldsize < ymin) //obere Reihe
            {
                if(pbe[x-fieldsize,y].BackColor == Color.Gray || pbe[x+fieldsize,y].BackColor == Color.Gray || pbe[x,y+fieldsize].BackColor == Color.Gray)
                {
                    return 1;
                }
                else { return 0; }
            }
            else if (x-fieldsize < xmin) //linke Reihe
            {
                if(pbe[x+fieldsize,y].BackColor == Color.Gray || pbe[x,y-fieldsize].BackColor == Color.Gray || pbe[x,y+fieldsize].BackColor == Color.Gray)
                {
                    return 1;
                }
                else { return 0; }
            }
            else if (x+fieldsize > xmax) //rechte Reihe
            {
                if (pbe[x - fieldsize, y].BackColor == Color.Gray || pbe[x, y - fieldsize].BackColor == Color.Gray || pbe[x, y + fieldsize].BackColor == Color.Gray)
                {
                    return 1;
                }
                else { return 0; }
            }
            else if (y+fieldsize > ymax) //untere Reihe
            {
                if (pbe[x - fieldsize, y].BackColor == Color.Gray || pbe[x + fieldsize, y].BackColor == Color.Gray || pbe[x, y - fieldsize].BackColor == Color.Gray)
                {
                    return 1;
                }
                else { return 0; }
            }
            else //Mittleres Feld
            {
                if (pbe[x - fieldsize, y].BackColor == Color.Gray || pbe[x + fieldsize, y].BackColor == Color.Gray || pbe[x, y - fieldsize].BackColor == Color.Gray || pbe[x, y + fieldsize].BackColor == Color.Gray)
                {
                    return 1;
                }
                else { return 0; }
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

        private void Btn_ship1_Click(object sender, EventArgs e)
        {
            rtb_status.Text = "1. Schiff mit einer Länge von 1 Feldern gewählt.";
            currentShipLength = 1;
        }

        private void Btn_ship2_Click(object sender, EventArgs e)
        {
            // Message Bitte erstes Feld für dein Schiff auswählen
            rtb_status.Text = "2. Schiff mit einer Länge von 2 Feldern gewählt.";

            // currentshiplength setzen
            currentShipLength = 2;
        }

        private void Btn_ship3_Click(object sender, EventArgs e)
        {
            rtb_status.Text = "3. Schiff mit einer Länge von 3 Feldern gewählt.";
            currentShipLength = 3;
        }
    }
}
