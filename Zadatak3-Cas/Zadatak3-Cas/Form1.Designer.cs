namespace Zadatak3_Cas
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
            this.txtBrojPartije = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipPartije = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_UnesiPartiju = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbPromene = new System.Windows.Forms.GroupBox();
            this.btnIsplata = new System.Windows.Forms.Button();
            this.btnUplata = new System.Windows.Forms.Button();
            this.cbValute = new System.Windows.Forms.ComboBox();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbPrikaz = new System.Windows.Forms.GroupBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPromene = new System.Windows.Forms.TextBox();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.gbPromene.SuspendLayout();
            this.gbPrikaz.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBrojPartije
            // 
            this.txtBrojPartije.Location = new System.Drawing.Point(140, 28);
            this.txtBrojPartije.Name = "txtBrojPartije";
            this.txtBrojPartije.Size = new System.Drawing.Size(121, 20);
            this.txtBrojPartije.TabIndex = 0;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(100, 19);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 1;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(99, 45);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 2;
            // 
            // txtJMBG
            // 
            this.txtJMBG.Location = new System.Drawing.Point(99, 71);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(100, 20);
            this.txtJMBG.TabIndex = 3;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(99, 97);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtTelefon.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Broj Partije";
            // 
            // cbTipPartije
            // 
            this.cbTipPartije.FormattingEnabled = true;
            this.cbTipPartije.Items.AddRange(new object[] {
            " TekuciRacun",
            " DeviznaStednja",
            " DinarskaStednja"});
            this.cbTipPartije.Location = new System.Drawing.Point(140, 66);
            this.cbTipPartije.Name = "cbTipPartije";
            this.cbTipPartije.Size = new System.Drawing.Size(121, 21);
            this.cbTipPartije.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tip Partije";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_UnesiPartiju);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Controls.Add(this.txtPrezime);
            this.groupBox1.Controls.Add(this.txtJMBG);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Location = new System.Drawing.Point(35, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 161);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vlasnik";
            // 
            // btn_UnesiPartiju
            // 
            this.btn_UnesiPartiju.Location = new System.Drawing.Point(99, 132);
            this.btn_UnesiPartiju.Name = "btn_UnesiPartiju";
            this.btn_UnesiPartiju.Size = new System.Drawing.Size(75, 23);
            this.btn_UnesiPartiju.TabIndex = 9;
            this.btn_UnesiPartiju.Text = "Unesi partiju";
            this.btn_UnesiPartiju.UseVisualStyleBackColor = true;
            this.btn_UnesiPartiju.Click += new System.EventHandler(this.btn_UnesiPartiju_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "JMBG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ime";
            // 
            // gbPromene
            // 
            this.gbPromene.Controls.Add(this.btnIsplata);
            this.gbPromene.Controls.Add(this.btnUplata);
            this.gbPromene.Controls.Add(this.cbValute);
            this.gbPromene.Controls.Add(this.txtIznos);
            this.gbPromene.Controls.Add(this.label7);
            this.gbPromene.Enabled = false;
            this.gbPromene.Location = new System.Drawing.Point(35, 294);
            this.gbPromene.Name = "gbPromene";
            this.gbPromene.Size = new System.Drawing.Size(261, 100);
            this.gbPromene.TabIndex = 11;
            this.gbPromene.TabStop = false;
            this.gbPromene.Text = "Promene";
            // 
            // btnIsplata
            // 
            this.btnIsplata.Location = new System.Drawing.Point(151, 54);
            this.btnIsplata.Name = "btnIsplata";
            this.btnIsplata.Size = new System.Drawing.Size(75, 23);
            this.btnIsplata.TabIndex = 14;
            this.btnIsplata.Text = "Unesi isplatu";
            this.btnIsplata.UseVisualStyleBackColor = true;
            this.btnIsplata.Click += new System.EventHandler(this.btnIsplata_Click);
            // 
            // btnUplata
            // 
            this.btnUplata.Location = new System.Drawing.Point(39, 54);
            this.btnUplata.Name = "btnUplata";
            this.btnUplata.Size = new System.Drawing.Size(75, 23);
            this.btnUplata.TabIndex = 10;
            this.btnUplata.Text = "Unesi uplatu";
            this.btnUplata.UseVisualStyleBackColor = true;
            this.btnUplata.Click += new System.EventHandler(this.btnUplata_Click);
            // 
            // cbValute
            // 
            this.cbValute.FormattingEnabled = true;
            this.cbValute.Items.AddRange(new object[] {
            "RSD",
            "EUR",
            "YEN ",
            "USD"});
            this.cbValute.Location = new System.Drawing.Point(188, 17);
            this.cbValute.Name = "cbValute";
            this.cbValute.Size = new System.Drawing.Size(52, 21);
            this.cbValute.TabIndex = 13;
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(62, 17);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(100, 20);
            this.txtIznos.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Iznos";
            // 
            // gbPrikaz
            // 
            this.gbPrikaz.Controls.Add(this.dtpDo);
            this.gbPrikaz.Controls.Add(this.dtpOd);
            this.gbPrikaz.Controls.Add(this.btnPrikazi);
            this.gbPrikaz.Controls.Add(this.label9);
            this.gbPrikaz.Controls.Add(this.label8);
            this.gbPrikaz.Enabled = false;
            this.gbPrikaz.Location = new System.Drawing.Point(35, 401);
            this.gbPrikaz.Name = "gbPrikaz";
            this.gbPrikaz.Size = new System.Drawing.Size(261, 119);
            this.gbPrikaz.TabIndex = 12;
            this.gbPrikaz.TabStop = false;
            this.gbPrikaz.Text = "Prikaz";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(134, 82);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 4;
            this.btnPrikazi.Text = "Prikazi promene";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Datum do";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Datum od";
            // 
            // txtPromene
            // 
            this.txtPromene.Location = new System.Drawing.Point(396, 21);
            this.txtPromene.Multiline = true;
            this.txtPromene.Name = "txtPromene";
            this.txtPromene.Size = new System.Drawing.Size(299, 485);
            this.txtPromene.TabIndex = 13;
            // 
            // dtpOd
            // 
            this.dtpOd.Location = new System.Drawing.Point(105, 14);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(135, 20);
            this.dtpOd.TabIndex = 0;
            // 
            // dtpDo
            // 
            this.dtpDo.Location = new System.Drawing.Point(105, 47);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(135, 20);
            this.dtpDo.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 529);
            this.Controls.Add(this.txtPromene);
            this.Controls.Add(this.gbPrikaz);
            this.Controls.Add(this.gbPromene);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTipPartije);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBrojPartije);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbPromene.ResumeLayout(false);
            this.gbPromene.PerformLayout();
            this.gbPrikaz.ResumeLayout(false);
            this.gbPrikaz.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBrojPartije;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipPartije;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_UnesiPartiju;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbPromene;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnIsplata;
        private System.Windows.Forms.Button btnUplata;
        private System.Windows.Forms.ComboBox cbValute;
        private System.Windows.Forms.GroupBox gbPrikaz;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPromene;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.DateTimePicker dtpOd;
    }
}

