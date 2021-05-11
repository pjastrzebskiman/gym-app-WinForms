namespace WindowsFormsApp4
{
    partial class Competitor_Result_entry
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
            this.competitor_result_listbox = new System.Windows.Forms.ListBox();
            this.competitor_lbl = new System.Windows.Forms.Label();
            this.competitor_name_listbox = new System.Windows.Forms.ListBox();
            this.competitor_result_lbl = new System.Windows.Forms.Label();
            this.search_competitor_entry_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.secondName_search_entry_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // competitor_result_listbox
            // 
            this.competitor_result_listbox.FormattingEnabled = true;
            this.competitor_result_listbox.Location = new System.Drawing.Point(97, 174);
            this.competitor_result_listbox.Name = "competitor_result_listbox";
            this.competitor_result_listbox.Size = new System.Drawing.Size(503, 30);
            this.competitor_result_listbox.TabIndex = 0;
            // 
            // competitor_lbl
            // 
            this.competitor_lbl.AutoSize = true;
            this.competitor_lbl.Location = new System.Drawing.Point(16, 146);
            this.competitor_lbl.Name = "competitor_lbl";
            this.competitor_lbl.Size = new System.Drawing.Size(80, 13);
            this.competitor_lbl.TabIndex = 1;
            this.competitor_lbl.Text = "Imię i Nazwisko";
            // 
            // competitor_name_listbox
            // 
            this.competitor_name_listbox.FormattingEnabled = true;
            this.competitor_name_listbox.Location = new System.Drawing.Point(97, 138);
            this.competitor_name_listbox.Name = "competitor_name_listbox";
            this.competitor_name_listbox.Size = new System.Drawing.Size(208, 30);
            this.competitor_name_listbox.TabIndex = 2;
            this.competitor_name_listbox.SelectedIndexChanged += new System.EventHandler(this.competitor_name_listbox_SelectedIndexChanged);
            // 
            // competitor_result_lbl
            // 
            this.competitor_result_lbl.AutoSize = true;
            this.competitor_result_lbl.Location = new System.Drawing.Point(49, 174);
            this.competitor_result_lbl.Name = "competitor_result_lbl";
            this.competitor_result_lbl.Size = new System.Drawing.Size(42, 13);
            this.competitor_result_lbl.TabIndex = 3;
            this.competitor_result_lbl.Text = "Wyniki:";
            // 
            // search_competitor_entry_btn
            // 
            this.search_competitor_entry_btn.Location = new System.Drawing.Point(268, 37);
            this.search_competitor_entry_btn.Name = "search_competitor_entry_btn";
            this.search_competitor_entry_btn.Size = new System.Drawing.Size(75, 23);
            this.search_competitor_entry_btn.TabIndex = 4;
            this.search_competitor_entry_btn.Text = "Szukaj";
            this.search_competitor_entry_btn.UseVisualStyleBackColor = true;
            this.search_competitor_entry_btn.Click += new System.EventHandler(this.search_competitor_entry_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nazwisko";
            // 
            // secondName_search_entry_text
            // 
            this.secondName_search_entry_text.Location = new System.Drawing.Point(118, 39);
            this.secondName_search_entry_text.Name = "secondName_search_entry_text";
            this.secondName_search_entry_text.Size = new System.Drawing.Size(100, 20);
            this.secondName_search_entry_text.TabIndex = 6;
            // 
            // Competitor_Result_entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 269);
            this.Controls.Add(this.secondName_search_entry_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_competitor_entry_btn);
            this.Controls.Add(this.competitor_result_lbl);
            this.Controls.Add(this.competitor_name_listbox);
            this.Controls.Add(this.competitor_lbl);
            this.Controls.Add(this.competitor_result_listbox);
            this.Name = "Competitor_Result_entry";
            this.Text = "Competitor_Result";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox competitor_result_listbox;
        private System.Windows.Forms.Label competitor_lbl;
        private System.Windows.Forms.ListBox competitor_name_listbox;
        private System.Windows.Forms.Label competitor_result_lbl;
        private System.Windows.Forms.Button search_competitor_entry_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox secondName_search_entry_text;
    }
}