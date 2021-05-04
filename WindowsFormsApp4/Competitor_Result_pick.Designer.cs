namespace WindowsFormsApp4
{
    partial class Competitor_Result_pick
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
            this.Competitor_select_result_listbox = new System.Windows.Forms.ListBox();
            this.Competitor_selected_Results_listox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Competitor_select_result_listbox
            // 
            this.Competitor_select_result_listbox.FormattingEnabled = true;
            this.Competitor_select_result_listbox.Location = new System.Drawing.Point(12, 12);
            this.Competitor_select_result_listbox.Name = "Competitor_select_result_listbox";
            this.Competitor_select_result_listbox.Size = new System.Drawing.Size(295, 420);
            this.Competitor_select_result_listbox.TabIndex = 0;
            this.Competitor_select_result_listbox.SelectedIndexChanged += new System.EventHandler(this.Competitor_select_result_listbox_SelectedIndexChanged);
            // 
            // Competitor_selected_Results_listox
            // 
            this.Competitor_selected_Results_listox.FormattingEnabled = true;
            this.Competitor_selected_Results_listox.Location = new System.Drawing.Point(329, 174);
            this.Competitor_selected_Results_listox.Name = "Competitor_selected_Results_listox";
            this.Competitor_selected_Results_listox.Size = new System.Drawing.Size(459, 30);
            this.Competitor_selected_Results_listox.TabIndex = 1;
            // 
            // Competitor_Result_pick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Competitor_selected_Results_listox);
            this.Controls.Add(this.Competitor_select_result_listbox);
            this.Name = "Competitor_Result_pick";
            this.Text = "Competitor_Result_pick";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Competitor_select_result_listbox;
        private System.Windows.Forms.ListBox Competitor_selected_Results_listox;
    }
}