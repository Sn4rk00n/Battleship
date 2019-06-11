namespace Battleship
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.spielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuesSpielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_infop = new System.Windows.Forms.GroupBox();
            this.lb_punktee = new System.Windows.Forms.Label();
            this.lb_pointse = new System.Windows.Forms.Label();
            this.tb_treffere = new System.Windows.Forms.TextBox();
            this.gb_infog = new System.Windows.Forms.GroupBox();
            this.lb_punkteg = new System.Windows.Forms.Label();
            this.lb_pointsg = new System.Windows.Forms.Label();
            this.tb_trefferg = new System.Windows.Forms.TextBox();
            this.rb_horizontal = new System.Windows.Forms.RadioButton();
            this.rb_vertical = new System.Windows.Forms.RadioButton();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_ship1 = new System.Windows.Forms.Button();
            this.btn_ship2 = new System.Windows.Forms.Button();
            this.lb_s1counter = new System.Windows.Forms.Label();
            this.rtb_status = new System.Windows.Forms.RichTextBox();
            this.lb_s2counter = new System.Windows.Forms.Label();
            this.lb_s1text = new System.Windows.Forms.Label();
            this.lb_s2text = new System.Windows.Forms.Label();
            this.btn_ship3 = new System.Windows.Forms.Button();
            this.lb_s3counter = new System.Windows.Forms.Label();
            this.lb_s3text = new System.Windows.Forms.Label();
            this.t_zug = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.gb_infop.SuspendLayout();
            this.gb_infog.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spielToolStripMenuItem,
            this.hilfeToolStripMenuItem,
            this.beendenToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // spielToolStripMenuItem
            // 
            this.spielToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuesSpielToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.spielToolStripMenuItem.Name = "spielToolStripMenuItem";
            this.spielToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.spielToolStripMenuItem.Text = "Spiel";
            // 
            // neuesSpielToolStripMenuItem
            // 
            this.neuesSpielToolStripMenuItem.Name = "neuesSpielToolStripMenuItem";
            this.neuesSpielToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.neuesSpielToolStripMenuItem.Text = "Neues Spiel";
            this.neuesSpielToolStripMenuItem.Click += new System.EventHandler(this.NeuesSpielToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.BeendenToolStripMenuItem_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // beendenToolStripMenuItem1
            // 
            this.beendenToolStripMenuItem1.Name = "beendenToolStripMenuItem1";
            this.beendenToolStripMenuItem1.Size = new System.Drawing.Size(65, 20);
            this.beendenToolStripMenuItem1.Text = "Beenden";
            this.beendenToolStripMenuItem1.Click += new System.EventHandler(this.BeendenToolStripMenuItem1_Click);
            // 
            // gb_infop
            // 
            this.gb_infop.Controls.Add(this.lb_punktee);
            this.gb_infop.Controls.Add(this.lb_pointse);
            this.gb_infop.Controls.Add(this.tb_treffere);
            this.gb_infop.Enabled = false;
            this.gb_infop.Location = new System.Drawing.Point(12, 374);
            this.gb_infop.Name = "gb_infop";
            this.gb_infop.Size = new System.Drawing.Size(196, 160);
            this.gb_infop.TabIndex = 97;
            this.gb_infop.TabStop = false;
            this.gb_infop.Text = "Spiel Informationen";
            // 
            // lb_punktee
            // 
            this.lb_punktee.AutoSize = true;
            this.lb_punktee.Location = new System.Drawing.Point(66, 96);
            this.lb_punktee.Name = "lb_punktee";
            this.lb_punktee.Size = new System.Drawing.Size(13, 13);
            this.lb_punktee.TabIndex = 2;
            this.lb_punktee.Text = "0";
            // 
            // lb_pointse
            // 
            this.lb_pointse.AutoSize = true;
            this.lb_pointse.Location = new System.Drawing.Point(24, 96);
            this.lb_pointse.Name = "lb_pointse";
            this.lb_pointse.Size = new System.Drawing.Size(44, 13);
            this.lb_pointse.TabIndex = 1;
            this.lb_pointse.Text = "Punkte:";
            // 
            // tb_treffere
            // 
            this.tb_treffere.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tb_treffere.Location = new System.Drawing.Point(27, 28);
            this.tb_treffere.Name = "tb_treffere";
            this.tb_treffere.ReadOnly = true;
            this.tb_treffere.Size = new System.Drawing.Size(139, 20);
            this.tb_treffere.TabIndex = 0;
            // 
            // gb_infog
            // 
            this.gb_infog.Controls.Add(this.lb_punkteg);
            this.gb_infog.Controls.Add(this.lb_pointsg);
            this.gb_infog.Controls.Add(this.tb_trefferg);
            this.gb_infog.Enabled = false;
            this.gb_infog.Location = new System.Drawing.Point(776, 374);
            this.gb_infog.Name = "gb_infog";
            this.gb_infog.Size = new System.Drawing.Size(196, 160);
            this.gb_infog.TabIndex = 98;
            this.gb_infog.TabStop = false;
            this.gb_infog.Text = "Spiel Informationen";
            // 
            // lb_punkteg
            // 
            this.lb_punkteg.AutoSize = true;
            this.lb_punkteg.Location = new System.Drawing.Point(66, 96);
            this.lb_punkteg.Name = "lb_punkteg";
            this.lb_punkteg.Size = new System.Drawing.Size(13, 13);
            this.lb_punkteg.TabIndex = 3;
            this.lb_punkteg.Text = "0";
            // 
            // lb_pointsg
            // 
            this.lb_pointsg.AutoSize = true;
            this.lb_pointsg.Location = new System.Drawing.Point(24, 96);
            this.lb_pointsg.Name = "lb_pointsg";
            this.lb_pointsg.Size = new System.Drawing.Size(44, 13);
            this.lb_pointsg.TabIndex = 2;
            this.lb_pointsg.Text = "Punkte:";
            // 
            // tb_trefferg
            // 
            this.tb_trefferg.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tb_trefferg.Location = new System.Drawing.Point(27, 29);
            this.tb_trefferg.Name = "tb_trefferg";
            this.tb_trefferg.ReadOnly = true;
            this.tb_trefferg.Size = new System.Drawing.Size(139, 20);
            this.tb_trefferg.TabIndex = 1;
            // 
            // rb_horizontal
            // 
            this.rb_horizontal.AutoSize = true;
            this.rb_horizontal.Location = new System.Drawing.Point(508, 181);
            this.rb_horizontal.Name = "rb_horizontal";
            this.rb_horizontal.Size = new System.Drawing.Size(72, 17);
            this.rb_horizontal.TabIndex = 103;
            this.rb_horizontal.Text = "Horizontal";
            this.rb_horizontal.UseVisualStyleBackColor = true;
            // 
            // rb_vertical
            // 
            this.rb_vertical.AutoSize = true;
            this.rb_vertical.Checked = true;
            this.rb_vertical.Location = new System.Drawing.Point(435, 181);
            this.rb_vertical.Name = "rb_vertical";
            this.rb_vertical.Size = new System.Drawing.Size(60, 17);
            this.rb_vertical.TabIndex = 102;
            this.rb_vertical.TabStop = true;
            this.rb_vertical.Text = "Vertikal";
            this.rb_vertical.UseVisualStyleBackColor = true;
            // 
            // btn_start
            // 
            this.btn_start.Enabled = false;
            this.btn_start.Location = new System.Drawing.Point(460, 336);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(80, 23);
            this.btn_start.TabIndex = 102;
            this.btn_start.Text = "Spiel starten";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.Btn_start_Click);
            // 
            // btn_ship1
            // 
            this.btn_ship1.Location = new System.Drawing.Point(435, 219);
            this.btn_ship1.Name = "btn_ship1";
            this.btn_ship1.Size = new System.Drawing.Size(60, 23);
            this.btn_ship1.TabIndex = 103;
            this.btn_ship1.Text = "1. Schiff";
            this.btn_ship1.UseVisualStyleBackColor = true;
            this.btn_ship1.Click += new System.EventHandler(this.Btn_ship1_Click);
            // 
            // btn_ship2
            // 
            this.btn_ship2.Location = new System.Drawing.Point(435, 248);
            this.btn_ship2.Name = "btn_ship2";
            this.btn_ship2.Size = new System.Drawing.Size(60, 23);
            this.btn_ship2.TabIndex = 104;
            this.btn_ship2.Text = "2. Schiff";
            this.btn_ship2.UseVisualStyleBackColor = true;
            this.btn_ship2.Click += new System.EventHandler(this.Btn_ship2_Click);
            // 
            // lb_s1counter
            // 
            this.lb_s1counter.AutoSize = true;
            this.lb_s1counter.Location = new System.Drawing.Point(505, 224);
            this.lb_s1counter.Name = "lb_s1counter";
            this.lb_s1counter.Size = new System.Drawing.Size(12, 13);
            this.lb_s1counter.TabIndex = 106;
            this.lb_s1counter.Text = "x";
            // 
            // rtb_status
            // 
            this.rtb_status.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtb_status.Location = new System.Drawing.Point(350, 40);
            this.rtb_status.Name = "rtb_status";
            this.rtb_status.ReadOnly = true;
            this.rtb_status.Size = new System.Drawing.Size(300, 135);
            this.rtb_status.TabIndex = 107;
            this.rtb_status.TabStop = false;
            this.rtb_status.Text = "";
            // 
            // lb_s2counter
            // 
            this.lb_s2counter.AutoSize = true;
            this.lb_s2counter.Location = new System.Drawing.Point(505, 253);
            this.lb_s2counter.Name = "lb_s2counter";
            this.lb_s2counter.Size = new System.Drawing.Size(12, 13);
            this.lb_s2counter.TabIndex = 108;
            this.lb_s2counter.Text = "x";
            // 
            // lb_s1text
            // 
            this.lb_s1text.AutoSize = true;
            this.lb_s1text.Location = new System.Drawing.Point(525, 224);
            this.lb_s1text.Name = "lb_s1text";
            this.lb_s1text.Size = new System.Drawing.Size(52, 13);
            this.lb_s1text.TabIndex = 109;
            this.lb_s1text.Text = "verfügbar";
            // 
            // lb_s2text
            // 
            this.lb_s2text.AutoSize = true;
            this.lb_s2text.Location = new System.Drawing.Point(525, 253);
            this.lb_s2text.Name = "lb_s2text";
            this.lb_s2text.Size = new System.Drawing.Size(52, 13);
            this.lb_s2text.TabIndex = 110;
            this.lb_s2text.Text = "verfügbar";
            // 
            // btn_ship3
            // 
            this.btn_ship3.Location = new System.Drawing.Point(435, 277);
            this.btn_ship3.Name = "btn_ship3";
            this.btn_ship3.Size = new System.Drawing.Size(60, 23);
            this.btn_ship3.TabIndex = 111;
            this.btn_ship3.Text = "3. Schiff";
            this.btn_ship3.UseVisualStyleBackColor = true;
            this.btn_ship3.Click += new System.EventHandler(this.Btn_ship3_Click);
            // 
            // lb_s3counter
            // 
            this.lb_s3counter.AutoSize = true;
            this.lb_s3counter.Location = new System.Drawing.Point(505, 282);
            this.lb_s3counter.Name = "lb_s3counter";
            this.lb_s3counter.Size = new System.Drawing.Size(12, 13);
            this.lb_s3counter.TabIndex = 112;
            this.lb_s3counter.Text = "x";
            // 
            // lb_s3text
            // 
            this.lb_s3text.AutoSize = true;
            this.lb_s3text.Location = new System.Drawing.Point(525, 282);
            this.lb_s3text.Name = "lb_s3text";
            this.lb_s3text.Size = new System.Drawing.Size(52, 13);
            this.lb_s3text.TabIndex = 113;
            this.lb_s3text.Text = "verfügbar";
            // 
            // t_zug
            // 
            this.t_zug.Interval = 1000;
            this.t_zug.Tick += new System.EventHandler(this.T_zug_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 545);
            this.Controls.Add(this.lb_s3text);
            this.Controls.Add(this.rb_horizontal);
            this.Controls.Add(this.lb_s3counter);
            this.Controls.Add(this.rb_vertical);
            this.Controls.Add(this.btn_ship3);
            this.Controls.Add(this.lb_s2text);
            this.Controls.Add(this.lb_s1text);
            this.Controls.Add(this.lb_s2counter);
            this.Controls.Add(this.rtb_status);
            this.Controls.Add(this.lb_s1counter);
            this.Controls.Add(this.btn_ship2);
            this.Controls.Add(this.btn_ship1);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.gb_infog);
            this.Controls.Add(this.gb_infop);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Battleship";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gb_infop.ResumeLayout(false);
            this.gb_infop.PerformLayout();
            this.gb_infog.ResumeLayout(false);
            this.gb_infog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem spielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuesSpielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem1;
        internal System.Windows.Forms.GroupBox gb_infop;
        internal System.Windows.Forms.Label lb_punktee;
        internal System.Windows.Forms.Label lb_pointse;
        internal System.Windows.Forms.TextBox tb_treffere;
        internal System.Windows.Forms.GroupBox gb_infog;
        internal System.Windows.Forms.Label lb_punkteg;
        internal System.Windows.Forms.Label lb_pointsg;
        internal System.Windows.Forms.TextBox tb_trefferg;
        internal System.Windows.Forms.RadioButton rb_horizontal;
        internal System.Windows.Forms.RadioButton rb_vertical;
        internal System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_ship1;
        private System.Windows.Forms.Button btn_ship2;
        private System.Windows.Forms.Label lb_s1counter;
        private System.Windows.Forms.RichTextBox rtb_status;
        private System.Windows.Forms.Label lb_s2counter;
        private System.Windows.Forms.Label lb_s1text;
        private System.Windows.Forms.Label lb_s2text;
        private System.Windows.Forms.Button btn_ship3;
        private System.Windows.Forms.Label lb_s3counter;
        private System.Windows.Forms.Label lb_s3text;
        private System.Windows.Forms.Timer t_zug;
    }
}

