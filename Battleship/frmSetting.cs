using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship
{
    public partial class frmSetting : Form
    {
        public frmSetting()
        {
            InitializeComponent();
            
        }
        public string breite { get; set; }

        private void FrmSetting_Load(object sender, EventArgs e)
        {

        }

        private void Btn_ok_Click(object sender, EventArgs e)
        {
            this.breite = tb_breite.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
 

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Tb_breite_TextChanged_1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tb_breite.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                tb_breite.Text = "";
            }
            string var = tb_breite.Text;
            int x = 0;
            Int32.TryParse(tb_breite.Text, out x);
            if (x > 10)
            {
                MessageBox.Show("Das Feld kann nur eine maximal Größe von 10x10 Feldern annehmen!");
                tb_breite.Text = "";
            }
            lb_xbr.Text = "x " + tb_breite.Text;
        }

        private void Tb_breite_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Btn_ok_Click((object)sender, (EventArgs)e);
            }
        }
    }
}
