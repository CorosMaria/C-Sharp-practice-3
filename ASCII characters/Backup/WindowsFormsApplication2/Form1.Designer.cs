namespace WindowsFormsApplication2
{
    partial class frmCaracterul_Ascii
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
            this.lbBinar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAscii = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstValori = new System.Windows.Forms.ListBox();
            this.tbLitera = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbUltimaLitera = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbBinar
            // 
            this.lbBinar.AutoSize = true;
            this.lbBinar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbBinar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBinar.Location = new System.Drawing.Point(325, 176);
            this.lbBinar.Name = "lbBinar";
            this.lbBinar.Size = new System.Drawing.Size(14, 20);
            this.lbBinar.TabIndex = 15;
            this.lbBinar.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(316, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Binar";
            // 
            // tbAscii
            // 
            this.tbAscii.Location = new System.Drawing.Point(320, 119);
            this.tbAscii.Name = "tbAscii";
            this.tbAscii.Size = new System.Drawing.Size(68, 20);
            this.tbAscii.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cod ASCII";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Valori utilizate";
            // 
            // lstValori
            // 
            this.lstValori.FormattingEnabled = true;
            this.lstValori.Location = new System.Drawing.Point(179, 46);
            this.lstValori.Name = "lstValori";
            this.lstValori.Size = new System.Drawing.Size(120, 160);
            this.lstValori.TabIndex = 10;
            this.lstValori.SelectedIndexChanged += new System.EventHandler(this.lstValori_SelectedIndexChanged);
            this.lstValori.Click += new System.EventHandler(this.lstValori_Click);
            // 
            // tbLitera
            // 
            this.tbLitera.Location = new System.Drawing.Point(128, 46);
            this.tbLitera.Name = "tbLitera";
            this.tbLitera.Size = new System.Drawing.Size(32, 20);
            this.tbLitera.TabIndex = 9;
            this.tbLitera.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbLitera_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Scrieti o litera";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Goleste lista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbUltimaLitera
            // 
            this.lbUltimaLitera.AutoSize = true;
            this.lbUltimaLitera.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUltimaLitera.Location = new System.Drawing.Point(337, 23);
            this.lbUltimaLitera.Name = "lbUltimaLitera";
            this.lbUltimaLitera.Size = new System.Drawing.Size(0, 73);
            this.lbUltimaLitera.TabIndex = 17;
            // 
            // frmCaracterul_Ascii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(467, 221);
            this.Controls.Add(this.lbUltimaLitera);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbBinar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAscii);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstValori);
            this.Controls.Add(this.tbLitera);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCaracterul_Ascii";
            this.Text = "Caracterul Ascii si valoarea binara";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBinar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAscii;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstValori;
        private System.Windows.Forms.TextBox tbLitera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbUltimaLitera;
    }
}

