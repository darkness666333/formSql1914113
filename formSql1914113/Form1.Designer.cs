namespace formSql1914113
{
    partial class Form1
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
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.nudJegy = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNEv = new System.Windows.Forms.TextBox();
            this.tbTema = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbTz = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudJegy)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDatum
            // 
            this.dtpDatum.AccessibleName = "dtpDatum";
            this.dtpDatum.Location = new System.Drawing.Point(263, 22);
            this.dtpDatum.MaxDate = new System.DateTime(2020, 6, 15, 0, 0, 0, 0);
            this.dtpDatum.MinDate = new System.DateTime(2000, 9, 9, 0, 0, 0, 0);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpDatum.TabIndex = 0;
            this.dtpDatum.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // nudJegy
            // 
            this.nudJegy.Location = new System.Drawing.Point(273, 111);
            this.nudJegy.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudJegy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudJegy.Name = "nudJegy";
            this.nudJegy.Size = new System.Drawing.Size(120, 20);
            this.nudJegy.TabIndex = 1;
            this.nudJegy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dátum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Téma:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Jegy";
            // 
            // tbNEv
            // 
            this.tbNEv.AccessibleName = "tbNEv";
            this.tbNEv.Location = new System.Drawing.Point(70, 22);
            this.tbNEv.Name = "tbNEv";
            this.tbNEv.Size = new System.Drawing.Size(100, 20);
            this.tbNEv.TabIndex = 8;
            // 
            // tbTema
            // 
            this.tbTema.AccessibleName = "tbTema";
            this.tbTema.Location = new System.Drawing.Point(70, 111);
            this.tbTema.Name = "tbTema";
            this.tbTema.Size = new System.Drawing.Size(100, 20);
            this.tbTema.TabIndex = 9;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(2, 193);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(517, 168);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Új jegy rögzítése";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cbTz
            // 
            this.cbTz.AccessibleName = "cbTz";
            this.cbTz.AutoSize = true;
            this.cbTz.Location = new System.Drawing.Point(428, 113);
            this.cbTz.Name = "cbTz";
            this.cbTz.Size = new System.Drawing.Size(46, 17);
            this.cbTz.TabIndex = 12;
            this.cbTz.Text = "TZ?";
            this.cbTz.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 380);
            this.Controls.Add(this.cbTz);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.tbTema);
            this.Controls.Add(this.tbNEv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudJegy);
            this.Controls.Add(this.dtpDatum);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudJegy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.NumericUpDown nudJegy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNEv;
        private System.Windows.Forms.TextBox tbTema;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbTz;
    }
}

