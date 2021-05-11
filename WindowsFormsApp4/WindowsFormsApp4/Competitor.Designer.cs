namespace WindowsFormsApp4
{
    partial class Competitor
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
            this.competitor_list = new System.Windows.Forms.ListBox();
            this.nazwislo_lbl = new System.Windows.Forms.Label();
            this.nazwisko_txt = new System.Windows.Forms.TextBox();
            this.szukaj_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // competitor_list
            // 
            this.competitor_list.FormattingEnabled = true;
            this.competitor_list.Location = new System.Drawing.Point(10, 61);
            this.competitor_list.Name = "competitor_list";
            this.competitor_list.Size = new System.Drawing.Size(778, 108);
            this.competitor_list.TabIndex = 0;
            // 
            // nazwislo_lbl
            // 
            this.nazwislo_lbl.AutoSize = true;
            this.nazwislo_lbl.Location = new System.Drawing.Point(12, 19);
            this.nazwislo_lbl.Name = "nazwislo_lbl";
            this.nazwislo_lbl.Size = new System.Drawing.Size(53, 13);
            this.nazwislo_lbl.TabIndex = 1;
            this.nazwislo_lbl.Text = "Nazwisko";
            // 
            // nazwisko_txt
            // 
            this.nazwisko_txt.Location = new System.Drawing.Point(85, 19);
            this.nazwisko_txt.Name = "nazwisko_txt";
            this.nazwisko_txt.Size = new System.Drawing.Size(100, 20);
            this.nazwisko_txt.TabIndex = 2;
            // 
            // szukaj_btn
            // 
            this.szukaj_btn.Location = new System.Drawing.Point(235, 19);
            this.szukaj_btn.Name = "szukaj_btn";
            this.szukaj_btn.Size = new System.Drawing.Size(75, 23);
            this.szukaj_btn.TabIndex = 3;
            this.szukaj_btn.Text = "Szukaj";
            this.szukaj_btn.UseVisualStyleBackColor = true;
            this.szukaj_btn.Click += new System.EventHandler(this.szukaj_btn_Click);
            // 
            // Competitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 204);
            this.Controls.Add(this.szukaj_btn);
            this.Controls.Add(this.nazwisko_txt);
            this.Controls.Add(this.nazwislo_lbl);
            this.Controls.Add(this.competitor_list);
            this.Name = "Competitor";
            this.Text = "Competitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox competitor_list;
        private System.Windows.Forms.Label nazwislo_lbl;
        private System.Windows.Forms.TextBox nazwisko_txt;
        private System.Windows.Forms.Button szukaj_btn;
    }
}