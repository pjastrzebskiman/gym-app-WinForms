namespace WindowsFormsApp4
{
    partial class Main
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
            this.szukaj_zawodnika_btn = new System.Windows.Forms.Button();
            this.szukaj_zawodnika_lbl = new System.Windows.Forms.Label();
            this.show_all_lbl = new System.Windows.Forms.Label();
            this.show_all_btn = new System.Windows.Forms.Button();
            this.szukaj_wynik_zaw_lbl = new System.Windows.Forms.Label();
            this.search_results_competitor_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ranking_btn = new System.Windows.Forms.Button();
            this.btn_add_competitor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // szukaj_zawodnika_btn
            // 
            this.szukaj_zawodnika_btn.Location = new System.Drawing.Point(194, 0);
            this.szukaj_zawodnika_btn.Name = "szukaj_zawodnika_btn";
            this.szukaj_zawodnika_btn.Size = new System.Drawing.Size(75, 23);
            this.szukaj_zawodnika_btn.TabIndex = 0;
            this.szukaj_zawodnika_btn.Text = "Szukaj";
            this.szukaj_zawodnika_btn.UseVisualStyleBackColor = true;
            this.szukaj_zawodnika_btn.Click += new System.EventHandler(this.szukaj_zawodnika_btn_Click);
            // 
            // szukaj_zawodnika_lbl
            // 
            this.szukaj_zawodnika_lbl.AutoSize = true;
            this.szukaj_zawodnika_lbl.Location = new System.Drawing.Point(0, 5);
            this.szukaj_zawodnika_lbl.Name = "szukaj_zawodnika_lbl";
            this.szukaj_zawodnika_lbl.Size = new System.Drawing.Size(188, 13);
            this.szukaj_zawodnika_lbl.TabIndex = 1;
            this.szukaj_zawodnika_lbl.Text = "Szukaj danych osobowych zawodnika";
            // 
            // show_all_lbl
            // 
            this.show_all_lbl.AutoSize = true;
            this.show_all_lbl.Location = new System.Drawing.Point(0, 34);
            this.show_all_lbl.Name = "show_all_lbl";
            this.show_all_lbl.Size = new System.Drawing.Size(153, 13);
            this.show_all_lbl.TabIndex = 3;
            this.show_all_lbl.Text = "Pokaż wszystkich zawodników";
            // 
            // show_all_btn
            // 
            this.show_all_btn.Location = new System.Drawing.Point(194, 29);
            this.show_all_btn.Name = "show_all_btn";
            this.show_all_btn.Size = new System.Drawing.Size(75, 23);
            this.show_all_btn.TabIndex = 2;
            this.show_all_btn.Text = "Pokaż";
            this.show_all_btn.UseVisualStyleBackColor = true;
            this.show_all_btn.Click += new System.EventHandler(this.show_all_btn_Click);
            // 
            // szukaj_wynik_zaw_lbl
            // 
            this.szukaj_wynik_zaw_lbl.AutoSize = true;
            this.szukaj_wynik_zaw_lbl.Location = new System.Drawing.Point(0, 65);
            this.szukaj_wynik_zaw_lbl.Name = "szukaj_wynik_zaw_lbl";
            this.szukaj_wynik_zaw_lbl.Size = new System.Drawing.Size(137, 13);
            this.szukaj_wynik_zaw_lbl.TabIndex = 5;
            this.szukaj_wynik_zaw_lbl.Text = "Szukaj wyników zawodnika";
            // 
            // search_results_competitor_btn
            // 
            this.search_results_competitor_btn.Location = new System.Drawing.Point(194, 60);
            this.search_results_competitor_btn.Name = "search_results_competitor_btn";
            this.search_results_competitor_btn.Size = new System.Drawing.Size(75, 23);
            this.search_results_competitor_btn.TabIndex = 4;
            this.search_results_competitor_btn.Text = "Szukaj";
            this.search_results_competitor_btn.UseVisualStyleBackColor = true;
            this.search_results_competitor_btn.Click += new System.EventHandler(this.search_results_competitor_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Rankingi";
            // 
            // ranking_btn
            // 
            this.ranking_btn.Location = new System.Drawing.Point(194, 95);
            this.ranking_btn.Name = "ranking_btn";
            this.ranking_btn.Size = new System.Drawing.Size(75, 23);
            this.ranking_btn.TabIndex = 7;
            this.ranking_btn.Text = "Pokaż";
            this.ranking_btn.UseVisualStyleBackColor = true;
            this.ranking_btn.Click += new System.EventHandler(this.ranking_btn_Click);
            // 
            // btn_add_competitor
            // 
            this.btn_add_competitor.Location = new System.Drawing.Point(194, 125);
            this.btn_add_competitor.Name = "btn_add_competitor";
            this.btn_add_competitor.Size = new System.Drawing.Size(75, 23);
            this.btn_add_competitor.TabIndex = 8;
            this.btn_add_competitor.Text = "Dodaj";
            this.btn_add_competitor.UseVisualStyleBackColor = true;
            this.btn_add_competitor.Click += new System.EventHandler(this.btn_add_competitor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dodaj zawodnika";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_add_competitor);
            this.Controls.Add(this.ranking_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.szukaj_wynik_zaw_lbl);
            this.Controls.Add(this.search_results_competitor_btn);
            this.Controls.Add(this.show_all_lbl);
            this.Controls.Add(this.show_all_btn);
            this.Controls.Add(this.szukaj_zawodnika_lbl);
            this.Controls.Add(this.szukaj_zawodnika_btn);
            this.Name = "Main";
            this.Text = "Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button szukaj_zawodnika_btn;
        private System.Windows.Forms.Label szukaj_zawodnika_lbl;
        private System.Windows.Forms.Label show_all_lbl;
        private System.Windows.Forms.Button show_all_btn;
        private System.Windows.Forms.Label szukaj_wynik_zaw_lbl;
        private System.Windows.Forms.Button search_results_competitor_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ranking_btn;
        private System.Windows.Forms.Button btn_add_competitor;
        private System.Windows.Forms.Label label2;
    }
}

