namespace BilgiHotelFormlar
{
    partial class OdaDurum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdaDurum));
            this.btnodasorgula = new System.Windows.Forms.Button();
            this.dtodacikis = new System.Windows.Forms.DateTimePicker();
            this.dtodagiris = new System.Windows.Forms.DateTimePicker();
            this.lblkaldigigun = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnodasorgula
            // 
            this.btnodasorgula.BackColor = System.Drawing.Color.Black;
            this.btnodasorgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnodasorgula.ForeColor = System.Drawing.Color.White;
            this.btnodasorgula.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnodasorgula.Location = new System.Drawing.Point(537, 124);
            this.btnodasorgula.Name = "btnodasorgula";
            this.btnodasorgula.Size = new System.Drawing.Size(135, 23);
            this.btnodasorgula.TabIndex = 98;
            this.btnodasorgula.Text = "Oda Sorgula";
            this.btnodasorgula.UseVisualStyleBackColor = false;
            this.btnodasorgula.Click += new System.EventHandler(this.btnodasorgula_Click);
            // 
            // dtodacikis
            // 
            this.dtodacikis.Location = new System.Drawing.Point(637, 41);
            this.dtodacikis.Name = "dtodacikis";
            this.dtodacikis.Size = new System.Drawing.Size(162, 20);
            this.dtodacikis.TabIndex = 97;
            this.dtodacikis.ValueChanged += new System.EventHandler(this.dtodacikis_ValueChanged);
            // 
            // dtodagiris
            // 
            this.dtodagiris.Location = new System.Drawing.Point(394, 41);
            this.dtodagiris.Name = "dtodagiris";
            this.dtodagiris.Size = new System.Drawing.Size(163, 20);
            this.dtodagiris.TabIndex = 96;
            // 
            // lblkaldigigun
            // 
            this.lblkaldigigun.AutoSize = true;
            this.lblkaldigigun.Location = new System.Drawing.Point(583, 88);
            this.lblkaldigigun.Name = "lblkaldigigun";
            this.lblkaldigigun.Size = new System.Drawing.Size(40, 13);
            this.lblkaldigigun.TabIndex = 100;
            this.lblkaldigigun.Text = "-----------";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 124);
            this.pictureBox1.TabIndex = 101;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(175, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(124, 124);
            this.pictureBox2.TabIndex = 102;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(34, 191);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(126, 128);
            this.pictureBox3.TabIndex = 103;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(175, 191);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(124, 128);
            this.pictureBox4.TabIndex = 104;
            this.pictureBox4.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(441, 180);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(324, 139);
            this.listView1.TabIndex = 105;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // OdaDurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(918, 389);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblkaldigigun);
            this.Controls.Add(this.btnodasorgula);
            this.Controls.Add(this.dtodacikis);
            this.Controls.Add(this.dtodagiris);
            this.Name = "OdaDurum";
            this.Text = "OdaDurum";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnodasorgula;
        private System.Windows.Forms.DateTimePicker dtodacikis;
        private System.Windows.Forms.DateTimePicker dtodagiris;
        private System.Windows.Forms.Label lblkaldigigun;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ListView listView1;
    }
}