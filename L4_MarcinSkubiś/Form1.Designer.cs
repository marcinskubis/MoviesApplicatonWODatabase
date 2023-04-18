namespace L4_MarcinSkubiś
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.koncert = new System.Windows.Forms.Button();
            this.film = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // koncert
            // 
            this.koncert.Location = new System.Drawing.Point(410, 59);
            this.koncert.Name = "koncert";
            this.koncert.Size = new System.Drawing.Size(212, 89);
            this.koncert.TabIndex = 3;
            this.koncert.Text = "Utwórz koncert";
            this.koncert.UseVisualStyleBackColor = true;
            this.koncert.Click += new System.EventHandler(this.button2_Click);
            // 
            // film
            // 
            this.film.Location = new System.Drawing.Point(86, 59);
            this.film.Name = "film";
            this.film.Size = new System.Drawing.Size(212, 89);
            this.film.TabIndex = 4;
            this.film.Text = "Utwórz film";
            this.film.UseVisualStyleBackColor = true;
            this.film.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 89);
            this.button1.TabIndex = 5;
            this.button1.Text = "Przeglądaj nagrania";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(86, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 89);
            this.button2.TabIndex = 6;
            this.button2.Text = "Przeciąż";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(86, 372);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(212, 89);
            this.button3.TabIndex = 7;
            this.button3.Text = "Sortowanie";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 625);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.film);
            this.Controls.Add(this.koncert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button koncert;
        private System.Windows.Forms.Button film;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

