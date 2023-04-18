namespace L4_MarcinSkubiś
{
    partial class Filmm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PLname = new System.Windows.Forms.TextBox();
            this.ORname = new System.Windows.Forms.TextBox();
            this.country = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lang = new System.Windows.Forms.TextBox();
            this.edit = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.awards = new System.Windows.Forms.NumericUpDown();
            this.blackandwhite = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.media = new System.Windows.Forms.TextBox();
            this.budget = new System.Windows.Forms.NumericUpDown();
            this.lngth = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBoxmaly = new System.Windows.Forms.PictureBox();
            this.price = new System.Windows.Forms.NumericUpDown();
            this.dataPL = new System.Windows.Forms.DateTimePicker();
            this.orgDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lngth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxmaly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.price)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa polska filmu:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwa oryginalna:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kraj:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Długość(w minutach):";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 345);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Cena wypożyczenia za dzień (zł):";
            // 
            // PLname
            // 
            this.PLname.Location = new System.Drawing.Point(179, 41);
            this.PLname.Name = "PLname";
            this.PLname.Size = new System.Drawing.Size(180, 20);
            this.PLname.TabIndex = 10;
            this.PLname.TextChanged += new System.EventHandler(this.PLname_TextChanged);
            // 
            // ORname
            // 
            this.ORname.Location = new System.Drawing.Point(179, 67);
            this.ORname.Name = "ORname";
            this.ORname.Size = new System.Drawing.Size(180, 20);
            this.ORname.TabIndex = 11;
            // 
            // country
            // 
            this.country.Location = new System.Drawing.Point(179, 93);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(180, 20);
            this.country.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(94, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Budżet filmu($):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(128, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Montaż:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(87, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Oryginalny język:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(46, 215);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Liczba wygranych nagród:";
            // 
            // lang
            // 
            this.lang.Location = new System.Drawing.Point(179, 190);
            this.lang.Name = "lang";
            this.lang.Size = new System.Drawing.Size(180, 20);
            this.lang.TabIndex = 26;
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(179, 140);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(180, 20);
            this.edit.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(250, -1);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(232, 39);
            this.label15.TabIndex = 28;
            this.label15.Text = "DODAJ FILM\r\n";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(56, 243);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(121, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Data premiery w Polsce:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(412, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 41);
            this.button1.TabIndex = 31;
            this.button1.Text = "Dodaj zdjęcie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "zdjęcia|*.jpg";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(412, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 308);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(637, 14);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(406, 381);
            this.listBox2.TabIndex = 33;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(198, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 53);
            this.button2.TabIndex = 34;
            this.button2.Text = "Dodaj film";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // awards
            // 
            this.awards.Location = new System.Drawing.Point(179, 213);
            this.awards.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.awards.Name = "awards";
            this.awards.Size = new System.Drawing.Size(180, 20);
            this.awards.TabIndex = 36;
            this.awards.ValueChanged += new System.EventHandler(this.awards_ValueChanged);
            // 
            // blackandwhite
            // 
            this.blackandwhite.AutoSize = true;
            this.blackandwhite.Location = new System.Drawing.Point(90, 369);
            this.blackandwhite.Name = "blackandwhite";
            this.blackandwhite.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.blackandwhite.Size = new System.Drawing.Size(83, 17);
            this.blackandwhite.TabIndex = 37;
            this.blackandwhite.Text = "Czarnobiałe";
            this.blackandwhite.UseVisualStyleBackColor = true;
            this.blackandwhite.CheckedChanged += new System.EventHandler(this.blackandwhite_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Nośnik:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Data premiery oryginalna:";
            // 
            // media
            // 
            this.media.Location = new System.Drawing.Point(179, 315);
            this.media.Name = "media";
            this.media.Size = new System.Drawing.Size(180, 20);
            this.media.TabIndex = 41;
            // 
            // budget
            // 
            this.budget.Location = new System.Drawing.Point(179, 116);
            this.budget.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.budget.Name = "budget";
            this.budget.Size = new System.Drawing.Size(180, 20);
            this.budget.TabIndex = 42;
            this.budget.ValueChanged += new System.EventHandler(this.budget_ValueChanged);
            this.budget.Leave += new System.EventHandler(this.budget_Leave);
            // 
            // lngth
            // 
            this.lngth.Location = new System.Drawing.Point(179, 291);
            this.lngth.Maximum = new decimal(new int[] {
            -1294967296,
            0,
            0,
            0});
            this.lngth.Name = "lngth";
            this.lngth.Size = new System.Drawing.Size(180, 20);
            this.lngth.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Gatunek:";
            // 
            // category
            // 
            this.category.Location = new System.Drawing.Point(179, 164);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(180, 20);
            this.category.TabIndex = 45;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(31, 392);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 53);
            this.button3.TabIndex = 46;
            this.button3.Text = "Uzupełnij";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBoxmaly
            // 
            this.pictureBoxmaly.Location = new System.Drawing.Point(555, 355);
            this.pictureBoxmaly.Name = "pictureBoxmaly";
            this.pictureBoxmaly.Size = new System.Drawing.Size(76, 41);
            this.pictureBoxmaly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxmaly.TabIndex = 47;
            this.pictureBoxmaly.TabStop = false;
            // 
            // price
            // 
            this.price.DecimalPlaces = 1;
            this.price.Location = new System.Drawing.Point(179, 343);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(180, 20);
            this.price.TabIndex = 48;
            // 
            // dataPL
            // 
            this.dataPL.Location = new System.Drawing.Point(179, 239);
            this.dataPL.Name = "dataPL";
            this.dataPL.Size = new System.Drawing.Size(180, 20);
            this.dataPL.TabIndex = 49;
            // 
            // orgDate
            // 
            this.orgDate.Location = new System.Drawing.Point(179, 265);
            this.orgDate.Name = "orgDate";
            this.orgDate.Size = new System.Drawing.Size(180, 20);
            this.orgDate.TabIndex = 50;
            // 
            // Filmm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 504);
            this.Controls.Add(this.orgDate);
            this.Controls.Add(this.dataPL);
            this.Controls.Add(this.price);
            this.Controls.Add(this.pictureBoxmaly);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.category);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lngth);
            this.Controls.Add(this.budget);
            this.Controls.Add(this.media);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.blackandwhite);
            this.Controls.Add(this.awards);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.lang);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.country);
            this.Controls.Add(this.ORname);
            this.Controls.Add(this.PLname);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Filmm";
            this.Text = "Film";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lngth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxmaly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox PLname;
        private System.Windows.Forms.TextBox ORname;
        private System.Windows.Forms.TextBox country;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox lang;
        private System.Windows.Forms.TextBox edit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown awards;
        public System.Windows.Forms.CheckBox blackandwhite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox media;
        private System.Windows.Forms.NumericUpDown budget;
        private System.Windows.Forms.NumericUpDown lngth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox category;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.PictureBox pictureBoxmaly;
        private System.Windows.Forms.NumericUpDown price;
        private System.Windows.Forms.DateTimePicker dataPL;
        private System.Windows.Forms.DateTimePicker orgDate;
    }
}