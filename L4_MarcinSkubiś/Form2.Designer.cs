namespace L4_MarcinSkubiś
{
    partial class Lista
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox11 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.DeleteObejct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "Poprzedni ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(277, 464);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 61);
            this.button2.TabIndex = 1;
            this.button2.Text = "Następny";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox11
            // 
            this.listBox11.FormattingEnabled = true;
            this.listBox11.Location = new System.Drawing.Point(12, 12);
            this.listBox11.Name = "listBox11";
            this.listBox11.Size = new System.Drawing.Size(452, 446);
            this.listBox11.TabIndex = 3;
            this.listBox11.SelectedIndexChanged += new System.EventHandler(this.listBox11_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(518, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 61);
            this.button3.TabIndex = 4;
            this.button3.Text = "Przeglądaj nagrania";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Location = new System.Drawing.Point(470, 12);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(271, 371);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 5;
            this.pictureBox11.TabStop = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(743, 464);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(187, 61);
            this.button5.TabIndex = 9;
            this.button5.Text = "Odczytaj z pliku";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(518, 464);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(187, 61);
            this.button4.TabIndex = 8;
            this.button4.Text = "Zapisz do pliku";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // DeleteObejct
            // 
            this.DeleteObejct.Location = new System.Drawing.Point(757, 12);
            this.DeleteObejct.Name = "DeleteObejct";
            this.DeleteObejct.Size = new System.Drawing.Size(187, 61);
            this.DeleteObejct.TabIndex = 12;
            this.DeleteObejct.Text = "Usuń wybrany obiekt";
            this.DeleteObejct.UseVisualStyleBackColor = true;
            this.DeleteObejct.Click += new System.EventHandler(this.button6_Click);
            this.DeleteObejct.MouseHover += new System.EventHandler(this.DeleteObejct_MouseHover_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 537);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Średnia długość nagrań na liście: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 592);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeleteObejct);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBox11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Lista";
            this.Text = "Lista";
            this.Load += new System.EventHandler(this.Lista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button DeleteObejct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}