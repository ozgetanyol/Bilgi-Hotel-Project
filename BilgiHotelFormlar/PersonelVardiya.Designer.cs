namespace BilgiHotelFormlar
{
    partial class PersonelVardiya
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelVardiya));
            this.label3 = new System.Windows.Forms.Label();
            this.lbpersonelvardiya = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.lblcalisma = new System.Windows.Forms.Label();
            this.txtpersoneltutar = new System.Windows.Forms.TextBox();
            this.txtsaatlikucret = new System.Windows.Forms.TextBox();
            this.txtistencikissaati = new System.Windows.Forms.MaskedTextBox();
            this.txtpersonelisebaslamasaati = new System.Windows.Forms.MaskedTextBox();
            this.cbxpersonelvardiyasaati = new System.Windows.Forms.ComboBox();
            this.cbxpersonelad = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(571, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // lbpersonelvardiya
            // 
            this.lbpersonelvardiya.FormattingEnabled = true;
            this.lbpersonelvardiya.Location = new System.Drawing.Point(757, 30);
            this.lbpersonelvardiya.Name = "lbpersonelvardiya";
            this.lbpersonelvardiya.Size = new System.Drawing.Size(337, 264);
            this.lbpersonelvardiya.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 193);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 38;
            this.label5.Tag = "";
            this.label5.Text = "Toplam Çalışma Saati:";
            // 
            // btnhesapla
            // 
            this.btnhesapla.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnhesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhesapla.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnhesapla.Location = new System.Drawing.Point(393, 337);
            this.btnhesapla.Margin = new System.Windows.Forms.Padding(2);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(143, 29);
            this.btnhesapla.TabIndex = 37;
            this.btnhesapla.Text = "Hesapla";
            this.btnhesapla.UseVisualStyleBackColor = false;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // lblcalisma
            // 
            this.lblcalisma.AutoSize = true;
            this.lblcalisma.Location = new System.Drawing.Point(520, 193);
            this.lblcalisma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcalisma.Name = "lblcalisma";
            this.lblcalisma.Size = new System.Drawing.Size(34, 13);
            this.lblcalisma.TabIndex = 36;
            this.lblcalisma.Text = ".........";
            // 
            // txtpersoneltutar
            // 
            this.txtpersoneltutar.Location = new System.Drawing.Point(523, 278);
            this.txtpersoneltutar.Name = "txtpersoneltutar";
            this.txtpersoneltutar.Size = new System.Drawing.Size(115, 20);
            this.txtpersoneltutar.TabIndex = 35;
            // 
            // txtsaatlikucret
            // 
            this.txtsaatlikucret.Location = new System.Drawing.Point(523, 232);
            this.txtsaatlikucret.Name = "txtsaatlikucret";
            this.txtsaatlikucret.Size = new System.Drawing.Size(115, 20);
            this.txtsaatlikucret.TabIndex = 34;
            // 
            // txtistencikissaati
            // 
            this.txtistencikissaati.Location = new System.Drawing.Point(523, 154);
            this.txtistencikissaati.Mask = "00:00";
            this.txtistencikissaati.Name = "txtistencikissaati";
            this.txtistencikissaati.Size = new System.Drawing.Size(115, 20);
            this.txtistencikissaati.TabIndex = 33;
            this.txtistencikissaati.ValidatingType = typeof(System.DateTime);
            // 
            // txtpersonelisebaslamasaati
            // 
            this.txtpersonelisebaslamasaati.Location = new System.Drawing.Point(523, 114);
            this.txtpersonelisebaslamasaati.Mask = "00:00";
            this.txtpersonelisebaslamasaati.Name = "txtpersonelisebaslamasaati";
            this.txtpersonelisebaslamasaati.Size = new System.Drawing.Size(115, 20);
            this.txtpersonelisebaslamasaati.TabIndex = 32;
            this.txtpersonelisebaslamasaati.ValidatingType = typeof(System.DateTime);
            // 
            // cbxpersonelvardiyasaati
            // 
            this.cbxpersonelvardiyasaati.FormattingEnabled = true;
            this.cbxpersonelvardiyasaati.Location = new System.Drawing.Point(523, 71);
            this.cbxpersonelvardiyasaati.Name = "cbxpersonelvardiyasaati";
            this.cbxpersonelvardiyasaati.Size = new System.Drawing.Size(115, 21);
            this.cbxpersonelvardiyasaati.TabIndex = 31;
            this.cbxpersonelvardiyasaati.SelectionChangeCommitted += new System.EventHandler(this.cbxpersonelvardiyasaati_SelectionChangeCommitted);
            // 
            // cbxpersonelad
            // 
            this.cbxpersonelad.FormattingEnabled = true;
            this.cbxpersonelad.Location = new System.Drawing.Point(523, 30);
            this.cbxpersonelad.Name = "cbxpersonelad";
            this.cbxpersonelad.Size = new System.Drawing.Size(115, 21);
            this.cbxpersonelad.TabIndex = 30;
            this.cbxpersonelad.SelectionChangeCommitted += new System.EventHandler(this.cbxpersonelad_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(390, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Tutar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(390, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Saatlik Ücret:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "İşten Çıkış Saati:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(390, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "İşe Başlama Saati:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(390, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Personel Vardiya Saatleri:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(390, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Personel Ad:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(30, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 256);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // PersonelVardiya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1136, 453);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnhesapla);
            this.Controls.Add(this.lblcalisma);
            this.Controls.Add(this.txtpersoneltutar);
            this.Controls.Add(this.txtsaatlikucret);
            this.Controls.Add(this.txtistencikissaati);
            this.Controls.Add(this.txtpersonelisebaslamasaati);
            this.Controls.Add(this.cbxpersonelvardiyasaati);
            this.Controls.Add(this.cbxpersonelad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbpersonelvardiya);
            this.Controls.Add(this.label3);
            this.Name = "PersonelVardiya";
            this.Text = "PersonelVardiya";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PersonelVardiya_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbpersonelvardiya;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnhesapla;
        private System.Windows.Forms.Label lblcalisma;
        private System.Windows.Forms.TextBox txtpersoneltutar;
        private System.Windows.Forms.TextBox txtsaatlikucret;
        private System.Windows.Forms.MaskedTextBox txtistencikissaati;
        private System.Windows.Forms.MaskedTextBox txtpersonelisebaslamasaati;
        private System.Windows.Forms.ComboBox cbxpersonelvardiyasaati;
        private System.Windows.Forms.ComboBox cbxpersonelad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}