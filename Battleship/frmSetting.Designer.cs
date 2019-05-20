namespace Battleship
{
    partial class frmSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.l_breite = new System.Windows.Forms.Label();
            this.tb_breite = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lb_xbr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l_breite
            // 
            this.l_breite.AutoSize = true;
            this.l_breite.Location = new System.Drawing.Point(12, 13);
            this.l_breite.Name = "l_breite";
            this.l_breite.Size = new System.Drawing.Size(159, 13);
            this.l_breite.TabIndex = 0;
            this.l_breite.Text = "Wie groß soll das Spielfeld sein?";
            // 
            // tb_breite
            // 
            this.tb_breite.Location = new System.Drawing.Point(177, 10);
            this.tb_breite.Name = "tb_breite";
            this.tb_breite.Size = new System.Drawing.Size(59, 20);
            this.tb_breite.TabIndex = 1;
            this.tb_breite.TextChanged += new System.EventHandler(this.Tb_breite_TextChanged_1);
            this.tb_breite.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tb_breite_KeyDown);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(50, 61);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.Btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(177, 61);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Abbrechen";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // lb_xbr
            // 
            this.lb_xbr.AutoSize = true;
            this.lb_xbr.Location = new System.Drawing.Point(242, 13);
            this.lb_xbr.Name = "lb_xbr";
            this.lb_xbr.Size = new System.Drawing.Size(12, 13);
            this.lb_xbr.TabIndex = 4;
            this.lb_xbr.Text = "x";
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 96);
            this.Controls.Add(this.lb_xbr);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.tb_breite);
            this.Controls.Add(this.l_breite);
            this.Name = "frmSetting";
            this.Text = "frmSetting";
            this.Load += new System.EventHandler(this.FrmSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_breite;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lb_xbr;
        public System.Windows.Forms.TextBox tb_breite;
    }
}